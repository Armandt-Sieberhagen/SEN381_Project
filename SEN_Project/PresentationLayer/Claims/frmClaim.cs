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
using SEN_Project.PresentationLayer.Forms.ListSearchForm;

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
        ClinicalProcedure Procedure;
        Call _Call;
        Policy _Policy;
        int Status => cbxStatus.SelectedIndex > -1 ? cbxStatus.SelectedIndex : 2;


        private void gbxProcedureInfo_Enter(object sender, EventArgs e)
        {

        }

        private void frmClaim_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public  Claim   GetResult   ()
        {
            //DO VALIDATION!!!
            return Factory.CreateClaim(CurrentClient,Procedure,numPrice.Value,_Call,_Policy,Status);
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

        private void btnSelectProcedure_Click(object sender, EventArgs e)
        {
            if (CurrentClient==null)
            {
                return;
            }
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<ClinicalProcedure>(CurrentClient.ClinicalHistory);
            SearchList.ConfirmCallback = SetProcedure;
            SearchList.Show();
        }

        public  void    SetProcedure    (int    Index,string    Line)
        {
            SetProcedure(BusinessLogic.current.GetByID<ClinicalProcedure>(Index));
        }

        public  void    SetProcedure    (ClinicalProcedure  Proc)
        {
            Procedure = Proc;
            rtxtProcedureDetails.Text = Proc.ToString();
        }

        private void btnSelectCall_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null)
            {
                return;
            }
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<Call>(CurrentClient.CallHistory);
            SearchList.ConfirmCallback = SetCall;
            SearchList.Show();
        }

        public  void    SetCall (int    Index,string    Line)
        {
            SetCall(BusinessLogic.current.GetByID<Call>(Index));
        }

        public  void    SetCall(Call    call)
        {
            _Call = call;
            rtxtCallDetails.Text = call.ToString();
        }

        private void btnSelectPolicyInfo_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null)
            {
                return;
            }
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<Policy>(CurrentClient.PastPolicies);
            SearchList.ConfirmCallback = SetPolicy;
            SearchList.Show();
        }

        public  void    SetPolicy   (int    Index,string    Line)
        {
            SetPolicy(BusinessLogic.current.GetByID<Policy>(Index));
        }

        public  void    SetPolicy   (Policy Pol)
        {
            _Policy = Pol;
            rtxtPolicyInfo.Text = Pol.ToString();
        }
    }
}
