using Clinic_Business;
using Project3_Simple_Clinic_.Global_Classes;
using Project3_Simple_Clinic_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_
{
    public partial class frmHome : Form
    {
        List<int> AllDoctorsIDList;
        int count = 0;
        public frmHome()
        {
            InitializeComponent();
        }
        private List<int> LoadAllDoctorsID()
        {
            List<int> list = new List<int>();
            DataTable dt = clsDoctors.GetAllDoctors();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(clsValidation.ValidateNumbers(dt.Rows[i]["DoctorID"].ToString()));
            }
            return list;
        }

        private void LoadDoctorsInfo(int DoctorID)
        {
            clsDoctors Doctor =clsDoctors.FindByDoctorID(DoctorID);
            if (Doctor.ImagePath == "")
            {
                pbDoctorImage.Image =(Doctor.Gender ==0)?Resources.man : Resources.woman;
            }
            else
            {
                pbDoctorImage.Image = Image.FromFile(Doctor.ImagePath);
            }
            lblDoctorName.Text = Doctor.Name;
            lblMedicalSpecialty.Text = Doctor.Specialization;
        }
       
        private void LoadDataNum()
        {
            lblAppointmentNum.Text = clsAppointment.GetAppointmentsCount().ToString();
            lblDoctorsNum.Text = clsDoctors.GetDoctorsCount().ToString();
            lblPatientNum.Text = clsPatient.GetPatientCount().ToString();
            lblUsers.Text = clsUsers.GetUsersCount().ToString();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            txtUserNmae.Text = clsGlobal.CurrentUser.UserName;
            LoadDataNum();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            AllDoctorsIDList = LoadAllDoctorsID();
            if (count > AllDoctorsIDList.Count - 1)
            {
                count = 0;
            }
            LoadDoctorsInfo(AllDoctorsIDList[count]);
            count++;
        }
    }
}
