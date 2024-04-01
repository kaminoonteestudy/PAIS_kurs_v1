using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace PAIS_kurs_v1
{
    class AddDepartmentData
    {
        string connectionString;
        SqlConnection connect;
        public string id { set; get; }
        public string name { set; get; }
        public string location { set; get; }




        public List<AddDepartmentData> departmentData()
        {
            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                
            }
            List<AddDepartmentData> listData = new List<AddDepartmentData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM Departments";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddDepartmentData addSD = new AddDepartmentData();
                            addSD.id = reader["DepartmentID"].ToString();
                            addSD.name = reader["name"].ToString();
                            addSD.location = reader["location"].ToString();

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

        public List<AddDepartmentData> dashboardDepartmentData()
        {
            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {

            }
            List<AddDepartmentData> listData = new List<AddDepartmentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM Departments";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddDepartmentData addSD = new AddDepartmentData();
                            addSD.id = reader["DepartmentID"].ToString();
                            addSD.name = reader["name"].ToString();
                            addSD.location = reader["location"].ToString();

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
