using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN_Project.PresentationLayer
{
    public partial class DatabaseForm : Form
    {
        public static DatabaseForm current;
        public DatabaseForm()
        {
            current = this;
            InitializeComponent();
        }
        TableOptions currentOptions;
        public TableOptions CurrentOptions
        {
            get
            {
                return currentOptions;
            }
            set
            {
                btnAddRecord.Enabled = value != null ? value.AddForm != null : false;
                btnDeleteRecord.Enabled = value != null ? value.DeleteForm != null : false;
                btnSearchRecord.Enabled = value != null ? value.SearchForm != null : false;
                btnUpdateRecord.Enabled = value != null ? value.UpdateForm != null : false;
                currentOptions = value;
            }
        }

        private void btnClientCenter_Click(object sender, EventArgs e)
        {
            PresentationController.current.CurrentState = PresentationController.State.CallCenter;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (CurrentOptions != null)
            {
                CurrentOptions.AddForm.Show();
            }
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTable.SelectedItem.ToString())
            {
                case "Addresses":
                    CurrentOptions = PresentationController.current.AddressOptions;
                    break;
                case "Conditions":
                    CurrentOptions = PresentationController.current.ConditionsOptions;
                    break;
                case "Service Providers":
                    CurrentOptions = PresentationController.current.ProvidersOptions;
                    break;
                case "Treatments":
                    CurrentOptions = PresentationController.current.TreatmentsOptions;
                    break;
                case "Packages":
                    CurrentOptions = PresentationController.current.PackagesOptions;
                    break;
                case "Policy Data":
                    CurrentOptions = PresentationController.current.PolicyDataOptions;
                    break;
                default:
                    CurrentOptions = null;
                    break;
            }
        }
    }
}

