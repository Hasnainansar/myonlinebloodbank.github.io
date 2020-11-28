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

namespace BloodBankOOAD.AdminForms
{
    public partial class DetailsID : Form
    {
        public DetailsID()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CompleteInfoOfUsers c = new CompleteInfoOfUsers();
            c.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void DetailsID_Load(object sender, EventArgs e)
        {
            UsersController uc = new UsersController();
            richTextBox1.Text= uc.DetailsUser(CompleteInfoOfUsers.a);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
