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
    public partial class UpdateMedicine : Form
    {
        int ID;
        public UpdateMedicine(int id)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            ID = id;

        }

        private void UpdateEntry_Click(object sender, EventArgs e)
        {
            MedicineController mc = new MedicineController();
            mc.UpdateUserMedicine(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString());
        }

        private void UpdateMedicine_Load(object sender, EventArgs e)
        {
            MedicineController mc = new MedicineController();
            MedicineEntry me = new MedicineEntry();
            me=mc.GetUserMedicineByID(ID);
            textBox1.Text = me.ID.ToString();
            textBox2.Text = me.Medicine;
            textBox3.Text = me.MedicineDesc;
            dateTimePicker1.Value = DateTime.Parse(me.TimeMedicine);
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MedicineAlloting ma = new MedicineAlloting();
            this.Hide();
            ma.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            MedicineAlloting m = new MedicineAlloting();
            this.Hide();
            m.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
