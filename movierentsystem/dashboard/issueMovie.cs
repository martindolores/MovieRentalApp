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
    public partial class issueMovie : Form
    {
        const string CONNECTION_STRING = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True";
        private int count;


        public issueMovie()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------
        // Clears all textboxes
        //--------------------------------------------------------------

        private void clearTextboxes()
        {
            txtCustSearch.Clear();
            txtcFirstName.Clear();
            txtcLastName.Clear();
            txtcEmail.Clear();
            comboBoxMovies.SelectedIndex = -1;
            datetimeiSubDate.Value = DateTime.Now;
        }

        //--------------------------------------------------------------
        // Update newMovie table quantity if movie has been issued
        //--------------------------------------------------------------

        private void updateQuan()
        {

            string sqlQuery = null;
            string mName = comboBoxMovies.Text;



            sqlQuery = "update newMovie set mQuan = mQuan - 1 where mName = @mName";

            SqlConnection connect = new SqlConnection(CONNECTION_STRING);
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connect))
                    {
                        cmd.Parameters.Add("@mName", SqlDbType.VarChar).Value = mName;
                        cmd.ExecuteNonQuery();
                        connect.Close();

                        MessageBox.Show("Movie Quantity Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void issueMovie_Load(object sender, EventArgs e)
        {
            string sql = null;

            sql = "select mName from newMovie";

            SqlConnection connect = new SqlConnection(CONNECTION_STRING);
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                comboBoxMovies.Items.Add(dataReader.GetString(i));
                            }
                        }

                        dataReader.Close();
                        connect.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            if (txtCustSearch.Text != "")
            {
                string sql = null;
                string custid = null;


                sql = "select * from CustomerDetails where custmemberno = @cmemberno";


                SqlConnection connect = new SqlConnection(CONNECTION_STRING);
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {

                            custid = txtCustSearch.Text;
                            cmd.Parameters.Add("@cmemberno", SqlDbType.VarChar).Value = custid;


                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);


                            var rows = dataSet.Tables[0].Rows;

                            //Checks if customers exist or not
                            if (rows.Count != 0)
                            {
                                txtcFirstName.Text = rows[0][1].ToString();
                                txtcLastName.Text = rows[0][2].ToString();
                                txtcEmail.Text = rows[0][3].ToString();

                            }
                            else
                            {
                                clearTextboxes();
                                MessageBox.Show("Customer Does not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Customer Does not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtcFirstName.Text != "" && comboBoxMovies.SelectedIndex != -1)
            {
                //--------------------------------------------------
                // Code to count how many movies has been issued
                // on selected member no. 
                //--------------------------------------------------

                string sqlCount;


                sqlCount = "select count(cust_memberNo) from issueMovie where cust_memberNo = @cmemberno and issue_returnDate = 'NULL'";
                string cMemberNum = txtCustSearch.Text;

                SqlConnection connectCount = new SqlConnection(CONNECTION_STRING);
                try
                {
                    connectCount.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlCount, connectCount))
                    {
                        cmd.Parameters.Add("@cmemberno", SqlDbType.VarChar).Value = cMemberNum;

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        count = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }

                //--------------------------------------------------
                // If count <= 2 then insert data into table
                //--------------------------------------------------

                if (count <= 2)
                {
                    string cMemberNo = txtCustSearch.Text;
                    string cFirstName = txtcFirstName.Text;
                    string cLastName = txtcLastName.Text;
                    string cEmail = txtcEmail.Text;
                    string mName = comboBoxMovies.Text;
                    string mIssueDate = datetimeiSubDate.Text;
                    string mReturnDate = "NULL";

                    string sql = null;



                    sql = "insert into issueMovie values (@cMemberNo, @cFname, @cLname, @cEmail, @mName, @mIssueDate, @mReturnDate);";

                    SqlConnection connect = new SqlConnection(CONNECTION_STRING);
                    {
                        try
                        {
                            connect.Open();
                            using (SqlCommand cmd = new SqlCommand(sql, connect))
                            {

                                cmd.Parameters.Add("@cMemberNo", SqlDbType.VarChar).Value = cMemberNo;
                                cmd.Parameters.Add("@cFname", SqlDbType.VarChar).Value = cFirstName;
                                cmd.Parameters.Add("@cLname", SqlDbType.VarChar).Value = cLastName;
                                cmd.Parameters.Add("@cEmail", SqlDbType.VarChar).Value = cEmail;
                                cmd.Parameters.Add("@mName", SqlDbType.VarChar).Value = mName;
                                cmd.Parameters.Add("@mIssueDate", SqlDbType.VarChar).Value = mIssueDate;
                                cmd.Parameters.Add("@mReturnDate", SqlDbType.VarChar).Value = mReturnDate;


                                cmd.ExecuteNonQuery();
                                connect.Close();

                                MessageBox.Show("Book Issued!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                updateQuan();
                            }
                            

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Maximum Amount of Books have Been Issued for Member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select Movie Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCustRefresh_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Refresh?", "Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes && (txtcFirstName.Text != "" || txtCustSearch.Text != ""))
            {
                clearTextboxes();
            }

        }

        private void btnCustExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Exit? Any Unsaved Data will be Deleted.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}

