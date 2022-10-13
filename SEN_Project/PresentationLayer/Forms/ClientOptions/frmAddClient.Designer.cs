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
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(138, 20);
            this.txtFirstName.TabIndex = 0;
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
            // 
            // rtxtPolicies
            // 
            this.rtxtPolicies.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtPolicies.Location = new System.Drawing.Point(12, 209);
            this.rtxtPolicies.Name = "rtxtPolicies";
            this.rtxtPolicies.ReadOnly = true;
            this.rtxtPolicies.Size = new System.Drawing.Size(246, 127);
            this.rtxtPolicies.TabIndex = 11;
            this.rtxtPolicies.Text = "";
            // 
            // lblPolicies
            // 
            this.lblPolicies.AutoSize = true;
            this.lblPolicies.Location = new System.Drawing.Point(9, 193);
            this.lblPolicies.Name = "lblPolicies";
            this.lblPolicies.Size = new System.Drawing.Size(88, 13);
            this.lblPolicies.TabIndex = 12;
            this.lblPolicies.Text = "Selected Policies";
            // 
            // btnChangePolicies
            // 
            this.btnChangePolicies.Location = new System.Drawing.Point(12, 342);
            this.btnChangePolicies.Name = "btnChangePolicies";
            this.btnChangePolicies.Size = new System.Drawing.Size(138, 36);
            this.btnChangePolicies.TabIndex = 13;
            this.btnChangePolicies.Text = "Change Policies";
            this.btnChangePolicies.UseVisualStyleBackColor = true;
            this.btnChangePolicies.Click += new System.EventHandler(this.btnChangePolicies_Click);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 665);
            this.ControlBox = false;
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
    }
}