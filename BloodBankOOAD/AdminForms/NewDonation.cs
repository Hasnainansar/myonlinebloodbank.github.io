using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankOOAD.Classes;
namespace BloodBankOOAD.AdminForms
{
    public partial class NewDonation : Form
    {
        public NewDonation()
        {
            InitializeComponent();
        }

        private void NewDonation_Load(object sender, EventArgs e)
        {

        }

        private void CreateEntry_Click(object sender, EventArgs e)
        {
            DonationsController dc = new DonationsController();
            dc.RegisterDonation( textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Donation D = new Donation();
            this.Hide();
            D.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Donation D = new Donation();
            this.Hide();
            D.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Donation D = new Donation();
            this.Hide();
            D.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
