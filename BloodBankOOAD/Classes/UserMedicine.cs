using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BloodBankOOAD.Classes
{
    class UserMedicine
    {
        SqlConnection MyCon = Connection.Make();

        int id;
        string Med;
        string MedDesc;
        DateTime TimeMed;

        public string ShowMedicine()
        {
            string query = "SelectMedicine";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", User.UserID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader[0].ToString());
                Med = reader[1].ToString();
                MedDesc = reader[2].ToString();
                TimeMed = DateTime.Parse(reader[3].ToString());
            }
            MyCon.Close();
            return ("User ID  :  " + id) + "\n" + ("Medicine  :  " + Med) + "\n" + ("Medicine Description  :  " + MedDesc) + "\n" + ("Time Of Medicine  :  " + TimeMed);
        } 
    }
}
