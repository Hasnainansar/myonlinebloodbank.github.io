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

namespace BloodBankOOAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 L = new Form1();
            L.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignUp S = new SignUp();
            S.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check;
            LoginController LC = new LoginController();
            check= LC.Logged(comboBox1.Text, int.Parse(textBox1.Text), textBox2.Text);
            if (check == true)
            {
                if (comboBox1.Text=="Admin")
                {
                    MessageBox.Show("Logged In");
                    this.Hide();
                    LoggedInAsAdmin LA = new LoggedInAsAdmin();
                    LA.Show();
                }
                else if (comboBox1.Text == "Donor" || comboBox1.Text == "Acceptor")
                {
                    MessageBox.Show("Logged In");
                    this.Hide();
                    LoggedInAsAcceptorDonor Lad = new LoggedInAsAcceptorDonor();
                    Lad.Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid UserName or password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Type";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs cu = new ContactUs();
            cu.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
