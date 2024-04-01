using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PAIS_kurs_v1

{
    public class AddUserData
    {
        public string id { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string IsAdmin { set; get; }
        public string DateInsert { set; get; }
        public string DepartmentID { set; get; }


        string connectionString;
        SqlConnection connect;

        public List<AddUserData> userData()
            {

            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {

            }
            List<AddUserData> listData = new List<AddUserData>();
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string sql = "SELECT * FROM users";

                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                AddUserData addSD = new AddUserData();
                                addSD.id = reader["id"].ToString();
                                addSD.username = reader["username"].ToString();
                                addSD.password = reader["password"].ToString();
                                addSD.DateInsert = reader["date_register"].ToString();
                                addSD.IsAdmin = reader["is_admin"].ToString();
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

            public List<AddUserData> dashboardStudentData()
            {

            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {

            }
            List<AddUserData> listData = new List<AddUserData>();

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string sql = "SELECT * FROM users";

                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            cmd.Parameters.AddWithValue("@date_register", today.ToString());
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                AddUserData addSD = new AddUserData();
                                addSD.id = reader["id"].ToString();
                                addSD.username = reader["username"].ToString();
                                addSD.password = reader["password"].ToString();
                                addSD.DateInsert = reader["date_register"].ToString();
                                addSD.IsAdmin = reader["is_admin"].ToString();
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