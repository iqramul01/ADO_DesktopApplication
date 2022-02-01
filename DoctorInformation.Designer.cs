namespace HospitalManagementSystem
{
    partial class DoctorInformation
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDoctorInformation = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.cmbBoxDepID = new System.Windows.Forms.ComboBox();
            this.lblDepartmentNameDoctor = new System.Windows.Forms.Label();
            this.picBoxDoctor = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtDoctorImagePath = new System.Windows.Forms.TextBox();
            this.dgDoctorInformation = new System.Windows.Forms.DataGridView();
            this.lblContactAddress = new System.Windows.Forms.Label();
            this.txtContactAddress = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctorInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(594, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(63, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(309, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(425, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(693, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDoctorInformation
            // 
            this.btnDoctorInformation.AutoSize = true;
            this.btnDoctorInformation.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorInformation.Location = new System.Drawing.Point(311, 35);
            this.btnDoctorInformation.Name = "btnDoctorInformation";
            this.btnDoctorInformation.Size = new System.Drawing.Size(234, 37);
            this.btnDoctorInformation.TabIndex = 2;
            this.btnDoctorInformation.Text = "Doctors Information";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(66, 117);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(53, 13);
            this.lblDoctorID.TabIndex = 3;
            this.lblDoctorID.Text = "Doctor ID";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(170, 106);
            this.txtDoctorID.Multiline = true;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(177, 33);
            this.txtDoctorID.TabIndex = 4;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(66, 159);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(70, 13);
            this.lblDoctorName.TabIndex = 3;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(170, 148);
            this.txtDoctorName.Multiline = true;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(177, 33);
            this.txtDoctorName.TabIndex = 4;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(66, 202);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 3;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(170, 192);
            this.txtContactNumber.Multiline = true;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(177, 33);
            this.txtContactNumber.TabIndex = 4;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(66, 294);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 3;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(170, 283);
            this.txtEmailAddress.Multiline = true;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(177, 33);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // cmbBoxDepID
            // 
            this.cmbBoxDepID.FormattingEnabled = true;
            this.cmbBoxDepID.Location = new System.Drawing.Point(170, 324);
            this.cmbBoxDepID.Name = "cmbBoxDepID";
            this.cmbBoxDepID.Size = new System.Drawing.Size(177, 21);
            this.cmbBoxDepID.TabIndex = 5;
            // 
            // lblDepartmentNameDoctor
            // 
            this.lblDepartmentNameDoctor.AutoSize = true;
            this.lblDepartmentNameDoctor.Location = new System.Drawing.Point(66, 330);
            this.lblDepartmentNameDoctor.Name = "lblDepartmentNameDoctor";
            this.lblDepartmentNameDoctor.Size = new System.Drawing.Size(93, 13);
            this.lblDepartmentNameDoctor.TabIndex = 6;
            this.lblDepartmentNameDoctor.Text = "Department Name";
            // 
            // picBoxDoctor
            // 
            this.picBoxDoctor.Location = new System.Drawing.Point(507, 106);
            this.picBoxDoctor.Name = "picBoxDoctor";
            this.picBoxDoctor.Size = new System.Drawing.Size(160, 150);
            this.picBoxDoctor.TabIndex = 7;
            this.picBoxDoctor.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(545, 264);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(83, 27);
            this.btnBrowseImage.TabIndex = 8;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtDoctorImagePath
            // 
            this.txtDoctorImagePath.Location = new System.Drawing.Point(381, 297);
            this.txtDoctorImagePath.Multiline = true;
            this.txtDoctorImagePath.Name = "txtDoctorImagePath";
            this.txtDoctorImagePath.ReadOnly = true;
            this.txtDoctorImagePath.Size = new System.Drawing.Size(411, 29);
            this.txtDoctorImagePath.TabIndex = 9;
            // 
            // dgDoctorInformation
            // 
            this.dgDoctorInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoctorInformation.Location = new System.Drawing.Point(42, 458);
            this.dgDoctorInformation.Name = "dgDoctorInformation";
            this.dgDoctorInformation.Size = new System.Drawing.Size(726, 169);
            this.dgDoctorInformation.TabIndex = 10;
            this.dgDoctorInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDoctorInformation_CellContentClick);
            // 
            // lblContactAddress
            // 
            this.lblContactAddress.AutoSize = true;
            this.lblContactAddress.Location = new System.Drawing.Point(65, 252);
            this.lblContactAddress.Name = "lblContactAddress";
            this.lblContactAddress.Size = new System.Drawing.Size(85, 13);
            this.lblContactAddress.TabIndex = 11;
            this.lblContactAddress.Text = "Contact Address";
            // 
            // txtContactAddress
            // 
            this.txtContactAddress.Location = new System.Drawing.Point(170, 241);
            this.txtContactAddress.Multiline = true;
            this.txtContactAddress.Name = "txtContactAddress";
            this.txtContactAddress.Size = new System.Drawing.Size(177, 30);
            this.txtContactAddress.TabIndex = 12;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(535, 390);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "Report";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // DoctorInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(813, 662);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtContactAddress);
            this.Controls.Add(this.lblContactAddress);
            this.Controls.Add(this.dgDoctorInformation);
            this.Controls.Add(this.txtDoctorImagePath);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.picBoxDoctor);
            this.Controls.Add(this.lblDepartmentNameDoctor);
            this.Controls.Add(this.cmbBoxDepID);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.btnDoctorInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHome);
            this.Name = "DoctorInformation";
            this.Text = "DoctorInformation";
            this.Load += new System.EventHandler(this.DoctorInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctorInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label btnDoctorInformation;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.ComboBox cmbBoxDepID;
        private System.Windows.Forms.Label lblDepartmentNameDoctor;
        private System.Windows.Forms.PictureBox picBoxDoctor;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtDoctorImagePath;
        private System.Windows.Forms.DataGridView dgDoctorInformation;
        private System.Windows.Forms.Label lblContactAddress;
        private System.Windows.Forms.TextBox txtContactAddress;
        private System.Windows.Forms.Button btnView;
    }
}