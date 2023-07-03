using Employee_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connection = new MySQLHelper();
            var l = new List<Staffs>();
            l = connection.GetStaffs();
            MessageBox.Show($"{l[0].id}\n{l[0].name}\n {l[0].dateOfBirth}\n {l[0].salary}\n {l[0].department}\n {l[0].project}\n {l[0].dateOfBirth}");

        }
    }
}
