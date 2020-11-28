using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankOOAD.Classes;
using System.Data.SqlClient;

namespace BloodBankOOAD.AcceptorDonorForms
{
    class UserReport
    {
        SqlConnection MyCon = Connection.Make();

        int id;
        string bt;
        string td;
        DateTime dot;
        DateTime dor;
        int age;

        public string ShowReadData()
        {
            SqlCommand cmd = new SqlCommand("select UserID,BloodTest,TestDesc,DateOfTest,DateOfReport,AgeOfPatient from ReportEntry where UserID = '" + User.UserID + "'", MyCon);
            MyCon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader[0].ToString());
                bt = reader[1].ToString();
                td = reader[2].ToString();
                dot = DateTime.Parse(reader[3].ToString());
                dor = DateTime.Parse(reader[4].ToString());
                age = int.Parse(reader[5].ToString());
            }
            MyCon.Close();
            return ("User ID  :  " + id) + "\n" + ("Blood Test  :  " + bt) + "\n" + ("Test Description  :  " + td) + "\n" + ("Date Of Test  :  " + dot) + "\n" + ("Date of Report  :  " + dor) + "\n" + ("Age of Patient  :  " + age);
        }
    }
}
