namespace HospitalManagementSystem
{
    partial class PatientInformation
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
            this.lblPatientInformation = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.rdoButtonMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoButtonFemale = new System.Windows.Forms.RadioButton();
            this.rdoButtonOther = new System.Windows.Forms.RadioButton();
            this.lblAdmitDate = new System.Windows.Forms.Label();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.lblEmergencyContact = new System.Windows.Forms.Label();
            this.txtAdmitFee = new System.Windows.Forms.TextBox();
            this.lblAdmitFee = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbBoxDepID = new System.Windows.Forms.ComboBox();
            this.dtpickerPatientAdmit = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgPatientAdmitInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientAdmitInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientInformation
            // 
            this.lblPatientInformation.AutoSize = true;
            this.lblPatientInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientInformation.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientInformation.Location = new System.Drawing.Point(296, 41);
            this.lblPatientInformation.Name = "lblPatientInformation";
            this.lblPatientInformation.Size = new System.Drawing.Size(254, 23);
            this.lblPatientInformation.TabIndex = 0;
            this.lblPatientInformation.Text = "Patient Information";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(601, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(702, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(48, 140);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(54, 13);
            this.lblPatientID.TabIndex = 3;
            this.lblPatientID.Text = "Patient ID";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(160, 134);
            this.txtPatientID.Multiline = true;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(150, 20);
            this.txtPatientID.TabIndex = 4;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(160, 180);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(150, 20);
            this.txtPatientName.TabIndex = 6;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(48, 185);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblPatientName.TabIndex = 5;
            this.lblPatientName.Text = "Patient Name";
            // 
            // rdoButtonMale
            // 
            this.rdoButtonMale.AutoSize = true;
            this.rdoButtonMale.Location = new System.Drawing.Point(161, 230);
            this.rdoButtonMale.Name = "rdoButtonMale";
            this.rdoButtonMale.Size = new System.Drawing.Size(48, 17);
            this.rdoButtonMale.TabIndex = 7;
            this.rdoButtonMale.TabStop = true;
            this.rdoButtonMale.Text = "Male";
            this.rdoButtonMale.UseVisualStyleBackColor = true;
            this.rdoButtonMale.CheckedChanged += new System.EventHandler(this.rdoButtonMale_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(49, 230);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // rdoButtonFemale
            // 
            this.rdoButtonFemale.AutoSize = true;
            this.rdoButtonFemale.Location = new System.Drawing.Point(215, 230);
            this.rdoButtonFemale.Name = "rdoButtonFemale";
            this.rdoButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoButtonFemale.TabIndex = 9;
            this.rdoButtonFemale.TabStop = true;
            this.rdoButtonFemale.Text = "Female";
            this.rdoButtonFemale.UseVisualStyleBackColor = true;
            this.rdoButtonFemale.CheckedChanged += new System.EventHandler(this.rdoButtonFemale_CheckedChanged);
            // 
            // rdoButtonOther
            // 
            this.rdoButtonOther.AutoSize = true;
            this.rdoButtonOther.Location = new System.Drawing.Point(280, 231);
            this.rdoButtonOther.Name = "rdoButtonOther";
            this.rdoButtonOther.Size = new System.Drawing.Size(51, 17);
            this.rdoButtonOther.TabIndex = 10;
            this.rdoButtonOther.TabStop = true;
            this.rdoButtonOther.Text = "Other";
            this.rdoButtonOther.UseVisualStyleBackColor = true;
            this.rdoButtonOther.CheckedChanged += new System.EventHandler(this.rdoButtonOther_CheckedChanged);
            // 
            // lblAdmitDate
            // 
            this.lblAdmitDate.AutoSize = true;
            this.lblAdmitDate.Location = new System.Drawing.Point(464, 134);
            this.lblAdmitDate.Name = "lblAdmitDate";
            this.lblAdmitDate.Size = new System.Drawing.Size(59, 13);
            this.lblAdmitDate.TabIndex = 13;
            this.lblAdmitDate.Text = "Admit Date";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(160, 270);
            this.txtBloodGroup.Multiline = true;
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(150, 20);
            this.txtBloodGroup.TabIndex = 12;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(48, 273);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblBloodGroup.TabIndex = 11;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Location = new System.Drawing.Point(576, 226);
            this.txtEmergencyContact.Multiline = true;
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(135, 20);
            this.txtEmergencyContact.TabIndex = 18;
            // 
            // lblEmergencyContact
            // 
            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Location = new System.Drawing.Point(464, 229);
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Size = new System.Drawing.Size(100, 13);
            this.lblEmergencyContact.TabIndex = 17;
            this.lblEmergencyContact.Text = "Emergency Contact";
            // 
            // txtAdmitFee
            // 
            this.txtAdmitFee.Location = new System.Drawing.Point(576, 176);
            this.txtAdmitFee.Multiline = true;
            this.txtAdmitFee.Name = "txtAdmitFee";
            this.txtAdmitFee.Size = new System.Drawing.Size(135, 20);
            this.txtAdmitFee.TabIndex = 16;
            // 
            // lblAdmitFee
            // 
            this.lblAdmitFee.AutoSize = true;
            this.lblAdmitFee.Location = new System.Drawing.Point(464, 180);
            this.lblAdmitFee.Name = "lblAdmitFee";
            this.lblAdmitFee.Size = new System.Drawing.Size(54, 13);
            this.lblAdmitFee.TabIndex = 15;
            this.lblAdmitFee.Text = "Admit Fee";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(464, 283);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "Department";
            // 
            // cmbBoxDepID
            // 
            this.cmbBoxDepID.FormattingEnabled = true;
            this.cmbBoxDepID.Location = new System.Drawing.Point(576, 280);
            this.cmbBoxDepID.Name = "cmbBoxDepID";
            this.cmbBoxDepID.Size = new System.Drawing.Size(135, 21);
            this.cmbBoxDepID.TabIndex = 20;
            // 
            // dtpickerPatientAdmit
            // 
            this.dtpickerPatientAdmit.Location = new System.Drawing.Point(574, 133);
            this.dtpickerPatientAdmit.Name = "dtpickerPatientAdmit";
            this.dtpickerPatientAdmit.Size = new System.Drawing.Size(137, 20);
            this.dtpickerPatientAdmit.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(343, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(459, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgPatientAdmitInfo
            // 
            this.dgPatientAdmitInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatientAdmitInfo.Location = new System.Drawing.Point(43, 411);
            this.dgPatientAdmitInfo.Name = "dgPatientAdmitInfo";
            this.dgPatientAdmitInfo.Size = new System.Drawing.Size(722, 150);
            this.dgPatientAdmitInfo.TabIndex = 23;
            this.dgPatientAdmitInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPatientAdmitInfo_CellContentClick);
            // 
            // PatientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(804, 591);
            this.Controls.Add(this.dgPatientAdmitInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpickerPatientAdmit);
            this.Controls.Add(this.cmbBoxDepID);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtEmergencyContact);
            this.Controls.Add(this.lblEmergencyContact);
            this.Controls.Add(this.txtAdmitFee);
            this.Controls.Add(this.lblAdmitFee);
            this.Controls.Add(this.lblAdmitDate);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.rdoButtonOther);
            this.Controls.Add(this.rdoButtonFemale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rdoButtonMale);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPatientInformation);
            this.Name = "PatientInformation";
            this.Text = "PatientInformation";
            this.Load += new System.EventHandler(this.PatientInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientAdmitInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientInformation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.RadioButton rdoButtonMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoButtonFemale;
        private System.Windows.Forms.RadioButton rdoButtonOther;
        private System.Windows.Forms.Label lblAdmitDate;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Label lblEmergencyContact;
        private System.Windows.Forms.TextBox txtAdmitFee;
        private System.Windows.Forms.Label lblAdmitFee;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbBoxDepID;
        private System.Windows.Forms.DateTimePicker dtpickerPatientAdmit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgPatientAdmitInfo;
    }
}