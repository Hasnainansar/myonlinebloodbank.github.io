using BloodBankOOAD.AdminForms;
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
namespace BloodBankOOAD.Classes
{
    public partial class BloodTransfusion : Form
    {
        BloodTranfuseController btc;
        public BloodTransfusion()
        {
            InitializeComponent();
        }

        private void BloodTransfusion_Load(object sender, EventArgs e)
        {
            btc = new BloodTranfuseController();
            dataGridView1.DataSource=btc.AllTransfusion().Tables[0];
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            GetByID u = new GetByID(dataGridView1.SelectedCells[0].Value.ToString());
            u.Show();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodTransfusionEntry bte = new BloodTransfusionEntry();
            bte.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            btc = new BloodTranfuseController();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = btc.SearchID(textBox1.Text).Tables[0];
        

        }

        private void label10_Click(object sender, EventArgs e)
        {
            MedicineAlloting ma = new MedicineAlloting();
            this.Hide();

            ma.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            BloodTransfusionEntry la= new BloodTransfusionEntry();
            
            this.Hide();
            la.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            RetrievingDonating be = new RetrievingDonating();
            this.Hide(); be.Show();
        }
    }
}
