using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cinematrix
{
    public partial class frmMovieCategory : Form
    {
        public frmMovieCategory()
        {
            InitializeComponent();
            LoadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmMovies frm = new frmMovies(this);
                frm.lblID.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtMovies.Text = dataGridView1[2, e.RowIndex].Value.ToString();

                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this movie?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=Cinematrix;Integrated Security=True;"))
                        {
                            cn.Open();
                            using (SqlCommand cm = new SqlCommand("DELETE FROM tblMovie WHERE id = @id", cn))
                            {
                                cm.Parameters.AddWithValue("@id", dataGridView1[1, e.RowIndex].Value.ToString());
                                cm.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Movie has been successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecords();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the movie: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();

            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=Cinematrix;Integrated Security=True;"))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand("SELECT * FROM tblMovie ORDER BY movie", cn))
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            i += 1;
                            dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["movie"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMovies frm = new frmMovies(this);
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
