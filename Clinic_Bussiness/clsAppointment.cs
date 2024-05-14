using Clinic_Business;
using Clinic_Bussiness;
using Clinic_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Business
{
    public class clsAppointment
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AppointmentID { set; get; }
        public int StatusID { set; get; }

        public clsStatus status { set; get; }
        public int PatientID { set; get; }

        private clsPatient _Patient;
        public int DoctorID { set; get; }

        private clsDoctors _Doctor;
        public DateTime AppointmentDateAndTime { set; get; }
        public int MedicalRecordID { set; get; }

        private clsMedicalRecordData _MedicalRecord;
        public int PaymentID { set; get; }


        public clsAppointment()
        {
            this.AppointmentID = -1;
            this.StatusID = -1;
            this.PatientID = -1;
            this.DoctorID = -1;
            this.AppointmentDateAndTime = DateTime.Now;
            this.MedicalRecordID = -1;
            this.PaymentID = -1;

            Mode = enMode.AddNew;
        }

        public clsAppointment(int AppointmentID, int DoctorID, int PatientID
        , DateTime AppointmentDateAndTime, int StatusID, int MedicalRecordID, int PaymentID)
        {
            this.AppointmentID = AppointmentID;
            this.DoctorID = DoctorID;
            this._Doctor = clsDoctors.FindByDoctorID(DoctorID);
            this.PatientID = PatientID;
            this._Patient = clsPatient.FindByPatientID(PatientID);
            this.AppointmentDateAndTime = AppointmentDateAndTime;
            this.StatusID = StatusID;
            this.status = clsStatus.Find(StatusID);
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;


            Mode = enMode.Update;
        }

        public static clsAppointment Find(int AppointmentID)
        {
            int DoctorID = -1, PatientID = -1, MedicalRecordID = -1, PaymentID = -1, StatusID = -1;
            DateTime AppointmentDateAndTime = DateTime.Now;
            if (clsAppointmentData.GetAppointmentInfoByID(AppointmentID, ref PatientID, ref DoctorID
                , ref AppointmentDateAndTime, ref StatusID, ref MedicalRecordID, ref PaymentID))

                return new clsAppointment(AppointmentID, DoctorID, PatientID
                    , AppointmentDateAndTime, StatusID, MedicalRecordID, PaymentID);

            else
                return null;
        }

        public static clsAppointment Find(int DoctorID, DateTime AppointmentDateAndTime)
        {
            int AppointmentID = -1, PatientID = -1, MedicalRecordID = -1, PaymentID = -1, StatusID = -1;
            if (clsAppointmentData.GetAppointmentInfoByDoctorIDAndAppointmentDate(DoctorID, AppointmentDateAndTime, ref PatientID, ref AppointmentID
                , ref StatusID, ref MedicalRecordID, ref PaymentID))

                return new clsAppointment(AppointmentID, DoctorID, PatientID
                    , AppointmentDateAndTime, StatusID, MedicalRecordID, PaymentID);

            else
                return null;
        }

        private bool _AddNewAppointment()
        {
            this.AppointmentID = clsAppointmentData.AddNewAppointment(DoctorID, PatientID, AppointmentDateAndTime,
                (int)StatusID, MedicalRecordID, PaymentID);
            return (this.AppointmentID != -1);
        }

        private bool _Update()
        {
            return clsAppointmentData.UpdateAppointment(AppointmentID, DoctorID, PatientID, AppointmentDateAndTime,
                (int)StatusID, MedicalRecordID, PaymentID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAppointment())
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

        public static bool Delete(int AppointmentID)
        {
            return clsAppointmentData.DeleteAppointment(AppointmentID);
        }

        public static DataTable GetAllAppointments()
        {
            return clsAppointmentData.GetAllAppointments();
        }

        public static int GetAppointmentsCount()
        {
            return clsAppointmentData.GetAppointmentsCount();
        }

    }
}
