namespace EmployeeInformationRetervial
{
    partial class frmCreateNewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewEmployee));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStateDeductions = new System.Windows.Forms.TextBox();
            this.txtFedDeductions = new System.Windows.Forms.TextBox();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.lblStateDeductions = new System.Windows.Forms.Label();
            this.lblFedDeductions = new System.Windows.Forms.Label();
            this.lblNumDependents = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtReportsTo = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLName = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumberAuto = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblAddressStreet = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDateOfHire = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmployeeFName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(62, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.frmAPIPrac_Load);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(140, 483);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 23);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.cmbMaritalStatus);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.dtpHireDate);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.lblConfirmPass);
            this.panel1.Controls.Add(this.txtAddress2);
            this.panel1.Controls.Add(this.lblAddress2);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtStateDeductions);
            this.panel1.Controls.Add(this.txtFedDeductions);
            this.panel1.Controls.Add(this.txtDependents);
            this.panel1.Controls.Add(this.lblStateDeductions);
            this.panel1.Controls.Add(this.lblFedDeductions);
            this.panel1.Controls.Add(this.lblNumDependents);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtReportsTo);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblReportsTo);
            this.panel1.Controls.Add(this.lblMaritalStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.lblEmployeeLName);
            this.panel1.Controls.Add(this.txtZipcode);
            this.panel1.Controls.Add(this.txtState);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.lblZipcode);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtPayRate);
            this.panel1.Controls.Add(this.lblEmployeeNumberAuto);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.lblAddressStreet);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.lblDateOfHire);
            this.panel1.Controls.Add(this.lblPayRate);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblEmployeeFName);
            this.panel1.ForeColor = System.Drawing.Color.FloralWhite;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 537);
            this.panel1.TabIndex = 48;
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "S",
            "M",
            "D",
            "W"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(140, 312);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(137, 21);
            this.cmbMaritalStatus.TabIndex = 90;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbStatus.Location = new System.Drawing.Point(140, 290);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(137, 21);
            this.cmbStatus.TabIndex = 89;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy/MM/dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(140, 243);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(137, 20);
            this.dtpDOB.TabIndex = 88;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CustomFormat = "yyyy/MM/dd";
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(140, 95);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(137, 20);
            this.dtpHireDate.TabIndex = 87;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(140, 377);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(137, 20);
            this.txtConfirmPass.TabIndex = 80;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(8, 380);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPass.TabIndex = 79;
            this.lblConfirmPass.Text = "Confirm Password:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(140, 157);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(137, 20);
            this.txtAddress2.TabIndex = 63;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(10, 164);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblAddress2.TabIndex = 62;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 53;
            // 
            // txtStateDeductions
            // 
            this.txtStateDeductions.Location = new System.Drawing.Point(140, 444);
            this.txtStateDeductions.Name = "txtStateDeductions";
            this.txtStateDeductions.Size = new System.Drawing.Size(137, 20);
            this.txtStateDeductions.TabIndex = 86;
            // 
            // txtFedDeductions
            // 
            this.txtFedDeductions.Location = new System.Drawing.Point(140, 422);
            this.txtFedDeductions.Name = "txtFedDeductions";
            this.txtFedDeductions.Size = new System.Drawing.Size(137, 20);
            this.txtFedDeductions.TabIndex = 84;
            // 
            // txtDependents
            // 
            this.txtDependents.Location = new System.Drawing.Point(140, 399);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(137, 20);
            this.txtDependents.TabIndex = 82;
            // 
            // lblStateDeductions
            // 
            this.lblStateDeductions.AutoSize = true;
            this.lblStateDeductions.Location = new System.Drawing.Point(10, 447);
            this.lblStateDeductions.Name = "lblStateDeductions";
            this.lblStateDeductions.Size = new System.Drawing.Size(92, 13);
            this.lblStateDeductions.TabIndex = 85;
            this.lblStateDeductions.Text = "State Deductions:";
            // 
            // lblFedDeductions
            // 
            this.lblFedDeductions.AutoSize = true;
            this.lblFedDeductions.Location = new System.Drawing.Point(10, 425);
            this.lblFedDeductions.Name = "lblFedDeductions";
            this.lblFedDeductions.Size = new System.Drawing.Size(102, 13);
            this.lblFedDeductions.TabIndex = 83;
            this.lblFedDeductions.Text = "Federal Deductions:";
            // 
            // lblNumDependents
            // 
            this.lblNumDependents.AutoSize = true;
            this.lblNumDependents.Location = new System.Drawing.Point(8, 402);
            this.lblNumDependents.Name = "lblNumDependents";
            this.lblNumDependents.Size = new System.Drawing.Size(118, 13);
            this.lblNumDependents.TabIndex = 81;
            this.lblNumDependents.Text = "Number of dependents:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 356);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 20);
            this.txtPassword.TabIndex = 78;
            // 
            // txtReportsTo
            // 
            this.txtReportsTo.Location = new System.Drawing.Point(140, 334);
            this.txtReportsTo.Name = "txtReportsTo";
            this.txtReportsTo.Size = new System.Drawing.Size(137, 20);
            this.txtReportsTo.TabIndex = 76;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(140, 268);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(137, 20);
            this.txtTitle.TabIndex = 72;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 359);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 77;
            this.lblPassword.Text = "Password:";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(10, 337);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(59, 13);
            this.lblReportsTo.TabIndex = 75;
            this.lblReportsTo.Text = "Reports to:";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(10, 315);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(72, 13);
            this.lblMaritalStatus.TabIndex = 74;
            this.lblMaritalStatus.Text = "Marital status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 293);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 73;
            this.lblStatus.Text = "Status:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 271);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "Title:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(10, 249);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 70;
            this.lblDOB.Text = "Date of birth:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(140, 24);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(137, 20);
            this.txtLName.TabIndex = 51;
            // 
            // lblEmployeeLName
            // 
            this.lblEmployeeLName.AutoSize = true;
            this.lblEmployeeLName.Location = new System.Drawing.Point(10, 29);
            this.lblEmployeeLName.Name = "lblEmployeeLName";
            this.lblEmployeeLName.Size = new System.Drawing.Size(61, 13);
            this.lblEmployeeLName.TabIndex = 50;
            this.lblEmployeeLName.Text = "Last Name:";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(140, 224);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(137, 20);
            this.txtZipcode.TabIndex = 69;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(140, 202);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(137, 20);
            this.txtState.TabIndex = 67;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(140, 180);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(137, 20);
            this.txtCity.TabIndex = 65;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(10, 227);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(50, 13);
            this.lblZipcode.TabIndex = 68;
            this.lblZipcode.Text = "ZipCode:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(10, 205);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 66;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 183);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 64;
            this.lblCity.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 20);
            this.txtAddress.TabIndex = 61;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(140, 116);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(137, 20);
            this.txtNumber.TabIndex = 59;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(140, 70);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(137, 20);
            this.txtPayRate.TabIndex = 55;
            // 
            // lblEmployeeNumberAuto
            // 
            this.lblEmployeeNumberAuto.AutoSize = true;
            this.lblEmployeeNumberAuto.Location = new System.Drawing.Point(137, 47);
            this.lblEmployeeNumberAuto.Name = "lblEmployeeNumberAuto";
            this.lblEmployeeNumberAuto.Size = new System.Drawing.Size(0, 13);
            this.lblEmployeeNumberAuto.TabIndex = 57;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(140, 3);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(137, 20);
            this.txtFName.TabIndex = 49;
            // 
            // lblAddressStreet
            // 
            this.lblAddressStreet.AutoSize = true;
            this.lblAddressStreet.Location = new System.Drawing.Point(10, 141);
            this.lblAddressStreet.Name = "lblAddressStreet";
            this.lblAddressStreet.Size = new System.Drawing.Size(79, 13);
            this.lblAddressStreet.TabIndex = 60;
            this.lblAddressStreet.Text = "Street Address:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(10, 119);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(79, 13);
            this.lblNumber.TabIndex = 58;
            this.lblNumber.Text = "Phone number:";
            // 
            // lblDateOfHire
            // 
            this.lblDateOfHire.AutoSize = true;
            this.lblDateOfHire.Location = new System.Drawing.Point(10, 95);
            this.lblDateOfHire.Name = "lblDateOfHire";
            this.lblDateOfHire.Size = new System.Drawing.Size(65, 13);
            this.lblDateOfHire.TabIndex = 56;
            this.lblDateOfHire.Text = "Date of hire:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(10, 73);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(49, 13);
            this.lblPayRate.TabIndex = 54;
            this.lblPayRate.Text = "Pay rate:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email:";
            // 
            // lblEmployeeFName
            // 
            this.lblEmployeeFName.AutoSize = true;
            this.lblEmployeeFName.Location = new System.Drawing.Point(10, 6);
            this.lblEmployeeFName.Name = "lblEmployeeFName";
            this.lblEmployeeFName.Size = new System.Drawing.Size(60, 13);
            this.lblEmployeeFName.TabIndex = 48;
            this.lblEmployeeFName.Text = "First Name:";
            // 
            // frmCreateNewEmployee
            // 
            this.AcceptButton = this.btnBack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(312, 573);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateNewEmployee";
            this.Text = "Create New Employee";
            this.Load += new System.EventHandler(this.frmCreateNewEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStateDeductions;
        private System.Windows.Forms.TextBox txtFedDeductions;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Label lblStateDeductions;
        private System.Windows.Forms.Label lblFedDeductions;
        private System.Windows.Forms.Label lblNumDependents;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtReportsTo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblEmployeeLName;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Label lblEmployeeNumberAuto;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblAddressStreet;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDateOfHire;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmployeeFName;
    }
}