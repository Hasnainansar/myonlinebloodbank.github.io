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
    public partial class UpdateDonation : Form
    {
        int ID;
        DonationsController dc;
        public UpdateDonation(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void UpdateDonation_Load(object sender, EventArgs e)
        {
            Donations D = new Donations();
            dc = new DonationsController();
            D = dc.GetDonationsByID(ID);
            textBox5.Text = D.Sno.ToString();
            textBox1.Text = D.Name;
            textBox2.Text = D.Amount;
            textBox3.Text = D.Branch;
            textBox4.Text = D.UsedFor;
            
        }

        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            dc.UpdateDonation(int.Parse(textBox5.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
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
