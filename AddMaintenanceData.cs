using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PAIS_kurs_v1
{
    class AddMaintenanceData
    {
        string connectionString;
        SqlConnection connect;

        // Class to hold maintenance record data
        public class MaintenanceRecord
        {
            public string RecordID { get; set; }
            public string VehicleID { get; set; }
            public DateTime DateOfService { get; set; }
            public string Description { get; set; }
            public decimal Cost { get; set; }


        }

        // Method to retrieve maintenance records
        public List<MaintenanceRecord> GetMaintenanceRecords()
        {
            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {

            }
            List<MaintenanceRecord> records = new List<MaintenanceRecord>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM MaintenanceRecords";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            MaintenanceRecord record = new MaintenanceRecord
                            {
                                RecordID = reader["RecordID"].ToString(),
                                VehicleID = reader["VehicleID"].ToString(),
                                DateOfService = Convert.ToDateTime(reader["DateOfService"]),
                                Description = reader["Description"].ToString(),
                                Cost = Convert.ToDecimal(reader["Cost"])
                            };

                            records.Add(record);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to Database: " + ex);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return records;
        }
    }
}
