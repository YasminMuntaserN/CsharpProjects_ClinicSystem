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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project3_Simple_Clinic_.Person
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        public class SelectPersonEventArgs : EventArgs
        {
            public int PersonID { get; }
            public string Name { get; }

            public SelectPersonEventArgs(int PersonID, string Name)
            {
                this.PersonID = PersonID;
                this.Name = Name;
            }
        }

        public event EventHandler<SelectPersonEventArgs> OnPersonSelectedEvent;

        public void OnPersonSelected(int PersonID, string Name)
        {
            if (OnPersonSelectedEvent != null)
            {
                OnPersonSelectedEvent(this, new SelectPersonEventArgs(PersonID, Name));
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private clsPeople _Person;

        public clsPeople PersonInfo
        {
            get
            {
                return _Person;
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFindBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();           
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            _Person = ctrlPersonCard1.SelectedPersonInfo;
        }

        private void FindNow()
        {
            if (!(cbFindBy.SelectedIndex > -1))
            {
                errorProvider1.SetError(cbFindBy, "You must choose how you want to search");
                return;
            }
            switch (cbFindBy.Text.Trim())
            {
                case "Person ID":
                    if (!clsPeople.isPersonExist(int.Parse(txtFilterValue.Text)))
                    {
                        MessageBox.Show("This person is not present in the system. To add a new person, click on the add icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "Name":
                    if (!clsPeople.isPersonExist(txtFilterValue.Text))
                    {
                        MessageBox.Show("This person is not present in the system. To add a new person, click on the add icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            _Person = ctrlPersonCard1.SelectedPersonInfo;
            if (OnPersonSelectedEvent != null)
                OnPersonSelected(_Person.PersonID, _Person.Name);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            FindNow();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            cbFindBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson();
            frmAddEditPerson.DataBack += DataBackEvent;
            frmAddEditPerson.ShowDialog();
            _Person = ctrlPersonCard1.SelectedPersonInfo;

            if (OnPersonSelectedEvent != null)
                OnPersonSelected(_Person.PersonID, _Person.Name);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFindBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
