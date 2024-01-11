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

namespace Test_project
{
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginform form2 = new loginform();
            form2.Show();
            Close();
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
                wronguser1.SetError(username1, "");
            }
            else
            {
                wronguser1.SetError(username1, "The username you entered does not exist!");
            }
        }

        private void hide1_Click(object sender, EventArgs e)
        {
            newpassword.UseSystemPasswordChar = true;
            hide1.Visible = false;
            show1.Visible = true;
        }

        private void show1_Click(object sender, EventArgs e)
        {
            newpassword.UseSystemPasswordChar = false;
            hide1.Visible = true;
            show1.Visible = false;
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {
            newpassword.UseSystemPasswordChar = true;
            hide1.Visible = false;
            show1.Visible = true;
            confirmnewpassword.UseSystemPasswordChar = true;
            hide2.Visible = false;
            show2.Visible = true;
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            confirmnewpassword.UseSystemPasswordChar = true;
            hide2.Visible = false;
            show2.Visible = true;
        }

        private void show2_Click(object sender, EventArgs e)
        {
            confirmnewpassword.UseSystemPasswordChar = false;
            hide2.Visible = true;
            show2.Visible = false;
        }

        private void resetpass_Click(object sender, EventArgs e)
        {
            string u, p, c, r;
            u = username1.Text;
            p = newpassword.Text;
            c = confirmnewpassword.Text;
            r = recoveryword.Text;
            string a = wronguser1.GetError(username1);

            if (u == "" || c == "" || p == "" || r == "")
            {
                MessageBox.Show("Please enter all the required information!");
            }
            else
            {
                if (confirmnewpassword.Text != newpassword.Text)
                {
                    MessageBox.Show("The passwords you entered do not match!");
                }
                else if (a == "The username you entered does not exist!")
                {
                    MessageBox.Show("The username you entered does not exist!");
                }
                else
                {
                    String SQL, sql;
                    SQL = "UPDATE [Final Project].[dbo].[Users] set Password ='" + p + "' WHERE Username = '"+u+"'";
                    sql = "select count(*) from [Final Project].[dbo].[Users] WHERE Username ='" + u + "' AND Recovery_Word ='" + r + "'";
                    string connectionString = Properties.Settings.Default.consetting;
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand cmnd = new SqlCommand(sql, connection); //count
                    SqlCommand cmd = new SqlCommand(SQL, connection); //update

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

                            MessageBox.Show("Password updated successfully!");

                            loginform form1 = new loginform();
                            form1.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("The username or recovery word you entered is incorrect!");

                        }

                    }
                }
            }
            
        }

        private void confirmnewpassword_TextChanged(object sender, EventArgs e)
        {
            if (confirmnewpassword.Text != newpassword.Text)
            {
                passmatch.SetError(confirmnewpassword, "The passwords you entered do not match!");
            }
            else
            {
                passmatch.SetError(confirmnewpassword, "");
            }
        }

        private void newpass_Click(object sender, EventArgs e)
        {

        }
    }
}
