﻿using Employee_Manager.Models;
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
    public partial class StaffsForm : UserControl
    {
        public static MySQLHelper db;
        public StaffsForm()
        {
            InitializeComponent();
            db = new MySQLHelper();
            var d_list = db.GetEmployees();
            staffs_grid.DataSource = d_list;


            /* Loading departments dropdown*/
            var departments = db.GetDepartments();
            department_dropdown.DataSource = departments;
            department_dropdown.DisplayMember = "dep_name";
            department_dropdown.ValueMember = "id";

            /* Loading projects dropdown*/
            var p = db.GetProjects();
            project_dropdown.DataSource = p;
            project_dropdown.DisplayMember = "pro_name";
            project_dropdown.ValueMember = "id";
        }

     

        private void add_button_Click(object sender, EventArgs e)
        {
            // 
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

            db.AddNewStaff(employee);

            this.Refresh();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_textbox.Clear();
            name_textbox.Clear();
            dateOfBirth_box.Text = "";
            salary_textbox.Clear() ;
            
        }
    }
}
