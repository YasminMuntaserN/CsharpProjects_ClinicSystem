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

namespace Project3_Simple_Clinic_.Patient
{
    public partial class ctrlPatientCard : UserControl
    {
        private clsPatient _Patient;
        public ctrlPatientCard()
        {
            InitializeComponent();
        }
        public void LoadData(int PatientID)
        {
            _Patient = clsPatient.FindByPatientID(PatientID);
            if (_Patient == null) return;
            if (_Patient.ImagePath == "")
                pbPatiantImage.Image = Resources.user;
            else
            pbPatiantImage.Image = Image.FromFile(_Patient.ImagePath);
            lblPatientID.Text = _Patient.PatientID.ToString();
            lblPatientName.Text = _Patient.Name;
            lblDateOfBirth.Text = clsFormat.DateToShort(_Patient.DateOfBirth);
            lblEmail.Text = _Patient.Email;
            lblPhone.Text = _Patient.Phone;
            lblGender.Text = (_Patient.Gender == 0) ? "Male" : "Female";
            lblAddress.Text = _Patient.Address;
        }

    }
}
