using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIS_kurs_v1
{
    public static class DatabaseConnection
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            try
            {
                if (connection == null || connection.State != System.Data.ConnectionState.Open)
                {
                    string connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }

            }

            catch (Exception ex)
            {
                
            }

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
