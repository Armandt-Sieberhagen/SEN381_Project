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
            return Factory.CreateCondition(txtName.Text, rtxtDescription.Text);
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
