using Project3_Simple_Clinic_.Appointment;
using Project3_Simple_Clinic_.Doctors;
using Project3_Simple_Clinic_.Home;
using Project3_Simple_Clinic_.Login;
using Project3_Simple_Clinic_.Medical_Record;
using Project3_Simple_Clinic_.Patient;
using Project3_Simple_Clinic_.Person;
using Project3_Simple_Clinic_.Prescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Simple_Clinic_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frmList("MedicalRecord"));
            Application.Run(new frmLogin());

        }
    }
}
