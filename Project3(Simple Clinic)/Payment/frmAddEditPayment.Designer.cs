namespace Project3_Simple_Clinic_
{
    partial class frmAddEditPayment
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
            this.txtNotes = new Guna.UI.WinForms.GunaTextBox();
            this.txtAmountPaid = new Guna.UI.WinForms.GunaTextBox();
            this.lblPaymentID = new Guna.UI.WinForms.GunaLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.btnSave.Location = new System.Drawing.Point(151, 446);
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
            this.txtNotes.Location = new System.Drawing.Point(224, 336);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.Radius = 10;
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(186, 72);
            this.txtNotes.TabIndex = 177;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.BackColor = System.Drawing.Color.Transparent;
            this.txtAmountPaid.BaseColor = System.Drawing.Color.White;
            this.txtAmountPaid.BorderColor = System.Drawing.Color.Silver;
            this.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountPaid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAmountPaid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAmountPaid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmountPaid.Location = new System.Drawing.Point(224, 274);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.PasswordChar = '\0';
            this.txtAmountPaid.Radius = 10;
            this.txtAmountPaid.SelectedText = "";
            this.txtAmountPaid.Size = new System.Drawing.Size(186, 34);
            this.txtAmountPaid.TabIndex = 176;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaymentID.Location = new System.Drawing.Point(269, 85);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(51, 28);
            this.lblPaymentID.TabIndex = 174;
            this.lblPaymentID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label7.Location = new System.Drawing.Point(16, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 30);
            this.label7.TabIndex = 173;
            this.label7.Text = "Amount Paid :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(3, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 30);
            this.label5.TabIndex = 172;
            this.label5.Text = "payment Method :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(3, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 30);
            this.label2.TabIndex = 171;
            this.label2.Text = "Payment Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 170;
            this.label1.Text = "Payment ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(0, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 54);
            this.lblTitle.TabIndex = 169;
            this.lblTitle.Text = "Add New Payment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(94, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 180;
            this.label3.Text = "Notes :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpPaymentDate.BaseColor = System.Drawing.Color.White;
            this.dtpPaymentDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpPaymentDate.CustomFormat = null;
            this.dtpPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPaymentDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpPaymentDate.ForeColor = System.Drawing.Color.Black;
            this.dtpPaymentDate.Location = new System.Drawing.Point(224, 144);
            this.dtpPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpPaymentDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpPaymentDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpPaymentDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpPaymentDate.Radius = 10;
            this.dtpPaymentDate.Size = new System.Drawing.Size(186, 34);
            this.dtpPaymentDate.TabIndex = 182;
            this.dtpPaymentDate.Text = "28 April 2024";
            this.dtpPaymentDate.Value = new System.DateTime(2024, 4, 28, 20, 3, 8, 394);
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "None",
            "Credit Card",
            "Cash",
            "Bank Transfer",
            "Debit Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(224, 215);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(186, 24);
            this.cbPaymentMethod.TabIndex = 183;
            this.cbPaymentMethod.Text = "None";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 508);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblPaymentID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPayment";
            this.Text = "frmAddEidtPayment";
            this.Load += new System.EventHandler(this.frmAddEditPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaTextBox txtNotes;
        private Guna.UI.WinForms.GunaTextBox txtAmountPaid;
        private Guna.UI.WinForms.GunaLabel lblPaymentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDateTimePicker dtpPaymentDate;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}