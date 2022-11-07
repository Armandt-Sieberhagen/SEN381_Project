
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
            this.btnFacilityManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Location = new System.Drawing.Point(12, 12);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(231, 127);
            this.btnCallCentre.TabIndex = 10;
            this.btnCallCentre.Text = "Open Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPolicy
            // 
            this.btnPolicy.Location = new System.Drawing.Point(249, 145);
            this.btnPolicy.Name = "btnPolicy";
            this.btnPolicy.Size = new System.Drawing.Size(231, 127);
            this.btnPolicy.TabIndex = 11;
            this.btnPolicy.Text = "Policy Management";
            this.btnPolicy.UseVisualStyleBackColor = true;
            this.btnPolicy.Click += new System.EventHandler(this.btnPolicy_Click);
            // 
            // btnTreatmentManagement
            // 
            this.btnTreatmentManagement.Location = new System.Drawing.Point(12, 145);
            this.btnTreatmentManagement.Name = "btnTreatmentManagement";
            this.btnTreatmentManagement.Size = new System.Drawing.Size(231, 127);
            this.btnTreatmentManagement.TabIndex = 12;
            this.btnTreatmentManagement.Text = "Open Treatment Management";
            this.btnTreatmentManagement.UseVisualStyleBackColor = true;
            this.btnTreatmentManagement.Click += new System.EventHandler(this.btnTreatmentManagement_Click);
            // 
            // btnConditionCentre
            // 
            this.btnConditionCentre.Location = new System.Drawing.Point(249, 12);
            this.btnConditionCentre.Name = "btnConditionCentre";
            this.btnConditionCentre.Size = new System.Drawing.Size(231, 127);
            this.btnConditionCentre.TabIndex = 13;
            this.btnConditionCentre.Text = "Open Condition Centre";
            this.btnConditionCentre.UseVisualStyleBackColor = true;
            this.btnConditionCentre.Click += new System.EventHandler(this.btnConditionCentre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 127);
            this.button1.TabIndex = 14;
            this.button1.Text = "Open Condition Centre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnFacilityManagement
            // 
            this.btnFacilityManagement.Location = new System.Drawing.Point(486, 144);
            this.btnFacilityManagement.Name = "btnFacilityManagement";
            this.btnFacilityManagement.Size = new System.Drawing.Size(231, 127);
            this.btnFacilityManagement.TabIndex = 15;
            this.btnFacilityManagement.Text = "Facility Managmenet";
            this.btnFacilityManagement.UseVisualStyleBackColor = true;
            this.btnFacilityManagement.Click += new System.EventHandler(this.btnFacilityManagement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 696);
            this.Controls.Add(this.btnFacilityManagement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConditionCentre);
            this.Controls.Add(this.btnTreatmentManagement);
            this.Controls.Add(this.btnPolicy);
            this.Controls.Add(this.btnCallCentre);
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
        private System.Windows.Forms.Button btnFacilityManagement;
    }
}

