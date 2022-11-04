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

namespace SEN_Project.PresentationLayer.PolicyDetails
{
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }
        public List<object> Objects;
        public ManageForm AddForm;
        public ManageForm ModifyForm;
        public ManageForm DeleteForm;

        private void frmManagement_Load(object sender, EventArgs e)
        {

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
            ModifyForm.Show();
            //ModifyForm.
            //ModifyForm.ConfirmCallback = ModifyItem;
        }
    }
}
