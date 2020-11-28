using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BloodBankOOAD.Classes
{
    class DonationEntryController
    {

        public void RegisterDonationRetrieving(string name, string Amount,string bloodtype,string type,string toFro,string Price ,string Branch, DateTime dt)
        {
            DonatingRetrieving dr = new DonatingRetrieving();
            dr.NameID = name;
            dr.Amount = Amount;
            dr.Type = type;
            dr.BloodType = bloodtype;
            dr.ToFrom = toFro;
            dr.Price = Price;
            dr.Branch = Branch;
            dr.Date = dt;
            dr.NewEntry(dr);
        }
        public DataSet GetDonationRetrieving()
        {
            DonatingRetrieving dr = new DonatingRetrieving();

            return dr.GetAllDonatingReceiving();

        }
        public void UpdateDonationRetrieving(int sno, string name, string Amount, string bloodtype,string Type, string toFro, string Price, string Branch, DateTime dt)
        {
            DonatingRetrieving dr = new DonatingRetrieving();
            dr.Sno = sno;
            dr.NameID = name;
            dr.Amount = Amount;
            dr.BloodType = bloodtype;
            dr.Type = Type;
            dr.ToFrom = toFro;
            dr.Price = Price;
            dr.Branch = Branch;
            dr.Date = dt;
            dr.UpdateDonatingRetrieving(dr);
        }
        public DataSet SearchID(int ID)
        {
            DonatingRetrieving D = new DonatingRetrieving();
            return D.SearchID(ID);
        }
        public DonatingRetrieving GetDonationsByID(int ID)
        {
            DonatingRetrieving D = new DonatingRetrieving();
            return D.GetDonatingReceivingByID(ID);
        }
    }
}
