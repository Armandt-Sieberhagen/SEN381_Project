namespace SEN_Project.PresentationLayer.Forms.ClientOptions
{
    partial class frmAddClient
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rtxtPolicies = new System.Windows.Forms.RichTextBox();
            this.lblPolicies = new System.Windows.Forms.Label();
            this.btnChangePolicies = new System.Windows.Forms.Button();
            this.lbxPerscriptions = new System.Windows.Forms.ListBox();
            this.lblPerscriptions = new System.Windows.Forms.Label();
            this.txtPerscription = new System.Windows.Forms.TextBox();
            this.btnAddPerscription = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePerscription = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewAddress = new System.Windows.Forms.Button();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.lblErrorDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(138, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name*";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(182, 22);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(62, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name*";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(182, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID*";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 86);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 20);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(182, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(182, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 127);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(82, 13);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "Phone Number*";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 143);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // rtxtPolicies
            // 
            this.rtxtPolicies.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtPolicies.Location = new System.Drawing.Point(12, 287);
            this.rtxtPolicies.Name = "rtxtPolicies";
            this.rtxtPolicies.ReadOnly = true;
            this.rtxtPolicies.Size = new System.Drawing.Size(246, 127);
            this.rtxtPolicies.TabIndex = 11;
            this.rtxtPolicies.Text = "";
            // 
            // lblPolicies
            // 
            this.lblPolicies.AutoSize = true;
            this.lblPolicies.Location = new System.Drawing.Point(9, 271);
            this.lblPolicies.Name = "lblPolicies";
            this.lblPolicies.Size = new System.Drawing.Size(88, 13);
            this.lblPolicies.TabIndex = 12;
            this.lblPolicies.Text = "Selected Policies";
            // 
            // btnChangePolicies
            // 
            this.btnChangePolicies.Location = new System.Drawing.Point(12, 420);
            this.btnChangePolicies.Name = "btnChangePolicies";
            this.btnChangePolicies.Size = new System.Drawing.Size(138, 36);
            this.btnChangePolicies.TabIndex = 13;
            this.btnChangePolicies.Text = "Change Policies";
            this.btnChangePolicies.UseVisualStyleBackColor = true;
            this.btnChangePolicies.Click += new System.EventHandler(this.btnChangePolicies_Click);
            // 
            // lbxPerscriptions
            // 
            this.lbxPerscriptions.FormattingEnabled = true;
            this.lbxPerscriptions.Location = new System.Drawing.Point(12, 483);
            this.lbxPerscriptions.Name = "lbxPerscriptions";
            this.lbxPerscriptions.Size = new System.Drawing.Size(246, 147);
            this.lbxPerscriptions.TabIndex = 14;
            this.lbxPerscriptions.SelectedIndexChanged += new System.EventHandler(this.lbxPerscriptions_SelectedIndexChanged);
            // 
            // lblPerscriptions
            // 
            this.lblPerscriptions.AutoSize = true;
            this.lblPerscriptions.Location = new System.Drawing.Point(9, 467);
            this.lblPerscriptions.Name = "lblPerscriptions";
            this.lblPerscriptions.Size = new System.Drawing.Size(100, 13);
            this.lblPerscriptions.TabIndex = 15;
            this.lblPerscriptions.Text = "Active Perscriptions";
            // 
            // txtPerscription
            // 
            this.txtPerscription.Location = new System.Drawing.Point(12, 661);
            this.txtPerscription.Name = "txtPerscription";
            this.txtPerscription.Size = new System.Drawing.Size(118, 20);
            this.txtPerscription.TabIndex = 16;
            this.txtPerscription.TextChanged += new System.EventHandler(this.txtPerscription_TextChanged);
            // 
            // btnAddPerscription
            // 
            this.btnAddPerscription.Enabled = false;
            this.btnAddPerscription.Location = new System.Drawing.Point(12, 687);
            this.btnAddPerscription.Name = "btnAddPerscription";
            this.btnAddPerscription.Size = new System.Drawing.Size(118, 23);
            this.btnAddPerscription.TabIndex = 17;
            this.btnAddPerscription.Text = "AddPerscription";
            this.btnAddPerscription.UseVisualStyleBackColor = true;
            this.btnAddPerscription.Click += new System.EventHandler(this.btnAddPerscription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Perscription";
            // 
            // btnRemovePerscription
            // 
            this.btnRemovePerscription.Enabled = false;
            this.btnRemovePerscription.Location = new System.Drawing.Point(136, 687);
            this.btnRemovePerscription.Name = "btnRemovePerscription";
            this.btnRemovePerscription.Size = new System.Drawing.Size(118, 23);
            this.btnRemovePerscription.TabIndex = 19;
            this.btnRemovePerscription.Text = "Remove Perscription";
            this.btnRemovePerscription.UseVisualStyleBackColor = true;
            this.btnRemovePerscription.Click += new System.EventHandler(this.btnRemovePerscription_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(9, 743);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(156, 43);
            this.btnAddClient.TabIndex = 20;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            this.btnAddClient.MouseHover += new System.EventHandler(this.btnAddClient_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 743);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 43);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewAddress
            // 
            this.btnNewAddress.Location = new System.Drawing.Point(12, 233);
            this.btnNewAddress.Name = "btnNewAddress";
            this.btnNewAddress.Size = new System.Drawing.Size(138, 23);
            this.btnNewAddress.TabIndex = 22;
            this.btnNewAddress.Text = "+New Address";
            this.btnNewAddress.UseVisualStyleBackColor = true;
            this.btnNewAddress.Click += new System.EventHandler(this.btnNewAddress_Click);
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Location = new System.Drawing.Point(182, 233);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(138, 23);
            this.btnSelectAddress.TabIndex = 23;
            this.btnSelectAddress.Text = "Select Existing Address";
            this.btnSelectAddress.UseVisualStyleBackColor = true;
            this.btnSelectAddress.Click += new System.EventHandler(this.btnSelectAddress_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(9, 175);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 13);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address*";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtAddress.Location = new System.Drawing.Point(12, 191);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.ReadOnly = true;
            this.rtxtAddress.Size = new System.Drawing.Size(308, 36);
            this.rtxtAddress.TabIndex = 25;
            this.rtxtAddress.Text = "";
            // 
            // lblErrorDisplay
            // 
            this.lblErrorDisplay.AutoSize = true;
            this.lblErrorDisplay.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorDisplay.Location = new System.Drawing.Point(12, 713);
            this.lblErrorDisplay.Name = "lblErrorDisplay";
            this.lblErrorDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDisplay.TabIndex = 26;
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 798);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorDisplay);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnSelectAddress);
            this.Controls.Add(this.btnNewAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnRemovePerscription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPerscription);
            this.Controls.Add(this.txtPerscription);
            this.Controls.Add(this.lblPerscriptions);
            this.Controls.Add(this.lbxPerscriptions);
            this.Controls.Add(this.btnChangePolicies);
            this.Controls.Add(this.lblPolicies);
            this.Controls.Add(this.rtxtPolicies);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddClient";
            this.Text = "Add Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RichTextBox rtxtPolicies;
        private System.Windows.Forms.Label lblPolicies;
        private System.Windows.Forms.Button btnChangePolicies;
        private System.Windows.Forms.ListBox lbxPerscriptions;
        private System.Windows.Forms.Label lblPerscriptions;
        private System.Windows.Forms.TextBox txtPerscription;
        private System.Windows.Forms.Button btnAddPerscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemovePerscription;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewAddress;
        private System.Windows.Forms.Button btnSelectAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.Label lblErrorDisplay;
    }
}