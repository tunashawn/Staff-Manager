using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class Home : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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
            change_header("Departments");
        }

        private void project_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            var p = new ProjectsForm();
            content_panel.Controls.Add(p);
            change_header("Projects");
        }

        private void staff_button_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            var s = new StaffsForm();
            content_panel.Controls.Add(s);
            change_header("Staffs");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void change_header(string h)
        {
            header_label.Text = h;
        }
    }
}
