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
    public partial class frmClient : TableForm
    {
        public frmClient()
        {
            InitializeComponent();
        }

        Address _Address;
        public ClientVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        List<Call> CallHistory;
        List<string> Perscriptions;

        public void SetClient(Client NewClient)
        {
            SetAddress(NewClient.PersonAddress);
            CallHistory.Clear();
            foreach (Call call in NewClient.CallHistory)
            {
                AddCall(call);
            }
            Perscriptions.Clear();
            foreach (string perscription in NewClient.ActivePerscriptions)
            {
                AddPerscription(perscription);
            }
            txtFirstName.Text = NewClient.FirstName;
            txtLastName.Text = NewClient.LastName;
            txtIDNumber.Text = NewClient.IDNumber;
            txtPhoneNumber.Text = NewClient.PhoneNumber;
            txtEmail.Text = NewClient.Email;
        }


        private void frmClient_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSearchList AddressSearch = Factory.GetSearchList();
            List<Address> AllAddresses = BusinessLogic.current.GetAll<Address>();
            List<string> Options = new List<string>();
            foreach (Address address in AllAddresses)
            {
                Options.Add(address.ToLine());
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
            SetAddress(BusinessLogic.current.GetByID<Address>(ID));
        }

        public  override    void    Reset   ()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtIDNumber.Clear();
            txtEmail.Clear();
            txtPerscription.Clear();
            txtPhoneNumber.Clear();
            rtxtAddress.Clear();
            _Address = null;
            if (CallHistory==null)
            {
                CallHistory = new List<Call>();
            }
            else
            {
                CallHistory.Clear();
            }
            if (Perscriptions==null)
            {
                Perscriptions = new List<string>();
            }
            else
            {
                Perscriptions.Clear();
            }
        }

        Client  GetResult   ()
        {
            //Do Validation

            string FirstName = txtFirstName.Text.Trim();
            string LastName = txtLastName.Text.Trim();
            string IDnumber = txtIDNumber.Text.Trim();
            string Phone = txtPhoneNumber.Text.Trim();
            string Email = txtEmail.Text.Trim();

            if (FirstName.Length > 0 && FirstName.Length < 20)
            {
                if (LastName.Length > 0 && LastName.Length < 20)
                {
                    if (IDnumber.Length > 0 && IDnumber.Length < 20)
                    {
                        if (Phone.Length > 0 && Phone.Length < 10)
                        {
                            if (Email.Length > 0 && Email.Length < 20)
                            {
                                if (_Address != null)
                                {
                                    return Factory.CreateClient(FirstName, LastName, CallHistory, null, IDnumber, _Address, Email, Phone, new List<Claim>(), new List<ClinicalProcedure>(), Perscriptions);
                                }
                                else
                                {
                                    MessageBox.Show("Please select an address, tip: create one from the table");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid email, its length must be less than 20");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid phone number, its length must be less than 10");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid ID number, its length must be less than 20");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid last name, its length must be less than 20");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid first name, its length must be less than 20");
            }

            return null;

            
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
        }


        private void btnAddCall_Click(object sender, EventArgs e)
        {
            frmSearchList CallSearch = Factory.GetSearchList();
            List<Call> AllCalls = BusinessLogic.current.GetAll<Call>();
            List<string> Options = new List<string>();
            foreach (Call call in AllCalls)
            {
                Options.Add(call.ToLine());
            }
            CallSearch.SetItems(Options);
            CallSearch.ConfirmCallback = AddCall;
            CallSearch.Show();
        }

        public  void    AddCall (int    Index,string    Line)
        {
            AddCall(BusinessLogic.current.GetByID<Call>(Index));
        }

        public  void    AddCall (Call   NewCall)
        {
            if (!CallHistory.Contains(NewCall))
            {
                CallHistory.Add(NewCall);
                lbxCallsHistory.Items.Add(NewCall.ToLine());
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

        }


        private void btnRemoveClinicalProcedure_Click(object sender, EventArgs e)
        {

        }

        private void lbxClinicalHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {

        }


        private void btnRemoveClaim_Click(object sender, EventArgs e)
        {

        }

        private void lbxClaimsHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnAddPerscription_Click(object sender, EventArgs e)
        {
            AddPerscription(txtPerscription.Text.Trim());
        }

        public  void    AddPerscription (string Perscription)
        {
            if (Perscription.Length>0 && !Perscriptions.Contains(Perscription))
            {
                lbxPerscriptions.Items.Add(Perscription);
                Perscriptions.Add(Perscription);
                txtPerscription.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelCallback!=null)
            {
                CancelCallback.Invoke();
            }
            Hide();
        }

        private void btnCopyClient_Click(object sender, EventArgs e)
        {
            Client Result = GetResult();
            if (Result!=null)
            {
                SEN_Clipboard._Client = Result;
            }
        }

        private void btnPasteClient_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Client != null)
            {
                SetClient(SEN_Clipboard._Client);
            }
        }
    }
}
