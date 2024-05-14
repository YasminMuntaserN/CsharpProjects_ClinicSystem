namespace Project3_Simple_Clinic_.Users
{
    partial class ctrlUserPermissions
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
            this.clbPermision = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbPermision
            // 
            this.clbPermision.Font = new System.Drawing.Font("Tahoma", 12F);
            this.clbPermision.FormattingEnabled = true;
            this.clbPermision.Items.AddRange(new object[] {
            " All",
            "Doctors",
            "Patients",
            "Payments",
            "Appointments",
            "Users"});
            this.clbPermision.Location = new System.Drawing.Point(0, 0);
            this.clbPermision.Name = "clbPermision";
            this.clbPermision.Size = new System.Drawing.Size(165, 166);
            this.clbPermision.TabIndex = 157;
            // 
            // ctrlUserPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.clbPermision);
            this.Name = "ctrlUserPermissions";
            this.Size = new System.Drawing.Size(173, 173);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbPermision;
    }
}
