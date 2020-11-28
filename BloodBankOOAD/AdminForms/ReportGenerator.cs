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
    public partial class ReportGenerator : Form
    {
        public ReportGenerator()
        {
            InitializeComponent();
        }

        private void ReportGenerator_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateEntry_Click(object sender, EventArgs e)
        {
         ReportController rm = new ReportController();
                rm.RegisterReports(int.Parse(textBox1.Text), comboBox1.Text, int.Parse(textBox2.Text), textBox3.Text, dateTimePicker1.Value, dateTimePicker2.Value, int.Parse(textBox5.Text));
                textBox1.Text = null;
                textBox3.Text = null;
                textBox2.Text = null;

                textBox5.Text = null;
                comboBox1.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllReports ar = new AllReports();
            ar.Show();


        }

        private void label25_Click(object sender, EventArgs e)
        {
            LoggedInAsAdmin rg = new LoggedInAsAdmin();
            this.Hide();
            rg.Show();
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
            this.Hide();
            be.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportGenerator RG = new ReportGenerator();
            RG.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            CompleteInfoOfUsers be = new CompleteInfoOfUsers();
            this.Hide();
            be.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MedicineAlloting be = new MedicineAlloting();
            this.Hide();
            be.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            RetrievingDonating be = new RetrievingDonating();
            this.Hide();
            be.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Donation be = new Donation();
            this.Hide();
            be.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
