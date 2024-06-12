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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VDBAAMB\SQLEXPRESS;Initial Catalog=CinematrixServer;Integrated Security=True;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMovieCategory frm = new frmMovieCategory();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MovieSales frm = new MovieSales(this); // Pass the current instance of Form1 to MovieSales
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN lg = new LOGIN();
            lg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 61)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 211)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        public void ShowMovieBooking()
        {
           
            panel4.Controls.Clear();

            
            MovieBooking bookingForm = new MovieBooking();
            bookingForm.TopLevel = false;
            panel4.Controls.Add(bookingForm);
            bookingForm.Dock = DockStyle.Fill;
            bookingForm.Show();
        }
       
    }
}
