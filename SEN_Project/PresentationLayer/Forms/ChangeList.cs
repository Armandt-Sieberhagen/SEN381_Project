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

namespace SEN_Project.PresentationLayer.Forms
{

    public partial class ChangeList : TableForm
    {
        public ChangeList()
        {
            InitializeComponent();
        }
        public ObjectListVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        List<object> LeftObjects;
        List<object> RightObjects;

        public override void Reset() {
            if (LeftObjects==null)
            {
                LeftObjects = new List<object>();
            }
            else
            {
                LeftObjects.Clear();
            }
            if (RightObjects == null)
            {
                RightObjects = new List<object>();
            }
            else
            {
                RightObjects.Clear();
            }
            lbxAll.Items.Clear();
            lbxSelected.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (ConfirmCallback!=null)
            { 
                ConfirmCallback.Invoke(RightObjects);
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

        private void lbxAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = lbxAll.SelectedItem != null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RightObjects.Add(LeftObjects[lbxAll.SelectedIndex]);
            LeftObjects.RemoveAt(lbxAll.SelectedIndex);
            lbxSelected.Items.Add(lbxAll.SelectedItem);
            lbxAll.Items.Remove(lbxAll.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            LeftObjects.Add(RightObjects[lbxSelected.SelectedIndex]);
            RightObjects.RemoveAt(lbxSelected.SelectedIndex);
            lbxAll.Items.Add(lbxSelected.SelectedItem);
            lbxSelected.Items.Remove(lbxSelected.SelectedItem);
        }

        private void lbxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lbxSelected.SelectedItem != null;
        }

        private void ChangeList_Load(object sender, EventArgs e)
        {

        }

        public  void    SetLeftItems    (List<object>   _LeftItems)
        {
            lbxAll.Items.Clear();
            LeftObjects = _LeftItems;
            foreach (object item in _LeftItems)
            {
                try
                {
                    lbxAll.Items.Add(((ILineable)item).ToLine());
                }
                catch (Exception)
                {
                    lbxAll.Items.Add(item.ToString());
                }
            }
        }

        public void SetRightItems(List<object> _RightItems)
        {
            lbxSelected.Items.Clear();
            RightObjects = _RightItems;
            foreach (object item in _RightItems)
            {
                try
                {
                    lbxSelected.Items.Add(((ILineable)item).ToLine());
                }
                catch (Exception)
                {
                    lbxSelected.Items.Add(item.ToString());
                }
            }
        }
    }
}
