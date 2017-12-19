namespace EmployeeInformationRetervial
{
    partial class frmEmployeeRetrevial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeRetrevial));
            this.grpEmployeeInput = new System.Windows.Forms.GroupBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.grpEmployeeOutput = new System.Windows.Forms.GroupBox();
            this.txtEmployeeInformation = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.grpEmployeeInput.SuspendLayout();
            this.grpEmployeeOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeInput
            // 
            this.grpEmployeeInput.Controls.Add(this.txtEmployeeName);
            this.grpEmployeeInput.Controls.Add(this.lblEmployeeName);
            this.grpEmployeeInput.Controls.Add(this.lblOr);
            this.grpEmployeeInput.Controls.Add(this.txtEmployeeNumber);
            this.grpEmployeeInput.Controls.Add(this.lblEmployeeNumber);
            this.grpEmployeeInput.ForeColor = System.Drawing.Color.FloralWhite;
            this.grpEmployeeInput.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeInput.Name = "grpEmployeeInput";
            this.grpEmployeeInput.Size = new System.Drawing.Size(243, 100);
            this.grpEmployeeInput.TabIndex = 1;
            this.grpEmployeeInput.TabStop = false;
            this.grpEmployeeInput.Text = "Search by";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(108, 66);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 4;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            this.txtEmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 66);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(85, 13);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "Employee &name:";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(84, 53);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(18, 13);
            this.lblOr.TabIndex = 2;
            this.lblOr.Text = "Or";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(108, 32);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNumber.TabIndex = 1;
            this.txtEmployeeNumber.TextChanged += new System.EventHandler(this.txtEmployeeNumber_TextChanged);
            this.txtEmployeeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayRate_KeyPress);
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(6, 35);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(94, 13);
            this.lblEmployeeNumber.TabIndex = 0;
            this.lblEmployeeNumber.Text = "Employee n&umber:";
            // 
            // grpEmployeeOutput
            // 
            this.grpEmployeeOutput.Controls.Add(this.txtEmployeeInformation);
            this.grpEmployeeOutput.Controls.Add(this.btnEdit);
            this.grpEmployeeOutput.ForeColor = System.Drawing.Color.FloralWhite;
            this.grpEmployeeOutput.Location = new System.Drawing.Point(288, 12);
            this.grpEmployeeOutput.Name = "grpEmployeeOutput";
            this.grpEmployeeOutput.Size = new System.Drawing.Size(207, 317);
            this.grpEmployeeOutput.TabIndex = 2;
            this.grpEmployeeOutput.TabStop = false;
            this.grpEmployeeOutput.Text = "Employee Information";
            // 
            // txtEmployeeInformation
            // 
            this.txtEmployeeInformation.Location = new System.Drawing.Point(6, 19);
            this.txtEmployeeInformation.Multiline = true;
            this.txtEmployeeInformation.Name = "txtEmployeeInformation";
            this.txtEmployeeInformation.ReadOnly = true;
            this.txtEmployeeInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmployeeInformation.Size = new System.Drawing.Size(196, 263);
            this.txtEmployeeInformation.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(6, 288);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(61, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.frmAPIPrac_Load);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(142, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(142, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(61, 149);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEmployee.TabIndex = 7;
            this.btnCreateEmployee.Text = "&Create New";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // frmEmployeeRetrevial
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpEmployeeOutput);
            this.Controls.Add(this.grpEmployeeInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeRetrevial";
            this.Text = "Shadow Games Employee Information Tool";
            this.grpEmployeeInput.ResumeLayout(false);
            this.grpEmployeeInput.PerformLayout();
            this.grpEmployeeOutput.ResumeLayout(false);
            this.grpEmployeeOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEmployeeInput;
        private System.Windows.Forms.GroupBox grpEmployeeOutput;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.TextBox txtEmployeeInformation;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblOr;
    }
}

