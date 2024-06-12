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

namespace Cinematrix
{
    public partial class frmMovies : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmMovieCategory frmcategory;
        public frmMovies(frmMovieCategory flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmcategory = flist;
            cn.Open();
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=CinematrixServer;Integrated Security=True;");

        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtMovies.Clear();
            txtMovies.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this movie?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    cm = new SqlCommand("INSERT INTo tblMovie(Movie)VALUEs(@movie)", cn);
                    cm.Parameters.AddWithValue("@movie", txtMovies.Text);
                    cm.ExecuteNonQuery();
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    MessageBox.Show("Record has been succesfully saved. ");
                    Clear();
                    frmcategory.LoadRecords();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this movie?", "Update Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    cm = new SqlCommand("UPDATE tblMovie SET movie = @movie WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@movie", txtMovies.Text);
                    cm.Parameters.AddWithValue("@id", lblID.Text); 
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Movie has been successfully updated.");
                    Clear();
                    frmcategory.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
