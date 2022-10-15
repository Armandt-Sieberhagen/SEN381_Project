namespace SEN_Project.PresentationLayer.PolicyData
{
    partial class frmPolicyDataAddEdit
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
            this.rtxtPolicyDescription = new System.Windows.Forms.RichTextBox();
            this.lblPolicyname = new System.Windows.Forms.Label();
            this.txtPolicyName = new System.Windows.Forms.TextBox();
            this.lblPolicyDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.rtxtTreatmentsCovered = new System.Windows.Forms.RichTextBox();
            this.lblTreatmentsCovered = new System.Windows.Forms.Label();
            this.btnChangeTreatments = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtPolicyDescription
            // 
            this.rtxtPolicyDescription.Location = new System.Drawing.Point(12, 77);
            this.rtxtPolicyDescription.Name = "rtxtPolicyDescription";
            this.rtxtPolicyDescription.Size = new System.Drawing.Size(194, 127);
            this.rtxtPolicyDescription.TabIndex = 0;
            this.rtxtPolicyDescription.Text = "";
            // 
            // lblPolicyname
            // 
            this.lblPolicyname.AutoSize = true;
            this.lblPolicyname.Location = new System.Drawing.Point(12, 9);
            this.lblPolicyname.Name = "lblPolicyname";
            this.lblPolicyname.Size = new System.Drawing.Size(69, 13);
            this.lblPolicyname.TabIndex = 1;
            this.lblPolicyname.Text = "Policy Name:";
            this.lblPolicyname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPolicyName
            // 
            this.txtPolicyName.Location = new System.Drawing.Point(12, 25);
            this.txtPolicyName.Name = "txtPolicyName";
            this.txtPolicyName.Size = new System.Drawing.Size(100, 20);
            this.txtPolicyName.TabIndex = 2;
            // 
            // lblPolicyDescription
            // 
            this.lblPolicyDescription.AutoSize = true;
            this.lblPolicyDescription.Location = new System.Drawing.Point(12, 61);
            this.lblPolicyDescription.Name = "lblPolicyDescription";
            this.lblPolicyDescription.Size = new System.Drawing.Size(94, 13);
            this.lblPolicyDescription.TabIndex = 3;
            this.lblPolicyDescription.Text = "Policy Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(9, 216);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(12, 244);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 5;
            // 
            // rtxtTreatmentsCovered
            // 
            this.rtxtTreatmentsCovered.Location = new System.Drawing.Point(12, 292);
            this.rtxtTreatmentsCovered.Name = "rtxtTreatmentsCovered";
            this.rtxtTreatmentsCovered.ReadOnly = true;
            this.rtxtTreatmentsCovered.Size = new System.Drawing.Size(194, 127);
            this.rtxtTreatmentsCovered.TabIndex = 6;
            this.rtxtTreatmentsCovered.Text = "";
            // 
            // lblTreatmentsCovered
            // 
            this.lblTreatmentsCovered.AutoSize = true;
            this.lblTreatmentsCovered.Location = new System.Drawing.Point(9, 276);
            this.lblTreatmentsCovered.Name = "lblTreatmentsCovered";
            this.lblTreatmentsCovered.Size = new System.Drawing.Size(106, 13);
            this.lblTreatmentsCovered.TabIndex = 7;
            this.lblTreatmentsCovered.Text = "Treatments Covered:";
            // 
            // btnChangeTreatments
            // 
            this.btnChangeTreatments.Location = new System.Drawing.Point(12, 425);
            this.btnChangeTreatments.Name = "btnChangeTreatments";
            this.btnChangeTreatments.Size = new System.Drawing.Size(194, 23);
            this.btnChangeTreatments.TabIndex = 8;
            this.btnChangeTreatments.Text = "Change Treatment Selection";
            this.btnChangeTreatments.UseVisualStyleBackColor = true;
            this.btnChangeTreatments.Click += new System.EventHandler(this.btnChangeTreatments_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(35, 463);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(161, 70);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(35, 539);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 70);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPolicyDataAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 627);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnChangeTreatments);
            this.Controls.Add(this.lblTreatmentsCovered);
            this.Controls.Add(this.rtxtTreatmentsCovered);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPolicyDescription);
            this.Controls.Add(this.txtPolicyName);
            this.Controls.Add(this.lblPolicyname);
            this.Controls.Add(this.rtxtPolicyDescription);
            this.Name = "frmPolicyDataAddEdit";
            this.Text = "frmPolicyDataAddEdit";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtPolicyDescription;
        private System.Windows.Forms.Label lblPolicyname;
        private System.Windows.Forms.TextBox txtPolicyName;
        private System.Windows.Forms.Label lblPolicyDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.RichTextBox rtxtTreatmentsCovered;
        private System.Windows.Forms.Label lblTreatmentsCovered;
        private System.Windows.Forms.Button btnChangeTreatments;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}