
namespace SEN_Project.PresentationLayer
{
    partial class DatabaseForm
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
            this.btnClientCenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientCenter
            // 
            this.btnClientCenter.Location = new System.Drawing.Point(856, 12);
            this.btnClientCenter.Name = "btnClientCenter";
            this.btnClientCenter.Size = new System.Drawing.Size(230, 104);
            this.btnClientCenter.TabIndex = 0;
            this.btnClientCenter.Text = "Return to Client Center";
            this.btnClientCenter.UseVisualStyleBackColor = true;
            this.btnClientCenter.Click += new System.EventHandler(this.btnClientCenter_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 578);
            this.Controls.Add(this.btnClientCenter);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientCenter;
    }
}