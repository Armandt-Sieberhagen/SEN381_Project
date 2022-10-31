namespace SEN_Project.PresentationLayer.Claims
{
    partial class frmViewPastClaims
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
            this.lbxClaims = new System.Windows.Forms.ListBox();
            this.gbxClientInfo = new System.Windows.Forms.GroupBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCopyClientInfo = new System.Windows.Forms.Button();
            this.btnPasteClient = new System.Windows.Forms.Button();
            this.gbxClaimDetails = new System.Windows.Forms.GroupBox();
            this.rtxtClaimInfo = new System.Windows.Forms.RichTextBox();
            this.btnPasteClaim = new System.Windows.Forms.Button();
            this.btnCopyClaim = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxClientInfo.SuspendLayout();
            this.gbxClaimDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxClaims
            // 
            this.lbxClaims.FormattingEnabled = true;
            this.lbxClaims.Location = new System.Drawing.Point(12, 139);
            this.lbxClaims.Name = "lbxClaims";
            this.lbxClaims.Size = new System.Drawing.Size(212, 134);
            this.lbxClaims.TabIndex = 0;
            // 
            // gbxClientInfo
            // 
            this.gbxClientInfo.Controls.Add(this.btnPasteClient);
            this.gbxClientInfo.Controls.Add(this.btnCopyClientInfo);
            this.gbxClientInfo.Controls.Add(this.richTextBox1);
            this.gbxClientInfo.Location = new System.Drawing.Point(12, 41);
            this.gbxClientInfo.Name = "gbxClientInfo";
            this.gbxClientInfo.Size = new System.Drawing.Size(397, 92);
            this.gbxClientInfo.TabIndex = 1;
            this.gbxClientInfo.TabStop = false;
            this.gbxClientInfo.Text = "Client Info";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(12, 12);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(113, 23);
            this.btnSelectClient.TabIndex = 2;
            this.btnSelectClient.Text = "Select Client";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(313, 67);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCopyClientInfo
            // 
            this.btnCopyClientInfo.Location = new System.Drawing.Point(333, 17);
            this.btnCopyClientInfo.Name = "btnCopyClientInfo";
            this.btnCopyClientInfo.Size = new System.Drawing.Size(26, 23);
            this.btnCopyClientInfo.TabIndex = 1;
            this.btnCopyClientInfo.Text = "C";
            this.btnCopyClientInfo.UseVisualStyleBackColor = true;
            // 
            // btnPasteClient
            // 
            this.btnPasteClient.Location = new System.Drawing.Point(365, 17);
            this.btnPasteClient.Name = "btnPasteClient";
            this.btnPasteClient.Size = new System.Drawing.Size(26, 23);
            this.btnPasteClient.TabIndex = 2;
            this.btnPasteClient.Text = "P";
            this.btnPasteClient.UseVisualStyleBackColor = true;
            // 
            // gbxClaimDetails
            // 
            this.gbxClaimDetails.Controls.Add(this.btnPasteClaim);
            this.gbxClaimDetails.Controls.Add(this.btnCopyClaim);
            this.gbxClaimDetails.Controls.Add(this.rtxtClaimInfo);
            this.gbxClaimDetails.Location = new System.Drawing.Point(12, 279);
            this.gbxClaimDetails.Name = "gbxClaimDetails";
            this.gbxClaimDetails.Size = new System.Drawing.Size(430, 251);
            this.gbxClaimDetails.TabIndex = 3;
            this.gbxClaimDetails.TabStop = false;
            this.gbxClaimDetails.Text = "Claim Details";
            // 
            // rtxtClaimInfo
            // 
            this.rtxtClaimInfo.Location = new System.Drawing.Point(6, 19);
            this.rtxtClaimInfo.Name = "rtxtClaimInfo";
            this.rtxtClaimInfo.ReadOnly = true;
            this.rtxtClaimInfo.Size = new System.Drawing.Size(331, 226);
            this.rtxtClaimInfo.TabIndex = 1;
            this.rtxtClaimInfo.Text = "";
            // 
            // btnPasteClaim
            // 
            this.btnPasteClaim.Location = new System.Drawing.Point(398, 19);
            this.btnPasteClaim.Name = "btnPasteClaim";
            this.btnPasteClaim.Size = new System.Drawing.Size(26, 23);
            this.btnPasteClaim.TabIndex = 4;
            this.btnPasteClaim.Text = "P";
            this.btnPasteClaim.UseVisualStyleBackColor = true;
            // 
            // btnCopyClaim
            // 
            this.btnCopyClaim.Location = new System.Drawing.Point(366, 19);
            this.btnCopyClaim.Name = "btnCopyClaim";
            this.btnCopyClaim.Size = new System.Drawing.Size(26, 23);
            this.btnCopyClaim.TabIndex = 3;
            this.btnCopyClaim.Text = "C";
            this.btnCopyClaim.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 536);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmViewPastClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 595);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxClaimDetails);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.gbxClientInfo);
            this.Controls.Add(this.lbxClaims);
            this.Name = "frmViewPastClaims";
            this.Text = "frmViewPastClaims";
            this.gbxClientInfo.ResumeLayout(false);
            this.gbxClaimDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxClaims;
        private System.Windows.Forms.GroupBox gbxClientInfo;
        private System.Windows.Forms.Button btnPasteClient;
        private System.Windows.Forms.Button btnCopyClientInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.GroupBox gbxClaimDetails;
        private System.Windows.Forms.Button btnPasteClaim;
        private System.Windows.Forms.Button btnCopyClaim;
        private System.Windows.Forms.RichTextBox rtxtClaimInfo;
        private System.Windows.Forms.Button btnClose;
    }
}