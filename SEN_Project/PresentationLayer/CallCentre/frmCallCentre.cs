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
using SEN_Project.PresentationLayer.Forms.ListSearchForm;

namespace SEN_Project.PresentationLayer.CallCentre
{
    public partial class frmCallCentre : Form
    {

        Call CurrentCall;
        DateTime CallStart;
        Client CurrentClient;

        public frmCallCentre()
        {
            InitializeComponent();
        }

        private void frmCallCentre_Load(object sender, EventArgs e)
        {

        }

        private void btnSimulateCall_Click(object sender, EventArgs e)
        {
            CallStart = DateTime.Now;
            lblStartTime.Text = CallStart.ToString();
            //Start Timer
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frmSearchClient SearchFrm   =   Factory.GetSearchClient();
            SearchFrm.ConfirmCallback = SetClient;
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
            frmSearchList SearchForm = Factory.GetSearchList();
            SearchForm.ConfirmCallback = RemoveClaim;
            List<string> Options = new List<string>();
            foreach (Claim claim in CurrentClient.ClaimsHistory)
            {
                Options.Add(claim.ToLine);
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
    }
}
