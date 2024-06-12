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
    public partial class Receipt : Form
    {
        public Receipt(string title , int tickets, int amount)
        {
            InitializeComponent();
            txt_title.Text = title;
            txt_ticket.Text = tickets.ToString();
            txt_amount.Text = amount.ToString();
           
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
