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

namespace Project3_Simple_Clinic_.Doctors
{
    public partial class ctrlDoctorCard : UserControl
    {
        private clsDoctors _Doctor;
        public ctrlDoctorCard()
        {
            InitializeComponent();
        }

        public void LoadData(int DoctorID)
        {
            _Doctor = clsDoctors.FindByDoctorID(DoctorID);
            if (_Doctor == null) return;
            if (_Doctor.ImagePath == "")
                pbDoctorImage.Image = Resources.user;
            else
                pbDoctorImage.Image = Image.FromFile(_Doctor.ImagePath);
            lblDoctorID.Text =_Doctor.DoctorID.ToString();
            lblDrName.Text = _Doctor.Name;
            lblDateOfBirth.Text =clsFormat.DateToShort(_Doctor.DateOfBirth);
            lblEmail.Text = _Doctor.Email;
            lblPhone.Text = _Doctor.Phone;
            lblSpecializtion.Text = _Doctor.Specialization;
            lblGender.Text = (_Doctor.Gender == 0) ? "Male" : "Female";
            lblAddress.Text = _Doctor.Address;
        }

    }
}
