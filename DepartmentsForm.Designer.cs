namespace Employee_Manager
{
    partial class DepartmentsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.creationDate_picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.department_name_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.department_datagrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.department_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.search_textbox);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.edit_button);
            this.panel1.Controls.Add(this.creationDate_picker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.department_name_textbox);
            this.panel1.Controls.Add(this.id_textbox);
            this.panel1.Controls.Add(this.department_datagrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 700);
            this.panel1.TabIndex = 0;
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(570, 30);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(248, 26);
            this.search_textbox.TabIndex = 41;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(113)))), ((int)(((byte)(203)))));
            this.search_button.Location = new System.Drawing.Point(830, 29);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(60, 27);
            this.search_button.TabIndex = 42;
            this.search_button.Text = "Search name";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(379, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Search department name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(76)))));
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(213, 485);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(126, 40);
            this.add_button.TabIndex = 38;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click_1);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.clear_button.FlatAppearance.BorderSize = 0;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(64, 485);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(126, 40);
            this.clear_button.TabIndex = 40;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(213, 544);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(126, 40);
            this.delete_button.TabIndex = 39;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click_1);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(210)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(64, 544);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(126, 40);
            this.edit_button.TabIndex = 37;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click_1);
            // 
            // creationDate_picker
            // 
            this.creationDate_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDate_picker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDate_picker.Location = new System.Drawing.Point(65, 315);
            this.creationDate_picker.Name = "creationDate_picker";
            this.creationDate_picker.Size = new System.Drawing.Size(274, 29);
            this.creationDate_picker.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Creation Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // department_name_textbox
            // 
            this.department_name_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_name_textbox.Location = new System.Drawing.Point(65, 245);
            this.department_name_textbox.Name = "department_name_textbox";
            this.department_name_textbox.Size = new System.Drawing.Size(274, 29);
            this.department_name_textbox.TabIndex = 2;
            this.department_name_textbox.TextChanged += new System.EventHandler(this.department_name_textbox_TextChanged);
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textbox.Location = new System.Drawing.Point(65, 177);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(274, 29);
            this.id_textbox.TabIndex = 1;
            this.id_textbox.TextChanged += new System.EventHandler(this.id_textbox_TextChanged);
            // 
            // department_datagrid
            // 
            this.department_datagrid.AllowUserToAddRows = false;
            this.department_datagrid.AllowUserToDeleteRows = false;
            this.department_datagrid.AutoGenerateColumns = false;
            this.department_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.department_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.department_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.department_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.depnameDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn});
            this.department_datagrid.DataSource = this.departmentBindingSource;
            this.department_datagrid.Location = new System.Drawing.Point(383, 69);
            this.department_datagrid.Margin = new System.Windows.Forms.Padding(10);
            this.department_datagrid.MultiSelect = false;
            this.department_datagrid.Name = "department_datagrid";
            this.department_datagrid.ReadOnly = true;
            this.department_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.department_datagrid.Size = new System.Drawing.Size(507, 621);
            this.department_datagrid.TabIndex = 0;
            this.department_datagrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectARow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // depnameDataGridViewTextBoxColumn
            // 
            this.depnameDataGridViewTextBoxColumn.DataPropertyName = "dep_name";
            this.depnameDataGridViewTextBoxColumn.HeaderText = "dep_name";
            this.depnameDataGridViewTextBoxColumn.Name = "depnameDataGridViewTextBoxColumn";
            this.depnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.depnameDataGridViewTextBoxColumn.Width = 280;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "creationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "creationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Employee_Manager.Models.Department);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "DepartmentsForm";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.Departments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.department_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.DataGridView department_datagrid;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox department_name_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker creationDate_picker;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
    }
}
