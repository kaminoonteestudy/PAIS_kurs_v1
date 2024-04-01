using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PAIS_kurs_v1
{
    public partial class AddDepartments : Form
    {
        string connectionString;
        SqlConnection connect;

        public AddDepartments()
        {
            InitializeComponent();

            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ПОмилка: " + ex.Message);
            }
            displayDepartmentData();
        }

        public void displayDepartmentData()
        {
            AddDepartmentData adData = new AddDepartmentData();

            departmentsDataGrid.DataSource = adData.departmentData();
        }

        public void clearFields()
        {
            locationInput.Text = "";
            nameInput.Text = "";
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (locationInput.Text == ""
                || nameInput.Text == ""
                )
            {
                MessageBox.Show("Будь ласка заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {

                        DateTime today = DateTime.Today;

                        string insertData = "INSERT INTO Departments (Name, Location) " +
                    "VALUES(@name, @location)";
                        connect.Open();

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@name", nameInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@location", locationInput.Text.Trim());


                            cmd.ExecuteNonQuery();

                            displayDepartmentData();

                            MessageBox.Show("Додано підприємство!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            }
                        }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка бази даних: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void UpdateDepartmentButton_Click(object sender, EventArgs e)
        {
            if (locationInput.Text == ""
                || nameInput.Text == ""
                )
            {
                MessageBox.Show("Виберіть підприемство зі списку", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        int selecteddepartmentId = Convert.ToInt32(departmentsDataGrid.SelectedRows[0].Cells["id"].Value);


                        String updateData = "UPDATE Departments SET name = @name, " +
                    "location = @location WHERE DepartmentID = @id";


                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@name", nameInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@location", locationInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", selecteddepartmentId);

                            cmd.ExecuteNonQuery();

                            displayDepartmentData();

                            MessageBox.Show("Оновлено підприємство!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка підключення до бази даних: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void deleteDepartmentButton_Click(object sender, EventArgs e)
        {
            if (departmentsDataGrid.SelectedRows.Count > 0)
            {
                int selectedDepartmentId = Convert.ToInt32(departmentsDataGrid.SelectedRows[0].Cells["id"].Value);

                string checkUsersQuery = "SELECT COUNT(*) FROM Users WHERE DepartmentID = @id";

                string deleteQuery = "DELETE FROM Departments WHERE DepartmentID = @id";

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                using (SqlCommand cmdCheck = new SqlCommand(checkUsersQuery, connect))
                {
                    cmdCheck.Parameters.AddWithValue("@id", selectedDepartmentId);
                    int usersCount = (int)cmdCheck.ExecuteScalar();

                    if (usersCount > 0)
                    {
                        MessageBox.Show("Неможливо видалити, оскільки до підприємства додано користувачів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                try
                {
                    using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, connect))
                    {
                        cmdDelete.Parameters.AddWithValue("@id", selectedDepartmentId);
                        int rowsAffected = cmdDelete.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Підприємство видалено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayDepartmentData();
                        }
                        else
                        {
                            MessageBox.Show("Підприемтсво не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при видаленні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Будь-ласка оберіть підприємтсво зі списку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toAdminMain_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Hide();
        }
    }
}
