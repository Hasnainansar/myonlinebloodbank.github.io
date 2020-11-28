using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BloodBankOOAD.Classes;

namespace BloodBankOOAD.AcceptorDonorForms
{
    public partial class UserReports : Form
    {
        public UserReports()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReports ur = new UserReports();
            ur.Show();
        }

        private void UserReports_Load(object sender, EventArgs e)
        {
            FacadeController fc = new FacadeController();
            //UserReportsController urc = new UserReportsController();
            richTextBox1.Text = fc.Data();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBloodTranfuse u = new UserBloodTranfuse();
            u.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateUser uu = new UpdateUser();
            uu.Show();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoggedInAsAcceptorDonor l = new LoggedInAsAcceptorDonor();
            l.Show();
        }
    }
}
