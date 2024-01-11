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
    public partial class Deleteaccnt : Form
    {
        public Deleteaccnt()
        {
            InitializeComponent();
        }

        private void cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Welcome form2 = new Welcome();
            form2.Show();
            Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string a = wronguser.GetError(username2);
            if(a== "The username you entered does not exist!")
            {
                MessageBox.Show("The username you entered does not exist!");
            }
            else { 
                string u, p;
                u = username2.Text;
                p = password2.Text;
                if (u == "" || p == "")
                {
                    MessageBox.Show("Please enter your username and password");
                }
                else
                {
                    String SQL, sql;
                    SQL = "DELETE from [Final Project].[dbo].[Users] WHERE Username ='" + u + "' AND Password ='" + p + "'";
                    sql = "select count(*) from [Final Project].[dbo].[Users] WHERE Username ='" + u + "' AND Password ='" + p + "'";
                    string connectionString = Properties.Settings.Default.consetting;
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand cmnd = new SqlCommand(sql, connection); //count
                    SqlCommand cmd = new SqlCommand(SQL, connection); //delete

                    using (cmnd)
                    {
                        connection.Open();
                        if (cmnd.ExecuteScalar().ToString() == "1")
                        {
                            using (cmd)
                            {
                                cmd.ExecuteNonQuery();
                                connection.Close();
                            }

                            MessageBox.Show("Account deleted successfully!");

                            loginform form1 = new loginform();
                            form1.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("The username or password you entered is incorrect!");

                        }


                    }
                }
            }
        }

        private void username1_TextChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select count(*) from [Final Project].[dbo].[Users] where Username = '" + username2.Text + "'";
            string connectionString = Properties.Settings.Default.consetting;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            if (cmd.ExecuteScalar().ToString() == "1")
            {
                wronguser.SetError(username2, "");
            }
            else
            {
                wronguser.SetError(username2, "The username you entered does not exist!");
            }
        }

        private void hide1_Click(object sender, EventArgs e)
        {
            password2.UseSystemPasswordChar = true;
            hide2.Visible = false;
            show2.Visible = true;
        }

        private void show2_Click(object sender, EventArgs e)
        {
            password2.UseSystemPasswordChar = false;
            hide2.Visible = true;
            show2.Visible = false;
        }

        private void Deleteaccnt_Load(object sender, EventArgs e)
        {
            password2.UseSystemPasswordChar = true;
            hide2.Visible = false;
            show2.Visible = true;
        }
    }
}
