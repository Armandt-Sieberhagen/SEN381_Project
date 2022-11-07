namespace SEN_Project.PresentationLayer.Facilities
{
    partial class frmFacility
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
            this.gbxFacilityDetails = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCreateAddress = new System.Windows.Forms.Button();
            this.btnChangePolicies = new System.Windows.Forms.Button();
            this.lblPolicyData = new System.Windows.Forms.Label();
            this.rtxPolicies = new System.Windows.Forms.RichTextBox();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxAddressDetails = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCopyFacility = new System.Windows.Forms.Button();
            this.btnPasteFacility = new System.Windows.Forms.Button();
            this.btnPasteAddress = new System.Windows.Forms.Button();
            this.btnCopyAddress = new System.Windows.Forms.Button();
            this.gbxFacilityDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFacilityDetails
            // 
            this.gbxFacilityDetails.Controls.Add(this.btnPasteAddress);
            this.gbxFacilityDetails.Controls.Add(this.btnCopyAddress);
            this.gbxFacilityDetails.Controls.Add(this.btnPasteFacility);
            this.gbxFacilityDetails.Controls.Add(this.btnCopyFacility);
            this.gbxFacilityDetails.Controls.Add(this.txtName);
            this.gbxFacilityDetails.Controls.Add(this.lblName);
            this.gbxFacilityDetails.Controls.Add(this.btnCreateAddress);
            this.gbxFacilityDetails.Controls.Add(this.btnChangePolicies);
            this.gbxFacilityDetails.Controls.Add(this.lblPolicyData);
            this.gbxFacilityDetails.Controls.Add(this.rtxPolicies);
            this.gbxFacilityDetails.Controls.Add(this.btnSelectAddress);
            this.gbxFacilityDetails.Controls.Add(this.lblAddress);
            this.gbxFacilityDetails.Controls.Add(this.rtxAddressDetails);
            this.gbxFacilityDetails.Location = new System.Drawing.Point(12, 12);
            this.gbxFacilityDetails.Name = "gbxFacilityDetails";
            this.gbxFacilityDetails.Size = new System.Drawing.Size(446, 531);
            this.gbxFacilityDetails.TabIndex = 0;
            this.gbxFacilityDetails.TabStop = false;
            this.gbxFacilityDetails.Text = "Medical Service Provider Details";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Service Provider Name";
            // 
            // btnCreateAddress
            // 
            this.btnCreateAddress.Location = new System.Drawing.Point(6, 269);
            this.btnCreateAddress.Name = "btnCreateAddress";
            this.btnCreateAddress.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAddress.TabIndex = 6;
            this.btnCreateAddress.Text = "Create";
            this.btnCreateAddress.UseVisualStyleBackColor = true;
            this.btnCreateAddress.Click += new System.EventHandler(this.btnCreateAddress_Click);
            // 
            // btnChangePolicies
            // 
            this.btnChangePolicies.Location = new System.Drawing.Point(6, 498);
            this.btnChangePolicies.Name = "btnChangePolicies";
            this.btnChangePolicies.Size = new System.Drawing.Size(75, 23);
            this.btnChangePolicies.TabIndex = 5;
            this.btnChangePolicies.Text = "Change";
            this.btnChangePolicies.UseVisualStyleBackColor = true;
            this.btnChangePolicies.Click += new System.EventHandler(this.btnChangePolicies_Click);
            // 
            // lblPolicyData
            // 
            this.lblPolicyData.AutoSize = true;
            this.lblPolicyData.Location = new System.Drawing.Point(6, 295);
            this.lblPolicyData.Name = "lblPolicyData";
            this.lblPolicyData.Size = new System.Drawing.Size(43, 13);
            this.lblPolicyData.TabIndex = 4;
            this.lblPolicyData.Text = "Policies";
            // 
            // rtxPolicies
            // 
            this.rtxPolicies.Location = new System.Drawing.Point(9, 311);
            this.rtxPolicies.Name = "rtxPolicies";
            this.rtxPolicies.Size = new System.Drawing.Size(431, 181);
            this.rtxPolicies.TabIndex = 3;
            this.rtxPolicies.Text = "";
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Location = new System.Drawing.Point(100, 269);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAddress.TabIndex = 2;
            this.btnSelectAddress.Text = "Select";
            this.btnSelectAddress.UseVisualStyleBackColor = true;
            this.btnSelectAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 111);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address Details";
            // 
            // rtxAddressDetails
            // 
            this.rtxAddressDetails.Location = new System.Drawing.Point(6, 127);
            this.rtxAddressDetails.Name = "rtxAddressDetails";
            this.rtxAddressDetails.ReadOnly = true;
            this.rtxAddressDetails.Size = new System.Drawing.Size(169, 136);
            this.rtxAddressDetails.TabIndex = 0;
            this.rtxAddressDetails.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(42, 549);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(154, 100);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(202, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 100);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCopyFacility
            // 
            this.btnCopyFacility.Location = new System.Drawing.Point(384, 17);
            this.btnCopyFacility.Name = "btnCopyFacility";
            this.btnCopyFacility.Size = new System.Drawing.Size(25, 23);
            this.btnCopyFacility.TabIndex = 9;
            this.btnCopyFacility.Text = "C";
            this.btnCopyFacility.UseVisualStyleBackColor = true;
            this.btnCopyFacility.Click += new System.EventHandler(this.btnCopyFacility_Click);
            // 
            // btnPasteFacility
            // 
            this.btnPasteFacility.Location = new System.Drawing.Point(415, 17);
            this.btnPasteFacility.Name = "btnPasteFacility";
            this.btnPasteFacility.Size = new System.Drawing.Size(25, 23);
            this.btnPasteFacility.TabIndex = 10;
            this.btnPasteFacility.Text = "P";
            this.btnPasteFacility.UseVisualStyleBackColor = true;
            this.btnPasteFacility.Click += new System.EventHandler(this.btnPasteFacility_Click);
            // 
            // btnPasteAddress
            // 
            this.btnPasteAddress.Location = new System.Drawing.Point(214, 125);
            this.btnPasteAddress.Name = "btnPasteAddress";
            this.btnPasteAddress.Size = new System.Drawing.Size(25, 23);
            this.btnPasteAddress.TabIndex = 12;
            this.btnPasteAddress.Text = "P";
            this.btnPasteAddress.UseVisualStyleBackColor = true;
            this.btnPasteAddress.Click += new System.EventHandler(this.btnPasteAddress_Click);
            // 
            // btnCopyAddress
            // 
            this.btnCopyAddress.Location = new System.Drawing.Point(183, 125);
            this.btnCopyAddress.Name = "btnCopyAddress";
            this.btnCopyAddress.Size = new System.Drawing.Size(25, 23);
            this.btnCopyAddress.TabIndex = 11;
            this.btnCopyAddress.Text = "C";
            this.btnCopyAddress.UseVisualStyleBackColor = true;
            this.btnCopyAddress.Click += new System.EventHandler(this.btnCopyAddress_Click);
            // 
            // frmFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 661);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxFacilityDetails);
            this.Name = "frmFacility";
            this.Text = "frmFacility";
            this.gbxFacilityDetails.ResumeLayout(false);
            this.gbxFacilityDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFacilityDetails;
        private System.Windows.Forms.Button btnChangePolicies;
        private System.Windows.Forms.Label lblPolicyData;
        private System.Windows.Forms.RichTextBox rtxPolicies;
        private System.Windows.Forms.Button btnSelectAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxAddressDetails;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPasteAddress;
        private System.Windows.Forms.Button btnCopyAddress;
        private System.Windows.Forms.Button btnPasteFacility;
        private System.Windows.Forms.Button btnCopyFacility;
    }
}