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
namespace BloodBankOOAD.AdminForms
{
    public partial class GetByID : Form
    {
        public string bloodTranID;
        
        
        public GetByID(string ID)
        {
            InitializeComponent();
            bloodTranID = ID;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
           Transfusion tfs = new Transfusion();
            tfs = tfs.GetTransfusionbyID(bloodTranID);
            textBox1.Text = tfs.userid;
            textBox3.Text = tfs.hemo;
            textBox2.Text = tfs.amount;
            textBox4.Text = Convert.ToString(tfs.bill);
            textBox5.Text = tfs.branch;
            comboBox1.Text = tfs.typeoftransfusion;
            dateTimePicker1.Value = tfs.dot;
            dateTimePicker2.Value = tfs.dnt;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateTransfusion_Click(object sender, EventArgs e)
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
                BloodTranfuseController btc = new BloodTranfuseController();
                btc.UpdateTransfusion(textBox1.Text, comboBox1.Text, textBox3.Text, textBox2.Text, DateTime.Parse(dateTimePicker1.Text.ToString()), int.Parse(textBox4.Text), textBox5.Text, DateTime.Parse(dateTimePicker2.Text.ToString()));

                this.Hide();
                BloodTransfusion bt = new BloodTransfusion();
                bt.Show();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            BloodTransfusion bt = new BloodTransfusion();
            this.Hide();
            bt.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 'm' && e.KeyChar != 'l')
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
