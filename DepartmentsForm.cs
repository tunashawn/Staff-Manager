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
    public partial class DepartmentsForm : UserControl
    {
        public DepartmentsForm()
        {
            InitializeComponent();
            var connect = new MySQLHelper();
            var d_list = connect.GetDepartments();
            department_datagrid.DataSource = d_list;
        }

        private void Departments_Load(object sender, EventArgs e)
        {

        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void department_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void find_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }
    }
}
