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
using SEN_Project.PresentationLayer.Forms.ListSearchForm;
using SEN_Project.PresentationLayer.Addresses;
using SEN_Project.PresentationLayer.PolicyForms;
using SEN_Project.PresentationLayer.Claims;
using SEN_Project.PresentationLayer.Procedure;

namespace SEN_Project.PresentationLayer.Clients
{
    public partial class btnPasteAddress : TableForm
    {
        public btnPasteAddress()
        {
            InitializeComponent();
        }

        Address _Address;
        public ClientVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        Policy MyPolicy;
        List<Call> CallHistory;
        List<ClinicalProcedure> PastProcedures;
        List<Claim> ClaimHistory;
        List<string> Perscriptions;

        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSearchList AddressSearch = Factory.GetSearchList();
            List<Address> AllAddresses = BusinessLogic.current.GetAllAddresses();
            List<string> Options = new List<string>();
            foreach (Address address in AllAddresses)
            {
                Options.Add(address.ToLine);
            }
            AddressSearch.SetItems(Options);
            AddressSearch.ConfirmCallback = SetAddress;
            AddressSearch.Show();
        }

        private void btnCreateAddress_Click(object sender, EventArgs e)
        {
            AddressCreator AddressForm = Factory.GetAddressCreator();
            AddressForm.OnConfirm = SetAddress;
            AddressForm.Show();
        }

        public void SetAddress(Address _address)
        {
            _Address = _address;
            rtxtAddress.Text = _Address.ToString();
        }

        public void SetAddress(int ID, string Line)
        {
            SetAddress(BusinessLogic.current.GetAddressByID(ID));
        }

        public  override    void    Reset   ()
        {

        }

        Client  GetResult   ()
        {
            //Do Validation

            string FirstName = txtFirstName.Text.Trim();
            string LastName = txtLastName.Text.Trim();
            string IDnumber = txtIDNumber.Text.Trim();
            string Phone = txtPhoneNumber.Text.Trim();
            string Email = txtEmail.Text.Trim();

            return Factory.CreateClient(FirstName,LastName,CallHistory,MyPolicy,IDnumber,_Address,Email,Phone,ClaimHistory, PastProcedures, Perscriptions);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Client Result = GetResult();
            if (ConfirmCallback!=null && Result!=null)
            {
                ConfirmCallback.Invoke(Result);
            }
            Hide();
        }

        private void btnSelectPolicy_Click(object sender, EventArgs e)
        {
        }

        private void btnChangePolicy_Click(object sender, EventArgs e)
        {
            frmChoosePolicy PolicyForm = Factory.GetPolicyForm();
            if (MyPolicy != null)
            {
                PolicyForm.SetPolicy(MyPolicy);
            }
            PolicyForm.ConfirmCallback = SetPolicy;
            PolicyForm.Show();
        }

        public  void    SetPolicy   (Policy Pol)
        {
            MyPolicy = Pol;
            rtxtPolicyDetails.Text = Pol.ToString();
        }

        private void btnAddCall_Click(object sender, EventArgs e)
        {
            frmSearchList CallSearch = Factory.GetSearchList();
            List<Call> AllCalls = BusinessLogic.current.GetAllCalls();
            List<string> Options = new List<string>();
            foreach (Call call in AllCalls)
            {
                Options.Add(call.ToLine);
            }
            CallSearch.SetItems(Options);
            CallSearch.ConfirmCallback = AddCall;
            CallSearch.Show();
        }

        public  void    AddCall (int    Index,string    Line)
        {
            Call NewCall = BusinessLogic.current.GetCallByID(Index);
            if (!CallHistory.Contains(NewCall))
            {
                CallHistory.Add(NewCall);
                lbxCallsHistory.Items.Add(NewCall.ToLine);
            }
        }

        private void lbxCallsHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveCall.Enabled = lbxCallsHistory.SelectedIndex > -1;
        }

        private void btnRemoveCall_Click(object sender, EventArgs e)
        {
            CallHistory.RemoveAt(lbxCallsHistory.SelectedIndex);
            lbxCallsHistory.Items.RemoveAt(lbxCallsHistory.SelectedIndex);
        }

        private void btnAddClinicalProcedure_Click(object sender, EventArgs e)
        {
            frmProcedure ProcedureForm = Factory.GetProcedureForm();
            ProcedureForm.ConfirmCallback = AddProcedure;
            ProcedureForm.Show();
        }

        public  void    AddProcedure    (ClinicalProcedure Proc)
        {
            if (!PastProcedures.Contains(Proc))
            {
                PastProcedures.Add(Proc);
                lbxClinicalHistory.Items.Add(Proc.ToLine());
            }
        }

        private void btnRemoveClinicalProcedure_Click(object sender, EventArgs e)
        {
            PastProcedures.RemoveAt(lbxClinicalHistory.SelectedIndex);
            lbxClinicalHistory.Items.RemoveAt(lbxClinicalHistory.SelectedIndex);
        }

        private void lbxClinicalHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveClinicalProcedure.Enabled = lbxClinicalHistory.SelectedIndex > -1;
        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            frmClaim ClaimForm = Factory.GetClaimForm();
            ClaimForm.ConfirmCallback = AddClaim;
            ClaimForm.Show();
        }

        public  void    AddClaim    (Claim  newClaim)
        {
            if (!ClaimHistory.Contains(newClaim))
            {
                ClaimHistory.Add(newClaim);
                lbxClaimsHistory.Items.Add(newClaim.ToLine());
            }
        }

        private void btnRemoveClaim_Click(object sender, EventArgs e)
        {
            ClaimHistory.RemoveAt(lbxClaimsHistory.SelectedIndex);
            lbxClaimsHistory.Items.RemoveAt(lbxClaimsHistory.SelectedIndex);
        }

        private void lbxClaimsHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveClaim.Enabled = lbxClaimsHistory.SelectedIndex>-1;
        }

        private void txtPerscription_TextChanged(object sender, EventArgs e)
        {
            btnAddPerscription.Enabled = txtPerscription.Text.Trim().Length > 0;
        }

        private void lbxPerscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemovePerscription.Enabled = lbxPerscriptions.SelectedIndex > -1;
        }

        private void btnRemovePerscription_Click(object sender, EventArgs e)
        {
            Perscriptions.RemoveAt(lbxPerscriptions.SelectedIndex);
            lbxPerscriptions.Items.RemoveAt(lbxPerscriptions.SelectedIndex);
        }
    }
}
