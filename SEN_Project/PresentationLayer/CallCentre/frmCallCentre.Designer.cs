namespace SEN_Project.PresentationLayer.CallCentre
{
    partial class frmCallCentre
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
            this.btnSimulateCall = new System.Windows.Forms.Button();
            this.gbxCallDetails = new System.Windows.Forms.GroupBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.rtxtEmployeeDetails = new System.Windows.Forms.RichTextBox();
            this.btnPasteCall = new System.Windows.Forms.Button();
            this.btnCopyCallDetails = new System.Windows.Forms.Button();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.gbxClientDetails = new System.Windows.Forms.GroupBox();
            this.rtxtAddressInfo = new System.Windows.Forms.RichTextBox();
            this.btnPasteClient = new System.Windows.Forms.Button();
            this.btnCopyClient = new System.Windows.Forms.Button();
            this.rtxtClientInfo = new System.Windows.Forms.RichTextBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.gbxClaimOptions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModifyClaim = new System.Windows.Forms.Button();
            this.btnViewPastClaims = new System.Windows.Forms.Button();
            this.btnCreateNewClaim = new System.Windows.Forms.Button();
            this.gbxPolicyInfo = new System.Windows.Forms.GroupBox();
            this.rtxtPolicyInfo = new System.Windows.Forms.RichTextBox();
            this.btnPasteSelectedPolicy = new System.Windows.Forms.Button();
            this.btnCopySelectedPolicy = new System.Windows.Forms.Button();
            this.btnChangePolicy = new System.Windows.Forms.Button();
            this.gbxProcedureInfo = new System.Windows.Forms.GroupBox();
            this.btnPasteProcedure = new System.Windows.Forms.Button();
            this.btnCopyProcedure = new System.Windows.Forms.Button();
            this.btnEditProcedure = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAddProcedure = new System.Windows.Forms.Button();
            this.lbxProcedures = new System.Windows.Forms.ListBox();
            this.lblCallLength = new System.Windows.Forms.Label();
            this.btnCreateNewClient = new System.Windows.Forms.Button();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.gbxCallDetails.SuspendLayout();
            this.gbxClientDetails.SuspendLayout();
            this.gbxClaimOptions.SuspendLayout();
            this.gbxPolicyInfo.SuspendLayout();
            this.gbxProcedureInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimulateCall
            // 
            this.btnSimulateCall.Location = new System.Drawing.Point(12, 12);
            this.btnSimulateCall.Name = "btnSimulateCall";
            this.btnSimulateCall.Size = new System.Drawing.Size(146, 90);
            this.btnSimulateCall.TabIndex = 0;
            this.btnSimulateCall.Text = "Simulate Call";
            this.btnSimulateCall.UseVisualStyleBackColor = true;
            this.btnSimulateCall.Click += new System.EventHandler(this.btnSimulateCall_Click);
            // 
            // gbxCallDetails
            // 
            this.gbxCallDetails.Controls.Add(this.btnCreateEmployee);
            this.gbxCallDetails.Controls.Add(this.btnSelectEmployee);
            this.gbxCallDetails.Controls.Add(this.rtxtEmployeeDetails);
            this.gbxCallDetails.Controls.Add(this.btnPasteCall);
            this.gbxCallDetails.Controls.Add(this.btnCopyCallDetails);
            this.gbxCallDetails.Controls.Add(this.lblEndTime);
            this.gbxCallDetails.Controls.Add(this.lblStartTime);
            this.gbxCallDetails.Location = new System.Drawing.Point(540, 12);
            this.gbxCallDetails.Name = "gbxCallDetails";
            this.gbxCallDetails.Size = new System.Drawing.Size(302, 175);
            this.gbxCallDetails.TabIndex = 2;
            this.gbxCallDetails.TabStop = false;
            this.gbxCallDetails.Text = "Call Details";
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(147, 38);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEmployee.TabIndex = 8;
            this.btnCreateEmployee.Text = "Create";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Location = new System.Drawing.Point(147, 67);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSelectEmployee.TabIndex = 7;
            this.btnSelectEmployee.Text = "Select Employee";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            this.btnSelectEmployee.Click += new System.EventHandler(this.btnSelectEmployee_Click);
            // 
            // rtxtEmployeeDetails
            // 
            this.rtxtEmployeeDetails.Location = new System.Drawing.Point(23, 19);
            this.rtxtEmployeeDetails.Name = "rtxtEmployeeDetails";
            this.rtxtEmployeeDetails.ReadOnly = true;
            this.rtxtEmployeeDetails.Size = new System.Drawing.Size(118, 71);
            this.rtxtEmployeeDetails.TabIndex = 6;
            this.rtxtEmployeeDetails.Text = "";
            // 
            // btnPasteCall
            // 
            this.btnPasteCall.Location = new System.Drawing.Point(265, 19);
            this.btnPasteCall.Name = "btnPasteCall";
            this.btnPasteCall.Size = new System.Drawing.Size(25, 23);
            this.btnPasteCall.TabIndex = 5;
            this.btnPasteCall.Text = "P";
            this.btnPasteCall.UseVisualStyleBackColor = true;
            this.btnPasteCall.Click += new System.EventHandler(this.btnPasteCall_Click);
            // 
            // btnCopyCallDetails
            // 
            this.btnCopyCallDetails.Location = new System.Drawing.Point(236, 19);
            this.btnCopyCallDetails.Name = "btnCopyCallDetails";
            this.btnCopyCallDetails.Size = new System.Drawing.Size(25, 23);
            this.btnCopyCallDetails.TabIndex = 4;
            this.btnCopyCallDetails.Text = "C";
            this.btnCopyCallDetails.UseVisualStyleBackColor = true;
            this.btnCopyCallDetails.Click += new System.EventHandler(this.btnCopyCallDetails_Click);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(20, 140);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblEndTime.TabIndex = 1;
            this.lblEndTime.Text = "End Time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(20, 111);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "Start Time";
            // 
            // gbxClientDetails
            // 
            this.gbxClientDetails.Controls.Add(this.rtxtAddressInfo);
            this.gbxClientDetails.Controls.Add(this.btnPasteClient);
            this.gbxClientDetails.Controls.Add(this.btnCopyClient);
            this.gbxClientDetails.Controls.Add(this.rtxtClientInfo);
            this.gbxClientDetails.Location = new System.Drawing.Point(12, 152);
            this.gbxClientDetails.Name = "gbxClientDetails";
            this.gbxClientDetails.Size = new System.Drawing.Size(505, 120);
            this.gbxClientDetails.TabIndex = 3;
            this.gbxClientDetails.TabStop = false;
            this.gbxClientDetails.Text = "Client Details";
            // 
            // rtxtAddressInfo
            // 
            this.rtxtAddressInfo.Location = new System.Drawing.Point(220, 19);
            this.rtxtAddressInfo.Name = "rtxtAddressInfo";
            this.rtxtAddressInfo.ReadOnly = true;
            this.rtxtAddressInfo.Size = new System.Drawing.Size(208, 95);
            this.rtxtAddressInfo.TabIndex = 8;
            this.rtxtAddressInfo.Text = "";
            // 
            // btnPasteClient
            // 
            this.btnPasteClient.Location = new System.Drawing.Point(468, 12);
            this.btnPasteClient.Name = "btnPasteClient";
            this.btnPasteClient.Size = new System.Drawing.Size(25, 23);
            this.btnPasteClient.TabIndex = 7;
            this.btnPasteClient.Text = "P";
            this.btnPasteClient.UseVisualStyleBackColor = true;
            this.btnPasteClient.Click += new System.EventHandler(this.btnPasteClient_Click);
            // 
            // btnCopyClient
            // 
            this.btnCopyClient.Location = new System.Drawing.Point(439, 12);
            this.btnCopyClient.Name = "btnCopyClient";
            this.btnCopyClient.Size = new System.Drawing.Size(25, 23);
            this.btnCopyClient.TabIndex = 6;
            this.btnCopyClient.Text = "C";
            this.btnCopyClient.UseVisualStyleBackColor = true;
            this.btnCopyClient.Click += new System.EventHandler(this.btnCopyClient_Click);
            // 
            // rtxtClientInfo
            // 
            this.rtxtClientInfo.Location = new System.Drawing.Point(6, 19);
            this.rtxtClientInfo.Name = "rtxtClientInfo";
            this.rtxtClientInfo.ReadOnly = true;
            this.rtxtClientInfo.Size = new System.Drawing.Size(208, 95);
            this.rtxtClientInfo.TabIndex = 0;
            this.rtxtClientInfo.Text = "";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(12, 123);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(75, 23);
            this.btnSelectClient.TabIndex = 4;
            this.btnSelectClient.Text = "Select Client";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(11, 825);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(146, 61);
            this.btnEndCall.TabIndex = 9;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // gbxClaimOptions
            // 
            this.gbxClaimOptions.Controls.Add(this.button1);
            this.gbxClaimOptions.Controls.Add(this.btnModifyClaim);
            this.gbxClaimOptions.Controls.Add(this.btnViewPastClaims);
            this.gbxClaimOptions.Controls.Add(this.btnCreateNewClaim);
            this.gbxClaimOptions.Location = new System.Drawing.Point(12, 278);
            this.gbxClaimOptions.Name = "gbxClaimOptions";
            this.gbxClaimOptions.Size = new System.Drawing.Size(601, 121);
            this.gbxClaimOptions.TabIndex = 10;
            this.gbxClaimOptions.TabStop = false;
            this.gbxClaimOptions.Text = "Claim Options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 70);
            this.button1.TabIndex = 12;
            this.button1.Text = "Remove Claim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModifyClaim
            // 
            this.btnModifyClaim.Location = new System.Drawing.Point(295, 30);
            this.btnModifyClaim.Name = "btnModifyClaim";
            this.btnModifyClaim.Size = new System.Drawing.Size(134, 70);
            this.btnModifyClaim.TabIndex = 11;
            this.btnModifyClaim.Text = "Modify Claim";
            this.btnModifyClaim.UseVisualStyleBackColor = true;
            this.btnModifyClaim.Click += new System.EventHandler(this.btnModifyClaim_Click);
            // 
            // btnViewPastClaims
            // 
            this.btnViewPastClaims.Location = new System.Drawing.Point(155, 30);
            this.btnViewPastClaims.Name = "btnViewPastClaims";
            this.btnViewPastClaims.Size = new System.Drawing.Size(134, 70);
            this.btnViewPastClaims.TabIndex = 10;
            this.btnViewPastClaims.Text = "View past Claims";
            this.btnViewPastClaims.UseVisualStyleBackColor = true;
            this.btnViewPastClaims.Click += new System.EventHandler(this.btnViewPastClaims_Click);
            // 
            // btnCreateNewClaim
            // 
            this.btnCreateNewClaim.Location = new System.Drawing.Point(12, 30);
            this.btnCreateNewClaim.Name = "btnCreateNewClaim";
            this.btnCreateNewClaim.Size = new System.Drawing.Size(134, 70);
            this.btnCreateNewClaim.TabIndex = 9;
            this.btnCreateNewClaim.Text = "Create Claim";
            this.btnCreateNewClaim.UseVisualStyleBackColor = true;
            this.btnCreateNewClaim.Click += new System.EventHandler(this.btnCreateNewClaim_Click);
            // 
            // gbxPolicyInfo
            // 
            this.gbxPolicyInfo.Controls.Add(this.rtxtPolicyInfo);
            this.gbxPolicyInfo.Controls.Add(this.btnPasteSelectedPolicy);
            this.gbxPolicyInfo.Controls.Add(this.btnCopySelectedPolicy);
            this.gbxPolicyInfo.Controls.Add(this.btnChangePolicy);
            this.gbxPolicyInfo.Location = new System.Drawing.Point(12, 405);
            this.gbxPolicyInfo.Name = "gbxPolicyInfo";
            this.gbxPolicyInfo.Size = new System.Drawing.Size(601, 204);
            this.gbxPolicyInfo.TabIndex = 11;
            this.gbxPolicyInfo.TabStop = false;
            this.gbxPolicyInfo.Text = "Police Info";
            // 
            // rtxtPolicyInfo
            // 
            this.rtxtPolicyInfo.Location = new System.Drawing.Point(12, 58);
            this.rtxtPolicyInfo.Name = "rtxtPolicyInfo";
            this.rtxtPolicyInfo.ReadOnly = true;
            this.rtxtPolicyInfo.Size = new System.Drawing.Size(569, 140);
            this.rtxtPolicyInfo.TabIndex = 18;
            this.rtxtPolicyInfo.Text = "";
            // 
            // btnPasteSelectedPolicy
            // 
            this.btnPasteSelectedPolicy.Location = new System.Drawing.Point(557, 19);
            this.btnPasteSelectedPolicy.Name = "btnPasteSelectedPolicy";
            this.btnPasteSelectedPolicy.Size = new System.Drawing.Size(25, 23);
            this.btnPasteSelectedPolicy.TabIndex = 17;
            this.btnPasteSelectedPolicy.Text = "P";
            this.btnPasteSelectedPolicy.UseVisualStyleBackColor = true;
            // 
            // btnCopySelectedPolicy
            // 
            this.btnCopySelectedPolicy.Location = new System.Drawing.Point(528, 19);
            this.btnCopySelectedPolicy.Name = "btnCopySelectedPolicy";
            this.btnCopySelectedPolicy.Size = new System.Drawing.Size(25, 23);
            this.btnCopySelectedPolicy.TabIndex = 16;
            this.btnCopySelectedPolicy.Text = "C";
            this.btnCopySelectedPolicy.UseVisualStyleBackColor = true;
            // 
            // btnChangePolicy
            // 
            this.btnChangePolicy.Location = new System.Drawing.Point(12, 19);
            this.btnChangePolicy.Name = "btnChangePolicy";
            this.btnChangePolicy.Size = new System.Drawing.Size(134, 33);
            this.btnChangePolicy.TabIndex = 15;
            this.btnChangePolicy.Text = "Change Policy";
            this.btnChangePolicy.UseVisualStyleBackColor = true;
            this.btnChangePolicy.Click += new System.EventHandler(this.btnChangePolicy_Click);
            // 
            // gbxProcedureInfo
            // 
            this.gbxProcedureInfo.Controls.Add(this.btnPasteProcedure);
            this.gbxProcedureInfo.Controls.Add(this.btnCopyProcedure);
            this.gbxProcedureInfo.Controls.Add(this.btnEditProcedure);
            this.gbxProcedureInfo.Controls.Add(this.button5);
            this.gbxProcedureInfo.Controls.Add(this.btnAddProcedure);
            this.gbxProcedureInfo.Controls.Add(this.lbxProcedures);
            this.gbxProcedureInfo.Location = new System.Drawing.Point(11, 615);
            this.gbxProcedureInfo.Name = "gbxProcedureInfo";
            this.gbxProcedureInfo.Size = new System.Drawing.Size(601, 204);
            this.gbxProcedureInfo.TabIndex = 18;
            this.gbxProcedureInfo.TabStop = false;
            this.gbxProcedureInfo.Text = "Procedure Info";
            // 
            // btnPasteProcedure
            // 
            this.btnPasteProcedure.Location = new System.Drawing.Point(557, 19);
            this.btnPasteProcedure.Name = "btnPasteProcedure";
            this.btnPasteProcedure.Size = new System.Drawing.Size(25, 23);
            this.btnPasteProcedure.TabIndex = 17;
            this.btnPasteProcedure.Text = "P";
            this.btnPasteProcedure.UseVisualStyleBackColor = true;
            // 
            // btnCopyProcedure
            // 
            this.btnCopyProcedure.Location = new System.Drawing.Point(528, 19);
            this.btnCopyProcedure.Name = "btnCopyProcedure";
            this.btnCopyProcedure.Size = new System.Drawing.Size(25, 23);
            this.btnCopyProcedure.TabIndex = 16;
            this.btnCopyProcedure.Text = "C";
            this.btnCopyProcedure.UseVisualStyleBackColor = true;
            // 
            // btnEditProcedure
            // 
            this.btnEditProcedure.Location = new System.Drawing.Point(357, 138);
            this.btnEditProcedure.Name = "btnEditProcedure";
            this.btnEditProcedure.Size = new System.Drawing.Size(134, 54);
            this.btnEditProcedure.TabIndex = 15;
            this.btnEditProcedure.Text = "Edit Procedure";
            this.btnEditProcedure.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(357, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 50);
            this.button5.TabIndex = 14;
            this.button5.Text = "Remove Procedure";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnAddProcedure
            // 
            this.btnAddProcedure.Location = new System.Drawing.Point(357, 19);
            this.btnAddProcedure.Name = "btnAddProcedure";
            this.btnAddProcedure.Size = new System.Drawing.Size(134, 57);
            this.btnAddProcedure.TabIndex = 13;
            this.btnAddProcedure.Text = "Add Procedure";
            this.btnAddProcedure.UseVisualStyleBackColor = true;
            this.btnAddProcedure.Click += new System.EventHandler(this.btnAddProcedure_Click);
            // 
            // lbxProcedures
            // 
            this.lbxProcedures.FormattingEnabled = true;
            this.lbxProcedures.Location = new System.Drawing.Point(12, 19);
            this.lbxProcedures.Name = "lbxProcedures";
            this.lbxProcedures.Size = new System.Drawing.Size(339, 173);
            this.lbxProcedures.TabIndex = 0;
            // 
            // lblCallLength
            // 
            this.lblCallLength.AutoSize = true;
            this.lblCallLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallLength.Location = new System.Drawing.Point(199, 36);
            this.lblCallLength.Name = "lblCallLength";
            this.lblCallLength.Size = new System.Drawing.Size(293, 31);
            this.lblCallLength.TabIndex = 19;
            this.lblCallLength.Text = "Call Length: 00:00:00";
            // 
            // btnCreateNewClient
            // 
            this.btnCreateNewClient.Location = new System.Drawing.Point(93, 123);
            this.btnCreateNewClient.Name = "btnCreateNewClient";
            this.btnCreateNewClient.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewClient.TabIndex = 20;
            this.btnCreateNewClient.Text = "Create Client";
            this.btnCreateNewClient.UseVisualStyleBackColor = true;
            this.btnCreateNewClient.Click += new System.EventHandler(this.btnCreateNewClient_Click);
            // 
            // btnMainForm
            // 
            this.btnMainForm.Location = new System.Drawing.Point(727, 825);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(146, 61);
            this.btnMainForm.TabIndex = 21;
            this.btnMainForm.Text = "Back to main form>>>";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // frmCallCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(885, 890);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.btnCreateNewClient);
            this.Controls.Add(this.lblCallLength);
            this.Controls.Add(this.gbxProcedureInfo);
            this.Controls.Add(this.gbxPolicyInfo);
            this.Controls.Add(this.gbxClaimOptions);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.gbxClientDetails);
            this.Controls.Add(this.gbxCallDetails);
            this.Controls.Add(this.btnSimulateCall);
            this.Name = "frmCallCentre";
            this.Text = "Call Centre";
            this.Load += new System.EventHandler(this.frmCallCentre_Load);
            this.gbxCallDetails.ResumeLayout(false);
            this.gbxCallDetails.PerformLayout();
            this.gbxClientDetails.ResumeLayout(false);
            this.gbxClaimOptions.ResumeLayout(false);
            this.gbxPolicyInfo.ResumeLayout(false);
            this.gbxProcedureInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimulateCall;
        private System.Windows.Forms.GroupBox gbxCallDetails;
        private System.Windows.Forms.Button btnPasteCall;
        private System.Windows.Forms.Button btnCopyCallDetails;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.RichTextBox rtxtEmployeeDetails;
        private System.Windows.Forms.GroupBox gbxClientDetails;
        private System.Windows.Forms.Button btnPasteClient;
        private System.Windows.Forms.Button btnCopyClient;
        private System.Windows.Forms.RichTextBox rtxtClientInfo;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.GroupBox gbxClaimOptions;
        private System.Windows.Forms.RichTextBox rtxtAddressInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModifyClaim;
        private System.Windows.Forms.Button btnViewPastClaims;
        private System.Windows.Forms.Button btnCreateNewClaim;
        private System.Windows.Forms.GroupBox gbxPolicyInfo;
        private System.Windows.Forms.Button btnPasteSelectedPolicy;
        private System.Windows.Forms.Button btnCopySelectedPolicy;
        private System.Windows.Forms.Button btnChangePolicy;
        private System.Windows.Forms.GroupBox gbxProcedureInfo;
        private System.Windows.Forms.Button btnPasteProcedure;
        private System.Windows.Forms.Button btnCopyProcedure;
        private System.Windows.Forms.Button btnEditProcedure;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAddProcedure;
        private System.Windows.Forms.ListBox lbxProcedures;
        private System.Windows.Forms.Label lblCallLength;
        private System.Windows.Forms.RichTextBox rtxtPolicyInfo;
        private System.Windows.Forms.Button btnCreateNewClient;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnMainForm;
    }
}