using Clinic_Business;
using Clinic_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Bussiness
{
    public class clsMedicalRecord
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int MedicalRecordsID {  get; set; }
        public string visitDescription {  get; set; }
        public string Diagnosis {  get; set; }
        public string Notes {  get; set; }

        public clsMedicalRecord()
        {
            this.MedicalRecordsID = -1;
            this.visitDescription = "";
            this.Diagnosis = "";
            this.Notes = "";

            Mode = enMode.AddNew;
        }

        public clsMedicalRecord(int MedicalRecordsID, string visitDescription, string Diagnosis, string Notes)
        {
            this.MedicalRecordsID = MedicalRecordsID;
            this.visitDescription = visitDescription;
            this.Diagnosis = Diagnosis;
            this.Notes = Notes;

            Mode = enMode.Update;
        }

        public static clsMedicalRecord Find(int MedicalRecordsID)
        {
            string visitDescription = "", Diagnosis = "", Notes = "";
            if(clsMedicalRecordData.GetMedicalRecordInfoByID(MedicalRecordsID ,ref visitDescription ,ref Diagnosis ,ref Notes))
                return new clsMedicalRecord(MedicalRecordsID, visitDescription, Diagnosis, Notes);
            else 
                return null;
        }

        private bool _AddNewPatient()
        {
            this.MedicalRecordsID = clsMedicalRecordData.AddNewMedicalRecord(visitDescription , Diagnosis , Notes);
            return (this.MedicalRecordsID != -1);
        }

        private bool _Update()
        {
            return clsMedicalRecordData.UpdateMedicalRecord(MedicalRecordsID, visitDescription, Diagnosis, Notes);
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

        public static DataTable GetAllMedicalRecords()
        {
            return clsMedicalRecordData.GetAllMedicalRecords();
        }

        public static bool IsMedicalRecordExist(int MedicalRecordID)
        {
            return clsMedicalRecordData.IsMedicalRecordExist(MedicalRecordID);
        }
    }
}
