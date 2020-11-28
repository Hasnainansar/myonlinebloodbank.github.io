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
    public partial class NewMedicine : Form
    {
        public NewMedicine()
        {
            InitializeComponent();
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm:tt";
         
            dateTimePicker1.ShowUpDown = true;
        }

        private void NewMedicine_Load(object sender, EventArgs e)
        {

        }

        private void CreateEntry_Click(object sender, EventArgs e)
        {
            MedicineController mc = new MedicineController();
            DateTime temp = dateTimePicker1.Value;
            string s = temp.ToString("hh:mm:tt");
            
            string a = dateTimePicker1.Value.ToString("hh:mm:tt");
            mc.RegisterUserMedicine(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, temp.ToShortTimeString());

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MedicineAlloting ma = new MedicineAlloting();
            this.Hide();
            ma.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
            MedicineAlloting ma = new MedicineAlloting();
            this.Hide();
            ma.Show();
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
    }
}
