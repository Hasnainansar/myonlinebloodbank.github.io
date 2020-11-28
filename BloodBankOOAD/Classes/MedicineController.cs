using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BloodBankOOAD.Classes
{
    class MedicineController
    {
 

        public void RegisterUserMedicine(int id,string medicine,string medicinedesc,string time)
        {
            MedicineEntry um = new MedicineEntry();

            um.ID=id;
			um.Medicine = medicine;
			um.MedicineDesc=medicinedesc;
			um.TimeMedicine=time;
            um.RegisterUserMedicineEntry(um);
        }
        public DataSet GetUserMedicine()
        {
            MedicineEntry um = new MedicineEntry();
            return um.GetAllUserMedicine();
        }
        public void UpdateUserMedicine(int id, string medicine, string medicinedesc, string time)
        {
            MedicineEntry um = new MedicineEntry();
            um.ID = id;
            um.Medicine = medicine;
            um.MedicineDesc = medicinedesc;
            um.TimeMedicine = time;
            um.UpdateUserMedicine(um);
        }
        public DataSet SearchID(int ID)
        {
            MedicineEntry um = new MedicineEntry();
            return um.SearchID(ID);
        }
        public MedicineEntry GetUserMedicineByID(int ID)
        {
            MedicineEntry um = new MedicineEntry();
            return um.GetUserMedicinebyID(ID);
        }
    }
}
