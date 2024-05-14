using Clinic_Business;
using Clinic_Bussiness;
using Project3_Simple_Clinic_.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_
{
    public partial class frmAddEditPayment : Form
    {
        public delegate void DataBackEventHandler(int PaymentID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsPayment _Payment;

        public int PaymentID;

        private void _ResetTitle()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Payment";
                this.Text = "Add New Payment";
                _Payment = new clsPayment();
            }
            else
            {
                this.Text = "Update Payment";
                lblTitle.Text = "Update Payment";
            }
        }

        public void LoadData()
        {
            _Payment = clsPayment.Find(PaymentID);
            if (_Payment == null)
            {
                MessageBox.Show("No Payment with ID = " + PaymentID, "  Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPaymentID.Text = _Payment.PaymentID.ToString();
            txtAmountPaid.Text = _Payment.AmountPaid.ToString();
            dtpPaymentDate.Value =_Payment.PaymentData.Date;

            cbPaymentMethod.SelectedIndex= cbPaymentMethod.FindString(_Payment.PaymentMethod);
            txtNotes.Text = _Payment.Notes.ToString();
        }

        public frmAddEditPayment()
        {
             InitializeComponent();
        }
        public frmAddEditPayment(int _PaymentID)
        {
            InitializeComponent();
            PaymentID = _PaymentID;
           _Mode = enMode.Update;
        }

        private bool _CheckForCorrectData()
        {
            if (cbPaymentMethod.Text == "None")
            {
                MessageBox.Show("Select the Payment Method first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if(txtAmountPaid.Text.Trim() == "")
            {
                errorProvider1.SetError(txtAmountPaid, "You must fill this field");
                return false;
            }
            if (decimal.TryParse(txtAmountPaid.Text.Trim(), out decimal Result))
            {
                _Payment.AmountPaid = Result;
            }
            else
            {
                MessageBox.Show("The input string is not in a valid format .",
                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
        private void _FillData()
        { 
            _Payment.PaymentData = dtpPaymentDate.Value;
            _Payment.Notes = txtNotes.Text.Trim();

            _Payment.PaymentMethod = cbPaymentMethod.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckForCorrectData()) return;

            _FillData();
            if (_Payment.Save())
            {
                PaymentID = _Payment.PaymentID;
                lblPaymentID.Text = _Payment.PaymentID.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "Update Medical Record";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //  send PaymentID to frmAddEditAppointment By Event
                DataBack?.Invoke(_Payment.PaymentID);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddEditPayment_Load(object sender, EventArgs e)
        {
            _ResetTitle();
            if (_Mode == enMode.Update)
                LoadData();
        }
    }
}
