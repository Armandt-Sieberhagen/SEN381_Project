namespace SEN_Project.PresentationLayer.Conditions
{
    partial class frmCondition
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
            this.gbxCondition = new System.Windows.Forms.GroupBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblConditionDescription = new System.Windows.Forms.Label();
            this.lblConditionName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCondition
            // 
            this.gbxCondition.Controls.Add(this.btnPaste);
            this.gbxCondition.Controls.Add(this.btnCopy);
            this.gbxCondition.Controls.Add(this.rtxtDescription);
            this.gbxCondition.Controls.Add(this.txtName);
            this.gbxCondition.Controls.Add(this.lblConditionDescription);
            this.gbxCondition.Controls.Add(this.lblConditionName);
            this.gbxCondition.Location = new System.Drawing.Point(12, 12);
            this.gbxCondition.Name = "gbxCondition";
            this.gbxCondition.Size = new System.Drawing.Size(228, 216);
            this.gbxCondition.TabIndex = 0;
            this.gbxCondition.TabStop = false;
            this.gbxCondition.Text = "Condition Details";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(191, 19);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(28, 23);
            this.btnPaste.TabIndex = 11;
            this.btnPaste.Text = "P";
            this.btnPaste.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(157, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(28, 23);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "C";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(29, 98);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(190, 96);
            this.rtxtDescription.TabIndex = 3;
            this.rtxtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblConditionDescription
            // 
            this.lblConditionDescription.AutoSize = true;
            this.lblConditionDescription.Location = new System.Drawing.Point(26, 82);
            this.lblConditionDescription.Name = "lblConditionDescription";
            this.lblConditionDescription.Size = new System.Drawing.Size(60, 13);
            this.lblConditionDescription.TabIndex = 1;
            this.lblConditionDescription.Text = "Description";
            // 
            // lblConditionName
            // 
            this.lblConditionName.AutoSize = true;
            this.lblConditionName.Location = new System.Drawing.Point(26, 35);
            this.lblConditionName.Name = "lblConditionName";
            this.lblConditionName.Size = new System.Drawing.Size(35, 13);
            this.lblConditionName.TabIndex = 0;
            this.lblConditionName.Text = "Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(13, 247);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(170, 112);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 112);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 397);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxCondition);
            this.Name = "frmCondition";
            this.Text = "frmCondition";
            this.Load += new System.EventHandler(this.frmCondition_Load);
            this.gbxCondition.ResumeLayout(false);
            this.gbxCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCondition;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblConditionDescription;
        private System.Windows.Forms.Label lblConditionName;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}