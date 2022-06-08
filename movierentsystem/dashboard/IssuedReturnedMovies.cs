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

    public partial class IssuedReturnedMovies : Form
    {
        const string CONNECTION_STRING = "data source = DESKTOP-3BH4BKK; database = MovieRentalApp; integrated security = True";

        //-------------------------Methods----------------------------------------------
        private void showIssuedList()
        {
            string sql = null;

            sql = "select * from issueMovie where issue_returnDate = 'NULL'";

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

                        dataGridIssuedList.DataSource = dataSet.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        //-----------------------------------------------------------------------
        private void showReturnList()
        {
            string sql = null;

            sql = "select * from issueMovie where issue_returnDate <> 'NULL' ";

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

                        dataGridReturnedList.DataSource = dataSet.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }
        //-----------------------------------------------------------------------

        public IssuedReturnedMovies()
        {
            InitializeComponent();
        }

        private void IssuedReturnedMovies_Load(object sender, EventArgs e)
        {
            showIssuedList();
            showReturnList();
             
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
