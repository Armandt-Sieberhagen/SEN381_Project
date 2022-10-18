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
using SEN_Project.DataAccessLayer;
using SEN_Project.PresentationLayer.Treatments;
using SEN_Project.PresentationLayer.Addresses.AddressCreator;

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
                btnDeleteRecord.Enabled = true;//value != null ? value.DeleteForm != null : false;
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
                CurrentOptions.AddForm.Reset();

                switch (cbxTable.SelectedItem.ToString())
                {
                    case "Addresses":
                        AddressCreator.current.OnCancel = AddressCreator.current.Hide;
                        AddressCreator.current.OnConfirm = BusinessLogic.current.AddAddress;
                        break;
                    case "Conditions":
                        break;
                    case "Service Providers":

                        break;
                    case "Treatments":
                        frmTreatmentAddEdit.current.CancelCallback = frmTreatmentAddEdit.current.Hide;
                        frmTreatmentAddEdit.current.ConfirmCallback = BusinessLogic.current.AddTreatment;
                        break;
                    case "Packages":

                        break;
                    case "Policy Data":

                        break;
                    default:
                        CurrentOptions = null;
                        break;
                }

                CurrentOptions.AddForm.Show();
            }
            RefreshDB();
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTable.SelectedItem.ToString())
            {
                case "Addresses":
                    CurrentOptions = PresentationController.current.AddressOptions;
                    dgvDatabase.DataSource    = DatabaseController.current.GetSource("tbl_Addresses");
                    break;
                case "Conditions":
                    CurrentOptions = PresentationController.current.ConditionsOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Conditions");
                    break;
                case "Service Providers":
                    CurrentOptions = PresentationController.current.ProvidersOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Service_Providers");
                    break;
                case "Treatments":
                    CurrentOptions = PresentationController.current.TreatmentsOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Treatments");
                    break;
                case "Packages":
                    CurrentOptions = PresentationController.current.PackagesOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Packages");
                    break;
                case "Policy Data":
                    CurrentOptions = PresentationController.current.PolicyDataOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Policy_Data");
                    break;
                default:
                    CurrentOptions = null;
                    break;
            }
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            if (CurrentOptions != null)
            {
                CurrentOptions.AddForm.Reset();

                switch (cbxTable.SelectedItem.ToString())
                {
                    case "Addresses":
                        AddressCreator.current.OnCancel = AddressCreator.current.Hide;
                        break;
                    case "Conditions":
                        break;
                    case "Service Providers":

                        break;
                    case "Treatments":
                        frmTreatmentAddEdit.current.CancelCallback = frmTreatmentAddEdit.current.Hide;
                        break;
                    case "Packages":

                        break;
                    case "Policy Data":

                        break;
                    default:
                        CurrentOptions = null;
                        break;
                }

                CurrentOptions.AddForm.Show();
            }
            RefreshDB();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDB();
        }

        void    RefreshDB ()
        {
            switch (cbxTable.SelectedItem.ToString())
            {
                case "Addresses":
                    CurrentOptions = PresentationController.current.AddressOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Addresses");
                    break;
                case "Conditions":
                    CurrentOptions = PresentationController.current.ConditionsOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Conditions");
                    break;
                case "Service Providers":
                    CurrentOptions = PresentationController.current.ProvidersOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Service_Providers");
                    break;
                case "Treatments":
                    CurrentOptions = PresentationController.current.TreatmentsOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Treatments");
                    break;
                case "Packages":
                    CurrentOptions = PresentationController.current.PackagesOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Packages");
                    break;
                case "Policy Data":
                    CurrentOptions = PresentationController.current.PolicyDataOptions;
                    dgvDatabase.DataSource = DatabaseController.current.GetSource("tbl_Policy_Data");
                    break;
                default:
                    CurrentOptions = null;
                    break;
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (dgvDatabase.SelectedRows.Count>0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    switch (cbxTable.SelectedItem.ToString())
                    {
                        case "Addresses":
                            string Street = dgvDatabase.SelectedRows[0].Cells[1].Value.ToString();
                            string City = dgvDatabase.SelectedRows[0].Cells[2].Value.ToString();
                            string Postal = dgvDatabase.SelectedRows[0].Cells[3].Value.ToString();
                            string Province = dgvDatabase.SelectedRows[0].Cells[4].Value.ToString();
                            Address _add = Factory.CreateAddress(Street, City, Province, Postal);
                            BusinessLogic.current.Delete(_add);
                            break;
                        case "Conditions":

                            break;
                        case "Service Providers":

                            break;
                        case "Treatments":

                            break;
                        case "Packages":

                            break;
                        case "Policy Data":

                            break;
                        default:
                            break;
                    }
                }
            }
            RefreshDB();
        }

        private void dgvDatabase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

