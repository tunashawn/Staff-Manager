namespace Employee_Manager
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.department_button = new System.Windows.Forms.Button();
            this.project_button = new System.Windows.Forms.Button();
            this.staff_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome_message = new System.Windows.Forms.Label();
            this.content_panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.department_button);
            this.flowLayoutPanel1.Controls.Add(this.project_button);
            this.flowLayoutPanel1.Controls.Add(this.staff_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 707);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // department_button
            // 
            this.department_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.department_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_button.Location = new System.Drawing.Point(3, 56);
            this.department_button.Name = "department_button";
            this.department_button.Size = new System.Drawing.Size(211, 57);
            this.department_button.TabIndex = 0;
            this.department_button.Text = "Departments";
            this.department_button.UseVisualStyleBackColor = true;
            this.department_button.Click += new System.EventHandler(this.department_button_Click);
            // 
            // project_button
            // 
            this.project_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.project_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_button.Location = new System.Drawing.Point(3, 119);
            this.project_button.Name = "project_button";
            this.project_button.Size = new System.Drawing.Size(211, 57);
            this.project_button.TabIndex = 0;
            this.project_button.Text = "Projects";
            this.project_button.UseVisualStyleBackColor = true;
            this.project_button.Click += new System.EventHandler(this.project_button_Click);
            // 
            // staff_button
            // 
            this.staff_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staff_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_button.Location = new System.Drawing.Point(3, 182);
            this.staff_button.Name = "staff_button";
            this.staff_button.Size = new System.Drawing.Size(211, 57);
            this.staff_button.TabIndex = 0;
            this.staff_button.Text = "Staffs";
            this.staff_button.UseVisualStyleBackColor = true;
            this.staff_button.Click += new System.EventHandler(this.staff_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.welcome_message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 53);
            this.panel1.TabIndex = 1;
            // 
            // welcome_message
            // 
            this.welcome_message.BackColor = System.Drawing.Color.Black;
            this.welcome_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome_message.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_message.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome_message.Location = new System.Drawing.Point(0, 0);
            this.welcome_message.Name = "welcome_message";
            this.welcome_message.Size = new System.Drawing.Size(217, 53);
            this.welcome_message.TabIndex = 0;
            this.welcome_message.Text = "Welcome Tuna Shawn";
            this.welcome_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content_panel
            // 
            this.content_panel.BackColor = System.Drawing.Color.White;
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.Location = new System.Drawing.Point(218, 0);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(907, 707);
            this.content_panel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1125, 707);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Text = "Home";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button staff_button;
        private System.Windows.Forms.Button project_button;
        private System.Windows.Forms.Button department_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcome_message;
        private System.Windows.Forms.Panel content_panel;
    }
}