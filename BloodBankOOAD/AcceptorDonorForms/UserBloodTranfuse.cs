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
    public partial class UserBloodTranfuse : Form
    {
        public UserBloodTranfuse()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBloodTranfuse_Load(object sender, EventArgs e)
        {
            FacadeController fc = new FacadeController();
            textBox1.Text = User.UserID.ToString();
            //UserTransfuseController utc = new UserTransfuseController();
            int no = fc.ID();
            if (fc.TransfusionData().tt != null)
            {
                UserBloodTransfusee u;
                u = fc.TransfusionData();
                
                u = fc.TransfusionData();
                comboBox1.Text = u.tt;
                textBox2.Text = u.ab;
                textBox3.Text = u.h;
                dateTimePicker1.Value = u.dot;
                textBox4.Text = u.p.ToString();
                textBox5.Text = u.b;
                dateTimePicker2.Text = u.dnt.ToString();
            }

   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Transfuse_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("ml") && !textBox3.Text.Contains("dl"))
            {
                MessageBox.Show("You need no enter amount of blood in ml and hemoglobin in dl");
            }
            else
            {
                FacadeController fc = new FacadeController();
                //UserTransfuseController utc = new UserTransfuseController();

                fc.UpdatingTransfusion(User.UserID, comboBox1.Text, textBox2.Text, textBox3.Text, DateTime.Parse(dateTimePicker1.Text), int.Parse(textBox4.Text), textBox5.Text, DateTime.Parse(dateTimePicker2.Text));
                textBox1.Clear();
                comboBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                textBox4.Clear();
                textBox5.Clear();
                dateTimePicker2.ResetText();
                if (fc.TransfusionData().tt == null)
                {
                    MessageBox.Show("Data Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Data Updated Successfully");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoggedInAsAcceptorDonor l = new LoggedInAsAcceptorDonor();
            l.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Information u = new User_Information();
            u.Show();
        }

        private void textBox2_DockChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar !='d' && e.KeyChar != 'l')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 'm' && e.KeyChar != 'l')
            {
                e.Handled = true;
            }
        }
    }
}
