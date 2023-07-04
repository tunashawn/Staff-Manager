using Employee_Manager.Models;
using System;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void login_click(object sender, EventArgs e)
        {
            var username = username_tb.Text;
            var password = password_tb.Text;
            var login = new MySQLHelper();

            var verify = login.Login(username, password);
            if ( verify != null)
            {
                Form home = new Home(verify.name);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_textbox(object sender, EventArgs e)
        {

        }

        private void password_textbox(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
