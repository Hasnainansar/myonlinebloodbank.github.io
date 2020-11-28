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
    public partial class UpdateReport : Form
    {
        int ID;
        ReportController rc;
        public UpdateReport(int id)
        {
            InitializeComponent();
            ID = id;

        }

        private void UpdateReport_Load(object sender, EventArgs e)
        {
            ReportEntry re = new ReportEntry();
            rc = new ReportController();
            re = rc.GetReportByID(ID);
            textBox1.Text = re.ID.ToString();
            comboBox1.Text = re.BT;
            textBox2.Text = re.TP.ToString();
            textBox3.Text = re.TDesc;
            textBox5.Text = re.Age.ToString();
            dateTimePicker1.Value = re.TDate;
            dateTimePicker2.Value = re.RDate;


        }

        private void UpdateReports_Click(object sender, EventArgs e)
        {
            rc = new ReportController();
            rc.UpdateReport(int.Parse(textBox1.Text), comboBox1.Text, int.Parse(textBox2.Text), textBox3.Text, dateTimePicker1.Value, dateTimePicker2.Value,int.Parse(textBox5.Text));
            this.Hide();
            AllReports ar = new AllReports();
            ar.Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportGenerator rg = new ReportGenerator();
            rg.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
            AllReports ge = new AllReports();
            this.Hide();
            ge.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
