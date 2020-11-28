using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankOOAD.Classes
{
    class SignUpController
    {
        public void NewUser(string a, string b, string c, string d, string e, string f, DateTime g, string h, string i, string j, string k, string l, string m, int n, string o, string p)
        {
            SignUp su = new SignUp(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
            su.NewRegistration(su);
        }
    }
}
