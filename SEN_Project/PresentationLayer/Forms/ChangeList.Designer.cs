namespace SEN_Project.PresentationLayer.Forms
{
    partial class ChangeList
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
            this.lbxAll = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxSelected = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxAll
            // 
            this.lbxAll.FormattingEnabled = true;
            this.lbxAll.Location = new System.Drawing.Point(12, 48);
            this.lbxAll.Name = "lbxAll";
            this.lbxAll.Size = new System.Drawing.Size(258, 238);
            this.lbxAll.TabIndex = 0;
            this.lbxAll.SelectedIndexChanged += new System.EventHandler(this.lbxAll_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(276, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(276, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 31);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<< Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxSelected
            // 
            this.lbxSelected.FormattingEnabled = true;
            this.lbxSelected.Location = new System.Drawing.Point(408, 48);
            this.lbxSelected.Name = "lbxSelected";
            this.lbxSelected.Size = new System.Drawing.Size(258, 238);
            this.lbxSelected.TabIndex = 3;
            this.lbxSelected.SelectedIndexChanged += new System.EventHandler(this.lbxSelected_SelectedIndexChanged);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(227, 317);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(107, 52);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Confirm";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(363, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(9, 21);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(46, 13);
            this.lblAll.TabIndex = 6;
            this.lblAll.Text = "All Items";
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Location = new System.Drawing.Point(405, 21);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedItems.TabIndex = 7;
            this.lblSelectedItems.Text = "Selected Items";
            // 
            // ChangeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 391);
            this.ControlBox = false;
            this.Controls.Add(this.lblSelectedItems);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbxSelected);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxAll);
            this.Name = "ChangeList";
            this.Text = "ChangeList";
            this.Load += new System.EventHandler(this.ChangeList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbxSelected;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblSelectedItems;
    }
}