using Employee_Manager.Models;
using System;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class DepartmentsForm : UserControl
    {
        public static DepartmentsSQLHelper db;
        public DepartmentsForm()
        {
            InitializeComponent();
            db = new DepartmentsSQLHelper();
            var d_list = db.GetDepartments();
            department_datagrid.DataSource = d_list;
        }
      

        private Department GetInput()
        {
            var d = new Department();
            d.id = int.Parse(id_textbox.Text);
            d.dep_name = department_name_textbox.Text;
            d.creationDate = creationDate_picker.Value;
            return d;
        }

        private void add_button_Click_1(object sender, EventArgs e)
        {

            try
            {
                var d = GetInput();

                db.AddDepartment(d);

                RefreshTable();
                MessageBox.Show("ADDED SUCCESSFULLY!");
            }
            catch
            {
                MessageBox.Show("ERROR! CANNOT ADD THIS DEPARTMENT");
            }
            
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearForm();
            RefreshTable();
        }

        private void delete_button_Click_1(object sender, EventArgs e)
        {
            
            if ((MessageBox.Show("ARE YOU SURE DELETING THIS DEPARTMENT?", "DELETE DEPARTMENT?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    var id = id_textbox.Text;

                    db.RemoveDepartment(id);

                    RefreshTable();
                    MessageBox.Show("DELETE SUCCESSFULLY!");
                }
                catch
                {
                    MessageBox.Show("ERROR! CANNOT DELETE THIS DEPARTMENT");
                }
            }
        }

        private void edit_button_Click_1(object sender, EventArgs e)
        {
            

            if ((MessageBox.Show("ARE YOU SURE UPDATING THIS DEPARTMENT?", "UPDATING DEPARTMENT?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    var d = GetInput();

                    db.EditDepartment(d);

                    RefreshTable();
                    MessageBox.Show("DELETE SUCCESSFULLY!");
                }
                catch
                {
                    MessageBox.Show("ERROR! CANNOT UPDATE THIS DEPARTMENT");
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            var searchKey = search_textbox.Text.Trim();
            var dep_list = db.FindDepartments(searchKey);
            department_datagrid.DataSource = dep_list;
            department_datagrid.Update();
            department_datagrid.Refresh();
        }

        private void RefreshTable()
        {
            ClearForm();
            department_datagrid.DataSource = db.GetDepartments();
            department_datagrid.Update();
            department_datagrid.Refresh();
        }

        private void ClearForm()
        {
            id_textbox.Clear();
            department_name_textbox.Clear();
            creationDate_picker.Value = DateTime.Today;
        }

        private void FillForm(Department d)
        {
            id_textbox.Text = d.id.ToString();
            department_name_textbox.Text = d.dep_name.ToString();
            creationDate_picker.Value = d.creationDate;
        }


        private void SelectARow(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.department_datagrid.SelectedRows)
            {
                Department d = row.DataBoundItem as Department;
                if (d != null)
                {
                    FillForm(d);
                }
            }
        }
    }
}
