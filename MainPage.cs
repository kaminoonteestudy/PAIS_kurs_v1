using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIS_kurs_v1
{
    public partial class MainPage : Form
    {
        private string _username;

        public MainPage(string username)
        {
            InitializeComponent();
            _username = username;
        }
        private void AddVehicles_Click(object sender, EventArgs e)
        {
            VehiclesForm VehiclesForm = new VehiclesForm(_username);
            VehiclesForm.Show();
            this.Hide();
        }

        private void AddDrivers_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceRecordsForm MaintenanceRecordsForm = new MaintenanceRecordsForm(_username);
            MaintenanceRecordsForm.Show();
            this.Hide();
        }
    }
}
