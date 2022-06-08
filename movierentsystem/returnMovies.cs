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
    public partial class returnMovies : Form
    {
        const string CONNECTION_STRING = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True";
        Int64 rowid;

        private void clearTextboxes()
        {
            txtCustSearch.Clear();
            txtmName.Clear();
            datetimeiReturnDate.Value = DateTime.Now;
        }

        private void showCustList(string sql, string memberNo)
        {
            SqlConnection connect = new SqlConnection(CONNECTION_STRING);
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.Add("@cmemberno", SqlDbType.VarChar).Value = memberNo;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        dataGridCustList.DataSource = dataSet.Tables[0];
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }
        public returnMovies()
        {
            InitializeComponent();
        }

        private void returnMovies_Load(object sender, EventArgs e)
        {
            panelReturnMovie.Visible = false;
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            if (txtCustSearch.Text != "")
            {
                string sql = null;
                string custid = null;
                string custid2 = null;


                sql = "select * from issueMovie where cust_memberNo = @cmemberno";


                SqlConnection connect = new SqlConnection(CONNECTION_STRING);
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {

                            custid = txtCustSearch.Text;
                            custid2 = txtCustSearch.Text;
                            cmd.Parameters.Add("@cmemberno", SqlDbType.VarChar).Value = custid;


                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);


                            var rows = dataSet.Tables[0].Rows;

                            //Checks if customers exist or not
                            if (rows.Count != 0)
                            {
                                showCustList(sql, custid2);
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

        private void dataGridCustList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelReturnMovie.Visible = true;

            string custMemberNo;
            string sqlQuery1 = null;
            string sqlQuery2 = null;

            sqlQuery1 = "select* from issueMovie";
            sqlQuery2 = "select * from issueMovie where cust_memberNo = @cust_memberNo";

            using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
            {
                try
                {

                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery1, connect))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        using (SqlCommand cmd2 = new SqlCommand(sqlQuery2, connect))
                        {
                            if (dataGridCustList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                            {
                                custMemberNo = dataGridCustList.Rows[e.RowIndex].Cells[1].Value.ToString();
                                cmd2.Parameters.Add("@cust_memberNo", SqlDbType.VarChar).Value = custMemberNo;
                                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
                                DataSet dataSet2 = new DataSet();
                                dataAdapter2.Fill(dataSet2);

                                rowid = Int64.Parse(dataSet2.Tables[0].Rows[e.RowIndex][0].ToString());

                                txtmName.Text = dataSet2.Tables[0].Rows[0][5].ToString();
                                txtIssueDate.Text = dataSet2.Tables[0].Rows[0][6].ToString();
                                
                                
                            }
                            else
                            {
                                MessageBox.Show("Please Select Valid Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            string sql = null;
            string issue_returnDate = datetimeiReturnDate.Text;

            sql = "update issueMovie set issue_returnDate = @issue_returnDate where id = @rowid";

            SqlConnection connect = new SqlConnection(CONNECTION_STRING);
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.Add("@issue_returnDate", SqlDbType.VarChar).Value = issue_returnDate;
                        cmd.Parameters.Add("@rowid", SqlDbType.Int).Value = rowid;

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        cmd.ExecuteNonQuery();
                        connect.Close();

                        MessageBox.Show("Movie Returned!", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridCustList.DataSource = null;
                        panelReturnMovie.Visible = false;
                        clearTextboxes();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
                                
            }
        }

        private void btnCustRefresh_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Refresh?", "Refesh", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes)
            {
                clearTextboxes();
                dataGridCustList.DataSource = null;
                panelReturnMovie.Visible = false;
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
