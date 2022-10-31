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
using SEN_Project.PresentationLayer.Client;

namespace SEN_Project.PresentationLayer.CallCentre
{
    public partial class frmCallCentre : Form
    {

        Call CurrentCall;
        DateTime CallStart;

        public frmCallCentre()
        {
            InitializeComponent();
        }

        private void frmCallCentre_Load(object sender, EventArgs e)
        {

        }

        private void btnSimulateCall_Click(object sender, EventArgs e)
        {
            CallStart = DateTime.Now;
            lblStartTime.Text = CallStart.ToString();
            //Start Timer
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frmSearchClient SearchFrm   =   Factory.GetSearchClient();
            SearchFrm.ConfirmCallback   =   
        }

        public  void    SetClient   (Client _Client)
        {

        }
    }
}
