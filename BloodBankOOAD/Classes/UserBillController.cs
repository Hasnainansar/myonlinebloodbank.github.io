using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankOOAD.Classes
{
    class UserBillController
    {
        public string Bill()
        {
            UserBill ub;
            ub = new UserBill();
            return ub.ShowBill();
        }
    }
}
