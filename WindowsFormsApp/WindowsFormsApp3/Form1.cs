using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            int ticketQuantity = Convert.ToInt32(textTicketQ.Text);
            double ticketPrice = 100;
            string message = "";

            if(ticketQuantity == 1)
            {
               ticketPrice = 100;
               message = "Hello! " + name + " you have brought " + ticketQuantity + " ticket and the price is " + ticketPrice;
            }

        }
    }
}
