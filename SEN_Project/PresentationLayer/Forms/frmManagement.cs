using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project;
using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.PresentationLayer.Forms
{
    public partial class frmManagement : TableForm
    {
        public frmManagement()
        {
            InitializeComponent();
            Reset();
        }
        public List<object> Objects;
        public ManageForm AddForm;
        public ManageForm ModifyForm;
        public ObjectVoid DeleteCallback;
        int ModifyIndex;

        private void frmManagement_Load(object sender, EventArgs e)
        {

        }

        public  override    void    Reset   ()
        {
            if (Objects==null)
            {
                Objects = new List<object>();
            }
            else
            {
                Objects.Clear();
            }
            lbxItems.Items.Clear();
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.current.Show();
        }

        public void AddObject(object Item)
        {
            if (!Objects.Contains(Item))
            {
                Objects.Add(Item);
                lbxItems.Items.Add(((ILineable)Item).ToLine());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm.Reset();
            AddForm.Show();
            AddForm.ConfirmCallback = AddObject;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lbxItems.SelectedIndex==-1)
            {
                PresentationController.current.ShowError("Please select an item to modify");
                return;
            }
            ModifyForm.Hide();
            ModifyForm.Show();
            ModifyIndex =   lbxItems.SelectedIndex;
            ModifyForm.SetObject(Objects[lbxItems.SelectedIndex]);
            ModifyForm.ConfirmCallback = ModifyItem;
        }

        public  void    ModifyItem  (object _Object)
        {
            Objects[ModifyIndex] = _Object;
            lbxItems.Items[ModifyIndex] = ((ILineable)_Object).ToLine();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxItems.SelectedIndex == -1)
            {
                PresentationController.current.ShowError("Please select an item to delete");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete item?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ////BusinessLogic.current.Delete<MedicalCondition>((MedicalCondition)Objects[lbxItems.SelectedIndex]);
                ////Type T = Objects[lbxItems.SelectedIndex].GetType();
                //object _Object = Objects[lbxItems.SelectedIndex];
                //BusinessLogic.current.Delete(_Object);
                DeleteCallback.Invoke(Objects[lbxItems.SelectedIndex]);
                Objects.RemoveAt(lbxItems.SelectedIndex);
                lbxItems.Items.RemoveAt(lbxItems.SelectedIndex);
            }
        }

        public  void    SetItems    (List<object>   Items)
        {
            lbxItems.Items.Clear();
            Objects = Items;
            foreach (object Item in Items)
            {
                lbxItems.Items.Add(((ILineable)Item).ToLine());
            }
        }
    }
}
