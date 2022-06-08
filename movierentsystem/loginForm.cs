using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace loginForm
{
    public partial class loginForm : Form
    {
        const string CONNECTION_STRING = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True";
        public loginForm()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textboxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if(textboxUsername.Text == "Username")
            { 
                textboxUsername.Clear();
            }
            
        }

        private void textboxPassword_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (textboxPassword.Text == "Password")
            {
                 textboxPassword.Clear();
            }
            
        }
        private void textboxPassword_TextChanged(object sender, EventArgs e)
        {
            textboxPassword.PasswordChar = '*';
        }

        private void pictureboxGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/martindolores");
        }

        private void pictureboxLinkedIn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/martindolores/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = null;
<<<<<<< HEAD

            sql = "select* from loginTable where username = @username and pass = @pass";
=======
            
            //connect to SQL database here
            connectionString = "data source = #####; database = ######; integrated security = True";
            
            //insert table name
            sql = "select* from ##### where username = @username and pass = @pass";
>>>>>>> 1c878d32fe0342c21c1a1a0db6df8e6646ef8318

            using(SqlConnection connect = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,connect))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = textboxUsername.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = textboxPassword.Text;

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count != 0)
                        {
                            MessageBox.Show("Success!");
                            this.Hide();
                            dashboard dashboard = new dashboard();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }  
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string sql = null;
<<<<<<< HEAD
            sql = "insert into loginTable (username, pass) values (@username, @pass)";
=======
            
            //connect to SQL database here
            connectionString = "data source = ####; database = ####; integrated security = True";
            
             //insert table name
            sql = "insert into #### (username, pass) values (@username, @pass)";
>>>>>>> 1c878d32fe0342c21c1a1a0db6df8e6646ef8318

            using(SqlConnection connect = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = textboxUsername.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = textboxPassword.Text;

                        int rowsAdd = cmd.ExecuteNonQuery();
                        if (rowsAdd > 0)
                            MessageBox.Show("Successfully Signed Up!");
                        else
                            MessageBox.Show("Error, please try signing up again.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

    }
}
