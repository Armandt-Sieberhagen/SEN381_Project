namespace SEN_Project.PresentationLayer.Clients
{
    partial class frmClient
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
            this.gbxClient = new System.Windows.Forms.GroupBox();
            this.txtPerscription = new System.Windows.Forms.TextBox();
            this.btnRemovePerscription = new System.Windows.Forms.Button();
            this.btnAddPerscription = new System.Windows.Forms.Button();
            this.lblPerscriptions = new System.Windows.Forms.Label();
            this.lbxPerscriptions = new System.Windows.Forms.ListBox();
            this.btnRemoveCall = new System.Windows.Forms.Button();
            this.btnAddCall = new System.Windows.Forms.Button();
            this.lblCallsHistory = new System.Windows.Forms.Label();
            this.lbxCallsHistory = new System.Windows.Forms.ListBox();
            this.btnPasteClient = new System.Windows.Forms.Button();
            this.btnCopyClient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCopyAddress = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCreateAddress = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClient
            // 
            this.gbxClient.Controls.Add(this.txtPerscription);
            this.gbxClient.Controls.Add(this.btnRemovePerscription);
            this.gbxClient.Controls.Add(this.btnAddPerscription);
            this.gbxClient.Controls.Add(this.lblPerscriptions);
            this.gbxClient.Controls.Add(this.lbxPerscriptions);
            this.gbxClient.Controls.Add(this.btnRemoveCall);
            this.gbxClient.Controls.Add(this.btnAddCall);
            this.gbxClient.Controls.Add(this.lblCallsHistory);
            this.gbxClient.Controls.Add(this.lbxCallsHistory);
            this.gbxClient.Controls.Add(this.btnPasteClient);
            this.gbxClient.Controls.Add(this.btnCopyClient);
            this.gbxClient.Controls.Add(this.button3);
            this.gbxClient.Controls.Add(this.btnCopyAddress);
            this.gbxClient.Controls.Add(this.btnSelect);
            this.gbxClient.Controls.Add(this.btnCreateAddress);
            this.gbxClient.Controls.Add(this.lblAddress);
            this.gbxClient.Controls.Add(this.rtxtAddress);
            this.gbxClient.Controls.Add(this.txtEmail);
            this.gbxClient.Controls.Add(this.lblEmail);
            this.gbxClient.Controls.Add(this.txtPhoneNumber);
            this.gbxClient.Controls.Add(this.lblPhoneNumber);
            this.gbxClient.Controls.Add(this.txtIDNumber);
            this.gbxClient.Controls.Add(this.lblID);
            this.gbxClient.Controls.Add(this.txtLastName);
            this.gbxClient.Controls.Add(this.txtFirstName);
            this.gbxClient.Controls.Add(this.lblLastName);
            this.gbxClient.Controls.Add(this.lblFirstName);
            this.gbxClient.Location = new System.Drawing.Point(12, 12);
            this.gbxClient.Name = "gbxClient";
            this.gbxClient.Size = new System.Drawing.Size(602, 456);
            this.gbxClient.TabIndex = 0;
            this.gbxClient.TabStop = false;
            this.gbxClient.Text = "Client Form";
            // 
            // txtPerscription
            // 
            this.txtPerscription.Location = new System.Drawing.Point(149, 416);
            this.txtPerscription.Name = "txtPerscription";
            this.txtPerscription.Size = new System.Drawing.Size(142, 20);
            this.txtPerscription.TabIndex = 47;
            this.txtPerscription.TextChanged += new System.EventHandler(this.txtPerscription_TextChanged);
            // 
            // btnRemovePerscription
            // 
            this.btnRemovePerscription.Location = new System.Drawing.Point(379, 416);
            this.btnRemovePerscription.Name = "btnRemovePerscription";
            this.btnRemovePerscription.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePerscription.TabIndex = 46;
            this.btnRemovePerscription.Text = "Remove";
            this.btnRemovePerscription.UseVisualStyleBackColor = true;
            this.btnRemovePerscription.Click += new System.EventHandler(this.btnRemovePerscription_Click);
            // 
            // btnAddPerscription
            // 
            this.btnAddPerscription.Location = new System.Drawing.Point(296, 416);
            this.btnAddPerscription.Name = "btnAddPerscription";
            this.btnAddPerscription.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerscription.TabIndex = 45;
            this.btnAddPerscription.Text = "Add";
            this.btnAddPerscription.UseVisualStyleBackColor = true;
            this.btnAddPerscription.Click += new System.EventHandler(this.btnAddPerscription_Click);
            // 
            // lblPerscriptions
            // 
            this.lblPerscriptions.AutoSize = true;
            this.lblPerscriptions.Location = new System.Drawing.Point(146, 299);
            this.lblPerscriptions.Name = "lblPerscriptions";
            this.lblPerscriptions.Size = new System.Drawing.Size(100, 13);
            this.lblPerscriptions.TabIndex = 44;
            this.lblPerscriptions.Text = "Active Perscriptions";
            // 
            // lbxPerscriptions
            // 
            this.lbxPerscriptions.FormattingEnabled = true;
            this.lbxPerscriptions.Location = new System.Drawing.Point(149, 315);
            this.lbxPerscriptions.Name = "lbxPerscriptions";
            this.lbxPerscriptions.Size = new System.Drawing.Size(306, 95);
            this.lbxPerscriptions.TabIndex = 43;
            this.lbxPerscriptions.SelectedIndexChanged += new System.EventHandler(this.lbxPerscriptions_SelectedIndexChanged);
            // 
            // btnRemoveCall
            // 
            this.btnRemoveCall.Location = new System.Drawing.Point(477, 258);
            this.btnRemoveCall.Name = "btnRemoveCall";
            this.btnRemoveCall.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCall.TabIndex = 36;
            this.btnRemoveCall.Text = "Remove";
            this.btnRemoveCall.UseVisualStyleBackColor = true;
            this.btnRemoveCall.Click += new System.EventHandler(this.btnRemoveCall_Click);
            // 
            // btnAddCall
            // 
            this.btnAddCall.Location = new System.Drawing.Point(382, 258);
            this.btnAddCall.Name = "btnAddCall";
            this.btnAddCall.Size = new System.Drawing.Size(75, 23);
            this.btnAddCall.TabIndex = 31;
            this.btnAddCall.Text = "Add";
            this.btnAddCall.UseVisualStyleBackColor = true;
            this.btnAddCall.Click += new System.EventHandler(this.btnAddCall_Click);
            // 
            // lblCallsHistory
            // 
            this.lblCallsHistory.AutoSize = true;
            this.lblCallsHistory.Location = new System.Drawing.Point(367, 141);
            this.lblCallsHistory.Name = "lblCallsHistory";
            this.lblCallsHistory.Size = new System.Drawing.Size(64, 13);
            this.lblCallsHistory.TabIndex = 30;
            this.lblCallsHistory.Text = "Calls History";
            // 
            // lbxCallsHistory
            // 
            this.lbxCallsHistory.FormattingEnabled = true;
            this.lbxCallsHistory.Location = new System.Drawing.Point(370, 157);
            this.lbxCallsHistory.Name = "lbxCallsHistory";
            this.lbxCallsHistory.Size = new System.Drawing.Size(191, 95);
            this.lbxCallsHistory.TabIndex = 29;
            this.lbxCallsHistory.SelectedIndexChanged += new System.EventHandler(this.lbxCallsHistory_SelectedIndexChanged);
            // 
            // btnPasteClient
            // 
            this.btnPasteClient.Location = new System.Drawing.Point(551, 16);
            this.btnPasteClient.Name = "btnPasteClient";
            this.btnPasteClient.Size = new System.Drawing.Size(27, 23);
            this.btnPasteClient.TabIndex = 22;
            this.btnPasteClient.Text = "P";
            this.btnPasteClient.UseVisualStyleBackColor = true;
            this.btnPasteClient.Click += new System.EventHandler(this.btnPasteClient_Click);
            // 
            // btnCopyClient
            // 
            this.btnCopyClient.Location = new System.Drawing.Point(518, 16);
            this.btnCopyClient.Name = "btnCopyClient";
            this.btnCopyClient.Size = new System.Drawing.Size(27, 23);
            this.btnCopyClient.TabIndex = 21;
            this.btnCopyClient.Text = "C";
            this.btnCopyClient.UseVisualStyleBackColor = true;
            this.btnCopyClient.Click += new System.EventHandler(this.btnCopyClient_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "P";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCopyAddress
            // 
            this.btnCopyAddress.Location = new System.Drawing.Point(282, 155);
            this.btnCopyAddress.Name = "btnCopyAddress";
            this.btnCopyAddress.Size = new System.Drawing.Size(27, 23);
            this.btnCopyAddress.TabIndex = 17;
            this.btnCopyAddress.Text = "C";
            this.btnCopyAddress.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(186, 259);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCreateAddress
            // 
            this.btnCreateAddress.Location = new System.Drawing.Point(44, 259);
            this.btnCreateAddress.Name = "btnCreateAddress";
            this.btnCreateAddress.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAddress.TabIndex = 12;
            this.btnCreateAddress.Text = "Create";
            this.btnCreateAddress.UseVisualStyleBackColor = true;
            this.btnCreateAddress.Click += new System.EventHandler(this.btnCreateAddress_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(33, 141);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address Details";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(36, 157);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.ReadOnly = true;
            this.rtxtAddress.Size = new System.Drawing.Size(234, 96);
            this.rtxtAddress.TabIndex = 10;
            this.rtxtAddress.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(184, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(181, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email Address";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(20, 101);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(158, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 85);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(348, 56);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(158, 20);
            this.txtIDNumber.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(345, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(184, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(20, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(181, 40);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(161, 474);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 60);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(315, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 60);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 549);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxClient);
            this.Name = "frmClient";
            this.ShowIcon = false;
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.gbxClient.ResumeLayout(false);
            this.gbxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClient;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCreateAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCopyAddress;
        private System.Windows.Forms.Button btnPasteClient;
        private System.Windows.Forms.Button btnCopyClient;
        private System.Windows.Forms.TextBox txtPerscription;
        private System.Windows.Forms.Button btnRemovePerscription;
        private System.Windows.Forms.Button btnAddPerscription;
        private System.Windows.Forms.Label lblPerscriptions;
        private System.Windows.Forms.ListBox lbxPerscriptions;
        private System.Windows.Forms.Button btnRemoveCall;
        private System.Windows.Forms.Button btnAddCall;
        private System.Windows.Forms.Label lblCallsHistory;
        private System.Windows.Forms.ListBox lbxCallsHistory;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}