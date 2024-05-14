using Clinic_Bussiness;
using Clinic_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Business
{
    public class clsPrescriptions
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PrescriptionID {  get; set; }
        public int MedicalRecordID { get; set; }

        private clsMedicalRecord _MedicalRecord;

        public string MedicationName {  get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }

        public clsPrescriptions()
        {
            this.PrescriptionID = -1;
            this.MedicalRecordID = -1;
            this.MedicationName = "";
            this.Dosage = "";
            this.Frequency = "";
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.SpecialInstructions = "";
            Mode = enMode.AddNew;
        }

        public clsPrescriptions(int PrescriptionID, int MedicalRecordID , string MedicationName , string Dosage 
            , string Frequency , DateTime StartDate , DateTime EndDate , string SpecialInstructions)
        {
            this.PrescriptionID= PrescriptionID;
            this.MedicalRecordID= MedicalRecordID;
            _MedicalRecord=clsMedicalRecord.Find(MedicalRecordID);
            this.MedicationName= MedicationName;
            this.Dosage= Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;

            Mode = enMode.Update;   

        }

        private bool _AddNewPrescription()
        {
            this.PrescriptionID = clsPrescriptionsData.AddNewPrescriptions(MedicalRecordID, MedicationName, Dosage,
                Frequency,StartDate , EndDate , SpecialInstructions);
            return (this.PrescriptionID != -1);
        }

        private bool _Update()
        {
            return clsPrescriptionsData.UpdatePrescription(PrescriptionID,MedicalRecordID,MedicationName, Dosage,
                Frequency, StartDate, EndDate, SpecialInstructions);
        }

        public static clsPrescriptions Find(int PrescriptionID)
        {
            int MedicalRecordID = -1;
            string MedicationName = "", Dosage = "", Frequency = "", SpecialInstructions = "";
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;

            if (clsPrescriptionsData.GetPrescriptionInfoByPrescriptionID(PrescriptionID, ref MedicalRecordID,
                ref MedicationName, ref Dosage, ref Frequency, ref StartDate, ref EndDate, ref SpecialInstructions))

                return new clsPrescriptions(PrescriptionID, MedicalRecordID, MedicationName, Dosage
                    , Frequency, StartDate, EndDate, SpecialInstructions);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPrescription())
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

        public static bool IsPrescriptionExist(int MedicalRecordID)
        {
            return clsPrescriptionsData.IsPrescriptionExist(MedicalRecordID);
        }

        public static DataTable GetAllPrescriptions()
        {
            return clsPrescriptionsData.GetAllPrescription();
        }
    }
}
