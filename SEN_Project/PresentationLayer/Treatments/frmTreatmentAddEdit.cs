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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelCallback!=null)
            {
                CancelCallback.Invoke();
            }
            Hide();
        }

        private void frmTreatmentAddEdit_Load(object sender, EventArgs e)
        {

        }

        public  override    void    Reset   ()
        {

        }

        private void lblTreatmentDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
