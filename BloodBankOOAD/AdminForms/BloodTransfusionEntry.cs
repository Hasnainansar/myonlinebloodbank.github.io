using BloodBankOOAD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankOOAD.AdminForms;
namespace BloodBankOOAD
{
    public partial class BloodTransfusionEntry : Form
    {
        public BloodTransfusionEntry()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BloodTransfusionEntry_Load(object sender, EventArgs e)
        {
            //label17.Hide();
            //label18.Hide();
            //label19.Hide();
            //label20.Hide();
            //label21.Hide();
            //label22.Hide();
            //label23.Hide();
        //    label24.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoggedInAsAdmin LA = new LoggedInAsAdmin();
            LA.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodTransfusionEntry BT = new BloodTransfusionEntry();
            BT.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodTransfusion B = new BloodTransfusion();
            B.Show();
        }

        private void CreateEntry_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("ID should be entered in 4 characters");
            }
            else if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("Amount should be entered in ML min 5 characters");
            }
            else if (textBox3.Text.Length < 4)
            {
                MessageBox.Show("Hemoglobin should be entered in DL min 4 characters");
            }
            else
            {
                BloodTranfuseController bt = new BloodTranfuseController();
            bt.NewTransfusion(textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, DateTime.Parse(dateTimePicker1.Text), int.Parse(textBox4.Text), textBox5.Text, DateTime.Parse(dateTimePicker2.Text));
                
                
                textBox1.Clear();
                comboBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                textBox4.Clear();
                textBox5.Clear();
                dateTimePicker2.ResetText();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            ReportGenerator rg = new ReportGenerator();
            this.Hide();
            rg.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            CompleteInfoOfUsers cof = new CompleteInfoOfUsers();
            this.Hide();
            cof.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MedicineAlloting ma = new MedicineAlloting();
            this.Hide();
            ma.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            RetrievingDonating be = new RetrievingDonating();
            this.Hide(); be.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Donation D = new Donation();
            this.Hide();
            D.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!='m' && e.KeyChar != 'l')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 'd' && e.KeyChar != 'l')
            {
                e.Handled = true;
            }
        }
    }
}
