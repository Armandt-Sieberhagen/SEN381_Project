﻿using System;
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
            Reset();
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
        }

        public  Claim   GetResult   ()
        {
            //DO VALIDATION!!!
            return Factory.CreateClaim(CurrentClient,Procedure, _Call, _Policy,(float)numPrice.Value,(Claim.ClaimStatus)Status);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Claim Result = GetResult();
            if (ConfirmCallback!=null   &&  Result!=null)
            {
                ConfirmCallback.Invoke(Result);
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
            rtxtClientInfo.Text = _Client.ToString();
        }

        private void btnSelectProcedure_Click(object sender, EventArgs e)
        {
            if (CurrentClient==null)
            {
                PresentationController.current.ShowError("Please select a client first");
                return;
            }
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<ClinicalProcedure>(CurrentClient.ClinicalHistory);
            if (SearchList==null)
            {
                PresentationController.current.ShowError("Client has no past procedures");
                return;
            }
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
                PresentationController.current.ShowError("Please select a client first");
                return;
            }
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<Call>(CurrentClient.CallHistory);
            if (SearchList == null)
            {
                PresentationController.current.ShowError("Client has no past calls");
                return;
            }
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
                PresentationController.current.ShowError("Please select a client first");
                return;
            }
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<Policy>(CurrentClient.PastPolicies);
            if (SearchList == null)
            {
                PresentationController.current.ShowError("Client has no past policies");
                return;
            }
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
