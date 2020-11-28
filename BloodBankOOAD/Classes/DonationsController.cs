using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BloodBankOOAD.Classes
{
    class DonationsController
    {

        public void RegisterDonation(string Name,string Amount,string Branch,string UsedFor)
        {
            Donations D = new Donations();
            
            D.Name = Name;
            D.Amount = Amount;
            D.Branch = Branch;
            D.UsedFor = UsedFor;
            D.NewEntry(D);
        }
        public DataSet GetDonation()
        {
            Donations D = new Donations();

            return D.GetAllDonations();

        }
        public void UpdateDonation(int sno, string Name, string Amount, string Branch, string UsedFor)
        {
            Donations D = new Donations();
            D.Sno = sno;
            D.Name = Name;
            D.Amount = Amount;
            D.Branch = Branch;
            D.UsedFor = UsedFor;
            D.UpdateDonation(D);
        }
        public DataSet SearchID(int ID)
        {
            Donations D = new Donations();
            return D.SearchID(ID);
        }
        public Donations GetDonationsByID(int ID)
        {
            Donations D = new Donations();
            return D.GetDonationByID(ID);
        }
    }
}
