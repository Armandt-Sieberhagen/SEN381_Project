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

namespace SEN_Project.PresentationLayer.Forms.ListSearchForm
{
    public partial class frmSearchList : TableForm
    {
        public frmSearchList()
        {
            InitializeComponent();
        }
        public ListItemVoid ConfirmCallback;
        public EmptyVoid CancelCallback;

        private void frmSearchList_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public override void    Reset   ()
        {
            lbxItems.Items.Clear();
            btnConfirm.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ConfirmCallback!=null   &&  lbxItems.SelectedIndex>-1)
            {
                ConfirmCallback.Invoke(lbxItems.SelectedIndex,lbxItems.SelectedItem.ToString());
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

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = lbxItems.SelectedIndex > -1;
        }

        public  void    SetItems    (List<string>   Items)
        {
            lbxItems.Items.Clear();
            foreach (string item in Items)
            {
                lbxItems.Items.Add(item);
            }
        }
    }
}
