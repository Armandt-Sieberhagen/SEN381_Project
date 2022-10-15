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
            this.lblTreatmentDesc = new System.Windows.Forms.Label();
            this.rtxtDescr = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTreatmentDesc
            // 
            this.lblTreatmentDesc.AutoSize = true;
            this.lblTreatmentDesc.Location = new System.Drawing.Point(9, 9);
            this.lblTreatmentDesc.Name = "lblTreatmentDesc";
            this.lblTreatmentDesc.Size = new System.Drawing.Size(114, 13);
            this.lblTreatmentDesc.TabIndex = 0;
            this.lblTreatmentDesc.Text = "Treatment Description:";
            // 
            // rtxtDescr
            // 
            this.rtxtDescr.Location = new System.Drawing.Point(12, 25);
            this.rtxtDescr.Name = "rtxtDescr";
            this.rtxtDescr.Size = new System.Drawing.Size(202, 96);
            this.rtxtDescr.TabIndex = 1;
            this.rtxtDescr.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 127);
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
            this.btnCancel.Location = new System.Drawing.Point(117, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 77);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // frmTreatmentAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(235, 216);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtxtDescr);
            this.Controls.Add(this.lblTreatmentDesc);
            this.Name = "frmTreatmentAddEdit";
            this.Text = "Treatment";
            this.Load += new System.EventHandler(this.frmTreatmentAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTreatmentDesc;
        private System.Windows.Forms.RichTextBox rtxtDescr;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}