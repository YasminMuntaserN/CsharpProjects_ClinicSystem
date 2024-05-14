using Clinic_Business;
using Project3_Simple_Clinic_.Global_Classes;
using Project3_Simple_Clinic_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Person
{
    public partial class frmAddEditPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1 };
        enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;

        clsPeople _Person;

        private int _PersonID = -1;

        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;

        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person";
                _Person = new clsPeople();
            }
            else
            {
                this.Text = "Update Person";
                lblTitle.Text = "Update Person";
            }
        }

        public void LoadData()
        {
            _Person = clsPeople.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _Person, " Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblPersonD.Text = _Person.PersonID.ToString();
            txtName.Text = _Person.Name;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            dtBirthDate.Value = _Person.DateOfBirth;
            txtAdreess.Text = _Person.Address;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;

            }

            llRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private void _FillDate()
        {
            _Person.Name = txtName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAdreess.Text.Trim();
            _Person.DateOfBirth = dtBirthDate.Value;


            if (rbMale.Checked)
                _Person.Gender = (short)enGender.Male;
            else
                _Person.Gender = (short)enGender.Female;


            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillDate();

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Person.Save())
            {
                lblPersonD.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = Resources.user;
            llRemoveImage.Visible = false;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }

            //validate email format
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
