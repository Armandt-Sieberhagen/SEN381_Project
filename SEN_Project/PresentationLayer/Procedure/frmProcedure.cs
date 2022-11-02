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
using SEN_Project.PresentationLayer.Clients;

namespace SEN_Project.PresentationLayer.Procedure
{
    public partial class frmProcedure : TableForm
    {
        public frmProcedure()
        {
            InitializeComponent();
        }
        public ProcedureVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        Client SelectedClient;
        MedicalCondition Condition;
        Treatment _Treatment;
        MedicalServiceProvider Facility;
        Policy SelectedPolicy;

        private void frmProcedure_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ClinicalProcedure Result = GetResult();
            if (ConfirmCallback!=null && Result!=null)
            {
                ConfirmCallback.Invoke(Result);
            }
            Hide();
        }

        public  ClinicalProcedure   GetResult   ()
        {
            //Do validation!!!
            return Factory.CreateClinicalProcedure(Condition,_Treatment,Facility,SelectedPolicy,SelectedClient);
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frmSearchClient ClientSearch = Factory.GetSearchClient();
            ClientSearch.ConfirmCallback = SetClient;
            ClientSearch.Show();
        }

        public  void    SetClient   (Client NewClient)
        {
            SelectedClient = NewClient;
            rtxtClientInfo.Text = NewClient.PersonalDetails;

            SetPolicy(NewClient.MyPolicy);
        }

        private void btnSelectCondition_Click(object sender, EventArgs e)
        {
            frmSearchList ConditionSearch = GlobalFunctions.CreateSearchForm<MedicalCondition>();
            ConditionSearch.ConfirmCallback = SetCondition;
            ConditionSearch.Show();
        }

        public  void    SetCondition    (int    Index,string    Line)
        {
            SetCondition(BusinessLogic.current.GetByID<MedicalCondition>(Index));
        }

        public  void    SetCondition    (MedicalCondition   condition)
        {
            Condition = condition;
            rtxtConditionInfo.Text = Condition != null ? Condition.ToString() : "";
        }

        private void btnSelectTreatment_Click(object sender, EventArgs e)
        {
            frmSearchList TreatmentSearch = GlobalFunctions.CreateSearchForm<Treatment>();
            TreatmentSearch.ConfirmCallback = SetTreatment;
            TreatmentSearch.Show();
        }

        public  void    SetTreatment    (int    Index,string    Line)
        {
            SetTreatment(BusinessLogic.current.GetByID<Treatment>(Index));
        }

        public  void    SetTreatment    (Treatment  treatment)
        {
            if (treatment!=null)
            {
                _Treatment = treatment;
                rtxtTreatmentInfo.Text = treatment != null ? treatment.ToString() : "";
            }
        }

        private void btnSelectFacility_Click(object sender, EventArgs e)
        {
            frmSearchList FacilitySearch = GlobalFunctions.CreateSearchForm<MedicalServiceProvider>();
            FacilitySearch.ConfirmCallback = SetFacility;
            FacilitySearch.Show();
        }

        public  void    SetFacility (int    ID,string   Line)
        {
            SetFacility(BusinessLogic.current.GetByID<MedicalServiceProvider>(ID));
        }

        public  void    SetFacility(MedicalServiceProvider  facility)
        {
            if (facility!=null)
            {
                Facility = facility;
                rtxtFacilityDisplay.Text = facility != null ? facility.ToString() : "";
            }
        }

        private void btnSelectPolicy_Click(object sender, EventArgs e)
        {
            if (SelectedClient==null)
            {
                return;
            }
            frmSearchList PolicySearch = GlobalFunctions.CreateSearchForm<Policy>(SelectedClient.PastPolicies);
            PolicySearch.ConfirmCallback = SetPolicy;
            PolicySearch.Show();
        }

        public void SetPolicy(int ID, string Line)
        {
            SetPolicy(BusinessLogic.current.GetByID<Policy>(ID));
        }

        public void SetPolicy(Policy pol)
        {
            if (pol != null)
            {
                SelectedPolicy = pol;
                rtxtFacilityDisplay.Text = pol != null ? pol.ToString() : "";
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
    }
}
