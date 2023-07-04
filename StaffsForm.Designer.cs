namespace Employee_Manager
{
    partial class StaffsForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employees_grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.project_dropdown = new System.Windows.Forms.ComboBox();
            this.department_dropdown = new System.Windows.Forms.ComboBox();
            this.dateOfBirth_box = new System.Windows.Forms.DateTimePicker();
            this.creation_date_box = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salary_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employees_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employees_grid
            // 
            this.employees_grid.AllowUserToAddRows = false;
            this.employees_grid.AllowUserToDeleteRows = false;
            this.employees_grid.AutoGenerateColumns = false;
            this.employees_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employees_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employees_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn});
            this.employees_grid.DataSource = this.staffBindingSource;
            this.employees_grid.Location = new System.Drawing.Point(10, 368);
            this.employees_grid.Margin = new System.Windows.Forms.Padding(10);
            this.employees_grid.Name = "employees_grid";
            this.employees_grid.ReadOnly = true;
            this.employees_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employees_grid.Size = new System.Drawing.Size(880, 322);
            this.employees_grid.TabIndex = 0;
            this.employees_grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowAction);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.project_dropdown);
            this.panel1.Controls.Add(this.department_dropdown);
            this.panel1.Controls.Add(this.dateOfBirth_box);
            this.panel1.Controls.Add(this.creation_date_box);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.salary_textbox);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.id_textbox);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 338);
            this.panel1.TabIndex = 1;
            // 
            // project_dropdown
            // 
            this.project_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_dropdown.FormattingEnabled = true;
            this.project_dropdown.Location = new System.Drawing.Point(153, 242);
            this.project_dropdown.Name = "project_dropdown";
            this.project_dropdown.Size = new System.Drawing.Size(336, 28);
            this.project_dropdown.TabIndex = 29;
            // 
            // department_dropdown
            // 
            this.department_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_dropdown.FormattingEnabled = true;
            this.department_dropdown.Location = new System.Drawing.Point(153, 199);
            this.department_dropdown.Name = "department_dropdown";
            this.department_dropdown.Size = new System.Drawing.Size(336, 28);
            this.department_dropdown.TabIndex = 28;
            // 
            // dateOfBirth_box
            // 
            this.dateOfBirth_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth_box.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth_box.Location = new System.Drawing.Point(153, 112);
            this.dateOfBirth_box.Name = "dateOfBirth_box";
            this.dateOfBirth_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateOfBirth_box.Size = new System.Drawing.Size(336, 26);
            this.dateOfBirth_box.TabIndex = 24;
            // 
            // creation_date_box
            // 
            this.creation_date_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creation_date_box.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creation_date_box.Location = new System.Drawing.Point(153, 291);
            this.creation_date_box.Name = "creation_date_box";
            this.creation_date_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.creation_date_box.Size = new System.Drawing.Size(336, 26);
            this.creation_date_box.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Creation Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Project";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // salary_textbox
            // 
            this.salary_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_textbox.Location = new System.Drawing.Point(153, 155);
            this.salary_textbox.Name = "salary_textbox";
            this.salary_textbox.Size = new System.Drawing.Size(336, 26);
            this.salary_textbox.TabIndex = 13;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(153, 63);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(336, 26);
            this.name_textbox.TabIndex = 11;
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textbox.Location = new System.Drawing.Point(153, 17);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(336, 26);
            this.id_textbox.TabIndex = 10;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(210)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(41, 278);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(126, 40);
            this.edit_button.TabIndex = 25;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(76)))));
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(190, 219);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(126, 40);
            this.add_button.TabIndex = 26;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(190, 278);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 40);
            this.delete_button.TabIndex = 27;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.clear_button.FlatAppearance.BorderSize = 0;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(41, 219);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(126, 40);
            this.clear_button.TabIndex = 28;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 700);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.search_textbox);
            this.panel3.Controls.Add(this.search_button);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.add_button);
            this.panel3.Controls.Add(this.clear_button);
            this.panel3.Controls.Add(this.delete_button);
            this.panel3.Controls.Add(this.edit_button);
            this.panel3.Location = new System.Drawing.Point(544, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 338);
            this.panel3.TabIndex = 32;
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(41, 63);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(205, 26);
            this.search_textbox.TabIndex = 30;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(203)))));
            this.search_button.Location = new System.Drawing.Point(256, 63);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(60, 27);
            this.search_button.TabIndex = 31;
            this.search_button.Text = "Search name";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Search for name";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectDataGridViewTextBoxColumn.Width = 150;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "creationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "creationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Employee_Manager.Models.Employee);
            // 
            // StaffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.employees_grid);
            this.Controls.Add(this.panel2);
            this.Name = "StaffsForm";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.employees_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employees_grid;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateOfBirth_box;
        private System.Windows.Forms.DateTimePicker creation_date_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ComboBox project_dropdown;
        private System.Windows.Forms.ComboBox department_dropdown;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
    }
}
