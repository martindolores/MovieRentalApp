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
    public partial class viewMovie : Form
    {

        const string CONNECTION_STRING = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True"; 
        private Int64 rowid;


        public viewMovie()
        {
            InitializeComponent();
        }

        //------------------------------Methods---------------------------------------------
        private void refreshMovieList()
        {
            string sql = null;

            sql = "select* from newMovie";

            using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
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
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void clearAllTextbox()
        {
            txtmName.Clear();
            txtmRating.Clear();
            txtmGenres.Clear();
            txtmDirectors.Clear();
            txtmPrice.Clear();
            txtmQuan.Clear();
            dateTimePurDate.Value = DateTime.Now;
        }

        //--------------------------------------------------------------------------------------------



        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Clear Textboxes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                panelMovieInfo.Visible = false;
            }
        }

        private void viewMovie_Load(object sender, EventArgs e)
        {
            panelMovieInfo.Visible = false;
            refreshMovieList();
        }


        private void dataGridMovieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelMovieInfo.Visible = true;

            int mid;
            string sqlQuery1 = null;
            string sqlQuery2 = null;

            sqlQuery1 = "select* from newMovie";
            sqlQuery2 = "select * from newMovie where mid = @mid";

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
                                mid = int.Parse(dataGridMovieList.Rows[e.RowIndex].Cells[0].Value.ToString());
                                cmd2.Parameters.Add("@mid", SqlDbType.Int).Value = mid;
                                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
                                DataSet dataSet2 = new DataSet();
                                dataAdapter2.Fill(dataSet2);

                                // Updates Local variable 'rowid' for use in btnDelete
                                rowid = Int64.Parse(dataSet2.Tables[0].Rows[0][0].ToString());

                                txtmName.Text = dataSet2.Tables[0].Rows[0][1].ToString();
                                txtmRating.Text = dataSet2.Tables[0].Rows[0][2].ToString();
                                txtmGenres.Text = dataSet2.Tables[0].Rows[0][3].ToString();
                                txtmDirectors.Text = dataSet2.Tables[0].Rows[0][4].ToString();
                                txtmPrice.Text = dataSet2.Tables[0].Rows[0][5].ToString();
                                dateTimePurDate.Text = dataSet2.Tables[0].Rows[0][6].ToString();
                                txtmQuan.Text = dataSet2.Tables[0].Rows[0][7].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Please Select Valid Movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are you sure you want to exit? Any unsaved data will be deleted.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtmSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = null;            
            sql = "select* from newMovie where mName LIKE @mName";
            
            if (txtmSearch.Text != "")
            {


                using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            cmd.Parameters.Add("@mName", SqlDbType.VarChar).Value = $"%{txtmSearch.Text}%";
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
                refreshMovieList();
                }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtmSearch.Clear();
            panelMovieInfo.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtmName.Text != "" && txtmRating.Text != "" && txtmGenres.Text != "" && txtmDirectors.Text != "" && txtmPrice.Text != "" && dateTimePurDate.Text != "" && txtmQuan.Text != "")
            {

                

                string mName = txtmName.Text;
                string mRating = txtmRating.Text;
                string mGenres = txtmGenres.Text;
                string mDirectors = txtmDirectors.Text;
                string mDate = dateTimePurDate.Text;
                try
                {
                    Int64 mPrice = Int64.Parse(txtmPrice.Text);
                    Int64 mQuan = Int64.Parse(txtmQuan.Text);
 

                    string sql = null;


                    sql = "update newMovie set mName = @mName, mRating = @mRating, mGenres = @mGenres, mDirectors = @mDirectors,  mPrice = @mPrice, mPurDate = @mPurDate, mQuan = @mQuan where mid = @rowid";

                    if (MessageBox.Show("Are you sure you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
                        {
                            try
                            {
                                connect.Open();
                                using (SqlCommand cmd = new SqlCommand(sql, connect))
                                {
                                    cmd.Parameters.Add("@mName", SqlDbType.VarChar).Value = mName;
                                    cmd.Parameters.Add("@mRating", SqlDbType.VarChar).Value = mRating;
                                    cmd.Parameters.Add("@mGenres", SqlDbType.VarChar).Value = mGenres;
                                    cmd.Parameters.Add("@mDirectors", SqlDbType.VarChar).Value = mDirectors;
                                    cmd.Parameters.Add("@mPrice", SqlDbType.BigInt).Value = mPrice;
                                    cmd.Parameters.Add("@mPurDate", SqlDbType.VarChar).Value = mDate;
                                    cmd.Parameters.Add("@mQuan", SqlDbType.BigInt).Value = mQuan;
                                    cmd.Parameters.Add("@rowid", SqlDbType.Int).Value = rowid;



                                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                                    DataSet dataSet = new DataSet();
                                    dataAdapter.Fill(dataSet);


                                    MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearAllTextbox();
                                    refreshMovieList();

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
            var DialogResult = MessageBox.Show("Are you sure you want to Delete?", "Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning); 
            if(DialogResult == DialogResult.Yes)
            {
                string sql = null;

                sql = "delete from newMovie where mid = @id";

                using (SqlConnection connect = new SqlConnection(CONNECTION_STRING))
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = rowid;

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
                        refreshMovieList();
                        clearAllTextbox();

                    }
                }
            }
        }
    }
}

