using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BloodBankOOAD.Classes
{
    class Donations
    {
        
        public int Sno { get; set; }
        DataSet ds;
        SqlDataAdapter adapter;
        SqlConnection MyCon = Connection.Make();

        public string Name { get; set; }

        public string Amount { get; set; }

        public string Branch { get; set; }

        public string UsedFor { get; set; }

        public void NewEntry(Donations D)
        {
            string query = "Donation";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CN", D.Name);
            cmd.Parameters.AddWithValue("@Donation", D.Amount);
            cmd.Parameters.AddWithValue("@IB", D.Branch);
            cmd.Parameters.AddWithValue("@UF", D.UsedFor);
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
        public void UpdateDonation(Donations d)
        {
            string query = "UpdatingDonation";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Sno", d.Sno);
            cmd.Parameters.AddWithValue("@Name", d.Name);
            cmd.Parameters.AddWithValue("@Donation", d.Amount);
            cmd.Parameters.AddWithValue("@Branch", d.Branch);
            cmd.Parameters.AddWithValue("@Used", d.UsedFor);
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
        public DataSet GetAllDonations()
        {
            string query = "Select Sno,CompanyNameUser,Donation,InBranch,UsedFor from Donations";
            MyCon.Open();
            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;
        }
        public DataSet SearchID(int id)
        {
            
            string query = "Select Sno,CompanyNameUser,Donation,InBranch,UsedFor from Donations where Sno='" + id + "'";
            MyCon.Open();

            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;


        }
        public Donations GetDonationByID(int id)
        {
            Donations D = new Donations();
            string query = "Select Sno,CompanyNameUser,Donation,InBranch,UsedFor from Donations where Sno='"+id+"'";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                D.Sno = int.Parse(reader[0].ToString());
                D.Name = reader[1].ToString();
                D.Amount = reader[2].ToString();
                D.Branch = reader[3].ToString();
                D.UsedFor = reader[4].ToString();

            }
            MyCon.Close();
            return D;
        }
    }
}
