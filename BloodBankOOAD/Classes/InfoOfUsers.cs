using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BloodBankOOAD.Classes
{
    class InfoOfUsers
    {
        SqlConnection MyCon = Connection.Make();
        public int ID;
        public string Type;
        public string FirstName;
        public string LastName;
        public string FatherName;
        public string BG;
        public string NIC;
        public DateTime DOB;
        public string PEmail;
        public string TEmail;
        public string Paddress;
        public string TAddress;
        public string Country;
        public string City;
        public int PostalCode;
        public string CellNo;
        public string Password;

        public DataTable AllEntries()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string query = "Select I.UserID,I.UserType,I.FirstName,I.FatherName,I.BloodGroup,I.NIC,C.PEmail,C.CellNo From UserInformation I inner join UserContactInfo C on I.UserID = C.UserID";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            MyCon.Close();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchEntry(int a)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string query = "Select I.UserID,I.UserType,I.FirstName,I.FatherName,I.BloodGroup,I.NIC,C.PEmail,C.CellNo From UserInformation I inner join UserContactInfo C on I.UserID = C.UserID where I.UserID = '"+a+"'";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            MyCon.Close();
            return dt;
        }

        public string OurUserData(int a)
        {
            string query = "SelectID";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",a);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = int.Parse(reader[0].ToString());
                Type = reader[1].ToString();
                Password = reader[2].ToString();
                FirstName = reader[3].ToString();
                LastName = reader[4].ToString();
                FatherName = reader[5].ToString();
                BG = reader[6].ToString();
                NIC = reader[7].ToString();
                DOB = DateTime.Parse(reader[8].ToString());
                PEmail = reader[9].ToString();
                TEmail = reader[10].ToString();
                Paddress = reader[11].ToString();
                TAddress = reader[12].ToString();
                City = reader[13].ToString();
                Country = reader[14].ToString();
                PostalCode = int.Parse(reader[15].ToString());
                CellNo = reader[16].ToString();
            }
            MyCon.Close();
            return ("User ID  :  " + ID) + "\n" + ("User Type  :  " + Type) + "\n" + ("Password  :  " + Password) + "\n"
                    + ("First Name  :  " + FirstName) + "\n" + ("Last Name  :  " + LastName) + "\n" + ("Father Name  :  " + FatherName) + "\n"
                    + ("Blood Group  :  " + BG) + "\n" + ("NIC  :  " + NIC) + "\n" + ("Date Of Birth  :  " + DOB) + "\n"
                    + ("Permanant Email  :  " + PEmail) + "\n" + ("Temporary Email  :  " + TEmail) + "\n"
                    + ("Permanant Address  :  " + Paddress) + "\n" + ("Temporary Address  :  " + TAddress) + "\n"
                    + ("City  :  " + City) + "\n" + ("Country  :  " + Country) + "\n" + ("Postal Code  :  " + PostalCode) + "\n"
                    + ("Cell No  :  " + CellNo);
        }

        public InfoOfUsers GetUser(int a)
        {
            InfoOfUsers u = new InfoOfUsers();
            string query = "SelectID";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", a);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u.ID = int.Parse(reader[0].ToString());
                u.Type = reader[1].ToString();
                u.Password = reader[2].ToString();
                u.FirstName = reader[3].ToString();
                u.LastName = reader[4].ToString();
                u.FatherName = reader[5].ToString();
                u.BG = reader[6].ToString();
                u.NIC = reader[7].ToString();
                u.DOB = DateTime.Parse(reader[8].ToString());
                u.PEmail = reader[9].ToString();
                u.TEmail = reader[10].ToString();
                u.Paddress = reader[11].ToString();
                u.TAddress = reader[12].ToString();
                u.City = reader[13].ToString();
                u.Country = reader[14].ToString();
                u.PostalCode = int.Parse(reader[15].ToString());
                u.CellNo = reader[16].ToString();
            }
            MyCon.Close();
            return u;
        }

        public void UpdateUser(int UserID,string a, string b, string c, string d, string e, string f, DateTime g, string h, string i, string j, string k, string l, string m, int n, string o, string p)
        {
            string query = "UpdateAUser";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", UserID);
            cmd.Parameters.AddWithValue("@type", a);
            cmd.Parameters.AddWithValue("@pass", p);
            cmd.Parameters.AddWithValue("@Firstname", b);
            cmd.Parameters.AddWithValue("@Lastname", c);
            cmd.Parameters.AddWithValue("@Fname", d);
            cmd.Parameters.AddWithValue("@BG", e);
            cmd.Parameters.AddWithValue("@nic", f);
            cmd.Parameters.AddWithValue("@DOB", g);
            cmd.Parameters.AddWithValue("@Pemail", h);
            cmd.Parameters.AddWithValue("@Temail", i);
            cmd.Parameters.AddWithValue("@Paddress", j);
            cmd.Parameters.AddWithValue("@Taddress", k);
            cmd.Parameters.AddWithValue("@Country", l);
            cmd.Parameters.AddWithValue("@City", m);
            cmd.Parameters.AddWithValue("@PCode", n);
            cmd.Parameters.AddWithValue("@Cellno", o);
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
    }
}
