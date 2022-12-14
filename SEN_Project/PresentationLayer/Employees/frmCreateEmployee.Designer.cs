namespace SEN_Project.PresentationLayer.Employees
{
    partial class frmCreateEmployee
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
            this.gbxEmployee = new System.Windows.Forms.GroupBox();
            this.btnPasteEmployee = new System.Windows.Forms.Button();
            this.btnCopyEmployee = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.btnPasteAddress = new System.Windows.Forms.Button();
            this.btnCopyAddress = new System.Windows.Forms.Button();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.btnCreateAddress = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxtAddressInfo = new System.Windows.Forms.RichTextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEmployee
            // 
            this.gbxEmployee.Controls.Add(this.btnPasteEmployee);
            this.gbxEmployee.Controls.Add(this.btnCopyEmployee);
            this.gbxEmployee.Controls.Add(this.txtEmail);
            this.gbxEmployee.Controls.Add(this.lblEmail);
            this.gbxEmployee.Controls.Add(this.txtPhoneNumber);
            this.gbxEmployee.Controls.Add(this.lblPhoneNumber);
            this.gbxEmployee.Controls.Add(this.txtID);
            this.gbxEmployee.Controls.Add(this.lblIDNumber);
            this.gbxEmployee.Controls.Add(this.btnPasteAddress);
            this.gbxEmployee.Controls.Add(this.btnCopyAddress);
            this.gbxEmployee.Controls.Add(this.btnSelectAddress);
            this.gbxEmployee.Controls.Add(this.btnCreateAddress);
            this.gbxEmployee.Controls.Add(this.lblAddress);
            this.gbxEmployee.Controls.Add(this.rtxtAddressInfo);
            this.gbxEmployee.Controls.Add(this.txtLastName);
            this.gbxEmployee.Controls.Add(this.lblLastName);
            this.gbxEmployee.Controls.Add(this.txtFirstName);
            this.gbxEmployee.Controls.Add(this.lblFirstName);
            this.gbxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployee.Location = new System.Drawing.Point(12, 12);
            this.gbxEmployee.Name = "gbxEmployee";
            this.gbxEmployee.Size = new System.Drawing.Size(289, 421);
            this.gbxEmployee.TabIndex = 0;
            this.gbxEmployee.TabStop = false;
            this.gbxEmployee.Text = "Employee Details";
            this.gbxEmployee.Enter += new System.EventHandler(this.gbxEmployee_Enter);
            // 
            // btnPasteEmployee
            // 
            this.btnPasteEmployee.Location = new System.Drawing.Point(255, 16);
            this.btnPasteEmployee.Name = "btnPasteEmployee";
            this.btnPasteEmployee.Size = new System.Drawing.Size(28, 23);
            this.btnPasteEmployee.TabIndex = 17;
            this.btnPasteEmployee.Text = "P";
            this.btnPasteEmployee.UseVisualStyleBackColor = true;
            this.btnPasteEmployee.Click += new System.EventHandler(this.btnPasteEmployee_Click);
            // 
            // btnCopyEmployee
            // 
            this.btnCopyEmployee.Location = new System.Drawing.Point(221, 16);
            this.btnCopyEmployee.Name = "btnCopyEmployee";
            this.btnCopyEmployee.Size = new System.Drawing.Size(28, 23);
            this.btnCopyEmployee.TabIndex = 16;
            this.btnCopyEmployee.Text = "C";
            this.btnCopyEmployee.UseVisualStyleBackColor = true;
            this.btnCopyEmployee.Click += new System.EventHandler(this.btnCopyEmployee_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 21);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email Address";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(115, 143);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(18, 146);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 109);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 11;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(18, 112);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(67, 15);
            this.lblIDNumber.TabIndex = 10;
            this.lblIDNumber.Text = "ID Number";
            // 
            // btnPasteAddress
            // 
            this.btnPasteAddress.Location = new System.Drawing.Point(227, 235);
            this.btnPasteAddress.Name = "btnPasteAddress";
            this.btnPasteAddress.Size = new System.Drawing.Size(28, 23);
            this.btnPasteAddress.TabIndex = 9;
            this.btnPasteAddress.Text = "P";
            this.btnPasteAddress.UseVisualStyleBackColor = true;
            this.btnPasteAddress.Click += new System.EventHandler(this.btnPasteAddress_Click);
            // 
            // btnCopyAddress
            // 
            this.btnCopyAddress.Location = new System.Drawing.Point(193, 235);
            this.btnCopyAddress.Name = "btnCopyAddress";
            this.btnCopyAddress.Size = new System.Drawing.Size(28, 23);
            this.btnCopyAddress.TabIndex = 8;
            this.btnCopyAddress.Text = "C";
            this.btnCopyAddress.UseVisualStyleBackColor = true;
            this.btnCopyAddress.Click += new System.EventHandler(this.btnCopyAddress_Click);
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAddress.Location = new System.Drawing.Point(161, 366);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(78, 25);
            this.btnSelectAddress.TabIndex = 7;
            this.btnSelectAddress.Text = "Select";
            this.btnSelectAddress.UseVisualStyleBackColor = true;
            this.btnSelectAddress.Click += new System.EventHandler(this.btnSelectAddress_Click);
            // 
            // btnCreateAddress
            // 
            this.btnCreateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAddress.Location = new System.Drawing.Point(53, 366);
            this.btnCreateAddress.Name = "btnCreateAddress";
            this.btnCreateAddress.Size = new System.Drawing.Size(78, 25);
            this.btnCreateAddress.TabIndex = 6;
            this.btnCreateAddress.Text = "Create";
            this.btnCreateAddress.UseVisualStyleBackColor = true;
            this.btnCreateAddress.Click += new System.EventHandler(this.btnCreateAddress_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 245);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 15);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // rtxtAddressInfo
            // 
            this.rtxtAddressInfo.Location = new System.Drawing.Point(32, 261);
            this.rtxtAddressInfo.Name = "rtxtAddressInfo";
            this.rtxtAddressInfo.ReadOnly = true;
            this.rtxtAddressInfo.Size = new System.Drawing.Size(228, 88);
            this.rtxtAddressInfo.TabIndex = 4;
            this.rtxtAddressInfo.Text = "";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 21);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(18, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 21);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(12, 453);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 67);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(180, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 67);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 534);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxEmployee);
            this.Name = "frmCreateEmployee";
            this.ShowIcon = false;
            this.Text = "Create Employee";
            this.Load += new System.EventHandler(this.frmCreateEmployee_Load);
            this.gbxEmployee.ResumeLayout(false);
            this.gbxEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEmployee;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSelectAddress;
        private System.Windows.Forms.Button btnCreateAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxtAddressInfo;
        private System.Windows.Forms.Button btnPasteAddress;
        private System.Windows.Forms.Button btnCopyAddress;
        private System.Windows.Forms.Button btnPasteEmployee;
        private System.Windows.Forms.Button btnCopyEmployee;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}