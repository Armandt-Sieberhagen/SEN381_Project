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
using SEN_Project.DataAccessLayer;

namespace SEN_Project.PresentationLayer.Addresses.AddressSelector
{
    public partial class AddressSelector : Form
    {
        public static AddressSelector current;
        public AddressSelector()
        {
            current = this;
            InitializeComponent();
        }
        public EmptyVoid OnCancel;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (OnCancel!=null)
            {
                OnCancel.Invoke();
            }

            string Street = "adbuia";
            string City = "adwuh";
            DatabaseAccess.current.SearchIndex(Factory.CreateAddress(Street,City));
        }
    }
}
