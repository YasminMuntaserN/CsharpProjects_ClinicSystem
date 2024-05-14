using Clinic_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Doctors
{
    public partial class frmAddDoctor : Form
    {
        enum enMode { AddNew = 0, Update = 1 };
        enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;

        private clsDoctors _Doctor;

        private int _DoctorID = -1;

        public frmAddDoctor()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _Doctor = new clsDoctors();
        }

        public frmAddDoctor(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
            _Mode = enMode.Update;
        }
        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Doctor";
                this.Text = "Add New Doctor";
                _Doctor = new clsDoctors();
            }
            else
            {
                this.Text = "Update Doctor";
                lblTitle.Text = "Update Doctor";
            }
        }

        public void LoadData()
        {
            _Doctor = clsDoctors.FindByDoctorID(_DoctorID);
            if (_Doctor == null)
            {
                MessageBox.Show("No Doctor with ID = " + _DoctorID, "Doctor Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }
            lblDoctorD.Text = _Doctor.DoctorID.ToString();
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Doctor.PersonID);
            txtSpecialization.Text = _Doctor.Specialization.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonInfo.Doctor)
            {
                MessageBox.Show("This person has already been registered as a doctor in this system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Doctor.Specialization = txtSpecialization.Text;
            _Doctor.PersonID = ctrlPersonCardWithFilter1.PersonInfo.PersonID;
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Doctor.Save())
            {
                lblDoctorD.Text = _Doctor.DoctorID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Doctor";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtSpecialization_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSpecialization.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSpecialization, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSpecialization, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddDoctor_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }
    }
}
