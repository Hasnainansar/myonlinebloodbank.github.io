using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BloodBankOOAD.Classes
{
    class BloodBase
    {
        //The class which is Abstraction Class
        private BloodBank bb;
        
        public BloodBase()
        {
       
        }

        public BloodBank Bank
        {
            get { return bb; }
            set { bb = value; }
        }

        public virtual DataSet AllBlood()
        {
            return bb.GetBloodInfo();
        }

        public virtual int Donors()
        {
            return bb.GetDonors();
        }

        public virtual int Acceptor()
        {
            return bb.GetAcceptors();
        }
    }
}
