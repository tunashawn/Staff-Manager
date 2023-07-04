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
    public partial class ProjectsForm : UserControl
    {
        public ProjectsForm()
        {
            InitializeComponent();
            var connect = new EmployeeSQLHelper();
            var d_list = connect.GetProjects();
            projects_grid.DataSource = d_list;
        }

        private void departmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
