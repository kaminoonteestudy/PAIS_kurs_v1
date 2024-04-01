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
    public partial class Login : Form
    {
        string connectionString;
        SqlConnection connect;
        public Login()
        {
            InitializeComponent();

            try
            {
                connectionString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "connectionString.txt"));

                connect = new SqlConnection(connectionString);

                textBoxConnectionString.Text = connectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ПОмилка: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordInput.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBoxConnectionString.Text == "")
            {
                MessageBox.Show("Будь ласка заповніть ConnectionString", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (usernameInput.Text == "" || passwordInput.Text == "")
            {
                MessageBox.Show("Будь ласка заповніть дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    String selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", usernameInput.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", passwordInput.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Успішний логін!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (usernameInput.Text == "admin")
                            {
                                AdminMain adminMain = new AdminMain();
                                adminMain.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Передаем имя пользователя в конструктор MainPage
                                MainPage mainPage = new MainPage(usernameInput.Text.Trim());
                                mainPage.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неправильний Логін/Пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка підключення до бази даних: " + ex, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxConnectionString.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = textBoxConnectionString.Text;

            string filePath = Path.Combine(Application.StartupPath, "connectionString.txt");

            File.WriteAllText(filePath, connectionString);
            MessageBox.Show("ConnetionString збережено.");

            textBoxConnectionString.Visible = false;
            button2.Visible = false;
        }
    }
}
