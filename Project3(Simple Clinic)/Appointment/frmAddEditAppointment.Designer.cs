namespace Project3_Simple_Clinic_.Appointment
{
    partial class frmAddEditAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditAppointment));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.NumDoctorID = new Guna.UI.WinForms.GunaNumeric();
            this.NumPatiantID = new Guna.UI.WinForms.GunaNumeric();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnPay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddNewRecord = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.lblAppointmetD = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblMedicalRecordID = new Guna.UI.WinForms.GunaLabel();
            this.lblPayID = new Guna.UI.WinForms.GunaLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.patientCard1 = new Project3_Simple_Clinic_.Patient.ctrlPatientCard();
            this.ctrlDoctorCard1 = new Project3_Simple_Clinic_.Doctors.ctrlDoctorCard();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(0, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1206, 59);
            this.lblTitle.TabIndex = 150;
            this.lblTitle.Text = "Add New Appointment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NumDoctorID
            // 
            this.NumDoctorID.BackColor = System.Drawing.Color.Transparent;
            this.NumDoctorID.BaseColor = System.Drawing.Color.White;
            this.NumDoctorID.BorderColor = System.Drawing.Color.RosyBrown;
            this.NumDoctorID.BorderSize = 3;
            this.NumDoctorID.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumDoctorID.ButtonForeColor = System.Drawing.Color.White;
            this.NumDoctorID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumDoctorID.ForeColor = System.Drawing.Color.Black;
            this.NumDoctorID.Location = new System.Drawing.Point(201, 92);
            this.NumDoctorID.Maximum = ((long)(9999999));
            this.NumDoctorID.Minimum = ((long)(18));
            this.NumDoctorID.Name = "NumDoctorID";
            this.NumDoctorID.Radius = 10;
            this.NumDoctorID.Size = new System.Drawing.Size(99, 30);
            this.NumDoctorID.TabIndex = 151;
            this.NumDoctorID.Value = ((long)(18));
            this.NumDoctorID.ValueChanged += new System.EventHandler(this.NumDoctorID_ValueChanged);
            // 
            // NumPatiantID
            // 
            this.NumPatiantID.BackColor = System.Drawing.Color.Transparent;
            this.NumPatiantID.BaseColor = System.Drawing.Color.White;
            this.NumPatiantID.BorderColor = System.Drawing.Color.RosyBrown;
            this.NumPatiantID.BorderSize = 3;
            this.NumPatiantID.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumPatiantID.ButtonForeColor = System.Drawing.Color.White;
            this.NumPatiantID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumPatiantID.ForeColor = System.Drawing.Color.Black;
            this.NumPatiantID.Location = new System.Drawing.Point(634, 92);
            this.NumPatiantID.Maximum = ((long)(9999999));
            this.NumPatiantID.Minimum = ((long)(3));
            this.NumPatiantID.Name = "NumPatiantID";
            this.NumPatiantID.Radius = 10;
            this.NumPatiantID.Size = new System.Drawing.Size(100, 30);
            this.NumPatiantID.TabIndex = 152;
            this.NumPatiantID.Value = ((long)(3));
            this.NumPatiantID.ValueChanged += new System.EventHandler(this.NumPatiantID_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 27);
            this.label1.TabIndex = 153;
            this.label1.Text = "Select Doctor ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 154;
            this.label2.Text = "Select Patient ID :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.gunaLabel1.Location = new System.Drawing.Point(907, 213);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 27);
            this.gunaLabel1.TabIndex = 155;
            this.gunaLabel1.Text = "Status :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.gunaLabel2.Location = new System.Drawing.Point(828, 270);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(160, 25);
            this.gunaLabel2.TabIndex = 156;
            this.gunaLabel2.Text = "Date And Time :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.gunaLabel3.Location = new System.Drawing.Point(805, 328);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(192, 25);
            this.gunaLabel3.TabIndex = 158;
            this.gunaLabel3.Text = "Medical Record ID :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(888, 395);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(84, 27);
            this.gunaLabel4.TabIndex = 160;
            this.gunaLabel4.Text = "Pay ID :";
            // 
            // btnPay
            // 
            this.btnPay.AnimationHoverSpeed = 0.07F;
            this.btnPay.AnimationSpeed = 0.03F;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BaseColor = System.Drawing.Color.RosyBrown;
            this.btnPay.BorderColor = System.Drawing.Color.DimGray;
            this.btnPay.BorderSize = 2;
            this.btnPay.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPay.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPay.CheckedForeColor = System.Drawing.Color.White;
            this.btnPay.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPay.CheckedImage")));
            this.btnPay.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::Project3_Simple_Clinic_.Properties.Resources.money__1_;
            this.btnPay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPay.Location = new System.Drawing.Point(1053, 393);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPay.OnHoverImage = null;
            this.btnPay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnPay.Radius = 10;
            this.btnPay.Size = new System.Drawing.Size(119, 42);
            this.btnPay.TabIndex = 163;
            this.btnPay.Text = "   Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.AnimationHoverSpeed = 0.07F;
            this.btnAddNewRecord.AnimationSpeed = 0.03F;
            this.btnAddNewRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewRecord.BaseColor = System.Drawing.Color.RosyBrown;
            this.btnAddNewRecord.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddNewRecord.BorderSize = 2;
            this.btnAddNewRecord.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddNewRecord.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddNewRecord.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddNewRecord.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewRecord.CheckedImage")));
            this.btnAddNewRecord.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddNewRecord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewRecord.Enabled = false;
            this.btnAddNewRecord.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRecord.Image = global::Project3_Simple_Clinic_.Properties.Resources.plus;
            this.btnAddNewRecord.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddNewRecord.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddNewRecord.Location = new System.Drawing.Point(1053, 328);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNewRecord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewRecord.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewRecord.OnHoverImage = null;
            this.btnAddNewRecord.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNewRecord.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewRecord.Radius = 10;
            this.btnAddNewRecord.Size = new System.Drawing.Size(133, 42);
            this.btnAddNewRecord.TabIndex = 162;
            this.btnAddNewRecord.Text = "Add New ";
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.LightPink;
            this.btnSave.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnSave.BorderSize = 3;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(944, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.LightPink;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(136, 42);
            this.btnSave.TabIndex = 173;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAppointmetD
            // 
            this.lblAppointmetD.AutoSize = true;
            this.lblAppointmetD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAppointmetD.Location = new System.Drawing.Point(1029, 151);
            this.lblAppointmetD.Name = "lblAppointmetD";
            this.lblAppointmetD.Size = new System.Drawing.Size(51, 28);
            this.lblAppointmetD.TabIndex = 176;
            this.lblAppointmetD.Text = "[???]";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(812, 153);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(176, 27);
            this.gunaLabel5.TabIndex = 177;
            this.gunaLabel5.Text = "Appointment ID :";
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMedicalRecordID.Location = new System.Drawing.Point(996, 328);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(0, 28);
            this.lblMedicalRecordID.TabIndex = 178;
            // 
            // lblPayID
            // 
            this.lblPayID.AutoSize = true;
            this.lblPayID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPayID.Location = new System.Drawing.Point(994, 396);
            this.lblPayID.Name = "lblPayID";
            this.lblPayID.Size = new System.Drawing.Size(0, 28);
            this.lblPayID.TabIndex = 179;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DateTime
            // 
            this.DateTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.DateTime.CalendarTitleForeColor = System.Drawing.Color.RosyBrown;
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(1014, 270);
            this.DateTime.MinDate = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            this.DateTime.Name = "DateTime";
            this.DateTime.ShowUpDown = true;
            this.DateTime.Size = new System.Drawing.Size(146, 24);
            this.DateTime.TabIndex = 180;
            this.DateTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DateTime_MouseDown_1);
            // 
            // patientCard1
            // 
            this.patientCard1.Location = new System.Drawing.Point(409, 128);
            this.patientCard1.Name = "patientCard1";
            this.patientCard1.Size = new System.Drawing.Size(359, 477);
            this.patientCard1.TabIndex = 1;
            // 
            // ctrlDoctorCard1
            // 
            this.ctrlDoctorCard1.Location = new System.Drawing.Point(9, 128);
            this.ctrlDoctorCard1.Name = "ctrlDoctorCard1";
            this.ctrlDoctorCard1.Size = new System.Drawing.Size(337, 483);
            this.ctrlDoctorCard1.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pending ",
            "Confirmed ",
            "Completed ",
            "Canceled ",
            "Rescheduled ",
            "NoShow"});
            this.cbStatus.Location = new System.Drawing.Point(1014, 218);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(146, 24);
            this.cbStatus.TabIndex = 181;
            this.cbStatus.Text = "None";
            // 
            // frmAddEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 617);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.lblPayID);
            this.Controls.Add(this.lblMedicalRecordID);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.lblAppointmetD);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAddNewRecord);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumPatiantID);
            this.Controls.Add(this.NumDoctorID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.patientCard1);
            this.Controls.Add(this.ctrlDoctorCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditAppointment";
            this.Text = "frmAddEditAppointment";
            this.Load += new System.EventHandler(this.frmAddEditAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Doctors.ctrlDoctorCard ctrlDoctorCard1;
        private Patient.ctrlPatientCard patientCard1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaNumeric NumDoctorID;
        private Guna.UI.WinForms.GunaNumeric NumPatiantID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddNewRecord;
        private Guna.UI.WinForms.GunaAdvenceButton btnPay;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaLabel lblAppointmetD;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lblMedicalRecordID;
        private Guna.UI.WinForms.GunaLabel lblPayID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}