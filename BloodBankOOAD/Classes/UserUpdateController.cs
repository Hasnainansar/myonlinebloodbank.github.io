using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BloodBankOOAD.Classes
{
    class UserUpdateController
    {
        public UserUpdate UserInformation()
        {
            UserUpdate u;
            u = new UserUpdate();
            return u.GetUser();
        }

        public DataTable User()
        {
            UserUpdate ui;
            ui = new UserUpdate();
            return ui.UserData();
        }

        public void updateauser(string a, string b, string c, string d, string e, string f, DateTime g, string h, string i, string j, string k, string l, string m, int n, string o, string p)
        {
            UserUpdate ui;
            ui = new UserUpdate();
            ui.UpdatingUser(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p);
        }
    }
}
