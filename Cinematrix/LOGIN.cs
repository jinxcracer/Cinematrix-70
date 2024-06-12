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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Username and Password", "",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "1234") 
                { 
                    MessageBox.Show("Welcome to Cinematrix","LOGIN SUCCESFULLY",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Username and Password is Incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
