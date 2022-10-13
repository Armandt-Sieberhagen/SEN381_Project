namespace SEN_Project.PresentationLayer.Addresses.AddressCreator
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
            this.components = new System.ComponentModel.Container();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnCreateAddress = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(12, 33);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 0;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(12, 86);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 2;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged);
            // 
            // cbxProvince
            // 
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(185, 33);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(121, 21);
            this.cbxProvince.TabIndex = 4;
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.cbxProvince_SelectedIndexChanged);
            // 
            // cbxCity
            // 
            this.cbxCity.Enabled = false;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(185, 91);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(121, 21);
            this.cbxCity.TabIndex = 5;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(9, 9);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Street";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(9, 70);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(61, 13);
            this.lblPostalCode.TabIndex = 7;
            this.lblPostalCode.Text = "PostalCode";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(182, 16);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 8;
            this.lblProvince.Text = "Province";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(185, 75);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // btnCreateAddress
            // 
            this.btnCreateAddress.Location = new System.Drawing.Point(12, 150);
            this.btnCreateAddress.Name = "btnCreateAddress";
            this.btnCreateAddress.Size = new System.Drawing.Size(117, 57);
            this.btnCreateAddress.TabIndex = 10;
            this.btnCreateAddress.Text = "+Create";
            this.btnCreateAddress.UseVisualStyleBackColor = true;
            this.btnCreateAddress.Click += new System.EventHandler(this.btnCreateAddress_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 57);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddressCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 245);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxProvince);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtStreet);
            this.Name = "AddressCreator";
            this.Text = "AddressCreator";
            this.Load += new System.EventHandler(this.AddressCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnCreateAddress;
        private System.Windows.Forms.Button btnCancel;
    }
}