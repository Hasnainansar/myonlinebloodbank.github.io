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

namespace BloodBankOOAD.Classes
{
    public partial class LoggedInAsAdmin : Form
    {
        public LoggedInAsAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoggedInAsAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        //    this.Hide();
        //    BloodTransfusionEntry BT = new BloodTransfusionEntry();
        //    BT.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompleteInfoOfUsers c = new CompleteInfoOfUsers();
            c.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
