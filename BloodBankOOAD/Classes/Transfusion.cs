using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BloodBankOOAD.Classes
{
    class Transfusion
    {
       SqlConnection MyCon = Connection.Make();

       public string userid { get; set; }
       public string typeoftransfusion { get; set; }
       public string amount { get; set; }
       public string hemo { get; set; }
       public DateTime dot { get; set; }
       public int bill { get; set; }
       public string branch { get; set; }
       public DateTime dnt { get; set; }
       Transfusion transfuse;
       DataSet ds;
       SqlDataAdapter adapter;
        // Connection con;
        //SqlConnection con = new SqlConnection(@"Data Source=RAZA;Initial Catalog=Project;Integrated Security=True");
        public Transfusion()
        {
        }


        public DataSet AllTransfusions()
        {
            
            string query = "Select * From BloodTransfusion B";
            MyCon.Open();
            ds = new DataSet();
            adapter= new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);
            
            
            MyCon.Close();
            return ds;
        }
        public void NewTranfusion(Transfusion t)
        {
            string query = "Tranfusion";
            SqlCommand cmd = new SqlCommand(query,MyCon);
            MyCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", t.userid);
            cmd.Parameters.AddWithValue("@TT", t.typeoftransfusion);
            cmd.Parameters.AddWithValue("@AB", t.amount);
            cmd.Parameters.AddWithValue("@Hemoglobin", t.hemo);
            cmd.Parameters.AddWithValue("@DT", t.dot);
            cmd.Parameters.AddWithValue("@bill", t.bill);
            cmd.Parameters.AddWithValue("@Branch", t.branch);
            cmd.Parameters.AddWithValue("@DNT", t.dnt);
            cmd.ExecuteNonQuery();
            MyCon.Close();
       }
        public Transfusion GetTransfusionbyID(string ID)
        {
            transfuse = new Transfusion();
            string query = "Select * From BloodTransfusion B where B.UserID = '" + ID + "'";
            MyCon.Open();
        
            SqlCommand cmd = new SqlCommand(query, MyCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                transfuse.userid = reader[0].ToString();
                transfuse.typeoftransfusion = reader[1].ToString();
                transfuse.amount = reader[2].ToString();
                transfuse.hemo = reader[3].ToString();
                transfuse.dot= Convert.ToDateTime(reader[4].ToString());
               transfuse.bill= Convert.ToInt32(reader[5].ToString());
                transfuse.branch = reader[6].ToString();
                transfuse.dnt= Convert.ToDateTime(reader[7].ToString());
            }
            MyCon.Close();
            return transfuse;
            
        }
        public DataSet SearchID(string ID)
        {
            transfuse = new Transfusion();
            string query = "Select * From BloodTransfusion B where B.UserID = '" + ID + "'";
            MyCon.Open();

            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;


        }
        public void UpdateTransfusion(Transfusion t)
        {
            string query = "UpdateTransfusion";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", t.userid);
            cmd.Parameters.AddWithValue("@TT", t.typeoftransfusion);
            cmd.Parameters.AddWithValue("@AB", t.amount);
            cmd.Parameters.AddWithValue("@Hemo", t.hemo);
            cmd.Parameters.AddWithValue("@DT", t.dot.Date.ToString());
            cmd.Parameters.AddWithValue("@bill", t.bill);
            cmd.Parameters.AddWithValue("@branch", t.branch);
            cmd.Parameters.AddWithValue("@DNT", t.dnt.Date.ToString());
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }

    }
}
