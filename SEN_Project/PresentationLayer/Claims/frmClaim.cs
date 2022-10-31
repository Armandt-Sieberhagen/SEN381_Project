using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.BusinessLogicLayer;
using System.Windows.Forms;

namespace SEN_Project.PresentationLayer.Claims
{
    public partial class frmClaim : TableForm
    {
        public frmClaim()
        {
            InitializeComponent();
        }
        public ClaimVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        Client CurrentClient;

        private void gbxProcedureInfo_Enter(object sender, EventArgs e)
        {

        }

        private void frmClaim_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public  Claim   GetResult   ()
        {
            return null;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ConfirmCallback!=null)
            {
                ConfirmCallback.Invoke(GetResult());
            }
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelCallback!=null)
            {
                CancelCallback.Invoke();
            }
            Hide();
        }

        public  override    void    Reset   ()
        {
            numPrice.Value = 0;
            rtxtCallDetails.Clear();
            rtxtPolicyInfo.Clear();
            rtxtProcedureDetails.Clear();
            CurrentClient = null;
        }

        public  void    SetClient   (Client _Client)
        {
            CurrentClient = _Client;
        }
    }
}
