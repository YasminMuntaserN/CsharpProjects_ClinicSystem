using Clinic_Business;
using Clinic_Bussiness;
using Project3_Simple_Clinic_.Prescription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Medical_Record
{
    public partial class frmAddEditMedicalRecord : Form
    {
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsMedicalRecord _MedicalRecord;

        public int _MedicalRecordID = -1;

        public delegate void DataBackEventHandler(int MedicalRecordID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmAddEditMedicalRecord()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditMedicalRecord(int MedicalRecordID)
        {
            _MedicalRecordID = MedicalRecordID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitle()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Medical Record";
                this.Text = "Add New Medical Record";
                _MedicalRecord = new clsMedicalRecord();
            }
            else
            {
                this.Text = "Update Medical Record";
                lblTitle.Text = "Update Medical Record";
            }
        }

        public void LoadData()
        {
            _MedicalRecord = clsMedicalRecord.Find(_MedicalRecordID);
            if (_MedicalRecord == null)
            {
                MessageBox.Show("No Medical Record with ID = " + _MedicalRecordID, " Medical Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblMedicalRecordID.Text = _MedicalRecord.MedicalRecordsID.ToString();
            txtDiagnosis.Text = _MedicalRecord.Diagnosis;
            txtvisitDescription.Text = _MedicalRecord.visitDescription;
            txtNotes.Text = _MedicalRecord.Notes;
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            frmAddEditPrescriptions frm = new frmAddEditPrescriptions(_MedicalRecordID);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _MedicalRecord.Diagnosis = txtDiagnosis.Text.Trim();
            _MedicalRecord.visitDescription = txtvisitDescription.Text.Trim();
            _MedicalRecord.Notes = txtNotes.Text.Trim();

            if (_MedicalRecord.Save())
            {
                _MedicalRecordID = _MedicalRecord.MedicalRecordsID;
                lblMedicalRecordID.Text = _MedicalRecord.MedicalRecordsID.ToString();
                btnAddPrescription.Enabled = true;
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Medical Record";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //  send MedicalRecordID to frmAddEditAppointment By Event
            DataBack?.Invoke(_MedicalRecord.MedicalRecordsID);
        }

        private void frmAddEditMedicalRecord_Load(object sender, EventArgs e)
        {
            _ResetTitle();
            if (_Mode == enMode.Update)
                LoadData();
        }

        
    }
}
