namespace SEN_Project.PresentationLayer.Procedure
{
    partial class frmProcedure
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
            this.gbxProcedureDetails = new System.Windows.Forms.GroupBox();
            this.gbxPolicy = new System.Windows.Forms.GroupBox();
            this.btnSelectPolicy = new System.Windows.Forms.Button();
            this.rtxtPolicyInfo = new System.Windows.Forms.RichTextBox();
            this.btnPastePolicy = new System.Windows.Forms.Button();
            this.btnCopyPolicy = new System.Windows.Forms.Button();
            this.gbxServiceProvider = new System.Windows.Forms.GroupBox();
            this.btnSelectFacility = new System.Windows.Forms.Button();
            this.rtxtFacilityDisplay = new System.Windows.Forms.RichTextBox();
            this.btnPasteFacility = new System.Windows.Forms.Button();
            this.btnCopyFacility = new System.Windows.Forms.Button();
            this.gbxClientDetails = new System.Windows.Forms.GroupBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.btnPasteClient = new System.Windows.Forms.Button();
            this.btnCopyClient = new System.Windows.Forms.Button();
            this.rtxtClientInfo = new System.Windows.Forms.RichTextBox();
            this.lblProcedureID = new System.Windows.Forms.Label();
            this.btnPasteProcedure = new System.Windows.Forms.Button();
            this.btnCopyProcedure = new System.Windows.Forms.Button();
            this.gbxTreatmentDetails = new System.Windows.Forms.GroupBox();
            this.btnSelectTreatment = new System.Windows.Forms.Button();
            this.rtxtTreatmentInfo = new System.Windows.Forms.RichTextBox();
            this.btnPasteTreatment = new System.Windows.Forms.Button();
            this.btnCopyTreatment = new System.Windows.Forms.Button();
            this.gbxCondition = new System.Windows.Forms.GroupBox();
            this.btnSelectCondition = new System.Windows.Forms.Button();
            this.rtxtConditionInfo = new System.Windows.Forms.RichTextBox();
            this.btnPasteCondition = new System.Windows.Forms.Button();
            this.btnCopyCondition = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxProcedureDetails.SuspendLayout();
            this.gbxPolicy.SuspendLayout();
            this.gbxServiceProvider.SuspendLayout();
            this.gbxClientDetails.SuspendLayout();
            this.gbxTreatmentDetails.SuspendLayout();
            this.gbxCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProcedureDetails
            // 
            this.gbxProcedureDetails.Controls.Add(this.gbxPolicy);
            this.gbxProcedureDetails.Controls.Add(this.gbxServiceProvider);
            this.gbxProcedureDetails.Controls.Add(this.gbxClientDetails);
            this.gbxProcedureDetails.Controls.Add(this.lblProcedureID);
            this.gbxProcedureDetails.Controls.Add(this.btnPasteProcedure);
            this.gbxProcedureDetails.Controls.Add(this.btnCopyProcedure);
            this.gbxProcedureDetails.Controls.Add(this.gbxTreatmentDetails);
            this.gbxProcedureDetails.Controls.Add(this.gbxCondition);
            this.gbxProcedureDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProcedureDetails.Location = new System.Drawing.Point(11, 10);
            this.gbxProcedureDetails.Name = "gbxProcedureDetails";
            this.gbxProcedureDetails.Size = new System.Drawing.Size(472, 808);
            this.gbxProcedureDetails.TabIndex = 0;
            this.gbxProcedureDetails.TabStop = false;
            this.gbxProcedureDetails.Text = "Procedure";
            // 
            // gbxPolicy
            // 
            this.gbxPolicy.Controls.Add(this.btnSelectPolicy);
            this.gbxPolicy.Controls.Add(this.rtxtPolicyInfo);
            this.gbxPolicy.Controls.Add(this.btnPastePolicy);
            this.gbxPolicy.Controls.Add(this.btnCopyPolicy);
            this.gbxPolicy.Location = new System.Drawing.Point(32, 665);
            this.gbxPolicy.Name = "gbxPolicy";
            this.gbxPolicy.Size = new System.Drawing.Size(412, 130);
            this.gbxPolicy.TabIndex = 17;
            this.gbxPolicy.TabStop = false;
            this.gbxPolicy.Text = "Policy";
            // 
            // btnSelectPolicy
            // 
            this.btnSelectPolicy.Location = new System.Drawing.Point(9, 25);
            this.btnSelectPolicy.Name = "btnSelectPolicy";
            this.btnSelectPolicy.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPolicy.TabIndex = 15;
            this.btnSelectPolicy.Text = "Select";
            this.btnSelectPolicy.UseVisualStyleBackColor = true;
            this.btnSelectPolicy.Click += new System.EventHandler(this.btnSelectPolicy_Click);
            // 
            // rtxtPolicyInfo
            // 
            this.rtxtPolicyInfo.Location = new System.Drawing.Point(9, 54);
            this.rtxtPolicyInfo.Name = "rtxtPolicyInfo";
            this.rtxtPolicyInfo.Size = new System.Drawing.Size(391, 70);
            this.rtxtPolicyInfo.TabIndex = 6;
            this.rtxtPolicyInfo.Text = "";
            // 
            // btnPastePolicy
            // 
            this.btnPastePolicy.Location = new System.Drawing.Point(365, 19);
            this.btnPastePolicy.Name = "btnPastePolicy";
            this.btnPastePolicy.Size = new System.Drawing.Size(28, 23);
            this.btnPastePolicy.TabIndex = 5;
            this.btnPastePolicy.Text = "P";
            this.btnPastePolicy.UseVisualStyleBackColor = true;
            this.btnPastePolicy.Click += new System.EventHandler(this.btnPastePolicy_Click);
            // 
            // btnCopyPolicy
            // 
            this.btnCopyPolicy.Location = new System.Drawing.Point(331, 19);
            this.btnCopyPolicy.Name = "btnCopyPolicy";
            this.btnCopyPolicy.Size = new System.Drawing.Size(28, 23);
            this.btnCopyPolicy.TabIndex = 4;
            this.btnCopyPolicy.Text = "C";
            this.btnCopyPolicy.UseVisualStyleBackColor = true;
            this.btnCopyPolicy.Click += new System.EventHandler(this.btnCopyPolicy_Click);
            // 
            // gbxServiceProvider
            // 
            this.gbxServiceProvider.Controls.Add(this.btnSelectFacility);
            this.gbxServiceProvider.Controls.Add(this.rtxtFacilityDisplay);
            this.gbxServiceProvider.Controls.Add(this.btnPasteFacility);
            this.gbxServiceProvider.Controls.Add(this.btnCopyFacility);
            this.gbxServiceProvider.Location = new System.Drawing.Point(32, 490);
            this.gbxServiceProvider.Name = "gbxServiceProvider";
            this.gbxServiceProvider.Size = new System.Drawing.Size(412, 170);
            this.gbxServiceProvider.TabIndex = 16;
            this.gbxServiceProvider.TabStop = false;
            this.gbxServiceProvider.Text = "Medical Service Provider";
            // 
            // btnSelectFacility
            // 
            this.btnSelectFacility.Location = new System.Drawing.Point(9, 25);
            this.btnSelectFacility.Name = "btnSelectFacility";
            this.btnSelectFacility.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFacility.TabIndex = 15;
            this.btnSelectFacility.Text = "Select";
            this.btnSelectFacility.UseVisualStyleBackColor = true;
            this.btnSelectFacility.Click += new System.EventHandler(this.btnSelectFacility_Click);
            // 
            // rtxtFacilityDisplay
            // 
            this.rtxtFacilityDisplay.Location = new System.Drawing.Point(9, 54);
            this.rtxtFacilityDisplay.Name = "rtxtFacilityDisplay";
            this.rtxtFacilityDisplay.Size = new System.Drawing.Size(391, 106);
            this.rtxtFacilityDisplay.TabIndex = 6;
            this.rtxtFacilityDisplay.Text = "";
            // 
            // btnPasteFacility
            // 
            this.btnPasteFacility.Location = new System.Drawing.Point(365, 19);
            this.btnPasteFacility.Name = "btnPasteFacility";
            this.btnPasteFacility.Size = new System.Drawing.Size(28, 23);
            this.btnPasteFacility.TabIndex = 5;
            this.btnPasteFacility.Text = "P";
            this.btnPasteFacility.UseVisualStyleBackColor = true;
            this.btnPasteFacility.Click += new System.EventHandler(this.btnPasteFacility_Click);
            // 
            // btnCopyFacility
            // 
            this.btnCopyFacility.Location = new System.Drawing.Point(331, 19);
            this.btnCopyFacility.Name = "btnCopyFacility";
            this.btnCopyFacility.Size = new System.Drawing.Size(28, 23);
            this.btnCopyFacility.TabIndex = 4;
            this.btnCopyFacility.Text = "C";
            this.btnCopyFacility.UseVisualStyleBackColor = true;
            this.btnCopyFacility.Click += new System.EventHandler(this.btnCopyFacility_Click);
            // 
            // gbxClientDetails
            // 
            this.gbxClientDetails.Controls.Add(this.btnSelectClient);
            this.gbxClientDetails.Controls.Add(this.btnPasteClient);
            this.gbxClientDetails.Controls.Add(this.btnCopyClient);
            this.gbxClientDetails.Controls.Add(this.rtxtClientInfo);
            this.gbxClientDetails.Location = new System.Drawing.Point(32, 40);
            this.gbxClientDetails.Name = "gbxClientDetails";
            this.gbxClientDetails.Size = new System.Drawing.Size(278, 94);
            this.gbxClientDetails.TabIndex = 10;
            this.gbxClientDetails.TabStop = false;
            this.gbxClientDetails.Text = "Client Details";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(177, 46);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(78, 23);
            this.btnSelectClient.TabIndex = 15;
            this.btnSelectClient.Text = "Select";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // btnPasteClient
            // 
            this.btnPasteClient.Location = new System.Drawing.Point(244, 17);
            this.btnPasteClient.Name = "btnPasteClient";
            this.btnPasteClient.Size = new System.Drawing.Size(28, 23);
            this.btnPasteClient.TabIndex = 14;
            this.btnPasteClient.Text = "P";
            this.btnPasteClient.UseVisualStyleBackColor = true;
            this.btnPasteClient.Click += new System.EventHandler(this.btnPasteClient_Click);
            // 
            // btnCopyClient
            // 
            this.btnCopyClient.Location = new System.Drawing.Point(210, 17);
            this.btnCopyClient.Name = "btnCopyClient";
            this.btnCopyClient.Size = new System.Drawing.Size(28, 23);
            this.btnCopyClient.TabIndex = 13;
            this.btnCopyClient.Text = "C";
            this.btnCopyClient.UseVisualStyleBackColor = true;
            this.btnCopyClient.Click += new System.EventHandler(this.btnCopyClient_Click);
            // 
            // rtxtClientInfo
            // 
            this.rtxtClientInfo.Location = new System.Drawing.Point(6, 19);
            this.rtxtClientInfo.Name = "rtxtClientInfo";
            this.rtxtClientInfo.Size = new System.Drawing.Size(165, 69);
            this.rtxtClientInfo.TabIndex = 12;
            this.rtxtClientInfo.Text = "";
            // 
            // lblProcedureID
            // 
            this.lblProcedureID.AutoSize = true;
            this.lblProcedureID.Location = new System.Drawing.Point(31, 23);
            this.lblProcedureID.Name = "lblProcedureID";
            this.lblProcedureID.Size = new System.Drawing.Size(82, 15);
            this.lblProcedureID.TabIndex = 9;
            this.lblProcedureID.Text = "Procedure ID:";
            // 
            // btnPasteProcedure
            // 
            this.btnPasteProcedure.Location = new System.Drawing.Point(438, 19);
            this.btnPasteProcedure.Name = "btnPasteProcedure";
            this.btnPasteProcedure.Size = new System.Drawing.Size(28, 23);
            this.btnPasteProcedure.TabIndex = 7;
            this.btnPasteProcedure.Text = "P";
            this.btnPasteProcedure.UseVisualStyleBackColor = true;
            this.btnPasteProcedure.Click += new System.EventHandler(this.btnPasteProcedure_Click);
            // 
            // btnCopyProcedure
            // 
            this.btnCopyProcedure.Location = new System.Drawing.Point(404, 19);
            this.btnCopyProcedure.Name = "btnCopyProcedure";
            this.btnCopyProcedure.Size = new System.Drawing.Size(28, 23);
            this.btnCopyProcedure.TabIndex = 6;
            this.btnCopyProcedure.Text = "C";
            this.btnCopyProcedure.UseVisualStyleBackColor = true;
            this.btnCopyProcedure.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbxTreatmentDetails
            // 
            this.gbxTreatmentDetails.Controls.Add(this.btnSelectTreatment);
            this.gbxTreatmentDetails.Controls.Add(this.rtxtTreatmentInfo);
            this.gbxTreatmentDetails.Controls.Add(this.btnPasteTreatment);
            this.gbxTreatmentDetails.Controls.Add(this.btnCopyTreatment);
            this.gbxTreatmentDetails.Location = new System.Drawing.Point(32, 314);
            this.gbxTreatmentDetails.Name = "gbxTreatmentDetails";
            this.gbxTreatmentDetails.Size = new System.Drawing.Size(412, 170);
            this.gbxTreatmentDetails.TabIndex = 5;
            this.gbxTreatmentDetails.TabStop = false;
            this.gbxTreatmentDetails.Text = "Treatment";
            // 
            // btnSelectTreatment
            // 
            this.btnSelectTreatment.Location = new System.Drawing.Point(9, 25);
            this.btnSelectTreatment.Name = "btnSelectTreatment";
            this.btnSelectTreatment.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTreatment.TabIndex = 15;
            this.btnSelectTreatment.Text = "Select";
            this.btnSelectTreatment.UseVisualStyleBackColor = true;
            this.btnSelectTreatment.Click += new System.EventHandler(this.btnSelectTreatment_Click);
            // 
            // rtxtTreatmentInfo
            // 
            this.rtxtTreatmentInfo.Location = new System.Drawing.Point(9, 54);
            this.rtxtTreatmentInfo.Name = "rtxtTreatmentInfo";
            this.rtxtTreatmentInfo.Size = new System.Drawing.Size(391, 106);
            this.rtxtTreatmentInfo.TabIndex = 6;
            this.rtxtTreatmentInfo.Text = "";
            // 
            // btnPasteTreatment
            // 
            this.btnPasteTreatment.Location = new System.Drawing.Point(365, 19);
            this.btnPasteTreatment.Name = "btnPasteTreatment";
            this.btnPasteTreatment.Size = new System.Drawing.Size(28, 23);
            this.btnPasteTreatment.TabIndex = 5;
            this.btnPasteTreatment.Text = "P";
            this.btnPasteTreatment.UseVisualStyleBackColor = true;
            this.btnPasteTreatment.Click += new System.EventHandler(this.btnPasteTreatment_Click);
            // 
            // btnCopyTreatment
            // 
            this.btnCopyTreatment.Location = new System.Drawing.Point(331, 19);
            this.btnCopyTreatment.Name = "btnCopyTreatment";
            this.btnCopyTreatment.Size = new System.Drawing.Size(28, 23);
            this.btnCopyTreatment.TabIndex = 4;
            this.btnCopyTreatment.Text = "C";
            this.btnCopyTreatment.UseVisualStyleBackColor = true;
            this.btnCopyTreatment.Click += new System.EventHandler(this.btnCopyTreatment_Click);
            // 
            // gbxCondition
            // 
            this.gbxCondition.Controls.Add(this.btnSelectCondition);
            this.gbxCondition.Controls.Add(this.rtxtConditionInfo);
            this.gbxCondition.Controls.Add(this.btnPasteCondition);
            this.gbxCondition.Controls.Add(this.btnCopyCondition);
            this.gbxCondition.Location = new System.Drawing.Point(32, 140);
            this.gbxCondition.Name = "gbxCondition";
            this.gbxCondition.Size = new System.Drawing.Size(412, 168);
            this.gbxCondition.TabIndex = 1;
            this.gbxCondition.TabStop = false;
            this.gbxCondition.Text = "Condition";
            // 
            // btnSelectCondition
            // 
            this.btnSelectCondition.Location = new System.Drawing.Point(6, 19);
            this.btnSelectCondition.Name = "btnSelectCondition";
            this.btnSelectCondition.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCondition.TabIndex = 13;
            this.btnSelectCondition.Text = "Select";
            this.btnSelectCondition.UseVisualStyleBackColor = true;
            this.btnSelectCondition.Click += new System.EventHandler(this.btnSelectCondition_Click);
            // 
            // rtxtConditionInfo
            // 
            this.rtxtConditionInfo.Location = new System.Drawing.Point(6, 48);
            this.rtxtConditionInfo.Name = "rtxtConditionInfo";
            this.rtxtConditionInfo.Size = new System.Drawing.Size(400, 109);
            this.rtxtConditionInfo.TabIndex = 12;
            this.rtxtConditionInfo.Text = "";
            // 
            // btnPasteCondition
            // 
            this.btnPasteCondition.Location = new System.Drawing.Point(378, 19);
            this.btnPasteCondition.Name = "btnPasteCondition";
            this.btnPasteCondition.Size = new System.Drawing.Size(28, 23);
            this.btnPasteCondition.TabIndex = 11;
            this.btnPasteCondition.Text = "P";
            this.btnPasteCondition.UseVisualStyleBackColor = true;
            this.btnPasteCondition.Click += new System.EventHandler(this.btnPasteCondition_Click);
            // 
            // btnCopyCondition
            // 
            this.btnCopyCondition.Location = new System.Drawing.Point(344, 19);
            this.btnCopyCondition.Name = "btnCopyCondition";
            this.btnCopyCondition.Size = new System.Drawing.Size(28, 23);
            this.btnCopyCondition.TabIndex = 10;
            this.btnCopyCondition.Text = "C";
            this.btnCopyCondition.UseVisualStyleBackColor = true;
            this.btnCopyCondition.Click += new System.EventHandler(this.btnCopyCondition_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(76, 826);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 60);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(253, 826);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 60);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 897);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxProcedureDetails);
            this.Name = "frmProcedure";
            this.ShowIcon = false;
            this.Text = "Procedure";
            this.Load += new System.EventHandler(this.frmProcedure_Load);
            this.gbxProcedureDetails.ResumeLayout(false);
            this.gbxProcedureDetails.PerformLayout();
            this.gbxPolicy.ResumeLayout(false);
            this.gbxServiceProvider.ResumeLayout(false);
            this.gbxClientDetails.ResumeLayout(false);
            this.gbxTreatmentDetails.ResumeLayout(false);
            this.gbxCondition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProcedureDetails;
        private System.Windows.Forms.GroupBox gbxCondition;
        private System.Windows.Forms.Button btnPasteCondition;
        private System.Windows.Forms.Button btnCopyCondition;
        private System.Windows.Forms.Button btnPasteProcedure;
        private System.Windows.Forms.Button btnCopyProcedure;
        private System.Windows.Forms.GroupBox gbxTreatmentDetails;
        private System.Windows.Forms.Button btnPasteTreatment;
        private System.Windows.Forms.Button btnCopyTreatment;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxClientDetails;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Button btnPasteClient;
        private System.Windows.Forms.Button btnCopyClient;
        private System.Windows.Forms.RichTextBox rtxtClientInfo;
        private System.Windows.Forms.Label lblProcedureID;
        private System.Windows.Forms.RichTextBox rtxtConditionInfo;
        private System.Windows.Forms.Button btnSelectCondition;
        private System.Windows.Forms.Button btnSelectTreatment;
        private System.Windows.Forms.RichTextBox rtxtTreatmentInfo;
        private System.Windows.Forms.GroupBox gbxPolicy;
        private System.Windows.Forms.Button btnSelectPolicy;
        private System.Windows.Forms.RichTextBox rtxtPolicyInfo;
        private System.Windows.Forms.Button btnPastePolicy;
        private System.Windows.Forms.Button btnCopyPolicy;
        private System.Windows.Forms.GroupBox gbxServiceProvider;
        private System.Windows.Forms.Button btnSelectFacility;
        private System.Windows.Forms.RichTextBox rtxtFacilityDisplay;
        private System.Windows.Forms.Button btnPasteFacility;
        private System.Windows.Forms.Button btnCopyFacility;
    }
}