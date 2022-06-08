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
    public partial class viewCustomers : Form
    {
        
        //Constants && Variables-----------------------------------------------------------
        const string CONNECTION_STRING = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True";
        private Int64 rowid;

        //Methods--------------------------------------------------------------------------
        private void refreshCustList()
        {
            string sql = null;

            sql = "select * from CustomerDetails";

            SqlConnection connect = new SqlConnection(CONNECTION_STRING);
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        dataGridMovieList.DataSource = dataSet.Tables[0];
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }
        }

        private void clearTextboxes()
        {
            txtcFirstName.Clear();
            txtcLastName.Clear();
            txtcEmail.Clear();
            datetimecSubDate.Value = DateTime.Now;
            txtcAddr.Clear();
            txtcSub.Clear();
            txtcState.Clear();
            txtcPost.Clear();
            txtcMemberNo.Clear();
        }

        //Events-------------------------------------------------------------------
        public viewCustomers()
        {
            InitializeComponent();
        }

       
        private void viewCustomers_Load(object sender, EventArgs e)
        {
            panelCustDetails.Visible = false;
            txtcMemberNo.ReadOnly = true;
            refreshCustList();
        }

        private void dataGridMovieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelCustDetails.Visible = true;

            int custid;
            string sqlQuery1 = null;
            string sqlQuery2 = null;

            sqlQuery1 = "select* from CustomerDetails";
            sqlQuery2 = "select * from CustomerDetails where custid = @custid";

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
                            if (dataGridMovieList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                            {
                                custid = int.Parse(dataGridMovieList.Rows[e.RowIndex].Cells[0].Value.ToString());
                                cmd2.Parameters.Add("@custid", SqlDbType.Int).Value = custid;
                                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
                                DataSet dataSet2 = new DataSet();
                                dataAdapter2.Fill(dataSet2);

                                rowid = Int64.Parse(dataSet2.Tables[0].Rows[0][0].ToString());

                                txtcFirstName.Text = dataSet2.Tables[0].Rows[0][1].ToString();
                                txtcLastName.Text = dataSet2.Tables[0].Rows[0][2].ToString();
                                txtcEmail.Text = dataSet2.Tables[0].Rows[0][3].ToString();
                                datetimecSubDate.Text = dataSet2.Tables[0].Rows[0][4].ToString();
                                txtcAddr.Text = dataSet2.Tables[0].Rows[0][5].ToString();
                                txtcSub.Text = dataSet2.Tables[0].Rows[0][6].ToString();
                                txtcState.Text = dataSet2.Tables[0].Rows[0][7].ToString();
                                txtcPost.Text = dataSet2.Tables[0].Rows[0][8].ToString();
                                txtcMemberNo.Text = dataSet2.Tables[0].Rows[0][9].ToString();

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

        //Buttons ---------------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You want to Clear Textboxes?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                clearTextboxes();
                panelCustDetails.Visible = false;
            }
               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtcFirstName.Text != "" && txtcLastName.Text != "" && txtcEmail.Text != "" && datetimecSubDate.Text != "" && txtcAddr.Text != "" && txtcSub.Text != "" && txtcState.Text != "" && txtcPost.Text != "")
            {
                string cFname = txtcFirstName.Text;
                string cLname = txtcLastName.Text;
                string cEmail = txtcEmail.Text;
                string cDate = datetimecSubDate.Text;
                string cAddr = txtcAddr.Text;
                string cSub = txtcSub.Text;
                string cState = txtcState.Text;
                try
                {
                    Int64 cPost = Int64.Parse(txtcPost.Text);


                    string sql = null;


                    sql = "update CustomerDetails set custfname = @custfname, custlname = @custlname, custemail = @custemail, custdate = @custdate,  custaddr = @custaddr, custsub = @custsub, custstate = @custstate, custpost = @custpost where custid = @rowid";

                    if (MessageBox.Show("Are you sure you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
                        {
                            try
                            {
                                connect.Open();
                                using (SqlCommand cmd = new SqlCommand(sql, connect))
                                {
                                    cmd.Parameters.Add("@custfname", SqlDbType.VarChar).Value = cFname;
                                    cmd.Parameters.Add("@custlname", SqlDbType.VarChar).Value = cLname;
                                    cmd.Parameters.Add("@custemail", SqlDbType.VarChar).Value = cEmail;
                                    cmd.Parameters.Add("@custdate", SqlDbType.VarChar).Value = cDate;
                                    cmd.Parameters.Add("@custaddr", SqlDbType.VarChar).Value = cAddr;
                                    cmd.Parameters.Add("@custsub", SqlDbType.VarChar).Value = cSub;
                                    cmd.Parameters.Add("@custstate", SqlDbType.VarChar).Value = cState;
                                    cmd.Parameters.Add("@custpost", SqlDbType.BigInt).Value = cPost;
                                    cmd.Parameters.Add("@rowid", SqlDbType.BigInt).Value = rowid;


                                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                                    DataSet dataSet = new DataSet();
                                    dataAdapter.Fill(dataSet);


                                    MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearTextboxes();
                                    refreshCustList();

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR: " + ex.Message);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter correct format for 'Price' or 'Quantity'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Please enter all fields", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                string sql = null;

                sql = "delete from CustomerDetails where custid = @rowid";

                using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            cmd.Parameters.Add("@rowid", SqlDbType.Int).Value = rowid;

                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                    finally
                    {
                        panelCustDetails.Visible = false;
                        refreshCustList();
                        clearTextboxes();

                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Exit? Any Unsaved Data will be deleted.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtmSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = null;
            sql = "select* from CustomerDetails where custlname LIKE @custlname";

            if (txtmSearch.Text != "")
            {


                using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            cmd.Parameters.Add("@custlname", SqlDbType.VarChar).Value = $"%{txtmSearch.Text}%";
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);

                            dataGridMovieList.DataSource = dataSet.Tables[0];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                }
            }
            else
            {
                refreshCustList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshCustList();
            panelCustDetails.Visible = false;
        }




    }
}
