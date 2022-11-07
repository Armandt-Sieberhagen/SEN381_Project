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
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.gbxServiceProvider = new System.Windows.Forms.GroupBox();
            this.btnSelectFacility = new System.Windows.Forms.Button();
            this.rtxtFacilityDisplay = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.gbxClientDetails = new System.Windows.Forms.GroupBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.btnPasteClient = new System.Windows.Forms.Button();
            this.btnCopyClient = new System.Windows.Forms.Button();
            this.rtxtClientInfo = new System.Windows.Forms.RichTextBox();
            this.lblProcedureID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbxTreatmentDetails = new System.Windows.Forms.GroupBox();
            this.btnSelectTreatment = new System.Windows.Forms.Button();
            this.rtxtTreatmentInfo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.gbxProcedureDetails.Controls.Add(this.button3);
            this.gbxProcedureDetails.Controls.Add(this.button4);
            this.gbxProcedureDetails.Controls.Add(this.gbxTreatmentDetails);
            this.gbxProcedureDetails.Controls.Add(this.gbxCondition);
            this.gbxProcedureDetails.Location = new System.Drawing.Point(11, 12);
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
            this.gbxPolicy.Controls.Add(this.button8);
            this.gbxPolicy.Controls.Add(this.button9);
            this.gbxPolicy.Location = new System.Drawing.Point(32, 672);
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
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(365, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "P";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(331, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "C";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // gbxServiceProvider
            // 
            this.gbxServiceProvider.Controls.Add(this.btnSelectFacility);
            this.gbxServiceProvider.Controls.Add(this.rtxtFacilityDisplay);
            this.gbxServiceProvider.Controls.Add(this.button6);
            this.gbxServiceProvider.Controls.Add(this.button7);
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(365, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "P";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(331, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "C";
            this.button7.UseVisualStyleBackColor = true;
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
            // 
            // btnCopyClient
            // 
            this.btnCopyClient.Location = new System.Drawing.Point(210, 17);
            this.btnCopyClient.Name = "btnCopyClient";
            this.btnCopyClient.Size = new System.Drawing.Size(28, 23);
            this.btnCopyClient.TabIndex = 13;
            this.btnCopyClient.Text = "C";
            this.btnCopyClient.UseVisualStyleBackColor = true;
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
            this.lblProcedureID.Location = new System.Drawing.Point(29, 24);
            this.lblProcedureID.Name = "lblProcedureID";
            this.lblProcedureID.Size = new System.Drawing.Size(73, 13);
            this.lblProcedureID.TabIndex = 9;
            this.lblProcedureID.Text = "Procedure ID:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "P";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gbxTreatmentDetails
            // 
            this.gbxTreatmentDetails.Controls.Add(this.btnSelectTreatment);
            this.gbxTreatmentDetails.Controls.Add(this.rtxtTreatmentInfo);
            this.gbxTreatmentDetails.Controls.Add(this.button1);
            this.gbxTreatmentDetails.Controls.Add(this.button2);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "P";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // btnCopyCondition
            // 
            this.btnCopyCondition.Location = new System.Drawing.Point(344, 19);
            this.btnCopyCondition.Name = "btnCopyCondition";
            this.btnCopyCondition.Size = new System.Drawing.Size(28, 23);
            this.btnCopyCondition.TabIndex = 10;
            this.btnCopyCondition.Text = "C";
            this.btnCopyCondition.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(43, 826);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(171, 69);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 826);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 69);
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
            this.Text = "frmProcedure";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gbxTreatmentDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox gbxServiceProvider;
        private System.Windows.Forms.Button btnSelectFacility;
        private System.Windows.Forms.RichTextBox rtxtFacilityDisplay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}