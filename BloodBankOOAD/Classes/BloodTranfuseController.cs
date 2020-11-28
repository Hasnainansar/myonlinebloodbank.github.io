using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BloodBankOOAD.Classes
{
    class BloodTranfuseController
    {
        
       public void UpdateTransfusion(string Userid, string tof, string Amount, string Hemo, DateTime dot, int Bill, string Branch, DateTime dnt)
        {
            Transfusion tfs = new Transfusion();
            tfs.userid = Userid;
            tfs.typeoftransfusion = tof;
            tfs.amount = Amount;
            tfs.bill = Bill;
            tfs.branch = Branch;
            tfs.dnt = dnt;
            tfs.dot = dot;
            tfs.hemo = Hemo;
            tfs.UpdateTransfusion(tfs);
            
        }

        public void NewTransfusion(string Userid, string tof , string Amount, string Hemo,DateTime dot,int Bill,string Branch,DateTime dnt)
        {
            Transfusion tfs = new Transfusion();
            tfs.userid = Userid;
            tfs.typeoftransfusion = tof;
            tfs.amount = Amount;
            tfs.bill = Bill;
            tfs.branch = Branch;
            tfs.dnt = dnt;
            tfs.dot = dot;
            tfs.hemo = Hemo;
            tfs.NewTranfusion(tfs);
        }
        public DataSet AllTransfusion()
        {
            Transfusion tfs = new Transfusion();

            return tfs.AllTransfusions();


        }
        
        public DataSet SearchID(string ID)
        {
            Transfusion tfs = new Transfusion();
            return tfs.SearchID(ID);
        }
        public Transfusion GetTransfusionbyID(string ID)
        {
            Transfusion tfs = new Transfusion();
            return tfs.GetTransfusionbyID(ID);
        }

    }
}
