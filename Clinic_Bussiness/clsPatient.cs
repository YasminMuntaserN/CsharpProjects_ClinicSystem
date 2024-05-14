using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_DataAccess;

namespace Clinic_Business
{
    public class clsPatient : clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PatientID { get; set; }

        public clsPatient()
        {
            this.PatientID = -1;
            this.PersonID = -1;
            Mode = enMode.AddNew;
        }

        public clsPatient(int PersonID, string Name, DateTime DateOfBirth,
           short Gender, string Address, string Phone, string Email, string ImagePath,
            int PatientID)
        {
            base.PersonID = PersonID;
            base.Name = Name;
            base.DateOfBirth = DateOfBirth;
            base.Gender = Gender;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.ImagePath = ImagePath;

            this.PatientID = PatientID;
            Mode = enMode.Update;
        }

        private bool _AddNewPatient()
        {
            this.PatientID = clsPatientData.AddNewPatient(PersonID);
            return (this.PatientID != -1);
        }

        private bool _Update()
        {
            return clsPatientData.UpdatePatient(PatientID, PersonID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {

                        Mode = enMode.AddNew;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static clsPatient FindByPatientID(int PatientID)
        {
            int PersonID = -1;

            bool IsFound = clsPatientData.GetPatientInfoByID(PatientID, ref PersonID);

            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsPatient(PersonID, Person.Name, Person.DateOfBirth, Person.Gender
                    , Person.Address, Person.Phone, Person.Email, Person.ImagePath, PatientID);

            else
                return null;
        }

        public static clsPatient FindByPersonID(int PersonID)
        {
            int PatientID = -1; ;

            bool IsFound = clsPatientData.GetPatientInfoByPersonID(PersonID, ref PatientID);

            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsPatient(PersonID, Person.Name, Person.DateOfBirth, Person.Gender
                    , Person.Address, Person.Phone, Person.Email, Person.ImagePath, PatientID);

            else
                return null;
        }

        public static DataTable GetAllPatient()
        {
            return clsPatientData.GetAllPatients();
        }

        public static bool IsPatientExists(int PatientID)
        {
            return clsPatientData.IsPatientExists(PatientID);
        }

        public static bool DoesPatientExistsByPersonID(int PersonID)
        {
            return clsPatientData.IsPatientExistsByPersonID(PersonID);
        }

        public static bool Delete(int PatientID)
        {
            return clsPatientData.DeletePatient(PatientID);
        }

        public static int GetPatientCount()
        {
            return clsPatientData.GetPatientsCount();
        }
    }
}
