using Clinic_Business;
using Clinic_Bussiness;
using Project3_Simple_Clinic_.Global_Classes;
using Project3_Simple_Clinic_.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Prescription
{
    public partial class frmAddEditPrescriptions : Form
    {
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsPrescriptions _Prescriptions;

        private int _PrescriptionsID = -1;
        private int _MedicalRecordID = -1;


        public frmAddEditPrescriptions(int MedicalRecordID)
        {
            InitializeComponent();
            _MedicalRecordID = MedicalRecordID;
        }

        private void _ResetTitle()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Prescription";
                this.Text = "Add New Prescription";
                _Prescriptions = new clsPrescriptions();
            }
            else
            {
                this.Text = "Update Prescription";
                lblTitle.Text = "Update Prescription";
            }
        }

        public void LoadData()
        {
            _Prescriptions = clsPrescriptions.Find(_PrescriptionsID);
            if (_Prescriptions == null)
            {
                MessageBox.Show("No Prescription with ID = " + _PrescriptionsID, " Prescription Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblPrescriptionID.Text = _Prescriptions.PrescriptionID.ToString();
            lblMedicalRecordID.Text = _Prescriptions.MedicalRecordID.ToString();
            txtMedicationName.Text = _Prescriptions.MedicationName;
            txtFrequency.Text = _Prescriptions.Frequency;
            txtSpecialInstructions.Text = _Prescriptions.SpecialInstructions;
            dtpEndDate.Value = _Prescriptions.EndDate;
            dtpStartDate.Value = _Prescriptions.StartDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Prescriptions.Dosage = txtDosage.Text.Trim();
            _Prescriptions.Frequency = txtFrequency.Text.Trim();
            _Prescriptions.MedicationName = txtMedicationName.Text.Trim();
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("The end date should be after the start date!", "Date Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Prescriptions.StartDate =dtpStartDate.Value;
            _Prescriptions.EndDate = dtpEndDate.Value;
            _Prescriptions.MedicalRecordID = _MedicalRecordID;
            _Prescriptions.SpecialInstructions = txtSpecialInstructions.Text.Trim();



            if (_Prescriptions.Save())
            {
                lblMedicalRecordID.Text = _MedicalRecordID.ToString();
                lblPrescriptionID.Text = _Prescriptions.PrescriptionID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Prescriptions";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddEditPrescriptions_Load(object sender, EventArgs e)
        {
            _ResetTitle();
            if (_Mode == enMode.Update)
                LoadData();
        }

        private void btnShowAllMedicalPrescriptions_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList("Prescriptions");
            frm.ShowDialog();
        }

        private void btnShowAllMedicalRecords_Click_1(object sender, EventArgs e)
        {
            frmList frm = new frmList("MedicalRecord");
            frm.ShowDialog();
        }
    }
}
