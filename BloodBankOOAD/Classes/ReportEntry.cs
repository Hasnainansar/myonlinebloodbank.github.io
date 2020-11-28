using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BloodBankOOAD.Classes
{
    class ReportEntry
    {
        SqlConnection MyCon = Connection.Make();

        public int ID { get; set; }
        public string BT { get; set; }
        public int TP { get; set; }
        public string TDesc { get; set; }
        public DateTime TDate { get; set; }
        public DateTime RDate { get; set; }
        public int Age { get; set; }
        DataSet ds;
        SqlDataAdapter adapter;
        public void RegisterReportEntry(ReportEntry RE)
        {
            string query = "RegisterReports";
            SqlCommand cmd = new SqlCommand(query, MyCon);
            MyCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", RE.ID);
            cmd.Parameters.AddWithValue("@BT", RE.BT);
            cmd.Parameters.AddWithValue("@TP", RE.TP);
            cmd.Parameters.AddWithValue("@TD", RE.TDesc);
            cmd.Parameters.AddWithValue("@DOT", RE.TDate.Date.ToString());
            cmd.Parameters.AddWithValue("@DOR", RE.RDate.Date.ToString());
            cmd.Parameters.AddWithValue("@Age", RE.Age);
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
        public ReportEntry GetReportByID(int id)
        {
            ReportEntry re = new ReportEntry();
            string query = "Select * from ReportEntry where UserID ='" + id + "'";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                re.ID = int.Parse(reader[0].ToString());
                re.BT = reader[1].ToString();
                re.TP = int.Parse(reader[2].ToString());
                re.TDesc = reader[3].ToString();
                re.TDate = Convert.ToDateTime(reader[4].ToString());
                re.RDate = Convert.ToDateTime(reader[5].ToString());
                re.Age = int.Parse(reader[6].ToString());
            }
            MyCon.Close();
            return re;
        }
        public DataSet SearchID(int ID)
        {
            ReportEntry re = new ReportEntry();
            string query = "Select * from ReportEntry where UserID ='" + ID + "'";
            MyCon.Open();

            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;


        }
        public DataSet GetAllReports()
        {
            string query = "Select * From ReportEntry";
            MyCon.Open();
            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;
        }
        public void UpdateReport(ReportEntry R)
        {
            string query = "UpdateingReports";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", R.ID);
            cmd.Parameters.AddWithValue("@BT", R.BT);
            cmd.Parameters.AddWithValue("@TP", R.TP);
            cmd.Parameters.AddWithValue("@TD", R.TDesc);
            cmd.Parameters.AddWithValue("@DT", R.TDate);
            cmd.Parameters.AddWithValue("@DR", R.RDate);
            cmd.Parameters.AddWithValue("@Age", R.Age);
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
    }
}
