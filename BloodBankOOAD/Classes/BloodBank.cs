using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BloodBankOOAD.Classes
{
    class BloodBank:BloodBankAbstract
    {
        //concrete implementation of Implementor
        DataSet ds;
        SqlDataAdapter adapter;
        SqlConnection MyCon = Connection.Make();

        public override DataSet GetBloodInfo()
        {
            string query = "Select * From BloodStock";

            if (MyCon.State == 0)
            { MyCon.Open(); }
            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;
        }
        public override int GetDonors()
        {
            int totaldonors = 0;
            string query = "Select count(TypeOf) From DonatingRetriving where TypeOf='Donor'";
            if (MyCon.State == 0)
            {
                MyCon.Open();
            }
            SqlCommand cmd = new SqlCommand(query, MyCon);
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                totaldonors = int.Parse(reader[0].ToString());
                totaldonors++;
            }
            MyCon.Close();
            return totaldonors;
        }

        public override int GetAcceptors()
        {
            int totalacceptor = 0;
            string query = "Select count(TypeOf) From DonatingRetriving where TypeOf='Receiver'";
            if (MyCon.State == 0)
            {
                MyCon.Open();

            }
            SqlCommand cmd = new SqlCommand(query, MyCon);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                totalacceptor=int.Parse(reader[0].ToString());
            }
            MyCon.Close();
            return totalacceptor;
        }
    }
}
