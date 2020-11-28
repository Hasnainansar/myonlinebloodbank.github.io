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
    public partial class AllReports : Form
    {
        ReportController rc;
        public AllReports()
        {
            InitializeComponent();
        }

        private void AllReports_Load(object sender, EventArgs e)
        {
            rc = new ReportController();
            dataGridView1.DataSource = rc.GetReports().Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rc = new ReportController();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rc.SearchID(int.Parse(textBox1.Text)).Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateReport ur = new UpdateReport(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            ur.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportGenerator rg = new ReportGenerator();
            rg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportGenerator rg = new ReportGenerator();
            this.Hide();
            rg.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            CompleteInfoOfUsers cof = new CompleteInfoOfUsers();
            this.Hide();
            cof.Show();
        }
    }
}
