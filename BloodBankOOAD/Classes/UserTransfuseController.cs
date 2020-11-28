using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankOOAD.Classes;

namespace BloodBankOOAD.Classes
{
    class UserTransfuseController
    {
        public int ID()
        {
            UserBloodTransfusee ubt;
            ubt = new UserBloodTransfusee();
            return ubt.ShowID();
        }

        public UserBloodTransfusee TransfusionData()
        {
            UserBloodTransfusee ut = new UserBloodTransfusee();
           return ut.ShowTransfuse();
        }

        public void UpdatingTransfusion(int a, string b, string c, string d,DateTime e,int f,string g,DateTime h)
        {
            UserBloodTransfusee u = new UserBloodTransfusee();
            u.UpdateTranfuse(a, b, c, d, e, f, g, h);
        }
    }
}
