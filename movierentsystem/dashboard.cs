using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        
        private void addNewMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            addMovie newMovie = new addMovie();
            newMovie.ShowDialog();
        }

        private void viewMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewMovie movieList = new viewMovie();
            movieList.ShowDialog();
        }

        private void menuitemClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuitemLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm login = new loginForm();
                this.Close();
                login.Show();
            }
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer customerAdd = new addCustomer();
            customerAdd.ShowDialog();
            
        }

        private void viewCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCustomers customersList = new viewCustomers();
            customersList.ShowDialog();
        }

        private void issueMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueMovie issueMovie = new issueMovie();
            issueMovie.ShowDialog();
        }

        private void returnMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnMovies returnMovie = new returnMovies();
            returnMovie.ShowDialog();
        }

        private void IssuedReturnedDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssuedReturnedMovies movies = new IssuedReturnedMovies();
            movies.ShowDialog();
        }
    }
}
