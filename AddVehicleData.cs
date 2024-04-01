using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PAIS_kurs_v1
{
    class AddVehicleData
    {
        string connectionString;
        SqlConnection connect;
        public string VehicleID { set; get; }
        public string LicensePlate { set; get; }
        public string Type { set; get; }
        public string Model { set; get; }
        public string Year { set; get; }
        public string DepartmentID { set; get; }

        public List<AddVehicleData> userData()
        {
            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {

            }
            List<AddVehicleData> listData = new List<AddVehicleData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM Vehicles";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddVehicleData addSD = new AddVehicleData();
                            addSD.VehicleID = reader["VehicleID"].ToString();
                            addSD.LicensePlate = reader["LicensePlate"].ToString();
                            addSD.Type = reader["Type"].ToString();
                            addSD.Model = reader["Model"].ToString();
                            addSD.Year = reader["Year"].ToString();
                            addSD.DepartmentID = reader["DepartmentID"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;

        }

        public List<AddVehicleData> dashboardStudentData()
        {
            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {

            }
            List<AddVehicleData> listData = new List<AddVehicleData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM Vehicles";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddVehicleData addSD = new AddVehicleData();
                            addSD.VehicleID = reader["VehicleID"].ToString();
                            addSD.LicensePlate = reader["LicensePlate"].ToString();
                            addSD.Type = reader["Type"].ToString();
                            addSD.Model = reader["Model"].ToString();
                            addSD.Year = reader["Year"].ToString();
                            addSD.DepartmentID = reader["DepartmentID"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
