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
    public partial class ChangeList : Form
    {
        public ChangeList()
        {
            InitializeComponent();
        }
        ChangeListOptions currentOptions;
        public ChangeListOptions CurrentOptions {
            get {
                return currentOptions;
            }
            set {
                lbxAll.Items.Clear();
                foreach (string item in value.AllOptions)
                {
                    lbxAll.Items.Add(item);
                }
                currentOptions = value;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            List<string> Result = new List<string>();
            foreach (var item in lbxSelected.Items)
            {
                Result.Add(item.ToString());
            }
            CurrentOptions.Callback.Invoke(Result);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CurrentOptions.CancelCallback.Invoke();
        }

        private void lbxAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = lbxAll.SelectedItem != null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxSelected.Items.Add(lbxAll.SelectedItem);
            lbxAll.Items.Remove(lbxAll.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbxAll.Items.Add(lbxSelected.SelectedItem);
            lbxSelected.Items.Remove(lbxSelected.SelectedItem);
        }

        private void lbxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lbxSelected.SelectedItem != null;
        }
    }
}
