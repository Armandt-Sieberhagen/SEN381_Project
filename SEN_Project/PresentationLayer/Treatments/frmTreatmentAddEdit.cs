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
using SEN_Project.PresentationLayer;
using SEN_Project.PresentationLayer.Forms;

namespace SEN_Project.PresentationLayer.Treatments
{
    public partial class frmTreatmentAddEdit : ManageForm
    {
        public frmTreatmentAddEdit()
        {
            InitializeComponent();
            Reset();
        }
        public EmptyVoid CancelCallback;
        List<MedicalCondition> Conditions;
        
        
        public  override    void    Reset   ()
        {
            txtTreatmentName.Clear();
            rtxtDescription.Clear();
            if (Conditions==null)
            {
                Conditions = new List<MedicalCondition>();
            }
            else
            {
                Conditions.Clear();
            }
        }

        public override void SetObject(object _Object)
        {
            SetTreatment((Treatment)_Object);
        }

        public  void    SetTreatment    (Treatment  _NewTreatment)
        {
            txtTreatmentName.Text = _NewTreatment.Name;
            rtxtDescription.Text = _NewTreatment.Description;
            Conditions = _NewTreatment.ConditionsCovered;
        }

        private void btnConfirm_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
        }

        public  Treatment   GetResult   ()
        {
            //validation
            return Factory.CreateTreatment(txtTreatmentName.Text,rtxtDescription.Text,Conditions);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Treatment Result = GetResult();
            if (ConfirmCallback != null && Result != null)
            {
                ConfirmCallback.Invoke(Result);
            }
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelCallback!=null)
            {
                CancelCallback.Invoke();
            }
            Hide();
        }

        private void frmTreatmentAddEdit_Load(object sender, EventArgs e)
        {

        }

        private void lblTreatmentDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ChangeList OptionsChange = GlobalFunctions.CreateChangeList<MedicalCondition>(Conditions);
            OptionsChange.ConfirmCallback = SetConditions;
            OptionsChange.Show();
        }

        public  void    SetConditions   (List<object>   Objects)
        {
            Conditions.Clear();
            lbxConditionsCovered.Items.Clear();
            foreach (object item in Objects)
            {
                AddCondition((MedicalCondition)item);
            }
        }

        public  void    AddCondition    (MedicalCondition   Condition)
        {
            if (!Conditions.Contains(Condition))
            {
                Conditions.Add(Condition);
                lbxConditionsCovered.Items.Add(Condition.ToLine());
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Treatment Result = GetResult();
            if (Result!=null)
            {
                SEN_Clipboard._Treatment = Result;
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Treatment!=null)
            {
                SetTreatment(SEN_Clipboard._Treatment);
            }
        }
    }
}
