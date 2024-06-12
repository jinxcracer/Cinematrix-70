using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinematrix
{
    public partial class MovieBooking : Form
    {
        
        public MovieBooking()
        {
            InitializeComponent();
            this.Load += new EventHandler(MovieBooking_Load);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTickets.SelectedItem.ToString() == "0")

                lbAmount.Text = cmbTickets.Text = "amount";

            else if (cmbTickets.SelectedItem.ToString() == "1")
                lbAmount.Text = cmbTickets.Text = "100";
            else if (cmbTickets.SelectedItem.ToString() == "2")
                lbAmount.Text = cmbTickets.Text = "200";
            else if (cmbTickets.SelectedItem.ToString() == "3")
                lbAmount.Text = cmbTickets.Text = "300";
            else if (cmbTickets.SelectedItem.ToString() == "4")
                lbAmount.Text = cmbTickets.Text = "400";
            else if (cmbTickets.SelectedItem.ToString() == "5")
                lbAmount.Text = cmbTickets.Text = "500";
            else if (cmbTickets.SelectedItem.ToString() == "6")
                lbAmount.Text = cmbTickets.Text = "600";
            else if (cmbTickets.SelectedItem.ToString() == "7")
                lbAmount.Text = cmbTickets.Text = "700";
            else if (cmbTickets.SelectedItem.ToString() == "8")
                lbAmount.Text = cmbTickets.Text = "800";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void MovieBooking_Load(object sender, EventArgs e)
        {
            Description.Text = MovieSales.passingText;
            Title.Text = MovieSales.passingTitle;
            if (Title.Text == "Haikyu")
            {
            pictureBox1.Image = Resource1.Haikyu;
            }
               
            if (Title.Text == "The First Omen")
            {
                pictureBox1.Image = Resource1.First_Omen;
            }
                
            if (Title.Text == "John Wick")
                pictureBox1.Image = Resource1.John_Wick;
            if (Title.Text == "Spiderman")
                pictureBox1.Image = Resource1.Spiderman;
            if (Title.Text == "Ratatouille")
                pictureBox1.Image = Resource1.Ratatouille;
            if(Title.Text == "Gran Turismo")
                pictureBox1.Image = Resource1.Gran_Turismo;
            if (Title.Text == "Transformers")
                pictureBox1.Image = Resource1.Transformers;
            if (Title.Text == "The NUN")
                pictureBox1.Image = Resource1.The_NUN;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 bck = new Form1();
            bck.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seats ss = new Seats();
            ss.Show();
        }
    }
}

