using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MainUI : Form
    {
        string firstName = "";
        string lastName = "";
        string fatherName = "";
        string motherName = "";
        string address = "";
        public MainUI()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            textFirstName.Text = "";
            textLastName.Text = "";
            textFatherName.Text = "";
            textMothername.Text = "";
            textAddress.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            firstName = textFirstName.Text;
            lastName = textLastName.Text;
            fatherName = textFatherName.Text;
            motherName = textMothername.Text;
            address = textAddress.Text;

            MessageBox.Show("All the data has been saved successfully!");

            Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            textFirstName.Text = firstName;
            textLastName.Text = lastName;
            textFatherName.Text = fatherName;
            textMothername.Text = motherName;
            textAddress.Text = address;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            Clear();

            textFirstName.Text = firstName;
            textLastName.Text = lastName;
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            Clear();

            textFatherName.Text = fatherName;
            textMothername.Text = motherName;
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            Clear();

            textAddress.Text = address;
        }
    }
}
