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
    public partial class MaintenanceRecordsForm : Form
    {

        string connectionString;
        SqlConnection connect;
        private string _username;

        public MaintenanceRecordsForm(string username)
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
            displayMaintenanceData();
            FillVehicleComboBox();
            displayMaintenanceData();
        }

        public void displayMaintenanceData()
        {
            AddMaintenanceData adMaintenance = new AddMaintenanceData();

            vehiclesDataGrid.DataSource = adMaintenance.GetMaintenanceRecords();
        }



        public void clearFields()
        {
            DateOfServiceInput.Text = "";
            DescriptionInput.Text = "";
            CostInput.Text = "";
        }

        private void FillVehicleComboBox()
        {
            string query = "SELECT DepartmentID FROM Users WHERE Username = @Username";
            SqlCommand cmd_user = new SqlCommand(query, connect);
            cmd_user.Parameters.AddWithValue("@Username", _username);

            connect.Open();
            SqlDataReader reader1 = cmd_user.ExecuteReader();

            List<int> userDepartments = new List<int>();

            while (reader1.Read())
            {
                userDepartments.Add(Convert.ToInt32(reader1["DepartmentID"]));
            }
            connect.Close();

            if (userDepartments.Count == 0)
            {
                throw new Exception("Для користувача не додано підприємства.");
            }

            StringBuilder departmentsQuery = new StringBuilder("SELECT VehicleID, DepartmentID FROM Vehicles WHERE DepartmentID IN (");
            departmentsQuery.Append(string.Join(",", userDepartments));
            departmentsQuery.Append(")");

            SqlCommand cmd_vehicles = new SqlCommand(departmentsQuery.ToString(), connect);

            try
            {
                connect.Open();
                SqlDataReader reader2 = cmd_vehicles.ExecuteReader();

                VehicleIDComboBox.Items.Clear();

                while (reader2.Read())
                {
                    int vehicleId = Convert.ToInt32(reader2["VehicleID"]);
                    int departmentId = Convert.ToInt32(reader2["DepartmentID"]);
                    VehicleIDComboBox.Items.Add(new ComboboxItem { Text = $"машина: {vehicleId}, підприємство: {departmentId}", Value = vehicleId });
                }

                VehicleIDComboBox.DisplayMember = "Text";
                VehicleIDComboBox.ValueMember = "Value";
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
        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (VehicleIDComboBox.SelectedItem == null || DateOfServiceInput.Text == "" || DescriptionInput.Text == "" || CostInput.Text == "")
            {
                MessageBox.Show("Будь ласка заповніть усі поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        if (VehicleIDComboBox.SelectedItem is ComboboxItem selectedItem)
                        {
                            int selectedDepartmentId = selectedItem.Value;
                            connect.Open();

                            int selectedVehicleID = selectedItem.Value;

                            string insertData = "INSERT INTO MaintenanceRecords (VehicleID, DateOfService, Description, Cost) " +
                                                "VALUES(@VehicleID, @DateOfService, @Description, @Cost)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                               
                                cmd.Parameters.AddWithValue("@VehicleID", selectedVehicleID);
                                cmd.Parameters.AddWithValue("@DateOfService", DateOfServiceInput.Value);
                                cmd.Parameters.AddWithValue("@Description", DescriptionInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@Cost", decimal.Parse(CostInput.Text.Trim()));

                                cmd.ExecuteNonQuery();

                                
                                displayMaintenanceData();

                                MessageBox.Show("Запис додано!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка бази даних: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            if (DateOfServiceInput.Value == null || string.IsNullOrEmpty(DescriptionInput.Text) || string.IsNullOrEmpty(CostInput.Text))
            {
                MessageBox.Show("Заповніть усі поля", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        if (vehiclesDataGrid.SelectedRows.Count > 0)
                        {
                            int selectedRecordId = Convert.ToInt32(vehiclesDataGrid.SelectedRows[0].Cells["RecordID"].Value);

                            string updateData = "UPDATE MaintenanceRecords SET " +
                                                "DateOfService = @DateOfService, " +
                                                "Description = @Description, " +
                                                "Cost = @Cost " +
                                                "WHERE RecordID = @RecordID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@DateOfService", DateOfServiceInput.Value.Date);
                                cmd.Parameters.AddWithValue("@Description", DescriptionInput.Text.Trim());
                                cmd.Parameters.AddWithValue("@Cost", decimal.Parse(CostInput.Text.Trim()));
                                cmd.Parameters.AddWithValue("@RecordID", selectedRecordId);

                                cmd.ExecuteNonQuery();

                                displayMaintenanceData(); 

                                MessageBox.Show("Запис оновлено!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields(); 
                            }
                        }
                        else
                        {
                            MessageBox.Show("Оберіть запис.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка оновлення запису: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (vehiclesDataGrid.SelectedRows.Count > 0)
            {
                
                int selectedRecordId = Convert.ToInt32(vehiclesDataGrid.SelectedRows[0].Cells["RecordID"].Value);

                
                string deleteQuery = "DELETE FROM MaintenanceRecords WHERE RecordID = @RecordID";

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@RecordID", selectedRecordId);

                            
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Запис видалено!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayMaintenanceData(); 
                            }
                            else
                            {
                                MessageBox.Show("Запис не знайдено", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка видалення: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Будь ласка оберіть запис", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toAdminMain_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(_username);
            mainPage.Show();
            this.Hide();
        }
    }
}
