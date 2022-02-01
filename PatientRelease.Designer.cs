namespace HospitalManagementSystem
{
    partial class frmPatientReleaseInformation
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
            this.lblReleaseInformation = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtDiscountRate = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.cmbBoxPatientID = new System.Windows.Forms.ComboBox();
            this.dgPatientRelease = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDepID = new System.Windows.Forms.Label();
            this.cmbBoxDepID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientRelease)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReleaseInformation
            // 
            this.lblReleaseInformation.AutoSize = true;
            this.lblReleaseInformation.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseInformation.Location = new System.Drawing.Point(258, 44);
            this.lblReleaseInformation.Name = "lblReleaseInformation";
            this.lblReleaseInformation.Size = new System.Drawing.Size(280, 26);
            this.lblReleaseInformation.TabIndex = 0;
            this.lblReleaseInformation.Text = "Release Information";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(587, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(696, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(101, 155);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(37, 13);
            this.lblBillNo.TabIndex = 3;
            this.lblBillNo.Text = "Bill No";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(248, 151);
            this.txtBillNo.Multiline = true;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(121, 20);
            this.txtBillNo.TabIndex = 4;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(248, 195);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(121, 20);
            this.dtpReleaseDate.TabIndex = 9;
            this.dtpReleaseDate.Value = new System.DateTime(2021, 8, 17, 3, 23, 0, 0);
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(96, 202);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lblReleaseDate.TabIndex = 10;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.Location = new System.Drawing.Point(587, 148);
            this.txtDiscountRate.Multiline = true;
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Size = new System.Drawing.Size(121, 20);
            this.txtDiscountRate.TabIndex = 14;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(432, 155);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 13;
            this.lblDiscount.Text = "Discount";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(248, 237);
            this.txtTotalBill.Multiline = true;
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(121, 20);
            this.txtTotalBill.TabIndex = 12;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Location = new System.Drawing.Point(93, 245);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(47, 13);
            this.lblTotalBill.TabIndex = 11;
            this.lblTotalBill.Text = "Total Bill";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(432, 245);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(51, 13);
            this.lblPatientID.TabIndex = 17;
            this.lblPatientID.Text = "PatientID";
            // 
            // cmbBoxPatientID
            // 
            this.cmbBoxPatientID.FormattingEnabled = true;
            this.cmbBoxPatientID.Location = new System.Drawing.Point(587, 242);
            this.cmbBoxPatientID.Name = "cmbBoxPatientID";
            this.cmbBoxPatientID.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPatientID.TabIndex = 18;
            // 
            // dgPatientRelease
            // 
            this.dgPatientRelease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatientRelease.Location = new System.Drawing.Point(54, 386);
            this.dgPatientRelease.Name = "dgPatientRelease";
            this.dgPatientRelease.Size = new System.Drawing.Size(717, 150);
            this.dgPatientRelease.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aqua;
            this.btnSave.Location = new System.Drawing.Point(216, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(345, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lime;
            this.btnDelete.Location = new System.Drawing.Point(482, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDepID
            // 
            this.lblDepID.AutoSize = true;
            this.lblDepID.Location = new System.Drawing.Point(433, 203);
            this.lblDepID.Name = "lblDepID";
            this.lblDepID.Size = new System.Drawing.Size(93, 13);
            this.lblDepID.TabIndex = 21;
            this.lblDepID.Text = "Department Name";
            // 
            // cmbBoxDepID
            // 
            this.cmbBoxDepID.FormattingEnabled = true;
            this.cmbBoxDepID.Location = new System.Drawing.Point(587, 195);
            this.cmbBoxDepID.Name = "cmbBoxDepID";
            this.cmbBoxDepID.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDepID.TabIndex = 22;
            // 
            // frmPatientReleaseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.cmbBoxDepID);
            this.Controls.Add(this.lblDepID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgPatientRelease);
            this.Controls.Add(this.cmbBoxPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtDiscountRate);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblReleaseInformation);
            this.Name = "frmPatientReleaseInformation";
            this.Text = "PatientReleaseInformation";
            this.Load += new System.EventHandler(this.frmPatientReleaseInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientRelease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReleaseInformation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.ComboBox cmbBoxPatientID;
        private System.Windows.Forms.DataGridView dgPatientRelease;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDepID;
        private System.Windows.Forms.ComboBox cmbBoxDepID;
    }
}