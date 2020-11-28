using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankOOAD.Classes;

namespace BloodBankOOAD.AcceptorDonorForms
{
    class UserReportsController
    {
        public string Data()
        {
            UserReport ur;
            ur = new UserReport();
            return ur.ShowReadData();
        }
   }
}
