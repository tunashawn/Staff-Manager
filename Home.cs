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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            content_panel.Controls.Clear();
            var s = new StaffsForm();
            content_panel.Controls.Add(s);
        }

        private void department_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            var d = new DepartmentsForm();
            content_panel.Controls.Add(d);
        }

        private void project_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            var p = new ProjectsForm();
            content_panel.Controls.Add(p);
        }

        private void staff_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            var s = new StaffsForm();
            content_panel.Controls.Add(s);
        }
    }
}
