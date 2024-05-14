using Clinic_Business;
using Clinic_Bussiness;
using Project3_Simple_Clinic_.Global_Classes;
using Project3_Simple_Clinic_.Medical_Record;
using Project3_Simple_Clinic_.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Appointment
{
    public partial class frmAddEditAppointment : Form
    {
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsAppointment _Appointment;

        private int _AppointmentID = -1;
        public frmAddEditAppointment()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditAppointment(int AppointmentID)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _Mode = enMode.Update;
        }

        private void _ResetTitle()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Appointment";
                this.Text = "Add New Appointment";
                _Appointment = new clsAppointment();
            }
            else
            {
                this.Text = "Update Appointment";
                lblTitle.Text = "Update Appointment";
            }
        }

        private bool CheckForCorrectData()
        {
            clsAppointment DuplicateAppointment = clsAppointment.Find(int.Parse(NumDoctorID.Value.ToString()), DateTime.Value);
            if (DuplicateAppointment != null && !clsStatus.getStatusName(DuplicateAppointment.StatusID).Equals("Canceled")
              && _Mode == enMode.AddNew)
            {

                MessageBox.Show("Sorry, the selected doctor already has an appointment scheduled at that time" +
                    ".Please choose a different time  or select a different doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!clsPatient.IsPatientExists((int)NumPatiantID.Value))
            {
                MessageBox.Show("There is no patient with ID = " + (int)NumPatiantID.Value,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (!clsDoctors.DoesDoctorExists((int)NumDoctorID.Value))
            {
                MessageBox.Show("There is no Doctor with ID = " + (int)NumDoctorID.Value,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (cbStatus.Text == "None")
            {
                MessageBox.Show("Select the status first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return true;
        }

        public void LoadData()
        {
            _Appointment = clsAppointment.Find(_AppointmentID);
            if (_Appointment == null)
            {
                MessageBox.Show("No Appointment with ID = " + _Appointment, " Appointment Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblAppointmetD.Text = _Appointment.AppointmentID.ToString();

            lblMedicalRecordID.Text = (_Appointment.MedicalRecordID == -1) ? "" : _Appointment.MedicalRecordID.ToString();

            lblPayID.Text = (_Appointment.PaymentID == -1) ? "" : _Appointment.PaymentID.ToString();

            NumPatiantID.Value = _Appointment.PatientID;

            NumDoctorID.Value = _Appointment.DoctorID;

            cbStatus.SelectedIndex = cbStatus.FindString(clsStatus.Find(_Appointment.StatusID).StatusName);

            DateTime.Value = _Appointment.AppointmentDateAndTime;

            ctrlDoctorCard1.LoadData(_Appointment.DoctorID);
            patientCard1.LoadData(_Appointment.PatientID);

        }

        private void _FillData()
        {

            _Appointment.PatientID = int.Parse(NumPatiantID.Value.ToString());

            _Appointment.StatusID = clsStatus.Find(cbStatus.Text).StatusID;

            _Appointment.AppointmentDateAndTime = DateTime.Value;

            _Appointment.DoctorID = int.Parse(NumDoctorID.Value.ToString());

            _Appointment.PaymentID = string.IsNullOrWhiteSpace(lblPayID.Text) ? -1 : int.Parse(lblPayID.Text);

            _Appointment.MedicalRecordID = string.IsNullOrWhiteSpace(lblMedicalRecordID.Text) ? -1 : int.Parse(lblMedicalRecordID.Text);

            _Appointment.status = clsStatus.Find(_Appointment.StatusID);

            if (_Appointment.status.StatusName.Equals("Completed") && _Appointment.PaymentID != -1)
                btnAddNewRecord.Enabled = true;
        }

        private void _SaveData()
        {
            if (_Appointment.Save())
            {
                MessageBox.Show("Appointment Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblTitle.Text = "Update Appointment";
                this._Mode = enMode.Update;

                _Appointment.Mode = clsAppointment.enMode.Update;
            }

            else
            {
                MessageBox.Show("Appointment Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckForCorrectData())
            {
                return;
            }

            _FillData();
            _SaveData();
        }

        private void _GetMedicalRecordIDFromfrmAddEditMedicalRecord(int MedicalRecord)
        {
            lblMedicalRecordID.Text = MedicalRecord.ToString();

            if (clsValidation.ValidateNumbers(lblMedicalRecordID.Text) != -1)
            {
                btnAddNewRecord.Visible = false;
            }
            _Appointment.MedicalRecordID= MedicalRecord;
        }

        private void btnAddNewRecord_Click_1(object sender, EventArgs e)
        {
            frmAddEditMedicalRecord frm = new frmAddEditMedicalRecord();
            frm.DataBack += _GetMedicalRecordIDFromfrmAddEditMedicalRecord; // Subscribe to the event
            frm.ShowDialog();

        }

        private void _GetPaymentIDFromfrmAddEditPayment(int PaymentID)
        {
            lblPayID.Text = PaymentID.ToString();

            if (clsValidation.ValidateNumbers(lblPayID.Text) != -1)
            {
                btnPay.Visible = false;
            }
            _Appointment.PaymentID= PaymentID;
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            frmAddEditPayment AddNewPayment = new frmAddEditPayment();
            AddNewPayment.DataBack += _GetPaymentIDFromfrmAddEditPayment; // Subscribe to the event
            AddNewPayment.ShowDialog();

        }

        private void frmAddEditAppointment_Load(object sender, EventArgs e)
        {
            _ResetTitle();

            if (_Mode == enMode.Update)
            {
                LoadData();
                if (_Appointment.PaymentID != -1) btnPay.Visible = false;
            }

        }

        private void NumPatiantID_ValueChanged(object sender, EventArgs e)
        {
            patientCard1.LoadData(int.Parse(NumPatiantID.Value.ToString()));

        }

        private void NumDoctorID_ValueChanged(object sender, EventArgs e)
        {
            ctrlDoctorCard1.LoadData(int.Parse(NumDoctorID.Value.ToString()));

        }

        private void DateTime_MouseDown_1(object sender, MouseEventArgs e)
        {
            DateTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";

        }

    }
}
