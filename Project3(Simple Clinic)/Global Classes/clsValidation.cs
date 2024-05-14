using Clinic_Business;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Global_Classes
{
    internal class clsValidation
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

        public static int ValidateNumbers(string text)
        {
            int Num = -1;
            if (int.TryParse(text, out int Result))
            {
                Num = Result;
            }
            return Num;

        }

        public static bool ValidateEmptyText(ErrorProvider errorProvider1, GunaTextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError((textBox), "This field is required!");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
                return true;
            }
        }

        public static bool HasPermissionToDoThisOperation(string OperationName)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermissions(clsUsers.GetPermissionName(OperationName)))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }
}
