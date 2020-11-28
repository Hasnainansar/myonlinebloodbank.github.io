using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BloodBankOOAD.Classes;

namespace BloodBankOOAD.Classes
{
    class Login
    {
        public bool check;
        SqlConnection MyCon = Connection.Make();

        public Login()
        {
            MyCon.Open();
        }

        public bool LoggedIn(string UserType,int UserID, string Password)
        {
            //con.Open();
            string query = "select count(*) from Users where UserType = '" + UserType + "' And UserID ='" + UserID + "' AND UserPassword ='" + Password + "'";
            SqlCommand cmd = new SqlCommand(query,MyCon);
            check = Convert.ToBoolean(cmd.ExecuteScalar());
            MyCon.Close();
            return check;
        }
    }
}
