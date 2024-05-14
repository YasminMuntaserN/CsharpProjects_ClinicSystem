using Clinic_Business;
using Project3_Simple_Clinic_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Patient
{
    public partial class frmAddEditPatient : Form
    {
        enum enMode { AddNew = 0, Update = 1 };
        enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;

        clsPatient _Patient;

        private int _PatientID = -1;
        public frmAddEditPatient()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditPatient(int PatientID)
        {
            _PatientID = PatientID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Patient";
                this.Text = "Add New Patient";
                _Patient = new clsPatient();
            }
            else
            {
                this.Text = "Update Patient";
                lblTitle.Text = "Update Patient";
            }
        }

        public void LoadData()
        {
            _Patient = clsPatient.FindByPatientID(_PatientID);
            if (_Patient == null)
            {
                MessageBox.Show("No Patient with ID = " + _PatientID, "Patient Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }
            lblPatientID.Text = _Patient.PatientID.ToString();
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Patient.PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonInfo.Patient)
            {
                MessageBox.Show("This person has already been registered as a Patient in this system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Patient.PersonID = ctrlPersonCardWithFilter1.PersonInfo.PersonID;
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Patient.Save())
            {
                lblPatientID.Text = _Patient.PatientID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Patient";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmAddEditPatient_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void frmAddEditPatient_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}
