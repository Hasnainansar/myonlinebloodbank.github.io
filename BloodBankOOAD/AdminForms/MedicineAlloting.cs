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
    public partial class MedicineAlloting : Form
    {
         MedicineController umc;
        public MedicineAlloting()
        {
            InitializeComponent();
        }

        private void MedicineAlloting_Load(object sender, EventArgs e)
        {
           umc = new MedicineController();
            dataGridView1.DataSource = umc.GetUserMedicine().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateMedicine um = new UpdateMedicine(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
            um.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            umc = new MedicineController();
            dataGridView1.DataSource=null;
            dataGridView1.DataSource=umc.SearchID(int.Parse(textBox1.Text)).Tables[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMedicine nm = new NewMedicine();
            this.Hide();
            nm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoggedInAsAdmin la = new LoggedInAsAdmin();
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
    }
}
