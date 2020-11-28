using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BloodBankOOAD.Classes
{
    class UserUpdate
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
        public string City;
        public string Country;
        public int PostalCode;
        public string CellNo;
        public string Pass;
        SqlCommand cmd;

        public UserUpdate GetUser()
        {
            UserUpdate user = new UserUpdate();
            string query = "SelectID";
            if(MyCon.State==0)
            { 
            MyCon.Open();
            }
            cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",User.UserID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.ID = int.Parse(reader[0].ToString());
                user.Type = reader[1].ToString();
                user.FirstName = reader[3].ToString();
                user.LastName = reader[4].ToString();
                user.FatherName = reader[5].ToString();
                user.BG = reader[6].ToString();
                user.NIC = reader[7].ToString();
                user.DOB = Convert.ToDateTime(reader[8].ToString());
                user.PEmail = reader[9].ToString();
                user.TEmail = reader[10].ToString();
                user.Paddress = reader[11].ToString();
                user.TAddress = reader[12].ToString();
                user.City = reader[13].ToString();
                user.Country = reader[14].ToString();
                user.PostalCode = int.Parse(reader[15].ToString());
                user.CellNo = reader[16].ToString();
                user.Pass = reader[2].ToString();
            }
            MyCon.Close();
            return user;
        }

        public DataTable UserData()
        {
            string query = "SelectID";
            SqlDataAdapter da = new SqlDataAdapter();
            cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", User.UserID);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdatingUser(string a, string b, string c, string d, string e, string f, DateTime g, string h, string i, string j, string k, string l,string m,int n,string o,string p)
        {
            string query;
            SqlCommand cmd;
            MyCon.Open();
            if (GetUser().CellNo != null)
            {
                MyCon.Open();
               query = "UpdateAUser";
               if (MyCon.State == 0)
               {
                   MyCon.Open();
               }
                 cmd = new SqlCommand(query, MyCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", User.UserID);
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
            }
            else
            {
                MyCon.Open();
                query = "Insert into UserInformation(UserID,FirstName,LastName,FatherName,BloodGroup,NIC,DateOfBirth) Values('" + User.UserID + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "','" + g + "')";

                cmd = new SqlCommand(query, MyCon);
                cmd.ExecuteNonQuery();
                query = "Insert into UserContactInfo(UserID,PEmail,TEmail,PAddress,TAddress,Country,City,PostalCode,CellNo) Values('" + User.UserID + "','" + h + "','" + i + "','" + j + "','" + k + "','" + l + "','" + m + "','" + n + "','" + o + "')";

                cmd = new SqlCommand(query, MyCon);
                cmd.ExecuteNonQuery();
                query = "update Users set UserType = '"+a+"' , UserPassword = '"+p+"' where UserID = '"+User.UserID+"'";

                cmd = new SqlCommand(query, MyCon);
                cmd.ExecuteNonQuery();

            }
            MyCon.Close();
        }
    }
}
