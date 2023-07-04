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

        public static ProjectsSQLHelper db;
        public ProjectsForm()
        {
            InitializeComponent();
            db = new ProjectsSQLHelper();
            var d_list = db.GetProjects();
            projects_grid.DataSource = d_list;
        }

        private Project GetInput()
        {
            var p = new Project();
            p.id = int.Parse(id_textbox.Text);
            p.pro_name = project_name_textbox.Text;
            p.creationDate = creationDate_picker.Value;
            return p;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                var p = GetInput();

                db.AddProject(p);

                RefreshTable();
                MessageBox.Show("ADDED SUCCESSFULLY!");
            }
            catch
            {
                MessageBox.Show("ERROR! CANNOT ADD THIS PROJECT");
            }
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("ARE YOU SURE DELETING THIS PROJECT?", "DELETE PROJECT?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    var id = id_textbox.Text.Trim();

                    db.RemoveProject(id);

                    RefreshTable();
                    MessageBox.Show("DELETE SUCCESSFULLY!");
                }
                catch
                {
                    MessageBox.Show("ERROR! CANNOT DELETE THIS PROJECT");
                }
            }

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            var emp = GetInput();
            if ((MessageBox.Show("ARE YOU SURE UPDATING THIS PROJECT?", "EDIT PROJECT?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    var p = GetInput();
                    db.EditProject(p);
                    RefreshTable();
                    MessageBox.Show("UPDATE SUCCESSFULLY!");
                }
                catch
                {
                    MessageBox.Show("ERROR! CANNOT UPDATE THIS PROJECT");
                }
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var searchKey = search_textbox.Text.Trim();

            var pro_list = db.FindProjects(searchKey);

            projects_grid.DataSource = pro_list;
            projects_grid.Update();
            projects_grid.Refresh();
        }

        private void RefreshTable()
        {
            ClearForm();
            projects_grid.DataSource = db.GetProjects();
            projects_grid.Update();
            projects_grid.Refresh();
        }

        private void ClearForm()
        {
            id_textbox.Clear();
            project_name_textbox.Clear();
            creationDate_picker.Value = DateTime.Today;
        }

        private void FillForm(Project d)
        {
            id_textbox.Text = d.id.ToString();
            project_name_textbox.Text = d.pro_name.ToString();
            creationDate_picker.Value = d.creationDate;
        }

        private void SelectRowAction(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.projects_grid.SelectedRows)
            {
                Project p = row.DataBoundItem as Project;
                if (p != null)
                {
                    FillForm(p);
                }
            }
        }
    }
}
