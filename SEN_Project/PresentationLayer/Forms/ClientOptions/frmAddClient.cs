using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.PresentationLayer.ChangeList;
using SEN_Project.PresentationLayer.Addresses.AddressCreator;
using SEN_Project.BusinessLogicLayer;
using SEN_Project.PresentationLayer.Addresses.AddressSelector;

namespace SEN_Project.PresentationLayer.Forms.ClientOptions
{
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }
        ChangeList CurrentChangeList;

        bool FlagFirstName
        {
            get
            {
                bool Result = txtFirstName.Text.Trim().Length > 0;
                lblFirstName.ForeColor = Result ? Color.Black : Color.Red;
                return Result;
            }
        }
        bool FlagLastName {
            get
            {
                bool Result = txtLastName.Text.Trim().Length > 0;
                lblLastName.ForeColor = Result ? Color.Black : Color.Red;
                return Result;
            }
        }
        bool FlagID {
            get
            {
                bool Result = txtID.Text.Trim().Length ==13;
                lblID.ForeColor = Result ? Color.Black : Color.Red;
                return Result;
            }
        }
        bool FlagPhoneNumber {
            get
            {
                bool Result = txtPhoneNumber.Text.Trim().Length ==10;
                lblPhoneNumber.ForeColor = Result ? Color.Black : Color.Red;
                return Result;
            }
        }
        bool FlagAddress => address != null;
        List<string> SelectedPolicies;
        Address address;
        
        private void btnChangePolicies_Click(object sender, EventArgs e)
        {
            ChangeListOptions Options = new ChangeListOptions();
            Options.CancelCallback = HideList;
            Options.Callback = ListPolicies;
            //Fix this!!!
            List<string> AllPolicies = new List<string>();
            AllPolicies.Add("Policy 1");
            AllPolicies.Add("Policy 2");
            AllPolicies.Add("Policy 3");
            AllPolicies.Add("Policy 4");
            AllPolicies.Add("Policy 5");

            Options.AllOptions = AllPolicies;
            CurrentChangeList = new ChangeList();
            CurrentChangeList.CurrentOptions = Options;
            CurrentChangeList.Show();
        }

        public void HideList() {
            if (CurrentChangeList!=null)
            {
                CurrentChangeList.Hide();
            }
        }

        public  void ListPolicies   (List<string>   Items)
        {
            rtxtPolicies.Clear();
            foreach (string item in Items)
            {
                rtxtPolicies.Text += item + '\n';
            }
            CurrentChangeList.Hide();
            SelectedPolicies = Items;
        }

        private void lbxPerscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemovePerscription.Enabled = lbxPerscriptions.SelectedItem != null;
        }

        private void btnAddPerscription_Click(object sender, EventArgs e)
        {
            if (txtPerscription.Text.Trim().Length>0)
            {
                lbxPerscriptions.Items.Add(txtPerscription.Text);
                txtPerscription.Clear();
            }
            else
            {
                txtPerscription.Focus();
            }
        }

        private void txtPerscription_TextChanged(object sender, EventArgs e)
        {
            btnAddPerscription.Enabled = txtPerscription.Text.Trim().Length > 0;
        }

        private void btnRemovePerscription_Click(object sender, EventArgs e)
        {
            lbxPerscriptions.Items.RemoveAt(lbxPerscriptions.SelectedIndex);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!FlagFirstName)
            {
                PresentationController.current.ShowError("Please enter a valid first name");
                txtFirstName.Focus();
                return;
            }
            if (!FlagLastName)
            {
                PresentationController.current.ShowError("Please enter a valid last name");
                txtLastName.Focus();
                return;
            }
            if (!FlagID)
            {
                PresentationController.current.ShowError("Please enter a valid ID");
                txtID.Focus();
                return;
            }
            if (!FlagPhoneNumber)
            {
                PresentationController.current.ShowError("Please enter a valid phone number");
                txtPhoneNumber.Focus();
                return;
            }
            if (!FlagAddress)
            {
                PresentationController.current.ShowError("Please enter a valid address");
                btnNewAddress.Focus();
                return;
            }
            List<string> Perscriptions = new List<string>();
            foreach (var item in lbxPerscriptions.Items)
            {
                Perscriptions.Add(item.ToString());
            }
            string FirstName = txtFirstName.Text.Trim();
            string LastName = txtLastName.Text.Trim();
            string ID = txtID.Text.Trim();
            string PhoneNumber = txtPhoneNumber.Text.Trim();
            string Email = txtEmail.Text.Trim();
            BusinessLogic.current.CreateClient(FirstName, LastName, ID, PhoneNumber, SelectedPolicies, Perscriptions, address,Email);
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public  void    QuickValidation ()
        {
            //btnAddClient.Enabled = FlagFirstName && FlagLastName && FlagID && FlagPhoneNumber   &&  FlagAddress;
            lblErrorDisplay.ForeColor = Color.Red;
            if (!FlagFirstName)
            {
                lblErrorDisplay.Text = "Please enter a valid first name";
                return;
            }
            if (!FlagLastName)
            {
                lblErrorDisplay.Text = "Please enter a valid last name";
                return;
            }
            if (!FlagID)
            {
                lblErrorDisplay.Text = "Please enter a valid ID";
                return;
            }
            if (!FlagPhoneNumber)
            {
                lblErrorDisplay.Text = "Please enter a valid phone number";
                return;
            }
            if (!FlagAddress)
            {
                lblErrorDisplay.Text = "Please enter a valid address";
                return;
            }
            lblErrorDisplay.ForeColor = Color.Green;
            lblErrorDisplay.Text = "All good";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            QuickValidation();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            QuickValidation();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            QuickValidation();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            QuickValidation();
        }

        private void btnNewAddress_Click(object sender, EventArgs e)
        {
            AddressCreator AC = new AddressCreator();
            AC.Show();
            AC.OnCancel = HideAddressCreator;
            AC.OnConfirm = SetAddress;
        }

        public  void    HideAddressCreator  ()
        {
            AddressCreator.current.Hide();
        }

        public  void  SetAddress (Address _Address)
        {
            rtxtAddress.Text = _Address.ToString();
            address = _Address;
            HideAddressCreator();
            QuickValidation();
        }

        private void btnAddClient_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnSelectAddress_Click(object sender, EventArgs e)
        {
            (AddressSelector.current ?? new AddressSelector()).Show();
            AddressSelector.current.OnCancel    =   HideAddressSelector;            
        }

        public  void    HideAddressSelector ()
        {
            AddressSelector.current.Hide();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }

        public  void Reset ()
        {
            address = null;
            SelectedPolicies.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtID.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            rtxtAddress.Clear();
            rtxtPolicies.Clear();
            txtPerscription.Clear();
            QuickValidation();
        }
    }
}
