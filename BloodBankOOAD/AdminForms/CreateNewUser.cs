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

namespace BloodBankOOAD.AdminForms
{
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompleteInfoOfUsers c = new CompleteInfoOfUsers();
            c.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CompleteInfoOfUsers c = new CompleteInfoOfUsers();
            c.Show();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            SignUpController suc = new SignUpController();
            if (textBox1.Text.Length < 3 && textBox2.Text.Length < 3 && textBox3.Text.Length < 3)
            {
                MessageBox.Show("First Name,Last Name,Father Name Should be at least 3 characters");
            }
            else if (textBox5.Text.Length < 18)
            {
                MessageBox.Show("NIC should be at least 18 characters");
            }
            else if (textBox7.Text.Length < 13 && textBox9.Text.Length < 13)
            {
                MessageBox.Show("Permenant and Temporary Email should contain minimum 13 characters and containing @ and .com in it");
            }
            else if (textBox8.Text.Length < 5 && textBox4.Text.Length < 5 && textBox6.Text.Length < 5 && textBox11.Text.Length < 5)
            {
                MessageBox.Show("Permanant and Temporary Address,Country and City should be at least 5 characters");
            }
            else if (textBox12.Text.Length < 5)
            {
                MessageBox.Show("Postal Code Should at least 5 characters");
            }
            else if (textBox13.Text.Length < 11)
            {
                MessageBox.Show("Cell no Should Be min and max 11 characters");
            }
            else if (textBox14.Text.Length < 6 && textBox15.Text.Length < 6)
            {
                MessageBox.Show("Password Should be atleast 6 characters");
            }
            else if (textBox14.Text != textBox15.Text)
            {
                MessageBox.Show("The Password and Confirm Password do not match");
            }
            else if (textBox14.Text == textBox15.Text)
            {
                suc.NewUser(comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox5.Text, DateTime.Parse(dateTimePicker1.Text), textBox7.Text, textBox9.Text, textBox8.Text, textBox4.Text, textBox6.Text, textBox11.Text, int.Parse(textBox12.Text), textBox13.Text, textBox15.Text);
                MessageBox.Show("User Created");
                //textBox10.Clear();
                comboBox2.Text = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                textBox5.Clear();
                dateTimePicker1.ResetText();
                textBox7.Clear();
                textBox9.Clear();
                textBox8.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
            }
        }
    }
}
