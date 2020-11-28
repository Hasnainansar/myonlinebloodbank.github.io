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
    public partial class GetAllEntries : Form
    {
        DonationEntryController dec;
        public GetAllEntries()
        {
            InitializeComponent();
        }

        private void GetAllEntries_Load(object sender, EventArgs e)
        {
            dec=new DonationEntryController();

            dataGridView1.DataSource = dec.GetDonationRetrieving().Tables[0];
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            UpdateByID ubd = new UpdateByID(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
            this.Hide();
            ubd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dec = new DonationEntryController();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dec.SearchID(int.Parse(textBox1.Text)).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetrievingDonating rd = new RetrievingDonating();
            this.Hide();
            rd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetrievingDonating D = new RetrievingDonating();
            this.Hide();
            D.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
