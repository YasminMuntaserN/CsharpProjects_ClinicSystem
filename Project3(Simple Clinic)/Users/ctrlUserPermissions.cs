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

namespace Project3_Simple_Clinic_.Users
{
    public partial class ctrlUserPermissions : UserControl
    {
        public ctrlUserPermissions()
        {
            InitializeComponent();
        }
        public int SelectedPermissions
        {
            get
            {
                return _ReadPermissionsToSet();
            }
        }

        private int _ReadPermissionsToSet()
        {
            int Permissions = 0;

            List<string> selectedFields = new List<string>();

            foreach (var item in clbPermision.CheckedItems)
            {
                selectedFields.Add(item.ToString());
            }

            if (selectedFields[0].ToString().Trim() == "All")
            {
                return -1;
            }


            foreach (string CheckedItem in selectedFields)
            {
                switch (CheckedItem.ToString().Trim())
                {
                    case "Doctors":
                        Permissions += (int)clsUsers.enPermissions.Doctors;
                        break;
                    case "Users":
                        Permissions += (int)clsUsers.enPermissions.Users;
                        break;
                    case "Patients":
                        Permissions += (int)clsUsers.enPermissions.Patients;
                        break;
                    case "Appointments":
                        Permissions += (int)clsUsers.enPermissions.Appointments;
                        break;
                    case "Payments":
                        Permissions += (int)clsUsers.enPermissions.Payments;
                        break;                  
                }
            }
            return Permissions;
        }

        private void CheckAllItems()
        {
            for (int i = 0; i < clbPermision.CheckedItems.Count; i++)
            {
                clbPermision.SetItemChecked(i, true);
            }
        }

        public void FillUserPermissions(clsUsers _User)
        {
            if (_User.CheckAccessPermissions(clsUsers.enPermissions.All))
            {
                CheckAllItems();
                // return;
            }
            if (_User.CheckAccessPermissions(clsUsers.enPermissions.Doctors)) clbPermision.SetItemChecked(1, true);
            if (_User.CheckAccessPermissions(clsUsers.enPermissions.Patients)) clbPermision.SetItemChecked(2, true);
            if (_User.CheckAccessPermissions(clsUsers.enPermissions.Payments)) clbPermision.SetItemChecked(3, true);
            if (_User.CheckAccessPermissions(clsUsers.enPermissions.Appointments)) clbPermision.SetItemChecked(4, true);
            if (_User.CheckAccessPermissions(clsUsers.enPermissions.Users)) clbPermision.SetItemChecked(5, true);

        }

        public void Clear()
        {
            for (int i = 0; i < clbPermision.CheckedItems.Count; i++)
            {
                clbPermision.SetItemChecked(i, false);
            }

        }

    }
}
