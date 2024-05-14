using Clinic_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Business
{
    public class clsDoctors : clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int DoctorID { get; set; }
        public string Specialization { get; set; }

        public clsDoctors()
        {
            this.DoctorID = -1;
            this.PersonID = -1;
            this.Specialization = "";
            Mode = enMode.AddNew;
        }

        public clsDoctors(int PersonID, string Name, DateTime DateOfBirth,
           short Gender, string Address, string Phone, string Email, string ImagePath,
            int doctorID, string Specialization)
        {
            base.PersonID = PersonID;
            base.Name = Name;
            base.DateOfBirth = DateOfBirth;
            base.Gender = Gender;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.ImagePath = ImagePath;

            this.DoctorID = doctorID;
            this.Specialization = Specialization;
            Mode = enMode.Update;
        }

        private bool _AddNewDoctor()
        {
            this.DoctorID = clsDoctorsData.AddNewDoctor(PersonID, Specialization);
            return (this.DoctorID != -1);
        }

        private bool _Update()
        {
            return clsDoctorsData.UpdateDoctor(DoctorID, PersonID, Specialization);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor())
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

        public static clsDoctors FindByDoctorID(int doctorID)
        {
            int PersonID = -1; string Specialization = "";

            bool IsFound = clsDoctorsData.GetDoctorInfoByID
                    (doctorID, ref PersonID, ref Specialization);

            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsDoctors(PersonID, Person.Name, Person.DateOfBirth, Person.Gender
                    , Person.Address, Person.Phone, Person.Email, Person.ImagePath, doctorID, Specialization);

            else
                return null;
        }

        public static clsDoctors FindByPersonID(int PersonID)
        {
            int DoctorID = -1; string Specialization = "";
            bool IsFound = clsDoctorsData.GetDoctorInfoByPersonID
                    (PersonID, ref DoctorID, ref Specialization);

            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsDoctors(PersonID, Person.Name, Person.DateOfBirth, Person.Gender
                    , Person.Address, Person.Phone, Person.Email, Person.ImagePath, DoctorID, Specialization);

            else
                return null;
        }

        public static DataTable GetAllDoctors()
        {
            return clsDoctorsData.GetAllDoctors();
        }

        public static bool DoesDoctorExists(int DoctorID)
        {
            return clsDoctorsData.IsDoctorExists(DoctorID);
        }

        public static bool DoesDoctorExistsByPersonID(int PersonID)
        {
            return clsDoctorsData.IsDoctorExistsByPersonID(PersonID);
        }

        public static bool Delete(int DoctorID)
        {
            return clsDoctorsData.DeleteDoctor(DoctorID);
        }

        public static int GetDoctorsCount()
        {
            return clsDoctorsData.GetDoctorsCount();
        }
    }
}
