namespace Project3_Simple_Clinic_.Prescription
{
    partial class frmAddEditPrescriptions
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
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.txtDosage = new Guna.UI.WinForms.GunaTextBox();
            this.lblPrescriptionID = new Guna.UI.WinForms.GunaLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicationName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrequency = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSpecialInstructions = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnShowAllMedicalPrescriptions = new Guna.UI.WinForms.GunaButton();
            this.btnShowAllMedicalRecords = new Guna.UI.WinForms.GunaButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMedicalRecordID = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(532, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.LightPink;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(136, 42);
            this.btnSave.TabIndex = 178;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDosage
            // 
            this.txtDosage.BackColor = System.Drawing.Color.Transparent;
            this.txtDosage.BaseColor = System.Drawing.Color.White;
            this.txtDosage.BorderColor = System.Drawing.Color.Silver;
            this.txtDosage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDosage.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDosage.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDosage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDosage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDosage.Location = new System.Drawing.Point(240, 220);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.Radius = 10;
            this.txtDosage.SelectedText = "";
            this.txtDosage.Size = new System.Drawing.Size(178, 34);
            this.txtDosage.TabIndex = 176;
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPrescriptionID.Location = new System.Drawing.Point(273, 95);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(51, 28);
            this.lblPrescriptionID.TabIndex = 174;
            this.lblPrescriptionID.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(95, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 172;
            this.label5.Text = "Dosage :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 170;
            this.label1.Text = "Prescription ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(0, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(870, 44);
            this.lblTitle.TabIndex = 169;
            this.lblTitle.Text = "Add New Prescription";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(435, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 30);
            this.label3.TabIndex = 180;
            this.label3.Text = "Medical Record ID :";
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.BackColor = System.Drawing.Color.Transparent;
            this.txtMedicationName.BaseColor = System.Drawing.Color.White;
            this.txtMedicationName.BorderColor = System.Drawing.Color.Silver;
            this.txtMedicationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicationName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMedicationName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMedicationName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMedicationName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMedicationName.Location = new System.Drawing.Point(240, 162);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.PasswordChar = '\0';
            this.txtMedicationName.Radius = 10;
            this.txtMedicationName.SelectedText = "";
            this.txtMedicationName.Size = new System.Drawing.Size(172, 34);
            this.txtMedicationName.TabIndex = 183;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 30);
            this.label4.TabIndex = 182;
            this.label4.Text = "Medication Name :";
            // 
            // txtFrequency
            // 
            this.txtFrequency.BackColor = System.Drawing.Color.Transparent;
            this.txtFrequency.BaseColor = System.Drawing.Color.White;
            this.txtFrequency.BorderColor = System.Drawing.Color.Silver;
            this.txtFrequency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrequency.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFrequency.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFrequency.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFrequency.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFrequency.Location = new System.Drawing.Point(240, 289);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.PasswordChar = '\0';
            this.txtFrequency.Radius = 10;
            this.txtFrequency.SelectedText = "";
            this.txtFrequency.Size = new System.Drawing.Size(178, 34);
            this.txtFrequency.TabIndex = 185;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.Location = new System.Drawing.Point(63, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 184;
            this.label6.Text = "Frequency :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label7.Location = new System.Drawing.Point(525, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 186;
            this.label7.Text = "Start Date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(672, 172);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(161, 24);
            this.dtpStartDate.TabIndex = 187;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(672, 236);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(161, 24);
            this.dtpEndDate.TabIndex = 189;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(525, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 30);
            this.label8.TabIndex = 188;
            this.label8.Text = "End Date :";
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.BackColor = System.Drawing.Color.Transparent;
            this.txtSpecialInstructions.BaseColor = System.Drawing.Color.White;
            this.txtSpecialInstructions.BorderColor = System.Drawing.Color.Silver;
            this.txtSpecialInstructions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecialInstructions.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSpecialInstructions.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSpecialInstructions.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSpecialInstructions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpecialInstructions.Location = new System.Drawing.Point(672, 305);
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.PasswordChar = '\0';
            this.txtSpecialInstructions.Radius = 10;
            this.txtSpecialInstructions.SelectedText = "";
            this.txtSpecialInstructions.Size = new System.Drawing.Size(178, 96);
            this.txtSpecialInstructions.TabIndex = 191;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label9.Location = new System.Drawing.Point(418, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 30);
            this.label9.TabIndex = 190;
            this.label9.Text = "SpecialInstructions :";
            // 
            // btnShowAllMedicalPrescriptions
            // 
            this.btnShowAllMedicalPrescriptions.AnimationHoverSpeed = 0.07F;
            this.btnShowAllMedicalPrescriptions.AnimationSpeed = 0.03F;
            this.btnShowAllMedicalPrescriptions.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllMedicalPrescriptions.BaseColor = System.Drawing.Color.BurlyWood;
            this.btnShowAllMedicalPrescriptions.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShowAllMedicalPrescriptions.BorderSize = 3;
            this.btnShowAllMedicalPrescriptions.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowAllMedicalPrescriptions.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowAllMedicalPrescriptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllMedicalPrescriptions.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllMedicalPrescriptions.Image = global::Project3_Simple_Clinic_.Properties.Resources.medical_prescription;
            this.btnShowAllMedicalPrescriptions.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowAllMedicalPrescriptions.Location = new System.Drawing.Point(42, 431);
            this.btnShowAllMedicalPrescriptions.Name = "btnShowAllMedicalPrescriptions";
            this.btnShowAllMedicalPrescriptions.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnShowAllMedicalPrescriptions.OnHoverBorderColor = System.Drawing.Color.RosyBrown;
            this.btnShowAllMedicalPrescriptions.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowAllMedicalPrescriptions.OnHoverImage = null;
            this.btnShowAllMedicalPrescriptions.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowAllMedicalPrescriptions.Radius = 10;
            this.btnShowAllMedicalPrescriptions.Size = new System.Drawing.Size(282, 63);
            this.btnShowAllMedicalPrescriptions.TabIndex = 193;
            this.btnShowAllMedicalPrescriptions.Text = "Show All Medical Prescriptions";
            this.btnShowAllMedicalPrescriptions.Click += new System.EventHandler(this.btnShowAllMedicalPrescriptions_Click);
            // 
            // btnShowAllMedicalRecords
            // 
            this.btnShowAllMedicalRecords.AnimationHoverSpeed = 0.07F;
            this.btnShowAllMedicalRecords.AnimationSpeed = 0.03F;
            this.btnShowAllMedicalRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllMedicalRecords.BaseColor = System.Drawing.Color.BurlyWood;
            this.btnShowAllMedicalRecords.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShowAllMedicalRecords.BorderSize = 3;
            this.btnShowAllMedicalRecords.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowAllMedicalRecords.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowAllMedicalRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllMedicalRecords.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllMedicalRecords.Image = global::Project3_Simple_Clinic_.Properties.Resources.health_report;
            this.btnShowAllMedicalRecords.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowAllMedicalRecords.Location = new System.Drawing.Point(42, 352);
            this.btnShowAllMedicalRecords.Name = "btnShowAllMedicalRecords";
            this.btnShowAllMedicalRecords.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnShowAllMedicalRecords.OnHoverBorderColor = System.Drawing.Color.RosyBrown;
            this.btnShowAllMedicalRecords.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowAllMedicalRecords.OnHoverImage = null;
            this.btnShowAllMedicalRecords.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowAllMedicalRecords.Radius = 10;
            this.btnShowAllMedicalRecords.Size = new System.Drawing.Size(282, 63);
            this.btnShowAllMedicalRecords.TabIndex = 192;
            this.btnShowAllMedicalRecords.Text = "Show All Medical Records";
            this.btnShowAllMedicalRecords.Click += new System.EventHandler(this.btnShowAllMedicalRecords_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMedicalRecordID.Location = new System.Drawing.Point(692, 93);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(51, 28);
            this.lblMedicalRecordID.TabIndex = 194;
            this.lblMedicalRecordID.Text = "[???]";
            // 
            // frmAddEditPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 504);
            this.Controls.Add(this.lblMedicalRecordID);
            this.Controls.Add(this.btnShowAllMedicalPrescriptions);
            this.Controls.Add(this.btnShowAllMedicalRecords);
            this.Controls.Add(this.txtSpecialInstructions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.lblPrescriptionID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPrescriptions";
            this.Text = "frmAddEditPrescriptions";
            this.Load += new System.EventHandler(this.frmAddEditPrescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaTextBox txtDosage;
        private Guna.UI.WinForms.GunaLabel lblPrescriptionID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtMedicationName;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtSpecialInstructions;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btnShowAllMedicalRecords;
        private Guna.UI.WinForms.GunaButton btnShowAllMedicalPrescriptions;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaLabel lblMedicalRecordID;
    }
}