using Clinic_Business;
using Clinic_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Business
{
    public class clsUsers : clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

        public enum enPermissions
        {
            All = -1, Doctors = 1, Patients = 2, Payments = 4, Appointments = 8, Users = 16
        };

        public clsUsers()
        {
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.Permissions = 0;
            Mode = enMode.AddNew;
        }

        public clsUsers(int PersonID, string Name, string Phone, string Email, string ImagePath,
            int UserID, string userName, string password, int permissions)
        {
            //this is for the base class
            base.PersonID = PersonID;
            base.Name = Name;
            base.Phone = Phone;
            base.Email = Email;
            base.ImagePath = ImagePath;

            this.UserID = UserID;
            this.UserName = userName;
            this.Password = password;
            this.Permissions = permissions;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersData.AddNewUser(this.PersonID, this.UserName, this.Password, this.Permissions);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.Permissions);
        }

        public static clsUsers Find(int UserID)
        {
            int PersonID = -1, Permissions = -1; string UserName = "", Password = "";

            bool IsFound = clsUsersData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref Permissions);

            //now we find the base Person
            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsUsers(Person.PersonID, Person.Name,
                    Person.Phone, Person.Email, Person.ImagePath,
                   UserID, UserName, Password, Permissions);
            else
                return null;
        }

        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserID = -1, Permissions = -1; string UserName = "", Password = "";

            bool IsFound = clsUsersData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref Permissions);

            //now we find the base Person
            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsUsers(Person.PersonID, Person.Name,
                    Person.Phone, Person.Email, Person.ImagePath,
                   UserID, UserName, Password, Permissions);
            else
                return null;
        }

        public static clsUsers Find(string UserName)
        {
            int PersonID = -1, Permissions = -1, UserID = -1; string Password = "";

            bool IsFound = clsUsersData.GetUserInfoByUserName(UserName, ref UserID, ref PersonID, ref Password, ref Permissions);

            //now we find the base Person
            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsUsers(Person.PersonID, Person.Name,
                   Person.Phone, Person.Email, Person.ImagePath,
                  UserID, UserName, Password, Permissions);
            else
                return null;
        }

        public static clsUsers Find(string UserName, string Password)
        {
            int PersonID = -1, Permissions = -1, UserID = -1;

            bool IsFound = clsUsersData.GetUserInfoByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID, ref Permissions);

            //now we find the base Person
            clsPeople Person = clsPeople.Find(PersonID);

            if (IsFound)

                return new clsUsers(Person.PersonID, Person.Name,
                   Person.Phone, Person.Email, Person.ImagePath,
                  UserID, UserName, Password, Permissions);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static bool DeleteUser(int ID)
        {
            return clsUsersData.DeleteUser(ID);
        }

        public static bool isUserExist(int ID)
        {
            return clsUsersData.IsUserExist(ID);
        }

        public static bool DoesUserExistByPersonID(int ID)
        {
            return clsUsersData.IsUserExistByPersonID(ID);
        }

        public static bool isUserExist(String UserName)
        {
            return clsUsersData.IsUserExist(UserName);
        }

        public static bool isUserExist(String UserName, string Password)
        {
            return clsUsersData.IsUserExist(UserName, Password);
        }

        public bool CheckAccessPermissions(enPermissions permissions)
        {
            if (this.Permissions == (int)enPermissions.All)
            {
                return true;
            }
            if (((int)permissions & this.Permissions) == (int)permissions)
            {
                return true;
            }
            return false;
        }

        public static enPermissions GetPermissionName(string permissionName)
        {
            switch (permissionName)
            {
                case "Payments":
                    return enPermissions.Payments;
                case "Appointments":
                    return enPermissions.Appointments;
                case "Patients":
                    return enPermissions.Patients;
                case "Doctors":
                    return enPermissions.Doctors;
                case "Users":
                    return enPermissions.Users;
                default:
                    return enPermissions.All;
            }
        }

        public static int GetUsersCount()
        {
            return clsUsersData.GetUsersCount();
        }
    }
}
