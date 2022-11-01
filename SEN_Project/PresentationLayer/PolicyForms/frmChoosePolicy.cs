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

namespace SEN_Project.PresentationLayer.PolicyForms
{
    public partial class frmChoosePolicy : TableForm
    {
        public frmChoosePolicy()
        {
            InitializeComponent();
        }
        public PolicyVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        bool Family = false;

        List<PolicyMember> Members;
        Client HeadMember;
        PolicyData DataRef;



        private void frmChoosePolicy_Load(object sender, EventArgs e)
        {
            Reset();
        }
        
        public  void    SetAll  (Client CurrentClient)
        {
            if (CurrentClient.MyPolicy.GetType()==typeof(FamilyPolicy))
            {
                SetHeadMember(CurrentClient);
                SetPolicy(CurrentClient.MyPolicy);
                SetMembers(((FamilyPolicy)CurrentClient.MyPolicy).Members);
                SwitchMode(true);
            }
            else
            {
                SwitchMode(false);
                SetIndividualMember(CurrentClient);
                SetPolicy(CurrentClient.MyPolicy);
            }
        }

        public  void    SetHeadMember   (Client CurrentClient)
        {
            HeadMember = CurrentClient;
            rtxtHeadMemberAddress.Text = CurrentClient.AddressDetails;
            rtxtHeadMemberInfo.Text = CurrentClient.PersonalDetails;
        }

        public  void    SetPolicy   (Policy Pol)
        {
            rtxtPolicyData.Text = Pol.DataRef.ToString();
        }

        public  void    SetIndividualMember (Client _Client)
        {
            HeadMember = _Client;
            rtxtIndividualAddress.Text = _Client.AddressDetails;
            rtxtIndividualInfo.Text = _Client.PersonalDetails;
        }

        public  void    SetMembers  (List<PolicyMember> _Members)
        {
            GlobalFunctions.CopyList(_Members, Members);
            lbxFamilyMembers.Items.Clear();
            foreach (PolicyMember member in _Members)
            {
                lbxFamilyMembers.Items.Add(member.Person.ToLine());
            }
        }

        public  override    void    Reset   ()
        {
            btnConfirm.Enabled = false;
            btnSwitchType.Text = "Switch to Family Policy";
            rtxtHeadMemberAddress.Clear();
            rtxtHeadMemberInfo.Clear();
            rtxtIndividualAddress.Clear();
            rtxtIndividualInfo.Clear();
            rtxtPolicyData.Clear();
            lbxFamilyMembers.Items.Clear();
            gbxFamilyPolicy.Enabled = false;
            gbxIndividualPolicy.Enabled = true;
            HeadMember = null;
            Family = false;
            DataRef = null;
            if (Members==null)
            {
                Members = new List<PolicyMember>();
            }
            else
            {
                Members.Clear();
            }
        }

        public  Policy  GetResult   ()
        {
            if (Family)
            {
                Members.Add(Factory.CreatePolicyMember(HeadMember, PolicyMember.PolicyRole.Head));
                return Factory.CreateFamilyPolicy(Members, DataRef);
            }
            else
            {
                return Factory.CreateIndividualPolicy(HeadMember,DataRef);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Policy Result = GetResult();
            if (ConfirmCallback!=null   &&  Result!=null)
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

        private void btnSwitchType_Click(object sender, EventArgs e)
        {
            SwitchMode();
        }

        void    SwitchMode  ()
        {
            Family = !Family;
            gbxIndividualPolicy.Enabled = !Family;
            gbxFamilyPolicy.Enabled = Family;
        }

        void SwitchMode(bool    Mode)
        {
            Family = Mode;
            gbxIndividualPolicy.Enabled = !Family;
            gbxFamilyPolicy.Enabled = Family;
        }
    }
}
