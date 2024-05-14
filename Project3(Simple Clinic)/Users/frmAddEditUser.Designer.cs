namespace Project3_Simple_Clinic_.Users
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.txtUserName = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tcUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.ctrlPersonCardWithFilter1 = new Project3_Simple_Clinic_.Person.ctrlPersonCardWithFilter();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.ctrlUserPermissions1 = new Project3_Simple_Clinic_.Users.ctrlUserPermissions();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tpUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(-4, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(885, 44);
            this.lblTitle.TabIndex = 149;
            this.lblTitle.Text = "Add New User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BaseColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.Location = new System.Drawing.Point(200, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.Radius = 10;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(172, 34);
            this.txtUserName.TabIndex = 173;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(26, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 30);
            this.label8.TabIndex = 172;
            this.label8.Text = "User Name :";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(200, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(172, 34);
            this.txtPassword.TabIndex = 175;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label9.Location = new System.Drawing.Point(26, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 30);
            this.label9.TabIndex = 174;
            this.label9.Text = "Password :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label10.Location = new System.Drawing.Point(17, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 30);
            this.label10.TabIndex = 177;
            this.label10.Text = "Permissions :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tcUser
            // 
            this.tcUser.Controls.Add(this.tabPage1);
            this.tcUser.Controls.Add(this.tpUserInfo);
            this.tcUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tcUser.Location = new System.Drawing.Point(6, 74);
            this.tcUser.Name = "tcUser";
            this.tcUser.SelectedIndex = 0;
            this.tcUser.Size = new System.Drawing.Size(895, 539);
            this.tcUser.TabIndex = 239;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.gunaLabel2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblUserID);
            this.tabPage1.Controls.Add(this.pictureBox8);
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BaseColor = System.Drawing.Color.RosyBrown;
            this.btnNext.BorderColor = System.Drawing.Color.LightPink;
            this.btnNext.BorderSize = 3;
            this.btnNext.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNext.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNext.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnNext.CheckedImage")));
            this.btnNext.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.Enabled = false;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::Project3_Simple_Clinic_.Properties.Resources.exit;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext.Location = new System.Drawing.Point(700, 454);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Radius = 10;
            this.btnNext.Size = new System.Drawing.Size(154, 42);
            this.btnNext.TabIndex = 245;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel2.Location = new System.Drawing.Point(218, 24);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel2.TabIndex = 244;
            this.gunaLabel2.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 241;
            this.label1.Text = "User ID :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUserID.Location = new System.Drawing.Point(161, 20);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 28);
            this.lblUserID.TabIndex = 242;
            this.lblUserID.Text = "[???]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Project3_Simple_Clinic_.Properties.Resources.id;
            this.pictureBox8.Location = new System.Drawing.Point(115, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 243;
            this.pictureBox8.TabStop = false;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(0, 68);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(865, 379);
            this.ctrlPersonCardWithFilter1.TabIndex = 239;
            this.ctrlPersonCardWithFilter1.OnPersonSelectedEvent += new System.EventHandler<Project3_Simple_Clinic_.Person.ctrlPersonCardWithFilter.SelectPersonEventArgs>(this.ctrlPersonCardWithFilter1_OnPersonSelectedEvent);
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.BackColor = System.Drawing.Color.Linen;
            this.tpUserInfo.Controls.Add(this.ctrlUserPermissions1);
            this.tpUserInfo.Controls.Add(this.label8);
            this.tpUserInfo.Controls.Add(this.txtUserName);
            this.tpUserInfo.Controls.Add(this.label9);
            this.tpUserInfo.Controls.Add(this.label10);
            this.tpUserInfo.Controls.Add(this.txtPassword);
            this.tpUserInfo.Location = new System.Drawing.Point(4, 33);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(887, 502);
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "User Info";
            // 
            // ctrlUserPermissions1
            // 
            this.ctrlUserPermissions1.BackColor = System.Drawing.Color.RosyBrown;
            this.ctrlUserPermissions1.Location = new System.Drawing.Point(200, 174);
            this.ctrlUserPermissions1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlUserPermissions1.Name = "ctrlUserPermissions1";
            this.ctrlUserPermissions1.Size = new System.Drawing.Size(172, 174);
            this.ctrlUserPermissions1.TabIndex = 178;
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
            this.btnClose.Location = new System.Drawing.Point(37, 633);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.RosyBrown;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(136, 42);
            this.btnClose.TabIndex = 246;
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
            this.btnSave.Enabled = false;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(227, 633);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.LightPink;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(136, 42);
            this.btnSave.TabIndex = 245;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(905, 687);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tpUserInfo.ResumeLayout(false);
            this.tpUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaTextBox txtUserName;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.TabControl tcUser;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel lblUserID;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Person.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpUserInfo;
        private Guna.UI.WinForms.GunaButton btnSave;
        private ctrlUserPermissions ctrlUserPermissions1;
        private Guna.UI.WinForms.GunaAdvenceButton btnNext;
    }
}