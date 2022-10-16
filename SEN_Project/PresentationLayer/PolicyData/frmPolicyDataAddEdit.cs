using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN_Project.PresentationLayer.PolicyData
{
    public partial class frmPolicyDataAddEdit : Form
    {
        public frmPolicyDataAddEdit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeTreatments_Click(object sender, EventArgs e)
        {
            List<string> AllTreatments = new List<string>();
            //AllTreatments = BusniessLogic.current.GetTreatmentsList(); IMPLEMENT THIS!!!
            AllTreatments.Add("");
        }
    }
}
