using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BloodBankOOAD.Classes
{
    class ReportController
    {
        
        public void RegisterReports(int ID,string BT,int TP,string TDesc,DateTime TDate,DateTime RDate,int Age)
        {
            ReportEntry re = new ReportEntry();
            re.ID = ID;
            re.BT = BT;
            re.TP = TP;
            re.TDesc = TDesc;
            re.TDate = TDate;
            re.RDate = RDate;
            re.Age = Age;
            re.RegisterReportEntry(re);
        }
        public DataSet GetReports()
        {
            ReportEntry re = new ReportEntry();
            return re.GetAllReports();
        }
        public void UpdateReport(int ID, string BT, int TP, string TDesc, DateTime TDate, DateTime RDate, int Age)
        {
            ReportEntry re = new ReportEntry();
            re.ID = ID;
            re.BT = BT;
            re.TP = TP;
            re.TDesc = TDesc;
            re.TDate = TDate;
            re.RDate = RDate;
            re.Age = Age;
            re.UpdateReport(re);
        }
        public DataSet SearchID(int ID)
        {
            ReportEntry re = new ReportEntry();
            return re.SearchID(ID);
        }
        public ReportEntry GetReportByID(int ID)
        {
            ReportEntry re = new ReportEntry();
            return re.GetReportByID(ID);
        }

    }
}
