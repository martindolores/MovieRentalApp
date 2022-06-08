using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginForm
{
    public partial class addCustomer : Form
    {
        const string CONNECTION_STRING = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True";

        public addCustomer()
        {
            InitializeComponent();
        }
        //Methods
        private void clearText()
        {
            txtcFirstName.Clear();
            txtcLastName.Clear();
            txtcEmail.Clear();
            datetimecSubDate.Value = DateTime.Now;
            txtcAddr.Clear();
            txtcSub.Clear();
            txtcState.Clear();
            txtcPost.Clear();
        }

        private string GenMemberNo()
        {
            string sql = null;
            Random rnd = new Random();
            string memberNo = "C" + (rnd.Next(1000, 9999).ToString());
            sql = "select custmemberno from CustomerDetails";

            SqlConnection connect = new SqlConnection(CONNECTION_STRING);
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        //Checks to see if there is one or more customers
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    if (memberNo != dataReader.GetString(i))
                                    {
                                        return memberNo;
                                    }
                                }
                            }

                        }

                        //no customers
                        else
                        {
                            return memberNo;
                        }

                        dataReader.Close();
                        connect.Close();


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                    return null;
                }
            } return null;
            

        }

        //Clearing Placeholders
        private void txtcAddr_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtcAddr.Text == "Street Address")
            {
                txtcAddr.Clear();
            }
        }

        private void txtcSub_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtcSub.Text == "Subarb / City")
            {
                txtcSub.Clear();
            }
        }

        private void txtcState_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtcState.Text == "State")
            {
                txtcState.Clear();
            }
        }

        private void txtcPost_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtcPost.Text == "Post Code")
            {
                txtcPost.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtcFirstName.Text != "" && txtcLastName.Text != "" && txtcEmail.Text != ""  && datetimecSubDate.Text != "" && txtcAddr.Text != "" && txtcSub.Text != "" && txtcState.Text != "" && txtcPost.Text != "")
            {
                Random rnd = new Random();

                string cFname = txtcFirstName.Text;
                string cLname = txtcLastName.Text;
                string cEmail = txtcEmail.Text;
                string cDate = datetimecSubDate.Text;
                string cAddr = txtcAddr.Text;
                string cSub = txtcSub.Text;
                string cState = txtcState.Text;
                string cMemberNo = GenMemberNo();

                try
                {
                    Int64 cPost = Int64.Parse(txtcPost.Text);
                    


                    
                    string sql = null;

                    

                    sql = "insert into CustomerDetails values (@cFname, @cLname, @cEmail, @cSubDate, @cAddr, @cSub, @cState, @cPost, @cMemberNo)";

                    using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
                    {
                        try
                        {
                            connect.Open();
                            using (SqlCommand cmd = new SqlCommand(sql, connect))
                            {
                                cmd.Parameters.Add("@cFname", SqlDbType.VarChar).Value = cFname;
                                cmd.Parameters.Add("@cLname", SqlDbType.VarChar).Value = cLname;
                                cmd.Parameters.Add("@cEmail", SqlDbType.VarChar).Value = cEmail;
                                cmd.Parameters.Add("@cSubDate", SqlDbType.VarChar).Value = cDate;
                                cmd.Parameters.Add("@cAddr", SqlDbType.VarChar).Value = cAddr;
                                cmd.Parameters.Add("@cSub", SqlDbType.VarChar).Value = cSub;
                                cmd.Parameters.Add("@cState", SqlDbType.VarChar).Value = cState;
                                cmd.Parameters.Add("@cPost", SqlDbType.BigInt).Value = cPost;
                                cmd.Parameters.Add("@cMemberNo", SqlDbType.VarChar).Value = cMemberNo;



                                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                                DataSet dataSet = new DataSet();
                                dataAdapter.Fill(dataSet);


                                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearText();
                                

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.Message);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter correct format for 'Post Code'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter all fields", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Want to Clear Entry Fields?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.Yes)
            {
                clearText();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Exit? Any Unsaved Data will be deleted.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
