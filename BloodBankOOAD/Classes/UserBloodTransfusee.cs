using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BloodBankOOAD.Classes
{
    class UserBloodTransfusee
    {
        SqlConnection MyCon = Connection.Make();

        public int id;
        public string tt;
        public string ab;
        public string h;
        public DateTime dot;
        public int p;
        public string b;
        public DateTime dnt;

        public UserBloodTransfusee()
        {

        }

        public int ShowID()
        {
            if(MyCon.State ==0)
            {
                MyCon.Open();
            }
            
            string query = "Select UserID From Users U where U.UserID = '" + User.UserID + "'";
            
            SqlCommand cmd = new SqlCommand(query, MyCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader[0].ToString());
            }
            MyCon.Close();
            return id;
        }

        public UserBloodTransfusee ShowTransfuse()
        {
            UserBloodTransfusee transfuse = new UserBloodTransfusee();
            string query = "Select * From BloodTransfusion B where B.UserID = '" + User.UserID + "'";
            if (MyCon.State == 0)
            {
                MyCon.Open();
            }
            SqlCommand cmd = new SqlCommand(query, MyCon);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transfuse.tt = reader[1].ToString();
                    transfuse.ab = reader[2].ToString();
                    transfuse.h = reader[3].ToString();
                    transfuse.dot = DateTime.Parse(reader[4].ToString());
                    transfuse.p = int.Parse(reader[5].ToString());
                    transfuse.b = reader[6].ToString();
                    transfuse.dnt = DateTime.Parse(reader[7].ToString());
                }
            }
            catch(Exception e)
            {

            }
            MyCon.Close();

            return transfuse;
        }
        public void UpdateTranfuse(int a, string b, string c, string d, DateTime e, int f, string g, DateTime h)
        {
            string query;
            SqlCommand cmd;
            MyCon.Open();
            if (ShowTransfuse().tt!=null)
            {

                MyCon.Open();
               query = "UserTransfusion";
               cmd = new SqlCommand(query, MyCon);
               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@ID", a);
               cmd.Parameters.AddWithValue("@TT", b);
               cmd.Parameters.AddWithValue("@AB", c);
               cmd.Parameters.AddWithValue("@H", d);
               cmd.Parameters.AddWithValue("@DT", e);
               cmd.Parameters.AddWithValue("@B", f);
               cmd.Parameters.AddWithValue("@Branch", g);
               cmd.Parameters.AddWithValue("@DNT", h);
               cmd.ExecuteNonQuery();
            }
            else
            {
                MyCon.Open();
                query = "Insert into BloodTransfusion(UserID,TypeOfTranfusion,AmountOfBlood,Hemoglobin,DateTransfusion,Bill,Branch,DateNextTransfusion) Values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "','" + g + "','" + h + "')";
                cmd = new SqlCommand(query, MyCon);
                cmd.ExecuteNonQuery();
            }
            
            MyCon.Close();
        }
    }
}
