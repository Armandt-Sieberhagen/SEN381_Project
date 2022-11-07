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
using SEN_Project.PresentationLayer.Clients;
using SEN_Project.PresentationLayer.Forms.ListSearchForm;

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
            SetPolicy(Pol.DataRef);
        }

        public void SetPolicy(PolicyData Pol)
        {
            rtxtPolicyData.Text = Pol.ToString();
        }

        public void SetPolicy(int Index,string Line)
        {
            SetPolicy(BusinessLogic.current.GetByID<PolicyData>(Index));
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
                Members.Add(Factory.CreatePolicyMember(HeadMember, BusinessLogic.current.GetAll<FamilyPolicy>().Count,PolicyMember.PolicyRole.Head));
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
            btnSwitchType.Text = Family ? "Switch to individual policy" : "Switch to family policy";
        }

        void SwitchMode(bool    Mode)
        {
            Family = Mode;
            gbxIndividualPolicy.Enabled = !Family;
            gbxFamilyPolicy.Enabled = Family;
        }

        private void btnChangeIndividual_Click(object sender, EventArgs e)
        {
            frmSearchClient ClientSearch = Factory.GetSearchClient();
            ClientSearch.ConfirmCallback = SetIndividualMember;
            ClientSearch.Show();
        }

        private void btnChangeHeadMember_Click(object sender, EventArgs e)
        {
            frmSearchClient ClientSearch = Factory.GetSearchClient();
            ClientSearch.ConfirmCallback = SetHeadMember;
            ClientSearch.Show();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmSearchClient ClientSearch = Factory.GetSearchClient();
            ClientSearch.ConfirmCallback = AddMember;
            ClientSearch.Show();
        }

        public  void    AddMember   (Client NewMember)
        {
            if (NewMember==HeadMember)
            {
                return;
            }
            Members.Add(Factory.CreatePolicyMember(NewMember, BusinessLogic.current.GetAll<FamilyPolicy>().Count));
            lbxFamilyMembers.Items.Add(NewMember.ToLine());
        }

        private void btnSelectPolicyData_Click(object sender, EventArgs e)
        {
            frmSearchList SearchList = GlobalFunctions.CreateSearchForm<PolicyData>();
            SearchList.ConfirmCallback = SetPolicy;
            SearchList.Show();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (lbxFamilyMembers.SelectedIndex>-1)
            {
                Members.RemoveAt(lbxFamilyMembers.SelectedIndex);
                lbxFamilyMembers.Items.RemoveAt(lbxFamilyMembers.SelectedIndex);
            }
            else
            {
                PresentationController.current.ShowError("Please select a member to remove");
            }
        }

        private void btnCopyIndividual_Click(object sender, EventArgs e)
        {
            if (HeadMember!=null && !Family)
            {
                SEN_Clipboard._Client = HeadMember;
            }
        }

        private void btnPasteIndividual_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Client!=null &&  !Family)
            {
                SetHeadMember(SEN_Clipboard._Client);
            }
        }

        private void btnCopyHeadMember_Click(object sender, EventArgs e)
        {
            if (HeadMember != null && Family)
            {
                SEN_Clipboard._Client = HeadMember;
            }
        }

        private void btnPasteHeadMember_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Client != null && Family)
            {
                SetHeadMember(SEN_Clipboard._Client);
            }
        }

        private void btnCopyMember_Click(object sender, EventArgs e)
        {
            if (lbxFamilyMembers.SelectedIndex>-1)
            {
                SEN_Clipboard._PolicyMember = Members[lbxFamilyMembers.SelectedIndex];
            }
        }

        private void btnPasteMember_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._PolicyMember!=null)
            {
                AddMember(SEN_Clipboard._PolicyMember.Person);
            }
        }

        private void btnCopyPolicyData_Click(object sender, EventArgs e)
        {
            if (DataRef!=null)
            {
                SEN_Clipboard._PolicyData = DataRef;
            }
        }

        private void btnPastePolicyData_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._PolicyData!=null)
            {
                SetPolicy(SEN_Clipboard._PolicyData);
            }
        }

        private void btnCopyPolicy_Click(object sender, EventArgs e)
        {
            Policy Result = GetResult();
            if (Result!=null)
            {
                SEN_Clipboard._Policy = Result;
            }
        }

        private void btnPastePolicy_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Policy!=null)
            {
                SetPolicy(SEN_Clipboard._Policy.DataRef);

            }
        }
    }
}
