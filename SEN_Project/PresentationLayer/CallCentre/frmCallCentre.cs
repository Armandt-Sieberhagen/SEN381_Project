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
using SEN_Project.PresentationLayer.Clients;
using SEN_Project.PresentationLayer.Claims;
using SEN_Project.PresentationLayer.PolicyForms;
using SEN_Project.PresentationLayer.Forms.ListSearchForm;
using SEN_Project.PresentationLayer.Employees;

namespace SEN_Project.PresentationLayer.CallCentre
{
    public partial class frmCallCentre : Form
    {

        Call CurrentCall;
        DateTime CallStart;
        Client CurrentClient;
        Employee CurrentEmployee;
        bool CallOperating;
        Claim CurrentClaim;

        public frmCallCentre()
        {
            InitializeComponent();
        }

        private void frmCallCentre_Load(object sender, EventArgs e)
        {
            Evaluate();
        }

        void    Evaluate    ()
        {
            btnSimulateCall.Enabled = CurrentEmployee != null;
            gbxClaimOptions.Enabled = CurrentClient != null && CallOperating;
            gbxClientDetails.Enabled = CallOperating;
            gbxPolicyInfo.Enabled = CallOperating && CurrentClient != null;
            gbxProcedureInfo.Enabled = CallOperating && CurrentClient != null;
        }

        private void btnSimulateCall_Click(object sender, EventArgs e)
        {
            CallStart = DateTime.Now;
            lblStartTime.Text = CallStart.ToString();
            CallOperating = true;
            Evaluate();
            //Start Timer
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frmSearchClient SearchFrm   =   Factory.GetSearchClient();
            SearchFrm.ConfirmCallback = SetClient;
            SearchFrm.Show();
        }

        public  void    SetClient   (Client _Client)
        {
            if (_Client==null)
            {
                return;
            }
            rtxtClientInfo.Clear();
            rtxtClientInfo.Text = _Client.PersonalDetails;
            rtxtAddressInfo.Clear();
            rtxtAddressInfo.Text = _Client.AddressDetails;
            CurrentClient = _Client;
            rtxtPolicyInfo.Text = CurrentClient.MyPolicy !=null ? CurrentClient.MyPolicy.ToString() : "";
            Evaluate();
        }

        private void btnCopyClient_Click(object sender, EventArgs e)
        {
            if (CurrentClient!=null)
            {
                SEN_Clipboard._Client = CurrentClient;
            }
        }

        private void btnPasteClient_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Client!=null)
            {
                SetClient(SEN_Clipboard._Client);
            }
        }

        private void btnCreateNewClaim_Click(object sender, EventArgs e)
        {
            if (CurrentClient==null)
            {
                PresentationController.current.ShowError("Please select a client first");
                return;
            }
            frmClaim ClaimForm = Factory.GetClaimForm();
            ClaimForm.ConfirmCallback = AddClaim;
            ClaimForm.SetClient(CurrentClient);
            ClaimForm.Show();
        }

        public  void    AddClaim    (Claim  NewClaim)
        {
            if (CurrentClient!=null)
            {
                CurrentClient.AddClaim(NewClaim);
            }
        }

        public  void    ModifyClaim (Claim  _Claim)
        {
            if (CurrentClient!=null)
            {
                CurrentClient.ModifyClaim(_Claim);
            }
        }

        private void btnViewPastClaims_Click(object sender, EventArgs e)
        {
            frmViewPastClaims PastClaimsForm = Factory.GetPastClaimsForm();
            PastClaimsForm.Show();
        }

        private void btnModifyClaim_Click(object sender, EventArgs e)
        {
            frmClaim ClaimForm = Factory.GetClaimForm();
            ClaimForm.ConfirmCallback = ModifyClaim;
            ClaimForm.SetClient(CurrentClient);
            ClaimForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null)
            {
                PresentationController.current.ShowError("Please select a client first");
                return;
            }
            if (CurrentClient.ClaimsHistory == null)
            {
                PresentationController.current.ShowError("The selected client does not have any claims yet");
                return;
            }
            frmSearchList SearchForm = Factory.GetSearchList();
            SearchForm.ConfirmCallback = RemoveClaim;
            List<string> Options = new List<string>();
            foreach (Claim claim in CurrentClient.ClaimsHistory)
            {
                Options.Add(claim.ToLine());
            }
            SearchForm.SetItems(Options);
            SearchForm.Show();
        }

        public  void    RemoveClaim (int    Index,string    Line)
        {
            if (Index>-1)
            {
                if (MessageBox.Show("Are you sure you want to remove this claim","Delete Claim",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    CurrentClient.RemoveClaim(Index);
                }
            }
        }

        private void btnChangePolicy_Click(object sender, EventArgs e)
        {
            frmChoosePolicy ChooseForm = Factory.GetPolicyForm();
            ChooseForm.ConfirmCallback = SetPolicy;
            if (CurrentClient!=null ? CurrentClient.MyPolicy!=null : false)
            {
                ChooseForm.SetAll(CurrentClient);
            }
            ChooseForm.Show();
        }

        public  void    SetPolicy   (Policy Pol)
        {
            if (CurrentClient!=null)
            {
                CurrentClient.MyPolicy = Pol;
                rtxtPolicyInfo.Text = CurrentClient.MyPolicy.ToString();
            }
        }

        private void btnCreateNewClient_Click(object sender, EventArgs e)
        {
            frmClient ClientCreator = Factory.GetClientForm();
            ClientCreator.ConfirmCallback = SetClient;
            ClientCreator.Show();
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            CallOperating = false;
            if (CurrentClient==null || CurrentClaim==null)
            {
                return;
            }
            CurrentCall = Factory.CreateCall(CallStart,DateTime.Now,CurrentEmployee);
            CurrentClient.AddCall(CurrentCall);
            CurrentCall = null;
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee CreateEmployee = Factory.GetCreateEmployeeForm();
            CreateEmployee.ConfirmCallback = SetEmployee;
            CreateEmployee.Show();
        }

        public  void    SetEmployee (Employee   _employee)
        {
            CurrentEmployee = _employee;
            rtxtEmployeeDetails.Text = _employee.ToString();
            btnSimulateCall.Enabled = _employee != null;
            Evaluate();
        }

        public  void    SetEmployee (int    Index,string    Line)
        {
            SetEmployee(BusinessLogic.current.GetEmployeeByID(Index));
        }

        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<Employee>();
            SearchList.ConfirmCallback = SetEmployee;
            SearchList.Show();
        }
    }
}
