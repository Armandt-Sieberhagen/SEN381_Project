namespace SEN_Project.PresentationLayer.Addresses
{
    partial class AddressCreator
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
            this.btnCreateAddress = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxAddressInfo = new System.Windows.Forms.GroupBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopyAddress = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.gbxAddressInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAddress
            // 
            this.btnCreateAddress.Location = new System.Drawing.Point(44, 212);
            this.btnCreateAddress.Name = "btnCreateAddress";
            this.btnCreateAddress.Size = new System.Drawing.Size(117, 57);
            this.btnCreateAddress.TabIndex = 10;
            this.btnCreateAddress.Text = "Confirm";
            this.btnCreateAddress.UseVisualStyleBackColor = true;
            this.btnCreateAddress.Click += new System.EventHandler(this.btnCreateAddress_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 57);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxAddressInfo
            // 
            this.gbxAddressInfo.Controls.Add(this.btnPaste);
            this.gbxAddressInfo.Controls.Add(this.btnCopyAddress);
            this.gbxAddressInfo.Controls.Add(this.lblCity);
            this.gbxAddressInfo.Controls.Add(this.lblProvince);
            this.gbxAddressInfo.Controls.Add(this.lblPostalCode);
            this.gbxAddressInfo.Controls.Add(this.lblStreet);
            this.gbxAddressInfo.Controls.Add(this.cbxCity);
            this.gbxAddressInfo.Controls.Add(this.cbxProvince);
            this.gbxAddressInfo.Controls.Add(this.txtPostalCode);
            this.gbxAddressInfo.Controls.Add(this.txtStreet);
            this.gbxAddressInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxAddressInfo.Name = "gbxAddressInfo";
            this.gbxAddressInfo.Size = new System.Drawing.Size(315, 185);
            this.gbxAddressInfo.TabIndex = 12;
            this.gbxAddressInfo.TabStop = false;
            this.gbxAddressInfo.Text = "Address Info";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(278, 19);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(26, 23);
            this.btnPaste.TabIndex = 19;
            this.btnPaste.Text = "P";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopyAddress
            // 
            this.btnCopyAddress.Location = new System.Drawing.Point(246, 19);
            this.btnCopyAddress.Name = "btnCopyAddress";
            this.btnCopyAddress.Size = new System.Drawing.Size(26, 23);
            this.btnCopyAddress.TabIndex = 18;
            this.btnCopyAddress.Text = "C";
            this.btnCopyAddress.UseVisualStyleBackColor = true;
            this.btnCopyAddress.Click += new System.EventHandler(this.btnCopyAddress_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(186, 123);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(183, 64);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 16;
            this.lblProvince.Text = "Province";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(10, 118);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(61, 13);
            this.lblPostalCode.TabIndex = 15;
            this.lblPostalCode.Text = "PostalCode";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(10, 57);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "Street";
            // 
            // cbxCity
            // 
            this.cbxCity.Enabled = false;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(186, 139);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(121, 21);
            this.cbxCity.TabIndex = 13;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged_1);
            // 
            // cbxProvince
            // 
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(186, 81);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(121, 21);
            this.cbxProvince.TabIndex = 12;
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.cbxProvince_SelectedIndexChanged_1);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(13, 134);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 11;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged_1);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(13, 81);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 10;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged_1);
            // 
            // AddressCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 315);
            this.ControlBox = false;
            this.Controls.Add(this.gbxAddressInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateAddress);
            this.Name = "AddressCreator";
            this.Text = "AddressCreator";
            this.Load += new System.EventHandler(this.AddressCreator_Load);
            this.gbxAddressInfo.ResumeLayout(false);
            this.gbxAddressInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxAddressInfo;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Button btnCopyAddress;
        private System.Windows.Forms.Button btnPaste;
    }
}