using Clinic_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Business
{
    public  class clsPayment
    {
        // Declare a delegate

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PaymentID { set; get; }
        public DateTime PaymentData { set; get; }
        public string PaymentMethod {  set; get; }
        public decimal AmountPaid { set; get; }
        public string Notes { set; get; }

       
        public clsPayment()
        {
            this.PaymentID = -1;
            this.PaymentData = DateTime.Now;
            this.PaymentMethod = "";
            this.Notes = "";
            this.AmountPaid = -1;
            Mode = enMode.AddNew;
        }

        public clsPayment(int paymentID , DateTime PaymentData , string PaymentMethod , decimal AmountPaid ,
          string Notes)
        {
            this.PaymentID = paymentID;
            this.PaymentData =PaymentData;
            this.PaymentMethod = PaymentMethod;
            this.AmountPaid=AmountPaid;
            this.Notes = Notes;
            Mode = enMode.Update;
        }

        public static clsPayment Find(int paymentID)
        {
            DateTime PaymentData = DateTime.Now;
            string PaymentMethod = "";
            decimal AmountPaid = 0;
            string Notes = "";
            if (clsPaymentData.GetPaymentInfoByID(paymentID, ref PaymentData, ref PaymentMethod, ref AmountPaid, ref Notes))
                return new clsPayment(paymentID, PaymentData, PaymentMethod, AmountPaid, Notes);
            else
                return null;

        }
        private bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentData.AddNewPayment( PaymentData, PaymentMethod,
                AmountPaid, Notes);
            return (this.PaymentID != -1);
        }

        private bool _Update()
        {
            return clsPaymentData.UpdatePayment(PaymentID, PaymentData, PaymentMethod,
                AmountPaid, Notes);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {

                        Mode = enMode.AddNew;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }

        public static bool Delete(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }


    }
}
