using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankOOAD
{
    public partial class WhyDonateBlood : Form
    {
        public WhyDonateBlood()
        {
            InitializeComponent();
        }

        private void WhyDonateBlood_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            WhyDonateBlood wdb = new WhyDonateBlood();
            wdb.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp s = new SignUp();
            s.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs c = new ContactUs();
            c.Show();
        }
    }
}
