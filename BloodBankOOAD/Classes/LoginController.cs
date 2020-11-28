using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankOOAD.Classes
{
    class LoginController
    {
      
       public bool Logged(string A,int B,string C)
        {
            Login l;
            l = new Login();
            l.check =l.LoggedIn(A, B, C);
            User.UserID = B;
            return l.check;
        }
    }
}
