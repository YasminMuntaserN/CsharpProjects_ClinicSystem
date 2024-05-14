namespace Project3_Simple_Clinic_.Home
{
    partial class frmList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new Guna.UI.WinForms.GunaImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter By :";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None"});
            this.cbFilterBy.Location = new System.Drawing.Point(172, 257);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(155, 24);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BaseColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderColor = System.Drawing.Color.Silver;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilterValue.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilterValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(346, 245);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 15;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(325, 42);
            this.txtFilterValue.TabIndex = 6;
            this.txtFilterValue.Text = "Enter to Search :";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(0, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(966, 65);
            this.lblTitle.TabIndex = 170;
            this.lblTitle.Text = "List Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvShowList
            // 
            this.dgvShowList.AllowUserToAddRows = false;
            this.dgvShowList.AllowUserToDeleteRows = false;
            this.dgvShowList.AllowUserToOrderColumns = true;
            this.dgvShowList.AllowUserToResizeRows = false;
            this.dgvShowList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvShowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowList.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvShowList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowList.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvShowList.Location = new System.Drawing.Point(35, 325);
            this.dgvShowList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.ReadOnly = true;
            this.dgvShowList.RowHeadersWidth = 51;
            this.dgvShowList.Size = new System.Drawing.Size(832, 342);
            this.dgvShowList.TabIndex = 172;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(125, 699);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(28, 24);
            this.lblRecordsCount.TabIndex = 174;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 699);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 173;
            this.label2.Text = "# Records:";
            // 
            // pbImage
            // 
            this.pbImage.Image = global::Project3_Simple_Clinic_.Properties.Resources.wallet__1_1;
            this.pbImage.Location = new System.Drawing.Point(389, 26);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(190, 126);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 176;
            this.pbImage.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNew.Image = global::Project3_Simple_Clinic_.Properties.Resources.plus;
            this.btnAddNew.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNew.Location = new System.Drawing.Point(768, 221);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.OnHoverImage = null;
            this.btnAddNew.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNew.Size = new System.Drawing.Size(112, 85);
            this.btnAddNew.TabIndex = 175;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Project3_Simple_Clinic_.Properties.Resources.searching_magnifying_glass2;
            this.pictureBox1.Location = new System.Drawing.Point(609, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(966, 732);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvShowList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmList";
            this.Text = "frmList";
            this.Load += new System.EventHandler(this.frmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.DataGridView dgvShowList;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI.WinForms.GunaImageButton btnAddNew;
        private System.Windows.Forms.PictureBox pbImage;
    }
}