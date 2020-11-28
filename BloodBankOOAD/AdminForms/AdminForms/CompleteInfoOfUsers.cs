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
    public partial class CompleteInfoOfUsers : Form
    {
        public static int a;

        public CompleteInfoOfUsers()
        {
            InitializeComponent();
        }

        private void CompleteInfoOfUsers_Load(object sender, EventArgs e)
        {
            UsersController uc = new UsersController();
            BindingSource bs = new BindingSource();
            bs.DataSource = uc.UsersInfo();
            dataGridView1.DataSource = bs;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                UsersController u = new UsersController();
                BindingSource b = new BindingSource();
                b.DataSource = u.UsersInfo();
                dataGridView1.DataSource = b;
            }
            else
            {
                UsersController uc = new UsersController();
                BindingSource bs = new BindingSource();
                bs.DataSource = uc.InfoUser(int.Parse(textBox1.Text));
                dataGridView1.DataSource = bs;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = (int)dataGridView1.SelectedCells[0].Value;
            this.Hide();
            DetailsID D = new DetailsID();
            D.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = (int)dataGridView1.SelectedCells[0].Value;
            this.Hide();
            EditUser f = new EditUser();
            f.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewUser cnu = new CreateNewUser();
            cnu.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoggedInAsAdmin c = new LoggedInAsAdmin();
            c.Show();
        }
    }
}
