using Clinic_Business;
using Project3_Simple_Clinic_.Global_Classes;
using Project3_Simple_Clinic_.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            if (clsUsers.isUserExist(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
                clsUsers user = clsUsers.Find(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                if (user != null)
                {
                    clsGlobal.CurrentUser = user;
                    this.Hide();
                    frmMain frm = new frmMain(this);
                    frm.ShowDialog();
                }
                else
                {
                    txtUserName.Focus();
                    errorProvider1.SetError(txtUserName, "Invalid Username/Password.");
                }
            }
            else
            {
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "Invalid Username/Password.");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                btnLogIn.PerformClick();
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
        }

        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (clsValidation.ValidateNumbers(txtPassword.Text.Trim()) == -1)
            {
                e.Cancel = true;
            }
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

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser();
            frmAddEditUser.ShowDialog();    
        }
    }
}
