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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Employee_Manager
{   
    public partial class StaffsForm : UserControl
    {
        public static EmployeeSQLHelper db;
        public StaffsForm()
        {
            InitializeComponent();
            db = new EmployeeSQLHelper();
            var d_list = db.GetEmployees();
            employees_grid.DataSource = d_list;


            /* Loading departments dropdown*/
            var departments = new DepartmentsSQLHelper().GetDepartments();
            department_dropdown.DataSource = departments;
            department_dropdown.DisplayMember = "dep_name";
            department_dropdown.ValueMember = "id";

            /* Loading projects dropdown*/
            var p = db.GetProjects();
            project_dropdown.DataSource = p;
            project_dropdown.DisplayMember = "pro_name";
            project_dropdown.ValueMember = "id";
        }

        private Employee GetInputEmployee()
        {
            var employee = new Employee();

            // Get employee ID
            employee.id = int.Parse(id_textbox.Text);
            // Get Name
            employee.name = name_textbox.Text;
            // Get Date of Birth
            employee.dateOfBirth = dateOfBirth_box.Value;
            // Get Salary
            employee.salary = Double.Parse(salary_textbox.Text);
            // Get ID of selected department
            Department selected_dep = (Department)department_dropdown.SelectedItem;
            employee.department = selected_dep.id.ToString();
            // Get ID of selected project
            Project selected_pro = (Project)project_dropdown.SelectedItem;
            employee.project = selected_pro.id.ToString();
            // Get Creation Date
            employee.creationDate = creation_date_box.Value;

            return employee;
        }

        private void RefreshTable()
        {
            clear_form();
            employees_grid.DataSource = db.GetEmployees();
            employees_grid.Update();
            employees_grid.Refresh();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            try {
                var employee = GetInputEmployee();

                db.AddNewEmployee(employee);

                MessageBox.Show($"SUCCESSFULLY ADDED {employee.name}");
                    
                RefreshTable();
            } catch {
                MessageBox.Show("ERROR! CANNOT ADD THIS EMPLOYEE!");
            }
            
            
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            var employee = GetInputEmployee();
            if ((MessageBox.Show($"DO YOU WANT TO APPLY UPDATES ON {employee.name}?", "UPDATING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    db.EditEmployee(employee);

                    MessageBox.Show($"SUCCESSFULLY UPDATE {employee.name}");

                    RefreshTable();
                }
                catch
                {
                    MessageBox.Show($"CANNOT UPDATE {employee.name}!");
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("DO YOU WANT TO DELETE THIS EMPLOYEE?", "DELETING?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                db.DeleteStaff(id_textbox.Text);
                MessageBox.Show($"SUCCESSFULLY DELETED");

                RefreshTable(); ;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_form();
        }

        private void clear_form()
        {
            id_textbox.Clear();
            name_textbox.Clear();
            dateOfBirth_box.Value = DateTime.Today;
            salary_textbox.Clear();
            department_dropdown.SelectedIndex = -1;
            project_dropdown.SelectedIndex = -1;
            creation_date_box.Value = DateTime.Today;
        }


        private void search_button_Click(object sender, EventArgs e)
        {
            employees_grid.DataSource = db.FindEmployee(search_textbox.Text);
            employees_grid.Update();
            employees_grid.Refresh();
        }


        private void FillForm( Employee emp )
        {
            id_textbox.Text = emp.id.ToString();
            name_textbox.Text = emp.name;
            dateOfBirth_box.Value = emp.dateOfBirth;
            salary_textbox.Text = emp.salary.ToString();
            department_dropdown.Text = emp.department;
            project_dropdown.Text = emp.project;
            creation_date_box.Value = emp.creationDate;
        }

        private void SelectRowAction(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.employees_grid.SelectedRows)
            {
                Employee emp = row.DataBoundItem as Employee;
                if (emp != null)
                {
                    FillForm(emp);
                }
            }
        }
    }
}
