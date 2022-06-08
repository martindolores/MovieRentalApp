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

namespace loginForm
{
    public partial class addMovie : Form
    {
        public addMovie()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Clear Textboxes?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                txtmName.Clear();
                txtmRating.Clear();
                txtmGenres.Clear();
                txtmDirectors.Clear();
                datetimemPurDate.Value = DateTime.Now;
                txtmPrice.Clear();
                txtQuan.Clear();
            }
        }   

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtmName.Text != "" && txtmRating.Text != "" && txtmGenres.Text != "" && txtmDirectors.Text != "" && txtmPrice.Text != "" && datetimemPurDate.Text != "" && txtQuan.Text != "")
            {
                string mName = txtmName.Text;
                string mRating = txtmRating.Text;
                string mGenres = txtmGenres.Text;
                string mDirectors = txtmDirectors.Text;
                string mDate = datetimemPurDate.Text;
                try
                {
                    Int64 mPrice = Int64.Parse(txtmPrice.Text);
                    Int64 mQuan = Int64.Parse(txtQuan.Text);

                 
                    string connectionString = null;
                    string sql = null;

                    connectionString = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True";

                    sql = "insert into newMovie values (@mName, @mRating, @mGenres, @mDirectors,@mPrice, @mPurDate, @mQuan)";

                    using (SqlConnection connect = new SqlConnection(connectionString))
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



                                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                                DataSet dataSet = new DataSet();
                                dataAdapter.Fill(dataSet);


                                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtmName.Clear();
                                txtmRating.Clear();
                                txtmGenres.Clear();
                                txtmDirectors.Clear();
                                txtmPrice.Clear();
                                txtQuan.Clear();
                                datetimemPurDate.Value = DateTime.Now;

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
                    MessageBox.Show("Please enter correct format for 'Price' or 'Quantity'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter all fields", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
