using Clinic_Business;
using Project3_Simple_Clinic_.Global_Classes;
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

namespace Project3_Simple_Clinic_.Users
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 0, Update = 1 };
        enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;

        clsUsers _User;

        private int _UserID = -1;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditUser(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUsers();
            }
            else
            {
                this.Text = "Update User";
                lblTitle.Text = "Update User";
            }
        }

        public void LoadData()
        {
            _User = clsUsers.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }
            lblUserID.Text = _User.UserID.ToString();
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            ctrlUserPermissions1.FillUserPermissions(_User);

            btnNext.Enabled = true;
            tpUserInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.Permissions = ctrlUserPermissions1.SelectedPermissions;
            _User.PersonID = ctrlPersonCardWithFilter1.PersonInfo.PersonID;
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "UserName cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }


            if (clsUsers.isUserExist(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "username is used by another user");
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcUser.SelectedTab = tcUser.TabPages["tpUserInfo"];
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, Person.ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonInfo.User)
            {
                MessageBox.Show("This person has already been registered as a User in this system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
                tpUserInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            btnNext.Enabled = true;
            tpUserInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            tpUserInfo.Enabled = false;
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
