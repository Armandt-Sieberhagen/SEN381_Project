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

namespace SEN_Project.PresentationLayer.Claims
{
    public partial class frmViewPastClaims : TableForm
    {
        Client CurrentClient;
        Claim SelectedClaim;
        
        public frmViewPastClaims()
        {
            InitializeComponent();
        }

        private void frmViewPastClaims_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public  void    Reset   ()
        {
            rtxtClaimInfo.Clear();
            rtxtClientInfo.Clear();
            lbxClaims.Items.Clear();
            CurrentClient = null;
        }

        public  void    SetClient   (Client _Client)
        {
            if (_Client==null)
            {
                return;
            }
            CurrentClient = _Client;
            rtxtClientInfo.Text = CurrentClient.PersonalDetails;
            lbxClaims.Items.Clear();
            foreach (Claim claim in CurrentClient.ClaimsHistory)
            {
                lbxClaims.Items.Add(claim.ToLine());
            }
            rtxtClaimInfo.Clear();
        }

        private void lbxClaims_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxClaims.SelectedItem!=null)
            {
                SetClaim(CurrentClient.ClaimsHistory[lbxClaims.SelectedIndex]);
            }
        }

        public  void    SetClaim    (Claim  _Claim)
        {
            rtxtClaimInfo.Text = _Claim.ToString();
            SelectedClaim = _Claim;
        }

        private void btnPasteClaim_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Claim!=null)
            {
                SetClaim(SEN_Clipboard._Claim);
            }
        }

        private void btnCopyClaim_Click(object sender, EventArgs e)
        {
            if (SelectedClaim!=null)
            {
                SEN_Clipboard._Claim = SelectedClaim;
            }
        }

        private void btnCopyClientInfo_Click(object sender, EventArgs e)
        {
            if (CurrentClient != null)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
