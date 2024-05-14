using Clinic_Business;
using Clinic_Bussiness;
using Project3_Simple_Clinic_.Appointment;
using Project3_Simple_Clinic_.Doctors;
using Project3_Simple_Clinic_.Global_Classes;
using Project3_Simple_Clinic_.Medical_Record;
using Project3_Simple_Clinic_.Patient;
using Project3_Simple_Clinic_.Prescription;
using Project3_Simple_Clinic_.Properties;
using Project3_Simple_Clinic_.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_.Home
{
    public partial class frmList : Form
    {
        private enum enListType { MedicalRecord = 1, Prescriptions = 2, Payments = 3, Users = 4, Appointment = 5, Patients = 6, Doctors = 7 }
        private enListType _ListType;
        private string _ListName;
        private DataTable _dtList;
        public frmList(string ListName)
        {
            _ListName = ListName;
            InitializeComponent();
        }
        private void MedicalRecord()
        {
            btnAddNew.Visible = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            cbFilterBy.Items.Add("MedicalRecordID");
            lblTitle.Text = "Medical Record List";
            this.Text = "Medical Record List";
            _dtList = clsMedicalRecord.GetAllMedicalRecords();
            dgvShowList.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            pbImage.Image = Resources.health_report;
            HideDeleteEdit();
        }

        private void Prescription()
        {
            btnAddNew.Visible = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            cbFilterBy.Items.Add("PrescriptionID");
            cbFilterBy.Items.Add("MedicalRecordID");
            lblTitle.Text = "Prescriptions List";
            this.Text = "Prescriptions List";
            _dtList = clsPrescriptions.GetAllPrescriptions();
            dgvShowList.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            HideDeleteEdit();
            pbImage.Image = Resources.prescription;
        }

        private void Appointment()
        {
            cbFilterBy.Items.Add("AppointmentID");
            cbFilterBy.Items.Add("DoctorID");
            cbFilterBy.Items.Add("PatientID");
            cbFilterBy.Items.Add("PaymentID");
            cbFilterBy.Items.Add("MedicalRecordID");
            lblTitle.Text = "Appointment List";
            this.Text = "Appointment List";
            _dtList = clsAppointment.GetAllAppointments();
            dgvShowList.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            pbImage.Image = Resources.online_appointment;
        }

        private void Patients()
        {
            cbFilterBy.Items.Add("PatientID");
            cbFilterBy.Items.Add("Name");
            lblTitle.Text = "Patients List";
            this.Text = "Patients List";
            _dtList = clsPatient.GetAllPatient();
            _dtList.Columns.Remove("Gender");
            dgvShowList.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            pbImage.Image = Resources.hospitalisation;
        }

        private void Doctors()
        {
            cbFilterBy.Items.Add("DoctorID");
            cbFilterBy.Items.Add("Name");
            lblTitle.Text = "Doctors List";
            this.Text = "Doctors List";
            _dtList = clsDoctors.GetAllDoctors();
            _dtList.Columns.Remove("ImagePath");
            dgvShowList.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            pbImage.Image = Resources.doctor__3_;
        }

        private void Payments()
        {
            btnAddNew.Visible = false;
            cbFilterBy.Items.Add("PaymentID");
            lblTitle.Text = "Payments List";
            this.Text = "Payments List";
            _dtList = clsPayment.GetAllPayments();
            dgvShowList.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            HideDeleteEdit();
            pbImage.Image = Resources.wallet__1_1;

        }

        private void Users()
        {
            cbFilterBy.Items.Add("UserID");
            cbFilterBy.Items.Add("UserName");

            lblTitle.Text = "Users List";
            this.Text = "Users List";
            _dtList = clsUsers.GetAllUsers();
            dgvShowList.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            pbImage.Image = Resources.working_together__2_;
        }

        private void _SetOperationType()
        {
            switch (_ListType)
            {
                case enListType.MedicalRecord:
                    MedicalRecord();
                    break;
                case enListType.Prescriptions:
                    Prescription();
                    break;
                case enListType.Appointment:
                    Appointment();
                    break;
                case enListType.Patients:
                    Patients();
                    break;
                case enListType.Doctors:
                    Doctors();
                    break;
                case enListType.Payments:
                    Payments();
                    break;
                case enListType.Users:
                    Users();
                    break;
            }
        }

        private void HideDeleteEdit()
        {
            foreach (ToolStripMenuItem Item in contextMenuStrip1.Items)
            {
                Item.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            pictureBox1.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "MedicalRecordID":
                    FilterColumn = "MedicalRecordID";
                    break;
                case "PrescriptionID":
                    FilterColumn = "PrescriptionID";
                    break;
                case "AppointmentID":
                    FilterColumn = "AppointmentID";
                    break;
                case "DoctorID":
                    FilterColumn = "DoctorID";
                    break;
                case "PatientID":
                    FilterColumn = "PatientID";
                    break;
                case "PaymentID":
                    FilterColumn = "PaymentID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "UserID":
                    FilterColumn = "UserID";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilterBy.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvShowList.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "Name" || FilterColumn == "UserName")
                _dtList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvShowList.Rows.Count.ToString();

        }

        private void frmList_Load(object sender, EventArgs e)
        {
            contextMenuStrip1.Visible = false;
            switch (_ListName)
            {
                case "MedicalRecord":
                    _ListType = enListType.MedicalRecord;
                    break;
                case "Prescriptions":
                    _ListType = enListType.Prescriptions;
                    break;
                case "Payments":
                    _ListType = enListType.Payments;
                    break;
                case "Appointments":
                    _ListType = enListType.Appointment;
                    break;
                case "Users":
                    _ListType = enListType.Users;
                    break;
                case "Patients":
                    _ListType = enListType.Patients;
                    break;
                case "Doctors":
                    _ListType = enListType.Doctors;
                    break;
            }

            _SetOperationType();
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int ID = (int)dgvShowList.CurrentRow.Cells[0].Value;
            switch (_ListType)
            {
                case enListType.Appointment:
                    frmAddEditAppointment frm = new frmAddEditAppointment(ID);
                    frm.ShowDialog();
                    break;
                case enListType.Patients:
                    frmAddEditPatient frmAddEditPatient = new frmAddEditPatient(ID);
                    frmAddEditPatient.ShowDialog();
                    break;
                case enListType.Doctors:
                    frmAddDoctor frmAddDoctor = new frmAddDoctor(ID);
                    frmAddDoctor.ShowDialog();
                    break;
                case enListType.Payments:
                    frmAddEditPayment frmAddEditPayment = new frmAddEditPayment(ID);
                    frmAddEditPayment.ShowDialog();
                    break;
                case enListType.Users:
                    frmAddEditUser frmAddEditUser = new frmAddEditUser(ID);
                    frmAddEditUser.ShowDialog();
                    break;
            }
            frmList_Load(null, null);
        }

        private void DeletedMessage(bool Result)
        {
            if (Result)
            {
                MessageBox.Show(" Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmList_Load(null, null);
            }

            else
                MessageBox.Show(" Deleted Failed due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int ID = (int)dgvShowList.CurrentRow.Cells[0].Value;
            switch (_ListType)
            {
                case enListType.Appointment:
                    DeletedMessage(clsAppointment.Delete(ID));
                    break;
                case enListType.Patients:
                    DeletedMessage(clsPatient.Delete(ID));
                    break;
                case enListType.Doctors:
                    DeletedMessage(clsDoctors.Delete(ID));
                    break;
                case enListType.Payments:
                    DeletedMessage(clsPayment.Delete(ID));
                    break;
                case enListType.Users:
                    DeletedMessage(clsUsers.DeleteUser(ID));
                    break;
            }

        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            switch (_ListType)
            {
                case enListType.MedicalRecord:
                    frmAddEditMedicalRecord frmAddEditMedicalRecord = new frmAddEditMedicalRecord();
                    frmAddEditMedicalRecord.ShowDialog();
                    break;
                case enListType.Appointment:
                    frmAddEditAppointment frm = new frmAddEditAppointment();
                    frm.ShowDialog();
                    break;
                case enListType.Patients:
                    frmAddEditPatient frmAddEditPatient = new frmAddEditPatient();
                    frmAddEditPatient.ShowDialog();
                    break;
                case enListType.Doctors:
                    frmAddDoctor frmAddDoctor = new frmAddDoctor();
                    frmAddDoctor.ShowDialog();
                    break;
                case enListType.Users:
                    frmAddEditUser frmAddEditUser = new frmAddEditUser();
                    frmAddEditUser.ShowDialog();
                    break;
            }
            // Refresh
            frmList_Load(null, null);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilterBy.Text.Trim() == "PrescriptionID" || cbFilterBy.Text.Trim() == "AppointmentID"
                || cbFilterBy.Text.Trim() == "MedicalRecordID"||
               cbFilterBy.Text.Trim() == "DoctorID" || cbFilterBy.Text.Trim() == "PatientID" ||
               cbFilterBy.Text.Trim() == "PaymentID" || cbFilterBy.Text.Trim() == "UserID"  )
                    // make sure that the user can only enter the numbers
                e.Handled =! char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
