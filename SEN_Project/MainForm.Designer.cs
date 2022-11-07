
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
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.btnPolicy = new System.Windows.Forms.Button();
            this.btnTreatmentManagement = new System.Windows.Forms.Button();
            this.btnConditionCentre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Location = new System.Drawing.Point(16, 15);
            this.btnCallCentre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(308, 156);
            this.btnCallCentre.TabIndex = 10;
            this.btnCallCentre.Text = "Open Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPolicy
            // 
            this.btnPolicy.Location = new System.Drawing.Point(332, 178);
            this.btnPolicy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPolicy.Name = "btnPolicy";
            this.btnPolicy.Size = new System.Drawing.Size(308, 156);
            this.btnPolicy.TabIndex = 11;
            this.btnPolicy.Text = "Policy Management";
            this.btnPolicy.UseVisualStyleBackColor = true;
            this.btnPolicy.Click += new System.EventHandler(this.btnPolicy_Click);
            // 
            // btnTreatmentManagement
            // 
            this.btnTreatmentManagement.Location = new System.Drawing.Point(16, 178);
            this.btnTreatmentManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTreatmentManagement.Name = "btnTreatmentManagement";
            this.btnTreatmentManagement.Size = new System.Drawing.Size(308, 156);
            this.btnTreatmentManagement.TabIndex = 12;
            this.btnTreatmentManagement.Text = "Open Treatment Management";
            this.btnTreatmentManagement.UseVisualStyleBackColor = true;
            this.btnTreatmentManagement.Click += new System.EventHandler(this.btnTreatmentManagement_Click);
            // 
            // btnConditionCentre
            // 
            this.btnConditionCentre.Location = new System.Drawing.Point(332, 15);
            this.btnConditionCentre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConditionCentre.Name = "btnConditionCentre";
            this.btnConditionCentre.Size = new System.Drawing.Size(308, 156);
            this.btnConditionCentre.TabIndex = 13;
            this.btnConditionCentre.Text = "Open Condition Centre";
            this.btnConditionCentre.UseVisualStyleBackColor = true;
            this.btnConditionCentre.Click += new System.EventHandler(this.btnConditionCentre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 156);
            this.button1.TabIndex = 14;
            this.button1.Text = "Open Condition Centre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 857);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConditionCentre);
            this.Controls.Add(this.btnTreatmentManagement);
            this.Controls.Add(this.btnPolicy);
            this.Controls.Add(this.btnCallCentre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCallCentre;
        private System.Windows.Forms.Button btnPolicy;
        private System.Windows.Forms.Button btnTreatmentManagement;
        private System.Windows.Forms.Button btnConditionCentre;
        private System.Windows.Forms.Button button1;
    }
}

