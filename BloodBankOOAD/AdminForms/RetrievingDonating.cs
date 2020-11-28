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
    public partial class RetrievingDonating : Form
    {
        public RetrievingDonating()
        {
            InitializeComponent();
        }

        private void Transfusion_Click(object sender, EventArgs e)
        {
            DonationEntryController dec = new DonationEntryController();
            dec.RegisterDonationRetrieving(textBox1.Text, textBox2.Text, comboBox2.Text, comboBox3.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value);

            GetAllEntries ge = new GetAllEntries();
            this.Hide();
            ge.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

            GetAllEntries ge = new GetAllEntries();
            this.Hide();
            ge.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            LoggedInAsAdmin la = new LoggedInAsAdmin();
            this.Hide();
            la.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            BloodTransfusionEntry be = new BloodTransfusionEntry();
            this.Hide(); be.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            ReportGenerator be = new ReportGenerator();
            this.Hide(); be.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            CompleteInfoOfUsers be = new CompleteInfoOfUsers();
            this.Hide(); be.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MedicineAlloting be = new MedicineAlloting();
            this.Hide(); be.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            RetrievingDonating be = new RetrievingDonating();
            this.Hide(); be.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            Donation be = new Donation();
            this.Hide(); be.Show();
        }

        private void RetrievingDonating_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
