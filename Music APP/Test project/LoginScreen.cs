using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Windows.Forms;

namespace Test_project
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password");
            }
            else
            {

                string sql = "SELECT count(*) FROM [Final Project].[dbo].[Users] where  Username = '" + username + "' and Password = '" + password + "'";

                string connectionString = Properties.Settings.Default.consetting;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();



                if (cmd.ExecuteScalar().ToString() == "1")
                {

                    Welcome form2 = new Welcome();
                    form2.Show();
                    Hide();
                    //Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            hide.Visible = false;
            show.Visible = true;
            //login.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass form = new ForgotPass();
            form.Show();
            Hide();
        }

        private void show_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            show.Visible = false;
            hide.Visible = true;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            hide.Visible = false;
            show.Visible = true;
        }

        private void createaccnt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Createaccnt form = new Createaccnt();
            form.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    //private void textBox1_TextChanged(object sender, EventArgs e)
    //{

    //}


}