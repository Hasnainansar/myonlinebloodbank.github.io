using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BloodBankOOAD.Classes
{
    abstract class BloodBankAbstract
    {
        //Abstract of bloodbank
        public abstract DataSet GetBloodInfo();
        public abstract int GetDonors();
        public abstract int GetAcceptors();
    }
}
