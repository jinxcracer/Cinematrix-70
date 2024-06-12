using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinematrix
{
    public partial class MovieSales : Form
    {
        public static string passingText;
        public static string passingTitle;

        private Form1 mainForm;

       
        public MovieSales(Form1 form)
        {
            InitializeComponent();
            mainForm = form; 
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void MovieSales_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            passingTitle = "Haikyu";
            passingText = "Haikyuu!! The Dumpster Battle is a 2024\nJapanese animated sports film written and \ndirected by Susumu Mitsunaka and \nproduced by Production I.G. Based \non Haruichi Furudate’s manga, the movie is \nthe fifth installment in the Haikyuu franchise \nand centers on the intense \nNational Inter High tournament match \nbetween Karasuno and Nekoma High School.";

            mainForm.ShowMovieBooking(); 
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passingTitle = "First Omen";
            passingText = "A young American woman is sent to Rome to \nbegin a life of service to the church, \nbut encounters a darkness that causes \nher to question her faith and uncovers a \nterrifying conspiracy that hopes to bring \nabout the birth of evil incarnate.";
            mainForm.ShowMovieBooking(); 
            this.Hide();
        }

        private void btMovie1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passingTitle = "John Wick";
            passingText = "An ex-hitman comes out of retirement to \ntrack down the gangsters who killed his dog \nand stole his car.";
            mainForm.ShowMovieBooking();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passingTitle = "Spiderman";
            passingText = "Spider-Man: Into the Spider-Verse is an \nanimated superhero film that follows the story \nof Miles Morales, a teenager who becomes \nthe new Spider-Man. The movie \nis set in a multiverse where multiple Spider-Men \nand Women from different dimensions converge \nto stop a threat to all realities.";
            mainForm.ShowMovieBooking();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            passingTitle = "Ratatouille";
            passingText = "A rat who can cook makes an unusual \nalliance with a young kitchen worker \nat a famous Paris restaurant.";
            mainForm.ShowMovieBooking();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            passingTitle = "Gran Turismo";
            passingText = "Based on the unbelievable, inspiring true \nstory of a team of underdogs - a struggling, \nworking-class gamer, a failed former race car \ndriver, and an idealistic motorsport exec \nwho risk it all to take on \nthe most elite sport in the world..";
            mainForm.ShowMovieBooking();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            passingTitle = "Transformers";
            passingText = "An ancient struggle between two \nCybertronian races, the heroic Autobots \nand the evil Decepticons, comes to Earth, \nwith a clue to the ultimate power held \nby a teenager.";
            mainForm.ShowMovieBooking();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            passingTitle = "The NUN";
            passingText = "A priest with a haunted past and \na novice on the threshold of her final \nvows are sent by the Vatican to investigate \nthe death of a young nun in Romania and \nconfront a malevolent force in the form of \na demonic nun.";
            mainForm.ShowMovieBooking();
            this.Hide();
        }
    }
}
