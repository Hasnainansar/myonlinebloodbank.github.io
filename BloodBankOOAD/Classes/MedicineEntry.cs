using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BloodBankOOAD.Classes
{
    class MedicineEntry
    {
        public int ID { get; set; }

        public string Medicine { get; set; }

        public string MedicineDesc { get; set; }

        public string TimeMedicine { get; set; }

        SqlDataAdapter adapter;
        DataSet ds;
        SqlConnection MyCon = Connection.Make();




        public void RegisterUserMedicineEntry(MedicineEntry ME)
        {
            string query = "MedicineAlloting";
            SqlCommand cmd = new SqlCommand(query, MyCon);
            MyCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ME.ID);
            cmd.Parameters.AddWithValue("@Medicine", ME.Medicine);
            cmd.Parameters.AddWithValue("@MedicineDesc", ME.MedicineDesc);
            cmd.Parameters.AddWithValue("@Time1", DateTime.Parse(ME.TimeMedicine));
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }
        public MedicineEntry GetUserMedicinebyID(int Id)
        {
            MedicineEntry me = new MedicineEntry();
            string query = "Select * from Medicines where UserID = '" + Id + "'";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                me.ID = int.Parse(reader[0].ToString());
                me.Medicine = reader[1].ToString();
                me.MedicineDesc = reader[2].ToString();
                me.TimeMedicine = reader[3].ToString();
                
            }
            MyCon.Close();
            return me;
        }
        public DataSet SearchID(int ID)
        {
            
            string query = "Select * from Medicines where UserID = '" + ID + "'";
            MyCon.Open();

            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);
            MyCon.Close();
            return ds;


        }
        public DataSet GetAllUserMedicine()
        {
            string query = "Select * from Medicines";
            MyCon.Open();
            ds = new DataSet();
            adapter = new SqlDataAdapter(query, MyCon);
            adapter.Fill(ds);


            MyCon.Close();
            return ds;
        }
        public void UpdateUserMedicine(MedicineEntry m)
        {
            string query = "UpdatingMedicine";
            MyCon.Open();
            SqlCommand cmd = new SqlCommand(query, MyCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", m.ID);
            cmd.Parameters.AddWithValue("@Med", m.Medicine);
            cmd.Parameters.AddWithValue("@MedDesc", m.MedicineDesc);
            cmd.Parameters.AddWithValue("@Timee", m.TimeMedicine);
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MyCon.Close();
        }

    }
}
