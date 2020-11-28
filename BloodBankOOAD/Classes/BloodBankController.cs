using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BloodBankOOAD.Classes
{
    class BloodBankController
    {
        public DataSet AllBloodInfo()
        {
            DataSet ds = new DataSet();
            BloodBank bb = new BloodBank();
            ds = bb.GetBloodInfo();
            return ds;

        }
        public int TotalDonors()
        {
            BloodBank bb = new BloodBank();
            return bb.GetDonors();
        }
        public int TotalAcceptors()
        {
            BloodBank bb = new BloodBank();
            return bb.GetAcceptors();
        }
    }
}
