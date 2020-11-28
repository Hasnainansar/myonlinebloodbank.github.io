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
    public partial class Donation : Form
    {
        DonationsController dc;
        public Donation()
        {
            InitializeComponent();
        }

        private void Donation_Load(object sender, EventArgs e)
        {
            dc= new DonationsController();
            dataGridView1.DataSource = dc.GetDonation().Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            NewDonation D = new NewDonation();
            this.Hide();
            D.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dc.SearchID(int.Parse(textBox1.Text)).Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDonation ud = new UpdateDonation(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
            this.Hide();
            ud.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewDonation D = new NewDonation();
            this.Hide();
            D.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
