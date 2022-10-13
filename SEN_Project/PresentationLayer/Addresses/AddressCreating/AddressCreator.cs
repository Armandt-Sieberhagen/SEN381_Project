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

namespace SEN_Project.PresentationLayer.Addresses.AddressCreator
{
    public partial class AddressCreator : Form
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

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuickValidate();
            cbxCity.Enabled = cbxProvince.SelectedIndex > -1;
            if (cbxProvince.SelectedIndex>-1)
            {
                cbxCity.Items.Clear();
                string[] Cities = GlobalDataLayer.CitiesOfProvince(cbxProvince.SelectedItem.ToString());
                foreach (string City in Cities)
                {
                    cbxCity.Items.Add(City);
                }
            }
        }

        private void btnCreateAddress_Click(object sender, EventArgs e)
        {
            if (OnConfirm!=null)
            {
                //Do validation!!!
                Address NewAddress = Factory.CreateAddress(txtStreet.Text.Trim(), cbxCity.SelectedItem.ToString(), cbxProvince.SelectedItem.ToString(), txtPostalCode.Text.Trim());
                OnConfirm.Invoke(NewAddress);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (OnCancel!=null)
            {
                OnCancel.Invoke();
            }
        }

        public  void    QuickValidate   ()
        {
            btnCreateAddress.Enabled = FlagStreet && FlagPostal && FlagCity && FlagProvince;
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            QuickValidate();
        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            QuickValidate();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuickValidate();
        }
    }
}
