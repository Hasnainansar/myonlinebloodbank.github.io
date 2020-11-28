using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankOOAD.Classes
{
    class BloodData:BloodBase
    {
        // main refined class
        public BloodData():base()
        {

        }

        public override DataSet AllBlood()
        {
            return base.AllBlood();
        }
    }
}
