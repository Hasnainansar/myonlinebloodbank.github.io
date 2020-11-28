using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankOOAD.AcceptorDonorForms;
using System.Data;

namespace BloodBankOOAD.Classes
{
    class FacadeController
    {
        //Facade

        //UserBillController
        public string Bill()
        {
            UserBill ub;
            ub = new UserBill();
            return ub.ShowBill();
        }

        //UserMedicineController
        public string MedData()
        {
            UserMedicine um;
            um = new UserMedicine();
            return um.ShowMedicine();
        }


        //UserReportsController
        public string Data()
        {
            UserReport ur;
            ur = new UserReport();
            return ur.ShowReadData();
        }

        //UserTranfuseController
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

        public void UpdatingTransfusion(int a, string b, string c, string d, DateTime e, int f, string g, DateTime h)
        {
            UserBloodTransfusee u = new UserBloodTransfusee();
            u.UpdateTranfuse(a, b, c, d, e, f, g, h);
        }

        //UserUpdateController
        public UserUpdate UserInformation()
        {
            UserUpdate u;
            u = new UserUpdate();
            return u.GetUser();
        }

        public DataTable User()
        {
            UserUpdate ui;
            ui = new UserUpdate();
            return ui.UserData();
        }

        public void updateauser(string a, string b, string c, string d, string e, string f, DateTime g, string h, string i, string j, string k, string l, string m, int n, string o, string p)
        {
            UserUpdate ui;
            ui = new UserUpdate();
            ui.UpdatingUser(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }
    }
}
