namespace SEN_Project.PresentationLayer.PolicyDetails
{
    partial class frmPolicyDetails
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
            this.gbxPolicyDataDetails = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.btnChangeTreatments = new System.Windows.Forms.Button();
            this.lblTreatmentsCovered = new System.Windows.Forms.Label();
            this.rtxtTreatmentCovered = new System.Windows.Forms.RichTextBox();
            this.rtxtPolicyDescription = new System.Windows.Forms.RichTextBox();
            this.txtPolicyName = new System.Windows.Forms.TextBox();
            this.lblPolicyDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxPolicyDataDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPolicyDataDetails
            // 
            this.gbxPolicyDataDetails.Controls.Add(this.lblPrice);
            this.gbxPolicyDataDetails.Controls.Add(this.btnPaste);
            this.gbxPolicyDataDetails.Controls.Add(this.btnCopy);
            this.gbxPolicyDataDetails.Controls.Add(this.numPrice);
            this.gbxPolicyDataDetails.Controls.Add(this.cbxAvailable);
            this.gbxPolicyDataDetails.Controls.Add(this.btnChangeTreatments);
            this.gbxPolicyDataDetails.Controls.Add(this.lblTreatmentsCovered);
            this.gbxPolicyDataDetails.Controls.Add(this.rtxtTreatmentCovered);
            this.gbxPolicyDataDetails.Controls.Add(this.rtxtPolicyDescription);
            this.gbxPolicyDataDetails.Controls.Add(this.txtPolicyName);
            this.gbxPolicyDataDetails.Controls.Add(this.lblPolicyDescription);
            this.gbxPolicyDataDetails.Controls.Add(this.lblName);
            this.gbxPolicyDataDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPolicyDataDetails.Location = new System.Drawing.Point(12, 12);
            this.gbxPolicyDataDetails.Name = "gbxPolicyDataDetails";
            this.gbxPolicyDataDetails.Size = new System.Drawing.Size(311, 490);
            this.gbxPolicyDataDetails.TabIndex = 0;
            this.gbxPolicyDataDetails.TabStop = false;
            this.gbxPolicyDataDetails.Text = "Policy Details";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 398);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(269, 15);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(33, 23);
            this.btnPaste.TabIndex = 14;
            this.btnPaste.Text = "P";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(229, 15);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(33, 23);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "C";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(9, 416);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 21);
            this.numPrice.TabIndex = 12;
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAvailable.Location = new System.Drawing.Point(9, 458);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(83, 20);
            this.cbxAvailable.TabIndex = 11;
            this.cbxAvailable.Text = "Available";
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // btnChangeTreatments
            // 
            this.btnChangeTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTreatments.Location = new System.Drawing.Point(65, 369);
            this.btnChangeTreatments.Name = "btnChangeTreatments";
            this.btnChangeTreatments.Size = new System.Drawing.Size(178, 25);
            this.btnChangeTreatments.TabIndex = 10;
            this.btnChangeTreatments.Text = "Change Selection";
            this.btnChangeTreatments.UseVisualStyleBackColor = true;
            this.btnChangeTreatments.Click += new System.EventHandler(this.btnChangeTreatments_Click);
            // 
            // lblTreatmentsCovered
            // 
            this.lblTreatmentsCovered.AutoSize = true;
            this.lblTreatmentsCovered.Location = new System.Drawing.Point(6, 215);
            this.lblTreatmentsCovered.Name = "lblTreatmentsCovered";
            this.lblTreatmentsCovered.Size = new System.Drawing.Size(117, 15);
            this.lblTreatmentsCovered.TabIndex = 9;
            this.lblTreatmentsCovered.Text = "Treatments Covered";
            // 
            // rtxtTreatmentCovered
            // 
            this.rtxtTreatmentCovered.Location = new System.Drawing.Point(9, 231);
            this.rtxtTreatmentCovered.Name = "rtxtTreatmentCovered";
            this.rtxtTreatmentCovered.ReadOnly = true;
            this.rtxtTreatmentCovered.Size = new System.Drawing.Size(296, 123);
            this.rtxtTreatmentCovered.TabIndex = 8;
            this.rtxtTreatmentCovered.Text = "";
            this.rtxtTreatmentCovered.TextChanged += new System.EventHandler(this.rtxtTreatmentCovered_TextChanged);
            // 
            // rtxtPolicyDescription
            // 
            this.rtxtPolicyDescription.Location = new System.Drawing.Point(9, 83);
            this.rtxtPolicyDescription.Name = "rtxtPolicyDescription";
            this.rtxtPolicyDescription.Size = new System.Drawing.Size(296, 125);
            this.rtxtPolicyDescription.TabIndex = 7;
            this.rtxtPolicyDescription.Text = "";
            // 
            // txtPolicyName
            // 
            this.txtPolicyName.Location = new System.Drawing.Point(88, 36);
            this.txtPolicyName.Name = "txtPolicyName";
            this.txtPolicyName.Size = new System.Drawing.Size(109, 21);
            this.txtPolicyName.TabIndex = 6;
            // 
            // lblPolicyDescription
            // 
            this.lblPolicyDescription.AutoSize = true;
            this.lblPolicyDescription.Location = new System.Drawing.Point(6, 67);
            this.lblPolicyDescription.Name = "lblPolicyDescription";
            this.lblPolicyDescription.Size = new System.Drawing.Size(69, 15);
            this.lblPolicyDescription.TabIndex = 5;
            this.lblPolicyDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Policy Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(34, 520);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 59);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(176, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 59);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPolicyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 592);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxPolicyDataDetails);
            this.Name = "frmPolicyDetails";
            this.ShowIcon = false;
            this.Text = "Policy Details";
            this.Load += new System.EventHandler(this.frmPolicyDetails_Load);
            this.gbxPolicyDataDetails.ResumeLayout(false);
            this.gbxPolicyDataDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPolicyDataDetails;
        private System.Windows.Forms.RichTextBox rtxtPolicyDescription;
        private System.Windows.Forms.TextBox txtPolicyName;
        private System.Windows.Forms.Label lblPolicyDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.CheckBox cbxAvailable;
        private System.Windows.Forms.Button btnChangeTreatments;
        private System.Windows.Forms.Label lblTreatmentsCovered;
        private System.Windows.Forms.RichTextBox rtxtTreatmentCovered;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrice;
    }
}