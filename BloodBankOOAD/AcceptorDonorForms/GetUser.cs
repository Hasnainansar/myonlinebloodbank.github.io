using BloodBankOOAD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankOOAD.AcceptorDonorForms;

namespace BloodBankOOAD.AcceptorDonorForms
{
    public partial class User_Information : Form
    {
        public User_Information()
        {
            InitializeComponent();
        }

        private void User_Information_Load(object sender, EventArgs e)
        {
            FacadeController fc = new FacadeController();
            //UserUpdateController uic = new UserUpdateController();
            BindingSource bs = new BindingSource();
            bs.DataSource = fc.User();
            dataGridView1.DataSource = bs;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UpdateUser u = new UpdateUser();
            u.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoggedInAsAcceptorDonor l = new LoggedInAsAcceptorDonor();
            l.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBloodTranfuse ub = new UserBloodTranfuse();
            ub.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReports ur = new UserReports();
            ur.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Information u = new User_Information();
            u.Show();
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
    }
}
