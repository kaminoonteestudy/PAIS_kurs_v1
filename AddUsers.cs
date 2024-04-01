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
    public partial class AddUsers : Form
    {
        string connectionString;
        SqlConnection connect;
        public AddUsers()
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
            displayData();
            FillDepartmentComboBox();

        }

        public void displayData()
        {
            AddUserData adData = new AddUserData();

            usersDataGrid.DataSource = adData.userData();
        }

        public void clearFields()
        {
            passwordInput.Text = "";
            usernameInput.Text = "";
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (passwordInput.Text == ""
                || usernameInput.Text == ""
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

                        if (departmentComboBox.SelectedItem is ComboboxItem selectedItem)
                        {
                            int selectedDepartmentId = selectedItem.Value;
                            string insertData = "INSERT INTO users (username, password, is_admin, date_register, DepartmentID) " +
                    "VALUES(@username, @password, @is_admin, @date_register, @DepartmentID)";
                            connect.Open();

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@username", usernameInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", passwordInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@is_admin", adminCheckbox.Checked ? 1 : 0);
                                cmd.Parameters.AddWithValue("@date_register", today);
                                cmd.Parameters.AddWithValue("@DepartmentID", selectedDepartmentId);


                                cmd.ExecuteNonQuery();

                                displayData();

                                MessageBox.Show("Додано користувача!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Оберіть підприємство", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (usersDataGrid.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(usersDataGrid.SelectedRows[0].Cells["id"].Value);

                string deleteQuery = "DELETE FROM users WHERE ID = @userID";

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@userID", selectedUserId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Користувача видалено!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();
                            }
                            else
                            {
                                MessageBox.Show("Користувача не знайдено", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка оберіть користувача для видалення", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            if (passwordInput.Text == ""
                || usernameInput.Text == ""
                )
            {
                MessageBox.Show("Будь ласка оберіть користувача для оновлення", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Student ID: "
                            + usernameInput.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            if (departmentComboBox.SelectedItem is ComboboxItem selectedItem)
                            {
                                int selectedDepartmentId = selectedItem.Value;

                                int selectedUserId = Convert.ToInt32(usersDataGrid.SelectedRows[0].Cells["id"].Value);

                                String updateData = "UPDATE users SET username = @username, " +
                            "password = @password, " +
                            "is_admin = @is_admin, " +
                            "departmentID = @departmentID " +
                            "WHERE id = @id";


                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", usernameInput.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", passwordInput.Text.Trim());
                                    cmd.Parameters.AddWithValue("@is_admin", adminCheckbox.Checked ? 1 : 0);
                                    cmd.Parameters.AddWithValue("@departmentID", selectedDepartmentId);
                                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                                    cmd.ExecuteNonQuery();

                                    displayData();

                                    MessageBox.Show("Оновлено користувача!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                            else
                            {
                                clearFields();
                            }

                            }
                        else
                        {
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

        private void toAdminMain_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Hide();
        }

        private void FillDepartmentComboBox()
        {
            string query = "SELECT DepartmentID, Name FROM Departments";
            SqlCommand cmd = new SqlCommand(query, connect);

            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                departmentComboBox.Items.Clear();

                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    int id = Convert.ToInt32(reader["DepartmentID"]);

                    departmentComboBox.Items.Add(new ComboboxItem { Text = name, Value = id });
                }

                departmentComboBox.DisplayMember = "Text";
                departmentComboBox.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка показу даних: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
