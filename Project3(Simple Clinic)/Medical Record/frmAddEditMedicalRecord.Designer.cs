namespace Project3_Simple_Clinic_.Medical_Record
{
    partial class frmAddEditMedicalRecord
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
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.txtNotes = new Guna.UI.WinForms.GunaTextBox();
            this.txtDiagnosis = new Guna.UI.WinForms.GunaTextBox();
            this.txtvisitDescription = new Guna.UI.WinForms.GunaTextBox();
            this.lblMedicalRecordID = new Guna.UI.WinForms.GunaLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnAddPrescription = new Guna.UI.WinForms.GunaButton();
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
            this.btnSave.Location = new System.Drawing.Point(313, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.LightPink;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(136, 42);
            this.btnSave.TabIndex = 167;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.Transparent;
            this.txtNotes.BaseColor = System.Drawing.Color.White;
            this.txtNotes.BorderColor = System.Drawing.Color.Silver;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNotes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNotes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(221, 270);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.Radius = 10;
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(228, 139);
            this.txtNotes.TabIndex = 166;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.txtDiagnosis.BaseColor = System.Drawing.Color.White;
            this.txtDiagnosis.BorderColor = System.Drawing.Color.Silver;
            this.txtDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosis.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiagnosis.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDiagnosis.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiagnosis.Location = new System.Drawing.Point(221, 217);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.PasswordChar = '\0';
            this.txtDiagnosis.Radius = 10;
            this.txtDiagnosis.SelectedText = "";
            this.txtDiagnosis.Size = new System.Drawing.Size(178, 34);
            this.txtDiagnosis.TabIndex = 164;
            // 
            // txtvisitDescription
            // 
            this.txtvisitDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtvisitDescription.BaseColor = System.Drawing.Color.White;
            this.txtvisitDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtvisitDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvisitDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtvisitDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtvisitDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtvisitDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtvisitDescription.Location = new System.Drawing.Point(227, 159);
            this.txtvisitDescription.Name = "txtvisitDescription";
            this.txtvisitDescription.PasswordChar = '\0';
            this.txtvisitDescription.Radius = 10;
            this.txtvisitDescription.SelectedText = "";
            this.txtvisitDescription.Size = new System.Drawing.Size(172, 34);
            this.txtvisitDescription.TabIndex = 163;
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMedicalRecordID.Location = new System.Drawing.Point(273, 96);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(51, 28);
            this.lblMedicalRecordID.TabIndex = 162;
            this.lblMedicalRecordID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label7.Location = new System.Drawing.Point(94, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 156;
            this.label7.Text = "Notes :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(67, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 30);
            this.label5.TabIndex = 154;
            this.label5.Text = "Diagnosis :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(7, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 30);
            this.label2.TabIndex = 151;
            this.label2.Text = "visit Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 30);
            this.label1.TabIndex = 150;
            this.label1.Text = "Medical Record ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(467, 44);
            this.lblTitle.TabIndex = 149;
            this.lblTitle.Text = "Add New Medical Record";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.AnimationHoverSpeed = 0.07F;
            this.btnAddPrescription.AnimationSpeed = 0.03F;
            this.btnAddPrescription.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPrescription.BaseColor = System.Drawing.Color.BurlyWood;
            this.btnAddPrescription.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddPrescription.BorderSize = 3;
            this.btnAddPrescription.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPrescription.Enabled = false;
            this.btnAddPrescription.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddPrescription.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnAddPrescription.ForeColor = System.Drawing.Color.Black;
            this.btnAddPrescription.Image = global::Project3_Simple_Clinic_.Properties.Resources.medical_prescription;
            this.btnAddPrescription.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddPrescription.Location = new System.Drawing.Point(4, 450);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnAddPrescription.OnHoverBorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddPrescription.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddPrescription.OnHoverImage = null;
            this.btnAddPrescription.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddPrescription.Radius = 10;
            this.btnAddPrescription.Size = new System.Drawing.Size(245, 63);
            this.btnAddPrescription.TabIndex = 168;
            this.btnAddPrescription.Text = "Add Prescription";
            this.btnAddPrescription.Click += new System.EventHandler(this.btnAddPrescription_Click);
            // 
            // frmAddEditMedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 525);
            this.Controls.Add(this.btnAddPrescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.txtvisitDescription);
            this.Controls.Add(this.lblMedicalRecordID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditMedicalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditMedicalRecord";
            this.Load += new System.EventHandler(this.frmAddEditMedicalRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAddPrescription;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaTextBox txtNotes;
        private Guna.UI.WinForms.GunaTextBox txtDiagnosis;
        private Guna.UI.WinForms.GunaTextBox txtvisitDescription;
        private Guna.UI.WinForms.GunaLabel lblMedicalRecordID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
    }
}