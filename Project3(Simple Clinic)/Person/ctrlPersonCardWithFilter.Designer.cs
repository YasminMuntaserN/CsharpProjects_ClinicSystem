namespace Project3_Simple_Clinic_.Person
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new Guna.UI.WinForms.GunaImageButton();
            this.btnFind = new Guna.UI.WinForms.GunaImageButton();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.cbFindBy = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ctrlPersonCard1 = new Project3_Simple_Clinic_.Person.ctrlPersonCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.gunaLabel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbFilter);
            this.splitContainer2.Size = new System.Drawing.Size(879, 94);
            this.splitContainer2.SplitterDistance = 36;
            this.splitContainer2.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 11);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(66, 25);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Filter :";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddNew);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.cbFindBy);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(4, -1);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(872, 52);
            this.gbFilter.TabIndex = 6;
            this.gbFilter.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNew.Image = global::Project3_Simple_Clinic_.Properties.Resources.add_user;
            this.btnAddNew.ImageSize = new System.Drawing.Size(26, 26);
            this.btnAddNew.Location = new System.Drawing.Point(569, 11);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.OnHoverImage = null;
            this.btnAddNew.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNew.Size = new System.Drawing.Size(68, 35);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click_1);
            // 
            // btnFind
            // 
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.Image = global::Project3_Simple_Clinic_.Properties.Resources.search_user;
            this.btnFind.ImageSize = new System.Drawing.Size(29, 29);
            this.btnFind.Location = new System.Drawing.Point(514, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnFind.Size = new System.Drawing.Size(69, 34);
            this.btnFind.TabIndex = 10;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BaseColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderColor = System.Drawing.Color.Silver;
            this.txtFilterValue.BorderSize = 3;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilterValue.FocusedBorderColor = System.Drawing.Color.RosyBrown;
            this.txtFilterValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterValue.Location = new System.Drawing.Point(297, 11);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 10;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(187, 34);
            this.txtFilterValue.TabIndex = 9;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFindBy
            // 
            this.cbFindBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFindBy.BaseColor = System.Drawing.Color.White;
            this.cbFindBy.BorderColor = System.Drawing.Color.Silver;
            this.cbFindBy.BorderSize = 3;
            this.cbFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFindBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFindBy.ForeColor = System.Drawing.Color.Black;
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Items.AddRange(new object[] {
            "Person ID",
            "Name"});
            this.cbFindBy.Location = new System.Drawing.Point(108, 11);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFindBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFindBy.Radius = 10;
            this.cbFindBy.Size = new System.Drawing.Size(165, 31);
            this.cbFindBy.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Find By :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 103);
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
            this.splitContainer1.Panel2.Controls.Add(this.ctrlPersonCard1);
            this.splitContainer1.Size = new System.Drawing.Size(878, 301);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(2, 7);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(232, 30);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Personal Information :";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(872, 242);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(886, 418);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI.WinForms.GunaImageButton btnAddNew;
        private Guna.UI.WinForms.GunaImageButton btnFind;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private Guna.UI.WinForms.GunaComboBox cbFindBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
