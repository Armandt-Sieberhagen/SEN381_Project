
namespace SEN_Project
{
    partial class Form1
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
            this.btnViewDatabase = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.gbxPersonalDetails = new System.Windows.Forms.GroupBox();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbxContactInfo = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.btnSimulateClient = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbxPersonalDetails.SuspendLayout();
            this.gbxContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewDatabase
            // 
            this.btnViewDatabase.Location = new System.Drawing.Point(12, 610);
            this.btnViewDatabase.Name = "btnViewDatabase";
            this.btnViewDatabase.Size = new System.Drawing.Size(177, 74);
            this.btnViewDatabase.TabIndex = 0;
            this.btnViewDatabase.Text = "View Database";
            this.btnViewDatabase.UseVisualStyleBackColor = true;
            this.btnViewDatabase.Click += new System.EventHandler(this.btnViewDatabase_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(195, 610);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(177, 74);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(378, 610);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(177, 74);
            this.btnUpdateClient.TabIndex = 2;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(561, 610);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(177, 74);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Location = new System.Drawing.Point(744, 610);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(177, 74);
            this.btnSearchClient.TabIndex = 4;
            this.btnSearchClient.Text = "Search Client";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // gbxPersonalDetails
            // 
            this.gbxPersonalDetails.Controls.Add(this.lblIdNumber);
            this.gbxPersonalDetails.Controls.Add(this.lblLastName);
            this.gbxPersonalDetails.Controls.Add(this.lblFirstName);
            this.gbxPersonalDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxPersonalDetails.Name = "gbxPersonalDetails";
            this.gbxPersonalDetails.Size = new System.Drawing.Size(177, 118);
            this.gbxPersonalDetails.TabIndex = 5;
            this.gbxPersonalDetails.TabStop = false;
            this.gbxPersonalDetails.Text = "Personal Details";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(15, 80);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(35, 13);
            this.lblIdNumber.TabIndex = 2;
            this.lblIdNumber.Text = "label3";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "label2";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "label1";
            // 
            // gbxContactInfo
            // 
            this.gbxContactInfo.Controls.Add(this.lblEmail);
            this.gbxContactInfo.Controls.Add(this.lblPhoneNumber);
            this.gbxContactInfo.Location = new System.Drawing.Point(195, 43);
            this.gbxContactInfo.Name = "gbxContactInfo";
            this.gbxContactInfo.Size = new System.Drawing.Size(177, 118);
            this.gbxContactInfo.TabIndex = 6;
            this.gbxContactInfo.TabStop = false;
            this.gbxContactInfo.Text = "Contact Information";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 54);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "lblEmail";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(15, 29);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(35, 13);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "label6";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(12, 9);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(128, 31);
            this.lblClientID.TabIndex = 3;
            this.lblClientID.Text = "Client ID";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(388, 43);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.ReadOnly = true;
            this.rtxtAddress.Size = new System.Drawing.Size(125, 118);
            this.rtxtAddress.TabIndex = 7;
            this.rtxtAddress.Text = "";
            // 
            // btnSimulateClient
            // 
            this.btnSimulateClient.Location = new System.Drawing.Point(927, 610);
            this.btnSimulateClient.Name = "btnSimulateClient";
            this.btnSimulateClient.Size = new System.Drawing.Size(177, 74);
            this.btnSimulateClient.TabIndex = 8;
            this.btnSimulateClient.Text = "Simulate Client";
            this.btnSimulateClient.UseVisualStyleBackColor = true;
            this.btnSimulateClient.Click += new System.EventHandler(this.btnSimulateClient_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(385, 24);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 13);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 696);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnSimulateClient);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.gbxContactInfo);
            this.Controls.Add(this.gbxPersonalDetails);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnViewDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPersonalDetails.ResumeLayout(false);
            this.gbxPersonalDetails.PerformLayout();
            this.gbxContactInfo.ResumeLayout(false);
            this.gbxContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewDatabase;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.GroupBox gbxPersonalDetails;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbxContactInfo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.Button btnSimulateClient;
        private System.Windows.Forms.Label lblAddress;
    }
}

