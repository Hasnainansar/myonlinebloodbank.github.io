using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BloodBankOOAD.Classes
{
    class SignUp
    {
        SqlConnection MyCon = Connection.Make();

        string UserType;
        string FirstName;
        string LastName;
        string FName;
        string BloodGroup;
        string NIC;
        DateTime DOB;
        string PEmail;
        string TEmail;
        string PAddress;
        string TAddress;
        string Country;
        string City;
        int PostalCode;
        string CellNo;
        string Password;
        //    Connection con;
//        SqlConnection con = new SqlConnection(@"Data Source=RAZA;Initial Catalog=Project;Integrated Security=True");

        public SignUp()
        {
        }


        public SignUp(string Ut,string Fn,string Ln,string fatherN,string BG,string Nic,DateTime dob,string Pe,string Te,string Pa,string Ta,string C,string city,int PC,string Cell,string pass)
        {
            UserType = Ut;
            FirstName = Fn;
            LastName = Ln;
            FName = fatherN;
            BloodGroup = BG;
            NIC = Nic;
            DOB = dob;
            PEmail = Pe;
            TEmail = Te;
            PAddress = Pa;
            TAddress = Ta;
            Country = C;
            City = city;
            PostalCode = PC;
            CellNo = Cell;
            Password = pass;
        }

        public void NewRegistration(SignUp su)
        {
            string query = "Register";
            SqlCommand cmd = new SqlCommand(query, MyCon);
            MyCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Type", su.UserType);
            cmd.Parameters.AddWithValue("@FName", su.FirstName);
            cmd.Parameters.AddWithValue("@LName", su.LastName);
            cmd.Parameters.AddWithValue("@Fathername", su.FName);
            cmd.Parameters.AddWithValue("@BG", su.BloodGroup);
            cmd.Parameters.AddWithValue("@nic", su.NIC);
            cmd.Parameters.AddWithValue("@DOB", su.DOB);
            cmd.Parameters.AddWithValue("@PEmail", su.PEmail);
            cmd.Parameters.AddWithValue("@TEmail", su.TEmail);
            cmd.Parameters.AddWithValue("@PAddress", su.PAddress);
            cmd.Parameters.AddWithValue("@TAddress", su.TAddress);
            cmd.Parameters.AddWithValue("@Country", su.Country);
            cmd.Parameters.AddWithValue("@City", su.City);
            cmd.Parameters.AddWithValue("@pcode", su.PostalCode);
            cmd.Parameters.AddWithValue("@Cell", su.CellNo);
            cmd.Parameters.AddWithValue("@Password", su.Password);
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
    }
}
