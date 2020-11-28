using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BloodBankOOAD.Classes
{
    class UsersController
    {
        public DataTable UsersInfo()
        {
            InfoOfUsers i;
            i = new InfoOfUsers();
            return i.AllEntries();
        }

        public DataTable InfoUser(int a)
        {
            InfoOfUsers i;
            i = new InfoOfUsers();
            return i.SearchEntry(a);
        }

        public string DetailsUser(int a)
        {
            InfoOfUsers i;
            i = new InfoOfUsers();
            return i.OurUserData(a);
        }

        public InfoOfUsers GetUserData(int a)
        {
            InfoOfUsers i;
            i = new InfoOfUsers();
            return i.GetUser(a);
        }

        public void UpdateOurUser(int id,string a, string b, string c, string d, string e, string f, DateTime g, string h, string i, string j, string k, string l, string m, int n, string o, string p)
        {
            InfoOfUsers z;
            z = new InfoOfUsers();
            z.UpdateUser(id, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }
    }
}
