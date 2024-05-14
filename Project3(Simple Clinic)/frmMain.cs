using Project3_Simple_Clinic_.Global_Classes;
using Project3_Simple_Clinic_.Home;
using Project3_Simple_Clinic_.Login;
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
    public partial class frmMain : Form
    {
        private frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }
        private void _FillContainer(object obj)
        {
            lblBestChoice.Visible = false;
            lblStayHealthy.Visible = false;
            picImage.Visible = false;
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            Form frm = obj as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(frm);
            this.splitContainer1.Panel2.Tag = frm;
            frm.Show();
        }

        private void PermissionMessage(string OperationName)
        {
            if (!clsValidation.HasPermissionToDoThisOperation(OperationName))
            {
                return;
            }
            _FillContainer(new frmList(OperationName));
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            PermissionMessage("Doctors");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _FillContainer(new frmHome());
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PermissionMessage("Patients");
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            PermissionMessage("Appointments");
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PermissionMessage("Payments");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            PermissionMessage("Users");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }
    }
}
