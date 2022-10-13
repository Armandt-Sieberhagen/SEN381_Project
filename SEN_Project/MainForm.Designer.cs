
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
            this.btnViewDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewDatabase
            // 
            this.btnViewDatabase.Location = new System.Drawing.Point(12, 610);
            this.btnViewDatabase.Name = "btnViewDatabase";
            this.btnViewDatabase.Size = new System.Drawing.Size(177, 74);
            this.btnViewDatabase.TabIndex = 0;
            this.btnViewDatabase.Text = "View Database";
            this.btnViewDatabase.UseVisualStyleBackColor = true;
            this.btnViewDatabase.Click += new System.EventHandler(this.btnViewDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 696);
            this.Controls.Add(this.btnViewDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewDatabase;
    }
}

