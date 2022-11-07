namespace SEN_Project.PresentationLayer.Claims
{
    partial class frmClaim
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
            this.gbxClaim = new System.Windows.Forms.GroupBox();
            this.lblClientInfo = new System.Windows.Forms.Label();
            this.rtxtClientInfo = new System.Windows.Forms.RichTextBox();
            this.lblClaimStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnPasteClaim = new System.Windows.Forms.Button();
            this.btnCopyClaim = new System.Windows.Forms.Button();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblClaimID = new System.Windows.Forms.Label();
            this.btnSelectPolicyInfo = new System.Windows.Forms.Button();
            this.gbxPolicyInfo = new System.Windows.Forms.GroupBox();
            this.rtxtPolicyInfo = new System.Windows.Forms.RichTextBox();
            this.btnPastePolicyInfo = new System.Windows.Forms.Button();
            this.btnCopyPolicyInfo = new System.Windows.Forms.Button();
            this.btnSelectCall = new System.Windows.Forms.Button();
            this.btnSelectProcedure = new System.Windows.Forms.Button();
            this.gbxCallDetails = new System.Windows.Forms.GroupBox();
            this.rtxtCallDetails = new System.Windows.Forms.RichTextBox();
            this.btnPasteCallInfo = new System.Windows.Forms.Button();
            this.btnCopyCallInfo = new System.Windows.Forms.Button();
            this.gbxProcedureInfo = new System.Windows.Forms.GroupBox();
            this.rtxtProcedureDetails = new System.Windows.Forms.RichTextBox();
            this.btnPasteProcedureInfo = new System.Windows.Forms.Button();
            this.btnCopyProcedureInfo = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxClaim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.gbxPolicyInfo.SuspendLayout();
            this.gbxCallDetails.SuspendLayout();
            this.gbxProcedureInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClaim
            // 
            this.gbxClaim.Controls.Add(this.lblClientInfo);
            this.gbxClaim.Controls.Add(this.rtxtClientInfo);
            this.gbxClaim.Controls.Add(this.lblClaimStatus);
            this.gbxClaim.Controls.Add(this.cbxStatus);
            this.gbxClaim.Controls.Add(this.lblPrice);
            this.gbxClaim.Controls.Add(this.btnPasteClaim);
            this.gbxClaim.Controls.Add(this.btnCopyClaim);
            this.gbxClaim.Controls.Add(this.numPrice);
            this.gbxClaim.Controls.Add(this.lblClaimID);
            this.gbxClaim.Controls.Add(this.btnSelectPolicyInfo);
            this.gbxClaim.Controls.Add(this.gbxPolicyInfo);
            this.gbxClaim.Controls.Add(this.btnSelectCall);
            this.gbxClaim.Controls.Add(this.btnSelectProcedure);
            this.gbxClaim.Controls.Add(this.gbxCallDetails);
            this.gbxClaim.Controls.Add(this.gbxProcedureInfo);
            this.gbxClaim.Location = new System.Drawing.Point(12, 12);
            this.gbxClaim.Name = "gbxClaim";
            this.gbxClaim.Size = new System.Drawing.Size(475, 674);
            this.gbxClaim.TabIndex = 0;
            this.gbxClaim.TabStop = false;
            this.gbxClaim.Text = "Claim Form";
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.AutoSize = true;
            this.lblClientInfo.Location = new System.Drawing.Point(20, 57);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(54, 13);
            this.lblClientInfo.TabIndex = 26;
            this.lblClientInfo.Text = "Client Info";
            // 
            // rtxtClientInfo
            // 
            this.rtxtClientInfo.Location = new System.Drawing.Point(19, 73);
            this.rtxtClientInfo.Name = "rtxtClientInfo";
            this.rtxtClientInfo.ReadOnly = true;
            this.rtxtClientInfo.Size = new System.Drawing.Size(246, 92);
            this.rtxtClientInfo.TabIndex = 25;
            this.rtxtClientInfo.Text = "";
            // 
            // lblClaimStatus
            // 
            this.lblClaimStatus.AutoSize = true;
            this.lblClaimStatus.Location = new System.Drawing.Point(220, 205);
            this.lblClaimStatus.Name = "lblClaimStatus";
            this.lblClaimStatus.Size = new System.Drawing.Size(65, 13);
            this.lblClaimStatus.TabIndex = 24;
            this.lblClaimStatus.Text = "Claim Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Declined"});
            this.cbxStatus.Location = new System.Drawing.Point(223, 221);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 23;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 205);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price:";
            // 
            // btnPasteClaim
            // 
            this.btnPasteClaim.Location = new System.Drawing.Point(436, 21);
            this.btnPasteClaim.Name = "btnPasteClaim";
            this.btnPasteClaim.Size = new System.Drawing.Size(22, 27);
            this.btnPasteClaim.TabIndex = 21;
            this.btnPasteClaim.Text = "P";
            this.btnPasteClaim.UseVisualStyleBackColor = true;
            this.btnPasteClaim.Click += new System.EventHandler(this.btnPasteClaim_Click);
            // 
            // btnCopyClaim
            // 
            this.btnCopyClaim.Location = new System.Drawing.Point(408, 21);
            this.btnCopyClaim.Name = "btnCopyClaim";
            this.btnCopyClaim.Size = new System.Drawing.Size(22, 27);
            this.btnCopyClaim.TabIndex = 20;
            this.btnCopyClaim.Text = "C";
            this.btnCopyClaim.UseVisualStyleBackColor = true;
            this.btnCopyClaim.Click += new System.EventHandler(this.btnCopyClaim_Click);
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(22, 221);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 19;
            // 
            // lblClaimID
            // 
            this.lblClaimID.AutoSize = true;
            this.lblClaimID.Location = new System.Drawing.Point(20, 21);
            this.lblClaimID.Name = "lblClaimID";
            this.lblClaimID.Size = new System.Drawing.Size(46, 13);
            this.lblClaimID.TabIndex = 18;
            this.lblClaimID.Text = "Claim ID";
            // 
            // btnSelectPolicyInfo
            // 
            this.btnSelectPolicyInfo.Location = new System.Drawing.Point(23, 537);
            this.btnSelectPolicyInfo.Name = "btnSelectPolicyInfo";
            this.btnSelectPolicyInfo.Size = new System.Drawing.Size(154, 23);
            this.btnSelectPolicyInfo.TabIndex = 17;
            this.btnSelectPolicyInfo.Text = "Select Policy";
            this.btnSelectPolicyInfo.UseVisualStyleBackColor = true;
            this.btnSelectPolicyInfo.Click += new System.EventHandler(this.btnSelectPolicyInfo_Click);
            // 
            // gbxPolicyInfo
            // 
            this.gbxPolicyInfo.Controls.Add(this.rtxtPolicyInfo);
            this.gbxPolicyInfo.Controls.Add(this.btnPastePolicyInfo);
            this.gbxPolicyInfo.Controls.Add(this.btnCopyPolicyInfo);
            this.gbxPolicyInfo.Location = new System.Drawing.Point(19, 566);
            this.gbxPolicyInfo.Name = "gbxPolicyInfo";
            this.gbxPolicyInfo.Size = new System.Drawing.Size(322, 102);
            this.gbxPolicyInfo.TabIndex = 16;
            this.gbxPolicyInfo.TabStop = false;
            this.gbxPolicyInfo.Text = "Policy";
            // 
            // rtxtPolicyInfo
            // 
            this.rtxtPolicyInfo.Location = new System.Drawing.Point(6, 20);
            this.rtxtPolicyInfo.Name = "rtxtPolicyInfo";
            this.rtxtPolicyInfo.ReadOnly = true;
            this.rtxtPolicyInfo.Size = new System.Drawing.Size(249, 81);
            this.rtxtPolicyInfo.TabIndex = 9;
            this.rtxtPolicyInfo.Text = "";
            // 
            // btnPastePolicyInfo
            // 
            this.btnPastePolicyInfo.Location = new System.Drawing.Point(294, 16);
            this.btnPastePolicyInfo.Name = "btnPastePolicyInfo";
            this.btnPastePolicyInfo.Size = new System.Drawing.Size(22, 27);
            this.btnPastePolicyInfo.TabIndex = 8;
            this.btnPastePolicyInfo.Text = "P";
            this.btnPastePolicyInfo.UseVisualStyleBackColor = true;
            // 
            // btnCopyPolicyInfo
            // 
            this.btnCopyPolicyInfo.Location = new System.Drawing.Point(266, 16);
            this.btnCopyPolicyInfo.Name = "btnCopyPolicyInfo";
            this.btnCopyPolicyInfo.Size = new System.Drawing.Size(22, 27);
            this.btnCopyPolicyInfo.TabIndex = 7;
            this.btnCopyPolicyInfo.Text = "C";
            this.btnCopyPolicyInfo.UseVisualStyleBackColor = true;
            this.btnCopyPolicyInfo.Click += new System.EventHandler(this.btnCopyPolicyInfo_Click);
            // 
            // btnSelectCall
            // 
            this.btnSelectCall.Location = new System.Drawing.Point(23, 394);
            this.btnSelectCall.Name = "btnSelectCall";
            this.btnSelectCall.Size = new System.Drawing.Size(154, 23);
            this.btnSelectCall.TabIndex = 15;
            this.btnSelectCall.Text = "Select Call";
            this.btnSelectCall.UseVisualStyleBackColor = true;
            this.btnSelectCall.Click += new System.EventHandler(this.btnSelectCall_Click);
            // 
            // btnSelectProcedure
            // 
            this.btnSelectProcedure.Location = new System.Drawing.Point(23, 261);
            this.btnSelectProcedure.Name = "btnSelectProcedure";
            this.btnSelectProcedure.Size = new System.Drawing.Size(124, 27);
            this.btnSelectProcedure.TabIndex = 14;
            this.btnSelectProcedure.Text = "Select Procedure";
            this.btnSelectProcedure.UseVisualStyleBackColor = true;
            this.btnSelectProcedure.Click += new System.EventHandler(this.btnSelectProcedure_Click);
            // 
            // gbxCallDetails
            // 
            this.gbxCallDetails.Controls.Add(this.rtxtCallDetails);
            this.gbxCallDetails.Controls.Add(this.btnPasteCallInfo);
            this.gbxCallDetails.Controls.Add(this.btnCopyCallInfo);
            this.gbxCallDetails.Location = new System.Drawing.Point(19, 423);
            this.gbxCallDetails.Name = "gbxCallDetails";
            this.gbxCallDetails.Size = new System.Drawing.Size(301, 108);
            this.gbxCallDetails.TabIndex = 13;
            this.gbxCallDetails.TabStop = false;
            this.gbxCallDetails.Text = "Call Details";
            // 
            // rtxtCallDetails
            // 
            this.rtxtCallDetails.Location = new System.Drawing.Point(9, 22);
            this.rtxtCallDetails.Name = "rtxtCallDetails";
            this.rtxtCallDetails.ReadOnly = true;
            this.rtxtCallDetails.Size = new System.Drawing.Size(218, 77);
            this.rtxtCallDetails.TabIndex = 7;
            this.rtxtCallDetails.Text = "";
            // 
            // btnPasteCallInfo
            // 
            this.btnPasteCallInfo.Location = new System.Drawing.Point(261, 18);
            this.btnPasteCallInfo.Name = "btnPasteCallInfo";
            this.btnPasteCallInfo.Size = new System.Drawing.Size(22, 27);
            this.btnPasteCallInfo.TabIndex = 6;
            this.btnPasteCallInfo.Text = "P";
            this.btnPasteCallInfo.UseVisualStyleBackColor = true;
            this.btnPasteCallInfo.Click += new System.EventHandler(this.btnPasteCallInfo_Click);
            // 
            // btnCopyCallInfo
            // 
            this.btnCopyCallInfo.Location = new System.Drawing.Point(233, 18);
            this.btnCopyCallInfo.Name = "btnCopyCallInfo";
            this.btnCopyCallInfo.Size = new System.Drawing.Size(22, 27);
            this.btnCopyCallInfo.TabIndex = 5;
            this.btnCopyCallInfo.Text = "C";
            this.btnCopyCallInfo.UseVisualStyleBackColor = true;
            this.btnCopyCallInfo.Click += new System.EventHandler(this.btnCopyCallInfo_Click);
            // 
            // gbxProcedureInfo
            // 
            this.gbxProcedureInfo.Controls.Add(this.rtxtProcedureDetails);
            this.gbxProcedureInfo.Controls.Add(this.btnPasteProcedureInfo);
            this.gbxProcedureInfo.Controls.Add(this.btnCopyProcedureInfo);
            this.gbxProcedureInfo.Location = new System.Drawing.Point(19, 294);
            this.gbxProcedureInfo.Name = "gbxProcedureInfo";
            this.gbxProcedureInfo.Size = new System.Drawing.Size(322, 94);
            this.gbxProcedureInfo.TabIndex = 12;
            this.gbxProcedureInfo.TabStop = false;
            this.gbxProcedureInfo.Text = "Procedure";
            // 
            // rtxtProcedureDetails
            // 
            this.rtxtProcedureDetails.Location = new System.Drawing.Point(9, 19);
            this.rtxtProcedureDetails.Name = "rtxtProcedureDetails";
            this.rtxtProcedureDetails.ReadOnly = true;
            this.rtxtProcedureDetails.Size = new System.Drawing.Size(246, 69);
            this.rtxtProcedureDetails.TabIndex = 5;
            this.rtxtProcedureDetails.Text = "";
            // 
            // btnPasteProcedureInfo
            // 
            this.btnPasteProcedureInfo.Location = new System.Drawing.Point(294, 15);
            this.btnPasteProcedureInfo.Name = "btnPasteProcedureInfo";
            this.btnPasteProcedureInfo.Size = new System.Drawing.Size(22, 27);
            this.btnPasteProcedureInfo.TabIndex = 4;
            this.btnPasteProcedureInfo.Text = "P";
            this.btnPasteProcedureInfo.UseVisualStyleBackColor = true;
            this.btnPasteProcedureInfo.Click += new System.EventHandler(this.btnPasteProcedureInfo_Click);
            // 
            // btnCopyProcedureInfo
            // 
            this.btnCopyProcedureInfo.Location = new System.Drawing.Point(266, 15);
            this.btnCopyProcedureInfo.Name = "btnCopyProcedureInfo";
            this.btnCopyProcedureInfo.Size = new System.Drawing.Size(22, 27);
            this.btnCopyProcedureInfo.TabIndex = 3;
            this.btnCopyProcedureInfo.Text = "C";
            this.btnCopyProcedureInfo.UseVisualStyleBackColor = true;
            this.btnCopyProcedureInfo.Click += new System.EventHandler(this.btnCopyProcedureInfo_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(80, 705);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(132, 85);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 705);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 85);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 802);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxClaim);
            this.Name = "frmClaim";
            this.Text = "frmClaim";
            this.Load += new System.EventHandler(this.frmClaim_Load);
            this.gbxClaim.ResumeLayout(false);
            this.gbxClaim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.gbxPolicyInfo.ResumeLayout(false);
            this.gbxCallDetails.ResumeLayout(false);
            this.gbxProcedureInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClaim;
        private System.Windows.Forms.Button btnPasteClaim;
        private System.Windows.Forms.Button btnCopyClaim;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblClaimID;
        private System.Windows.Forms.Button btnSelectPolicyInfo;
        private System.Windows.Forms.GroupBox gbxPolicyInfo;
        private System.Windows.Forms.Button btnPastePolicyInfo;
        private System.Windows.Forms.Button btnCopyPolicyInfo;
        private System.Windows.Forms.Button btnSelectCall;
        private System.Windows.Forms.Button btnSelectProcedure;
        private System.Windows.Forms.GroupBox gbxCallDetails;
        private System.Windows.Forms.Button btnPasteCallInfo;
        private System.Windows.Forms.Button btnCopyCallInfo;
        private System.Windows.Forms.GroupBox gbxProcedureInfo;
        private System.Windows.Forms.Button btnPasteProcedureInfo;
        private System.Windows.Forms.Button btnCopyProcedureInfo;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RichTextBox rtxtProcedureDetails;
        private System.Windows.Forms.RichTextBox rtxtCallDetails;
        private System.Windows.Forms.RichTextBox rtxtPolicyInfo;
        private System.Windows.Forms.Label lblClaimStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblClientInfo;
        private System.Windows.Forms.RichTextBox rtxtClientInfo;
    }
}