using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.PresentationLayer.ChangeList;

namespace SEN_Project.PresentationLayer.Forms.ClientOptions
{
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }
        ChangeList CurrentChangeList;

        private void btnChangePolicies_Click(object sender, EventArgs e)
        {
            ChangeListOptions Options = new ChangeListOptions();
            Options.CancelCallback = HideList;
            Options.Callback = ListPolicies;
            //Fix this!!!
            List<string> AllPolicies = new List<string>();
            AllPolicies.Add("Policy 1");
            AllPolicies.Add("Policy 2");
            AllPolicies.Add("Policy 3");
            AllPolicies.Add("Policy 4");
            AllPolicies.Add("Policy 5");
            Options.AllOptions = AllPolicies;
            CurrentChangeList = new ChangeList();
            CurrentChangeList.CurrentOptions = Options;
            CurrentChangeList.Show();
        }

        public void HideList() {
            if (CurrentChangeList!=null)
            {
                CurrentChangeList.Hide();
            }
        }

        public  void ListPolicies   (List<string>   Items)
        {
            rtxtPolicies.Clear();
            foreach (string item in Items)
            {
                rtxtPolicies.Text += item + '\n';
            }
            CurrentChangeList.Hide();
        }

        private void lbxPerscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemovePerscription.Enabled = lbxPerscriptions.SelectedItem != null;
        }

        private void btnAddPerscription_Click(object sender, EventArgs e)
        {
            if (txtPerscription.Text.Trim().Length>0)
            {
                lbxPerscriptions.Items.Add(txtPerscription.Text);
                txtPerscription.Clear();
            }
            else
            {
                txtPerscription.Focus();
            }
        }

        private void txtPerscription_TextChanged(object sender, EventArgs e)
        {
            btnAddPerscription.Enabled = txtPerscription.Text.Trim().Length > 0;
        }

        private void btnRemovePerscription_Click(object sender, EventArgs e)
        {
            lbxPerscriptions.Items.RemoveAt(lbxPerscriptions.SelectedIndex);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
