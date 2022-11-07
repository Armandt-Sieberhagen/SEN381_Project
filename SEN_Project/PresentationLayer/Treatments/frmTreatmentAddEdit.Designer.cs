namespace SEN_Project.PresentationLayer.Treatments
{
    partial class frmTreatmentAddEdit
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxTreatmentDetails = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblConditionsCovered = new System.Windows.Forms.Label();
            this.lbxConditionsCovered = new System.Windows.Forms.ListBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtTreatmentName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxTreatmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(76, 549);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 77);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.MouseEnter += new System.EventHandler(this.btnConfirm_MouseEnter);
            this.btnConfirm.MouseLeave += new System.EventHandler(this.btnConfirm_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 77);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // gbxTreatmentDetails
            // 
            this.gbxTreatmentDetails.Controls.Add(this.btnSelect);
            this.gbxTreatmentDetails.Controls.Add(this.lblConditionsCovered);
            this.gbxTreatmentDetails.Controls.Add(this.lbxConditionsCovered);
            this.gbxTreatmentDetails.Controls.Add(this.btnPaste);
            this.gbxTreatmentDetails.Controls.Add(this.btnCopy);
            this.gbxTreatmentDetails.Controls.Add(this.rtxtDescription);
            this.gbxTreatmentDetails.Controls.Add(this.txtTreatmentName);
            this.gbxTreatmentDetails.Controls.Add(this.lblDescription);
            this.gbxTreatmentDetails.Controls.Add(this.lblName);
            this.gbxTreatmentDetails.Location = new System.Drawing.Point(12, 12);
            this.gbxTreatmentDetails.Name = "gbxTreatmentDetails";
            this.gbxTreatmentDetails.Size = new System.Drawing.Size(412, 531);
            this.gbxTreatmentDetails.TabIndex = 4;
            this.gbxTreatmentDetails.TabStop = false;
            this.gbxTreatmentDetails.Text = "Treatment Details";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(26, 267);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(135, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Change Selection";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblConditionsCovered
            // 
            this.lblConditionsCovered.AutoSize = true;
            this.lblConditionsCovered.Location = new System.Drawing.Point(23, 241);
            this.lblConditionsCovered.Name = "lblConditionsCovered";
            this.lblConditionsCovered.Size = new System.Drawing.Size(99, 13);
            this.lblConditionsCovered.TabIndex = 7;
            this.lblConditionsCovered.Text = "Conditions Covered";
            // 
            // lbxConditionsCovered
            // 
            this.lbxConditionsCovered.FormattingEnabled = true;
            this.lbxConditionsCovered.Location = new System.Drawing.Point(26, 296);
            this.lbxConditionsCovered.Name = "lbxConditionsCovered";
            this.lbxConditionsCovered.Size = new System.Drawing.Size(367, 212);
            this.lbxConditionsCovered.TabIndex = 6;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(365, 19);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(28, 23);
            this.btnPaste.TabIndex = 5;
            this.btnPaste.Text = "P";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(331, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(28, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "C";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(26, 104);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(213, 118);
            this.rtxtDescription.TabIndex = 3;
            this.rtxtDescription.Text = "";
            // 
            // txtTreatmentName
            // 
            this.txtTreatmentName.Location = new System.Drawing.Point(26, 50);
            this.txtTreatmentName.Name = "txtTreatmentName";
            this.txtTreatmentName.Size = new System.Drawing.Size(100, 20);
            this.txtTreatmentName.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Treatment Name";
            // 
            // frmTreatmentAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(442, 640);
            this.ControlBox = false;
            this.Controls.Add(this.gbxTreatmentDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmTreatmentAddEdit";
            this.Text = "Treatment";
            this.Load += new System.EventHandler(this.frmTreatmentAddEdit_Load);
            this.gbxTreatmentDetails.ResumeLayout(false);
            this.gbxTreatmentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxTreatmentDetails;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtTreatmentName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblConditionsCovered;
        private System.Windows.Forms.ListBox lbxConditionsCovered;
        private System.Windows.Forms.Button btnSelect;
    }
}