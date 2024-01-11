using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Test_project
{
    public partial class Createaccnt : Form
    {
        public Createaccnt()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            password1.UseSystemPasswordChar = false;
            show1.Visible = false;
            hide1.Visible = true;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            password1.UseSystemPasswordChar = true;
            hide1.Visible = false;
            show1.Visible = true;
        }

        private void step1_Enter(object sender, EventArgs e)
        {

        }

        private void Createaccnt_Load(object sender, EventArgs e)
        {
            password1.UseSystemPasswordChar = true;
            confirmpassword.UseSystemPasswordChar = true;
            show2.Visible = true;
            hide2.Visible = false;

            hide1.Visible = false;
            show1.Visible = true;
        }

        private void show2_Click(object sender, EventArgs e)
        {
            confirmpassword.UseSystemPasswordChar = false;
            show2.Visible = false;
            hide2.Visible = true;
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            confirmpassword.UseSystemPasswordChar = true;
            show2.Visible = true;
            hide2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u, p, f, l, r, b;

            u = username1.Text;
            f = firstname.Text;
            l = lastname.Text;
            p = password1.Text;
            r = recoveryword.Text;

            if (u == "" || f == "" || l == "" || r == "" || p == "")
            {
                MessageBox.Show("Please enter all the required information!");
            }
            else
            {
                string a = usedusername.GetError(username1);
                if (confirmpassword.Text != password1.Text)
                {
                    MessageBox.Show("The passwords you entered do not match!");
                }
                else if (a == "The username you entered is taken!") 
                {
                    MessageBox.Show("The username you entered is taken!");
                }
                else 
                {
                    String SQL;
                    SQL = "INSERT INTO Users(Username,First_Name,Last_Name,Password,Recovery_Word) VALUES ('" + u + "','" + f + "','" + l + "','" + p + "','" + r + "')";
                    string connectionString = Properties.Settings.Default.consetting;
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = SQL;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Account successfully created! Please log in on the next screen.");

                    loginform form2 = new loginform();
                    form2.Show();
                    Close();
                }
                
            }
        }

        private void username1_TextChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select count(*) from [Final Project].[dbo].[Users] where Username = '" + username1.Text + "'";
            string connectionString = Properties.Settings.Default.consetting;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                usedusername.SetError(username1, "The username you entered is taken!");
            }
            else
            {
                usedusername.SetError(username1, "");
            }
        
    }

        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (confirmpassword.Text != password1.Text)
            {
                wrongpass.SetError(confirmpassword, "The passwords you entered do not match!");
            }
            else
            {
                wrongpass.SetError(confirmpassword, "");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginform form2 = new loginform();
            form2.Show();
            Close();
        }
    }
}
