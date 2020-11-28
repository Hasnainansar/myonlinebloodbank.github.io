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
    public partial class UpdateByID : Form
    {
        int ID;
        public UpdateByID(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void UpdateByID_Load(object sender, EventArgs e)
        {
            DonatingRetrieving dr = new DonatingRetrieving();
            DonationEntryController dec = new DonationEntryController();
            dr = dec.GetDonationsByID(ID);
            textBox6.Text = dr.Sno.ToString();
            textBox1.Text = dr.NameID;
            textBox2.Text = dr.Amount;
            textBox3.Text = dr.ToFrom;
            textBox4.Text = dr.Price;
            textBox5.Text = dr.Branch;
            comboBox2.Text = dr.BloodType;
            comboBox3.Text = dr.Type;
            dateTimePicker1.Value = dr.Date;
        }

        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            DonationEntryController dec = new DonationEntryController();
            dec.UpdateDonationRetrieving(int.Parse(textBox6.Text),textBox1.Text,textBox2.Text,comboBox2.Text, comboBox3.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value);
            GetAllEntries ge = new GetAllEntries();
            this.Hide();
            ge.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GetAllEntries ge = new GetAllEntries();
            this.Hide();
            ge.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            GetAllEntries ge = new GetAllEntries();
            this.Hide();
            ge.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!='m' && e.KeyChar!='l') 
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
    }
}
