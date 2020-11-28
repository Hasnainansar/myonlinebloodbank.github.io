using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBankOOAD.Classes
{
    class Connection
    {
        //Singleton
        private static SqlConnection con;

        protected Connection()
        {

        }

        public static SqlConnection Make()
        {
            if (con == null)
            {
                con = new SqlConnection(@"Data Source=RAZA;Initial Catalog=Project;Integrated Security=True");
            }
            else
            {
                return con;
            }
            return con;
        }
    }
}
