using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankOOAD.Classes
{
    class UserMedicineController
    {
        public string MedData()
        {
            UserMedicine um;
            um = new UserMedicine();
            return um.ShowMedicine();
        }
    }
}
