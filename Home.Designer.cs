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
            this.staff_button = new System.Windows.Forms.Button();
            this.department_button = new System.Windows.Forms.Button();
            this.project_button = new System.Windows.Forms.Button();
            this.welcome_message = new System.Windows.Forms.Label();
            this.content_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flowLayoutPanel1.Controls.Add(this.staff_button);
            this.flowLayoutPanel1.Controls.Add(this.department_button);
            this.flowLayoutPanel1.Controls.Add(this.project_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 700);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // staff_button
            // 
            this.staff_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staff_button.FlatAppearance.BorderSize = 0;
            this.staff_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_button.ForeColor = System.Drawing.Color.White;
            this.staff_button.Location = new System.Drawing.Point(0, 0);
            this.staff_button.Margin = new System.Windows.Forms.Padding(0);
            this.staff_button.Name = "staff_button";
            this.staff_button.Size = new System.Drawing.Size(200, 69);
            this.staff_button.TabIndex = 0;
            this.staff_button.Text = "Staffs";
            this.staff_button.UseVisualStyleBackColor = true;
            this.staff_button.Click += new System.EventHandler(this.staff_button_Click);
            // 
            // department_button
            // 
            this.department_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.department_button.FlatAppearance.BorderSize = 0;
            this.department_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.department_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_button.ForeColor = System.Drawing.Color.White;
            this.department_button.Location = new System.Drawing.Point(0, 69);
            this.department_button.Margin = new System.Windows.Forms.Padding(0);
            this.department_button.Name = "department_button";
            this.department_button.Size = new System.Drawing.Size(200, 69);
            this.department_button.TabIndex = 0;
            this.department_button.Text = "Departments";
            this.department_button.UseVisualStyleBackColor = true;
            this.department_button.Click += new System.EventHandler(this.department_button_Click);
            // 
            // project_button
            // 
            this.project_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.project_button.FlatAppearance.BorderSize = 0;
            this.project_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.project_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_button.ForeColor = System.Drawing.Color.White;
            this.project_button.Location = new System.Drawing.Point(0, 138);
            this.project_button.Margin = new System.Windows.Forms.Padding(0);
            this.project_button.Name = "project_button";
            this.project_button.Size = new System.Drawing.Size(200, 69);
            this.project_button.TabIndex = 0;
            this.project_button.Text = "Projects";
            this.project_button.UseVisualStyleBackColor = true;
            this.project_button.Click += new System.EventHandler(this.project_button_Click);
            // 
            // welcome_message
            // 
            this.welcome_message.BackColor = System.Drawing.Color.Black;
            this.welcome_message.Dock = System.Windows.Forms.DockStyle.Left;
            this.welcome_message.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_message.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome_message.Location = new System.Drawing.Point(0, 0);
            this.welcome_message.Name = "welcome_message";
            this.welcome_message.Size = new System.Drawing.Size(200, 50);
            this.welcome_message.TabIndex = 0;
            this.welcome_message.Text = "Welcome Tuna Shawn";
            this.welcome_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content_panel
            // 
            this.content_panel.BackColor = System.Drawing.Color.White;
            this.content_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.Location = new System.Drawing.Point(200, 50);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(900, 700);
            this.content_panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.welcome_message);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 50);
            this.panel2.TabIndex = 0;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit.Location = new System.Drawing.Point(1050, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.TabIndex = 0;
            this.exit.Text = "❌";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button staff_button;
        private System.Windows.Forms.Button project_button;
        private System.Windows.Forms.Button department_button;
        private System.Windows.Forms.Label welcome_message;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
    }
}