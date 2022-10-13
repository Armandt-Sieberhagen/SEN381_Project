using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN_Project.PresentationLayer
{
    public partial class DatabaseForm : Form
    {
        public static DatabaseForm current;
        public DatabaseForm()
        {
            current = this;
            InitializeComponent();
        }
        TableOptions currentOptions;
        public TableOptions CurrentOptions {
            get {
                return currentOptions;
            }
            set {
                btnAddRecord.Enabled = value.AddForm != null;
                btnDeleteRecord.Enabled = value.DeleteForm != null;
                btnSearchRecord.Enabled = value.SearchForm != null;
                btnUpdateRecord.Enabled = value.UpdateForm != null;
                currentOptions = value;
            }
        }

        private void btnClientCenter_Click(object sender, EventArgs e)
        {
            PresentationController.current.CurrentState = PresentationController.State.CallCenter;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (CurrentOptions!=null)
            {
                CurrentOptions.AddForm.Show();
            }
        }
    }
}

