namespace Project3_Simple_Clinic_.Doctors
{
    partial class frmAddDoctor
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
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtSpecialization = new Guna.UI.WinForms.GunaTextBox();
            this.pbGendor = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDoctorD = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCardWithFilter1 = new Project3_Simple_Clinic_.Person.ctrlPersonCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(-3, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(891, 44);
            this.lblTitle.TabIndex = 127;
            this.lblTitle.Text = "Add New Doctor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-3, 546);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.gunaLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtSpecialization);
            this.splitContainer1.Panel2.Controls.Add(this.pbGendor);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(891, 97);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 129;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(216, 30);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Doctor Information :";
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.BackColor = System.Drawing.Color.Transparent;
            this.txtSpecialization.BaseColor = System.Drawing.Color.White;
            this.txtSpecialization.BorderColor = System.Drawing.Color.Silver;
            this.txtSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecialization.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSpecialization.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSpecialization.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSpecialization.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpecialization.Location = new System.Drawing.Point(244, 13);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.PasswordChar = '\0';
            this.txtSpecialization.Radius = 10;
            this.txtSpecialization.SelectedText = "";
            this.txtSpecialization.Size = new System.Drawing.Size(202, 34);
            this.txtSpecialization.TabIndex = 229;
            this.txtSpecialization.Validating += new System.ComponentModel.CancelEventHandler(this.txtSpecialization_Validating);
            // 
            // pbGendor
            // 
            this.pbGendor.Image = global::Project3_Simple_Clinic_.Properties.Resources.doctor__2_;
            this.pbGendor.Location = new System.Drawing.Point(190, 13);
            this.pbGendor.Name = "pbGendor";
            this.pbGendor.Size = new System.Drawing.Size(39, 34);
            this.pbGendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGendor.TabIndex = 228;
            this.pbGendor.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 30);
            this.label6.TabIndex = 227;
            this.label6.Text = "Specialization :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel2.Location = new System.Drawing.Point(252, 87);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel2.TabIndex = 207;
            this.gunaLabel2.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(13, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 30);
            this.label8.TabIndex = 204;
            this.label8.Text = "Doctor ID :";
            // 
            // lblDoctorD
            // 
            this.lblDoctorD.AutoSize = true;
            this.lblDoctorD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDoctorD.Location = new System.Drawing.Point(195, 87);
            this.lblDoctorD.Name = "lblDoctorD";
            this.lblDoctorD.Size = new System.Drawing.Size(51, 28);
            this.lblDoctorD.TabIndex = 205;
            this.lblDoctorD.Text = "[???]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Project3_Simple_Clinic_.Properties.Resources.id;
            this.pictureBox8.Location = new System.Drawing.Point(158, 87);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 206;
            this.pictureBox8.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Pink;
            this.btnClose.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnClose.BorderSize = 3;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(426, 660);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.RosyBrown;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(136, 42);
            this.btnClose.TabIndex = 230;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(604, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.LightPink;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(136, 42);
            this.btnSave.TabIndex = 229;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(-3, 118);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(877, 422);
            this.ctrlPersonCardWithFilter1.TabIndex = 128;
            // 
            // frmAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(886, 714);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDoctorD);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddDoctor";
            this.Activated += new System.EventHandler(this.frmAddDoctor_Activated);
            this.Load += new System.EventHandler(this.frmAddDoctor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Person.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtSpecialization;
        private System.Windows.Forms.PictureBox pbGendor;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLabel lblDoctorD;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}