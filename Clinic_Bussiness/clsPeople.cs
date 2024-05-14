using Clinic_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Business
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string Name { set; get; }
        public DateTime DateOfBirth { set; get; }
        public short Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string ImagePath { set; get; }

        public bool Doctor
        {
            get
            {
                return clsDoctors.DoesDoctorExistsByPersonID(this.PersonID);
            }
        }

        public bool Patient
        {
            get
            {
                return clsPatient.DoesPatientExistsByPersonID(this.PersonID);
            }
        }

        public bool User
        {
            get
            {
                return clsUsers.DoesUserExistByPersonID(this.PersonID);
            }
        }

        public clsPeople()
        {
            this.PersonID = -1;
            this.Name = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }

        private clsPeople(int PersonID, string Name, DateTime DateOfBirth, short Gender,
             string Address, string Phone, string Email, string ImagePath)
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPeopleData.AddNewPerson(this.Name, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.ImagePath);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPeopleData.UpdatePerson(
                this.PersonID, this.Name, this.DateOfBirth, this.Gender,
                this.Address, this.Phone, this.Email, this.ImagePath);
        }

        public static clsPeople Find(int PersonID)
        {

            string Name = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;

            bool IsFound = clsPeopleData.GetPersonInfoByID
                                (
                                    PersonID, ref Name, ref DateOfBirth,
                                    ref Gender, ref Address, ref Phone, ref Email, ref ImagePath
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPeople(PersonID, Name, DateOfBirth, Gender, Address, Phone, Email, ImagePath);
            else
                return null;
        }

        public static clsPeople Find(string Name)
        {
            int PersonID = -1;
            string Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;

            bool IsFound = clsPeopleData.GetPersonInfoByName
                                (
                                   Name, ref PersonID, ref DateOfBirth,
                                    ref Gender, ref Address, ref Phone, ref Email, ref ImagePath
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPeople(PersonID, Name, DateOfBirth, Gender, Address, Phone, Email, ImagePath);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();
            }

            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPeopleData.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsPeopleData.IsPersonExist(ID);
        }

        public static bool isPersonExist(string Name)
        {
            return clsPeopleData.IsPersonExist(Name);
        }


    }
}
