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
using SEN_Project.PresentationLayer.Forms;

namespace SEN_Project.PresentationLayer.PolicyDetails
{
    public partial class frmPolicyDetails : ManageForm
    {
        public frmPolicyDetails()
        {
            InitializeComponent();
            Reset();
        }
        List<Treatment> TreatmentsCovered;

        public  void    SetPolicyData   (PolicyData Data)
        {
            TreatmentsCovered.Clear();
            foreach (Treatment treatment in Data.TreatmentsCovered)
            {
                AddTreatment(treatment);
            }
            txtPolicyName.Text = Data.Name;
            rtxtPolicyDescription.Text = Data.Description;
            numPrice.Value = (decimal)Data.Price;
            cbxAvailable.Checked = Data.Available;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PolicyData Result = GetResult();
            if (ConfirmCallback!=null && Result!=null)
            {
                ConfirmCallback.Invoke(Result);
            }
            Hide();
        }

        public override void Reset()
        {
            if (TreatmentsCovered==null)
            {
                TreatmentsCovered = new List<Treatment>();
            }
            else
            {
                TreatmentsCovered.Clear();
            }
            txtPolicyName.Clear();
            rtxtPolicyDescription.Clear();
            rtxtTreatmentCovered.Clear();
        }

        public  PolicyData  GetResult   ()
        {
            //Validation!!
            return Factory.CreatePolicyData(txtPolicyName.Text,rtxtPolicyDescription.Text,(float)numPrice.Value,TreatmentsCovered);
        }

        private void frmPolicyDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeTreatments_Click(object sender, EventArgs e)
        {
            ChangeList TreatmentSelection = GlobalFunctions.CreateChangeList<Treatment>(TreatmentsCovered, true);
            TreatmentSelection.ConfirmCallback = SetTreatments;
            TreatmentSelection.Show();
        }

        public  void    SetTreatments   (List<object>    Treatments)
        {
            TreatmentsCovered.Clear();
            foreach (object item in Treatments)
            {
                AddTreatment((Treatment)item);
            }
        }

        public  void    AddTreatment    (Treatment  treatment)
        {
            if (!TreatmentsCovered.Contains(treatment))
            {
                TreatmentsCovered.Add(treatment);
                rtxtTreatmentCovered.Text += treatment.ToLine() + '\n';
            }
        }

        private void rtxtTreatmentCovered_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            PolicyData Result = GetResult();
            if (Result!=null)
            {
                SEN_Clipboard._PolicyData = Result;
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._PolicyData!=null)
            {
                SetPolicyData(SEN_Clipboard._PolicyData);
            }
        }
    }
}
