using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.PresentationLayer.Conditions
{
    public partial class frmCondition : ManageForm
    {
        public frmCondition()
        {
            InitializeComponent();
            Reset();
        }

        public  override    void    Reset   ()
        {
            txtName.Clear();
            rtxtDescription.Clear();
        }

        public  override    void    SetObject   (object Object)
        {
            MedicalCondition condition = (MedicalCondition)Object;
            txtName.Text = condition.Name;
            rtxtDescription.Text = condition.Description;
        }

        private void frmCondition_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public  MedicalCondition    GetResult   ()
        {
            if (txtName.Text.Length > 0 && txtName.Text.Length < 50)
            {
                if (rtxtDescription.Text.Length>0 && rtxtDescription.Text.Length<50)
                {
                    return Factory.CreateCondition(txtName.Text, rtxtDescription.Text);
                }
                else
                {
                    MessageBox.Show("Description must be between 1 and 50 characters");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name");
            }
            return null;
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MedicalCondition Result = GetResult();
            if (ConfirmCallback!=null && Result!=null)
            {
                ConfirmCallback.Invoke(Result);
            }
            Hide();
        }
    }
}
