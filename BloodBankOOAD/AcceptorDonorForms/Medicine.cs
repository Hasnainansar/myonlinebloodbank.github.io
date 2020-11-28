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
using BloodBankOOAD.AcceptorDonorForms;

namespace BloodBankOOAD
{
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            FacadeController fc = new FacadeController();
            richTextBox1.Text = fc.MedData();
            //UserMedicineController umc = new UserMedicineController();
            //richTextBox1.Text= umc.MedData();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine m = new Medicine();
            m.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReports ur = new UserReports();
            ur.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourBill yb = new YourBill();
            yb.Show();
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
    }
}
