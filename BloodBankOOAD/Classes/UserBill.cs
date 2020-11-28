using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BloodBankOOAD.Classes
{
    class UserBill
    {
        SqlConnection MyCon = Connection.Make();

        int id;
        int tb;
        int rb;
        int totalb;

        public string ShowBill()
        {
            string query = "BillUser";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", User.UserID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader[0].ToString());
                tb = int.Parse(reader[1].ToString());
                rb = int.Parse(reader[2].ToString());
                totalb = int.Parse(reader[3].ToString());
            }
            MyCon.Close();
            return ("User ID  :  " + id) + "\n" + ("Transfusion Bill  :  " + tb) + "\n" + ("Report Bill  :  " + rb) + "\n" + ("Total Bill  :  " + totalb);
        }
    }
}
