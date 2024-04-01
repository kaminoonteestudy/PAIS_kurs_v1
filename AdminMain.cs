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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUsers addUsers = new AddUsers();
            addUsers.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDepartments addDepartments = new AddDepartments();
            addDepartments.Show();
            this.Hide();
        }
    }
}
