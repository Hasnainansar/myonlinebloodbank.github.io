using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BloodBankOOAD.Classes
{
    class DonatingRetrieving
    {
        SqlConnection MyCon = Connection.Make();

        public int Sno { get; set; }

        public string NameID { get; set; }

        public string Amount { get; set; }

        public string Type { get; set; }

        public string ToFrom { get; set; }

        public string Price { get; set; }
        
        public string Branch { get; set; }
        DataSet ds;
        SqlDataAdapter adapter;
        public DateTime Date { get; set; }
        public string BloodType { get; set; }
        
        public void NewEntry(DonatingRetrieving dr)
        {
            string a = "";
            foreach (char item in dr.Amount)
            {
                if (item != 'm')
                {
                    a = a + item;
                }
                else
                {
                    break;
                }
            }
            string query = "BloodEntry";
            SqlCommand cmd = new SqlCommand(query, MyCon);
            MyCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nameid", dr.NameID);
            cmd.Parameters.AddWithValue("@Amount", dr.Amount);
            cmd.Parameters.AddWithValue("@Type", dr.Type);
            cmd.Parameters.AddWithValue("@ToFrom", dr.ToFrom);
            cmd.Parameters.AddWithValue("@price", dr.Price);
            cmd.Parameters.AddWithValue("@branch", dr.Branch);
            cmd.Parameters.AddWithValue("@ondate", dr.Date);

            cmd.Parameters.AddWithValue("@bloodtype", dr.BloodType);
            cmd.Parameters.AddWithValue("@amout", a);
            cmd.ExecuteNonQuery();

            MyCon.Close();
        }
        public DonatingRetrieving GetDonatingReceivingByID(int id)
        {
            DonatingRetrieving dr = new DonatingRetrieving();
            string query = "Select * from DonatingRetriving where Sno ='" + id + "'";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dr.Sno = int.Parse(reader[0].ToString());
                dr.NameID = reader[1].ToString();
                dr.Amount = reader[2].ToString();
                dr.Type = reader[3].ToString();
                dr.ToFrom = reader[4].ToString();
                dr.Price = reader[5].ToString();
                dr.Branch = reader[6].ToString();
                dr.Date = Convert.ToDateTime(reader[7].ToString());
            }
            MyCon.Close();
            return dr;
        }
        public DataSet SearchID(int ID)
        {
            string query = "Select * from DonatingRetriving where Sno ='" + ID+ "'";
            MyCon.Open();

            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);
            MyCon.Close();
            return ds;


        }
        public DataSet GetAllDonatingReceiving()
        {
            string query = "Select * from DonatingRetriving";
            MyCon.Open();
            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;
        }

        public void UpdateDonatingRetrieving(DonatingRetrieving DR)
        {
            string a = "";
            foreach (char item in DR.Amount)
            {
                if (item != 'm')
                {
                    a = a + item;
                }
                else
                {
                    break;
                }
            }
            string query = "UpdatingDonatingRetriving";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Sno", DR.Sno);
            cmd.Parameters.AddWithValue("@NameID", DR.NameID);
            cmd.Parameters.AddWithValue("@AB", DR.Amount);
            cmd.Parameters.AddWithValue("@TypeOf", DR.Type);
            cmd.Parameters.AddWithValue("@ToFrom", DR.ToFrom);
            cmd.Parameters.AddWithValue("@Price", DR.Price);
            cmd.Parameters.AddWithValue("@Branch", DR.Branch);
            cmd.Parameters.AddWithValue("@Ondate", DR.Date);
            cmd.Parameters.AddWithValue("@bloodtype", DR.BloodType);
            cmd.Parameters.AddWithValue("@amout", int.Parse(a));
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
    }
}
