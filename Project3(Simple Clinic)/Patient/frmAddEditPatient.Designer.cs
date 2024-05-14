namespace Project3_Simple_Clinic_.Patient
{
    partial class frmAddEditPatient
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
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPatientID = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.ctrlPersonCardWithFilter1 = new Project3_Simple_Clinic_.Person.ctrlPersonCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(561, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.RosyBrown;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(136, 42);
            this.btnClose.TabIndex = 148;
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
            this.btnSave.Location = new System.Drawing.Point(703, 506);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.LightPink;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(136, 42);
            this.btnSave.TabIndex = 147;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(-6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(885, 53);
            this.lblTitle.TabIndex = 126;
            this.lblTitle.Text = "Add New Patient";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel2.Location = new System.Drawing.Point(257, 76);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel2.TabIndex = 213;
            this.gunaLabel2.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(18, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 30);
            this.label8.TabIndex = 210;
            this.label8.Text = "Patient ID :";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPatientID.Location = new System.Drawing.Point(200, 76);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(51, 28);
            this.lblPatientID.TabIndex = 211;
            this.lblPatientID.Text = "[???]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Project3_Simple_Clinic_.Properties.Resources.id;
            this.pictureBox8.Location = new System.Drawing.Point(163, 76);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 212;
            this.pictureBox8.TabStop = false;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(2, 107);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(877, 393);
            this.ctrlPersonCardWithFilter1.TabIndex = 208;
            // 
            // frmAddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(872, 562);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPatient";
            this.Activated += new System.EventHandler(this.frmAddEditPatient_Activated);
            this.Load += new System.EventHandler(this.frmAddEditPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLabel lblPatientID;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Person.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}