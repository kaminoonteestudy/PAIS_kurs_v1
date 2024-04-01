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
    public partial class VehiclesForm : Form
    {
        string connectionString;
        SqlConnection connect;
        private string _username;

        public VehiclesForm(string username)
        {
            _username = username;

            InitializeComponent();
            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {

            }
            displayVehicleData();
            FillDepartmentComboBox();
            displayVehicleData();
        }

        public void displayVehicleData()
        {
            AddVehicleData adData = new AddVehicleData();

            vehiclesDataGrid.DataSource = adData.userData();
        }

        public void clearFields()
        {
            licensePlateInput.Text = "";
            modelInput.Text = "";
            modelInput.Text = "";
            numericUpDownYear.Value = 1970;
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

        public class ComboboxDriverItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (licensePlateInput.Text == "" || modelInput.Text == "" || departmentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заповніть усі поля!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        if (departmentComboBox.SelectedItem is ComboboxItem selectedItem)
                        {
                            int selectedDepartmentId = selectedItem.Value;
                            string insertData = "INSERT INTO Vehicles (LicensePlate, Type, Model, Year, DepartmentID) " +
                                                "VALUES(@LicensePlate, @Type, @Model, @Year, @DepartmentID)";
                            connect.Open();

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@LicensePlate", licensePlateInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@Type", TypeInput.Text.Trim()); 
                                cmd.Parameters.AddWithValue("@Model", modelInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@Year", Convert.ToInt32(numericUpDownYear.Value)); 
                                cmd.Parameters.AddWithValue("@DepartmentID", selectedDepartmentId);

                                cmd.ExecuteNonQuery();

                                displayVehicleData();

                                MessageBox.Show("Додано транспортний засіб!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Будь ласка оберіть підприємство", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка підключення до бази: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }

                }

            }
        }

        private void FillDepartmentComboBox()
        {
            string query = "SELECT DepartmentID FROM Users WHERE Username = @Username";
            SqlCommand cmd_user = new SqlCommand(query, connect);
            
            cmd_user.Parameters.AddWithValue("@Username", _username);

            connect.Open();
            SqlDataReader reader1 = cmd_user.ExecuteReader();

            
            int userDepartment = 0;

            
            if (reader1.Read())
            {
                
                userDepartment = Convert.ToInt32(reader1["DepartmentID"]);
            }
            else
            {
                
                throw new Exception("Для користувача не додано підприємства.");
            }
            connect.Close();

            query = $"SELECT DepartmentID, Name FROM Departments WHERE DepartmentID = {userDepartment}";
            SqlCommand cmd_department = new SqlCommand(query, connect);

            try
            {
                connect.Open();
                SqlDataReader reader2 = cmd_department.ExecuteReader();

                departmentComboBox.Items.Clear(); 

                while (reader2.Read())
                {
                    string name = reader2["Name"].ToString();
                    int id = Convert.ToInt32(reader2["DepartmentID"]);

                    
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

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            if (licensePlateInput.Text == "" || modelInput.Text == "" || departmentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка оберіть транспортний засіб", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();


                        DateTime today = DateTime.Today;

                        if (departmentComboBox.SelectedItem is ComboboxItem selectedItem)
                        {
                            int selectedDepartmentId = selectedItem.Value;

                            int selectedVehicleId = Convert.ToInt32(vehiclesDataGrid.SelectedRows[0].Cells["VehicleID"].Value);

                            String updateData = "UPDATE Vehicles SET LicensePlate = @LicensePlate, " +
                                                "Type = @Type, " +
                                                "Model = @Model, " +
                                                "Year = @Year, " +
                                                "DepartmentID = @DepartmentID " +
                                                "WHERE VehicleID = @VehicleID"; 


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@LicensePlate", licensePlateInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@Type", TypeInput.Text.Trim()); 
                                cmd.Parameters.AddWithValue("@Model", modelInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@Year", Convert.ToInt32(numericUpDownYear.Value)); 
                                cmd.Parameters.AddWithValue("@DepartmentID", selectedDepartmentId);
                                cmd.Parameters.AddWithValue("@VehicleID", selectedVehicleId);

                                cmd.ExecuteNonQuery();

                                displayVehicleData();

                                MessageBox.Show("Оновлено транспортний засіб!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        MessageBox.Show("Помилка, оберіть транспортний засіб: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if (vehiclesDataGrid.SelectedRows.Count > 0)
            {
                
                int selectedUserId = Convert.ToInt32(vehiclesDataGrid.SelectedRows[0].Cells["VehicleID"].Value);

                
                string deleteQuery = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@VehicleID", selectedUserId);

                            
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Транспортний засіб видалено!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayVehicleData();
                            }
                            else
                            {
                                MessageBox.Show("Транспорний засіб не знайдено", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка видалання: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MainPage mainPage = new MainPage(_username);
            mainPage.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
