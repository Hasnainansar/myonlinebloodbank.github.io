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
using BloodBankOOAD.AdminForms;
namespace BloodBankOOAD.Classes
{
    public partial class LoggedInAsAdmin : Form
    {
        public LoggedInAsAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoggedInAsAdmin_Load(object sender, EventArgs e)
        {
            //BloodBankController bbc = new BloodBankController();
            //textBox1.Text = bbc.TotalAcceptors().ToString();
            //textBox2.Text = bbc.TotalDonors().ToString();
            //dataGridView1.DataSource = bbc.AllBloodInfo().Tables[0];

            //Create Refined Abstraction
            BloodData br = new BloodData();
            //Concrete Implementor and bridge
            br.Bank = new BloodBank();
            AcceptorDonorInfo adi = new AcceptorDonorInfo();
            textBox1.Text = adi.Acceptor().ToString();
            textBox2.Text = adi.Donors().ToString();
            dataGridView1.DataSource = br.AllBlood().Tables[0];
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodTransfusionEntry BT = new BloodTransfusionEntry();
            BT.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportGenerator rg = new ReportGenerator();
            rg.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MedicineAlloting ma = new MedicineAlloting();
            this.Hide();
            ma.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RetrievingDonating rd = new RetrievingDonating();
            this.Hide();
            rd.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Donation D = new Donation();
            this.Hide();
            D.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompleteInfoOfUsers c = new CompleteInfoOfUsers();
            c.Show();
        }
    }
}
