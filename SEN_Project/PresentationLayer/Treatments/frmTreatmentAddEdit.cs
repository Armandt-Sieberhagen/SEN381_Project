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
using SEN_Project.PresentationLayer;

namespace SEN_Project.PresentationLayer.Treatments
{
    public partial class frmTreatmentAddEdit : TableForm
    {
        public static frmTreatmentAddEdit current;
        public frmTreatmentAddEdit()
        {
            InitializeComponent();
            current = this;
            NormalColor = btnConfirm.BackColor;
        }
        Color NormalColor;
        public TreatmentVoid ConfirmCallback;
        public EmptyVoid CancelCallback;

        private void btnConfirm_MouseEnter(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.LightGreen;
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.BackColor = NormalColor;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Maroon;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = NormalColor;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rtxtDescr.Text.Trim().Length==0)
            {
                PresentationController.current.ShowError("Please enter a description for the treatment");
                return;
            }
            if (ConfirmCallback!=null)
            {
                ConfirmCallback.Invoke(Factory.CreateTreatment(rtxtDescr.Text));
                Hide();
            }
            else
            {
                PresentationController.current.ShowError("No callback");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelCallback!=null)
            {
                CancelCallback.Invoke();
            }
        }

        private void frmTreatmentAddEdit_Load(object sender, EventArgs e)
        {

        }

        public  override    void    Reset   ()
        {
            rtxtDescr.Clear();
        }
    }
}
