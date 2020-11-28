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

namespace BloodBankOOAD.AcceptorDonorForms
{
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            User_Information l = new User_Information();
            l.Show();
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
            UserBloodTranfuse ubt = new UserBloodTranfuse();
            ubt.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReports ur = new UserReports();
            ur.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Information u = new User_Information();
            u.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine m = new Medicine();
            m.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourBill yb = new YourBill();
            yb.Show();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            UserUpdate u = new UserUpdate();
            UserUpdateController uup = new UserUpdateController();
            textBox1.Text = User.UserID.ToString();

            if (uup.UserInformation().CellNo != null)
            {
                u = uup.UserInformation();
                
                comboBox1.Text = u.Type;
                textBox2.Text = u.FirstName;
                textBox3.Text = u.LastName;
                textBox4.Text = u.FatherName;
                comboBox2.Text = u.BG;
                textBox5.Text = u.NIC;
                dateTimePicker1.Text = u.DOB.ToString();
                textBox6.Text = u.PEmail;
                textBox7.Text = u.TEmail;
                textBox8.Text = u.Paddress;
                textBox9.Text = u.TAddress;
                textBox10.Text = u.Country;
                textBox11.Text = u.City;
                textBox12.Text = u.PostalCode.ToString();
                textBox13.Text = u.CellNo;
                textBox14.Text = u.Pass;
            }
        }

        private void UserUpdate_Click(object sender, EventArgs e)
        {
            if (textBox13.Text.Length <11)
            {
                MessageBox.Show("Cell Number should be 11 characters");
            }
            else if (textBox5.Text.Length <18)
            {
                MessageBox.Show("NIC should be min 18 characters");
            }
            else if (textBox12.Text.Length < 5)
            {
                MessageBox.Show("Postal code should be at least 5 characters");
            }
            else if (textBox2.Text.Length <3 && textBox3.Text.Length<3 && textBox4.Text.Length <3)
            {
                MessageBox.Show("First Name,Last Name,Father Name should be at least 3 characters");
            }
            else if (textBox6.Text.Length <13 && textBox7.Text.Length<13)
            {
                MessageBox.Show("Permanant and Temporary Email should be atleast 13 characters with @ and .com in it");
            }
            else if (textBox8.Text.Length <5 && textBox9.Text.Length < 5 && textBox10.Text.Length < 5 && textBox11.Text.Length < 5)
            {
                MessageBox.Show("Permanant Address,Temporary Address,Country,City should be at least 5 characters");
            }
            else if (textBox14.Text.Length <6)
            {
                MessageBox.Show("Password should be atleast 6 characters");
            }
            else
            {
                UserUpdateController uup = new UserUpdateController();
                uup.updateauser(comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox2.Text, textBox5.Text, DateTime.Parse(dateTimePicker1.Text), textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, int.Parse(textBox12.Text), textBox13.Text, textBox14.Text);
                MessageBox.Show("Data Updated Successfully");
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!='-')
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
