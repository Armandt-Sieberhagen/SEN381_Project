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
using SEN_Project.PresentationLayer.Forms;

namespace SEN_Project.PresentationLayer.Facilities
{
    public partial class frmFacility : ManageForm
    {
        public frmFacility()
        {
            InitializeComponent();
            Reset();
        }
        Address _Address;
        List<PolicyData> PolicyDetails;

        public  override    void    Reset   ()
        {
            _Address = null;
            rtxAddressDetails.Clear();
            rtxPolicies.Clear();
            if (PolicyDetails==null)
            {
                PolicyDetails = new List<PolicyData>();
            }
            else
            {
                PolicyDetails.Clear();
            }
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
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

        public  void    SetAddress  (int    Index,string    Line)
        {
            SetAddress(BusinessLogic.current.GetByID<Address>(Index));
        }

        public  void    SetAddress (Address newAddress)
        {
            if (newAddress==null)
            {
                return;
            }
            _Address = newAddress;
            rtxAddressDetails.Clear();
            rtxAddressDetails.Text = _Address.ToString();
        }

        private void btnCreateAddress_Click(object sender, EventArgs e)
        {
            AddressCreator AddressForm = Factory.GetAddressCreator();
            AddressForm.OnConfirm = SetAddress;
            AddressForm.Show();
        }

        private void btnChangePolicies_Click(object sender, EventArgs e)
        {
            ChangeList OptionsChange = GlobalFunctions.CreateChangeList<PolicyData>(PolicyDetails);
            OptionsChange.ConfirmCallback = SetPolicies;
            OptionsChange.Show();
        }

        public  void    SetPolicies (List<object>   Objects)
        {
            PolicyDetails.Clear();
            rtxPolicies.Clear();
            foreach (object item in Objects)
            {
                AddPolicy((PolicyData)item);
            }
        }

        public  void    AddPolicy   (PolicyData data)
        {
            if (!PolicyDetails.Contains(data))
            {
                PolicyDetails.Add(data);
                rtxPolicies.Text += data.ToLine() + '\n';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MedicalServiceProvider Result = GetResult();
            if (Result!=null && ConfirmCallback!=null)
            {
                ConfirmCallback.Invoke(Result);
            }
            Hide();
        }

        public MedicalServiceProvider GetResult ()
        {
            //DO validation
            return Factory.CreateMedicalServiceProvider(txtName.Text,_Address,PolicyDetails);
        }

        private void btnCopyFacility_Click(object sender, EventArgs e)
        {
            MedicalServiceProvider Facility = GetResult();
            if (Facility!=null)
            {
                SEN_Clipboard._MedicalServiceProvider = Facility;
            }
        }

        private void btnPasteFacility_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._MedicalServiceProvider!=null)
            {
                SetFacility(SEN_Clipboard._MedicalServiceProvider);
            }
        }

        public  void    SetFacility (MedicalServiceProvider Facility)
        {
            txtName.Text = Facility.Name;
            SetAddress(Facility.MyAddress);
            PolicyDetails.Clear();
            foreach (PolicyData data in Facility.Policies)
            {
                AddPolicy(data);
            }
        }

        private void btnCopyAddress_Click(object sender, EventArgs e)
        {
            if (_Address!=null)
            {
                SEN_Clipboard._Address = _Address;
            }
        }

        private void btnPasteAddress_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Address!=null)
            {
                SetAddress(SEN_Clipboard._Address);
            }
        }
    }
}
