using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.DataLayer;
using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.PresentationLayer.Addresses
{
    public partial class AddressCreator : TableForm
    {
        public static AddressCreator current;
        public AddressCreator()
        {
            current = this;
            InitializeComponent();
        }
        public EmptyVoid OnCancel;
        public AddressVoid OnConfirm;
        bool FlagStreet => txtStreet.Text.Trim().Length > 0;
        bool FlagPostal => txtPostalCode.Text.Trim().Length > 0;
        bool FlagCity => cbxCity.SelectedIndex > -1;
        bool FlagProvince => cbxProvince.SelectedIndex > -1;

        private void AddressCreator_Load(object sender, EventArgs e)
        {
            btnCreateAddress.Enabled = false;
            cbxProvince.Items.Clear();
            string[] Provinces = GlobalDataLayer.ProvinceNames();
            foreach (string Province in Provinces)
            {
                cbxProvince.Items.Add(Province);
            }
        }

        public  void    SetAddress (Address _Address)
        {
            if (_Address==null)
            {
                txtStreet.Clear();
                txtPostalCode.Clear();
                cbxCity.SelectedIndex = -1;
                cbxProvince.SelectedIndex = 0;
                txtStreet.Focus();
                QuickValidate();
            }
            else
            {
                txtStreet.Text = _Address.Street;
                txtPostalCode.Text = _Address.PostalCode;
                cbxProvince.SelectedText = _Address.Province;
                cbxCity.SelectedText = _Address.City;
                txtStreet.Focus();
                QuickValidate();
            }
        }

        private void btnCreateAddress_Click(object sender, EventArgs e)
        {
            Address Result = GetResult();
            if (OnConfirm!=null && Result!=null)
            {
               OnConfirm.Invoke(Result);
            }
            Hide();
        }

        Address GetResult   ()
        {
            //Do validation!!!
            return Factory.CreateAddress(txtStreet.Text.Trim(), cbxCity.SelectedItem.ToString(), cbxProvince.SelectedItem.ToString(), txtPostalCode.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (OnCancel!=null)
            {
                OnCancel.Invoke();
            }
            Hide();
        }

        public  void    QuickValidate   ()
        {
            btnCreateAddress.Enabled = FlagStreet && FlagPostal && FlagCity && FlagProvince;
        }


        public  override    void    Reset   ()
        {
            txtStreet.Clear();
            txtPostalCode.Clear();
            cbxProvince.SelectedIndex = -1;
            cbxCity.SelectedIndex = -1;
        }

        private void btnCopyAddress_Click(object sender, EventArgs e)
        {
            Address Result = GetResult();
            if (Result != null)
            {
                SEN_Clipboard._Address = Result;
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Address!=null)
            {
                SetAddress(SEN_Clipboard._Address);
            }
        }

        private void cbxProvince_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            QuickValidate();
            cbxCity.Enabled = cbxProvince.SelectedIndex > -1;
            if (cbxProvince.SelectedIndex > -1)
            {
                cbxCity.Items.Clear();
                string[] Cities = GlobalDataLayer.CitiesOfProvince(cbxProvince.SelectedItem.ToString());
                foreach (string City in Cities)
                {
                    cbxCity.Items.Add(City);
                }
            }
        }

        private void txtStreet_TextChanged_1(object sender, EventArgs e)
        {
            QuickValidate();
        }

        private void txtPostalCode_TextChanged_1(object sender, EventArgs e)
        {
            QuickValidate();
        }

        private void cbxCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            QuickValidate();
        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }
    }
}
