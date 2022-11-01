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

namespace SEN_Project.PresentationLayer.Clients
{
    public partial class frmSearchClient : TableForm
    {
        public frmSearchClient()
        {
            InitializeComponent();
        }
        List<SEN_Project.BusinessLogicLayer.Client> CurrentClients;
        public ClientVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        Client   SelectedClient  => lbxClients.SelectedIndex>-1 ? CurrentClients[lbxClients.SelectedIndex] : null;

        private void frmSearchClient_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            List<Client> Clients = BusinessLogic.current.GetClientsByID(txtClientID.Text);
            SetItems(Clients);
        }

        void    SetItems    (List<Client>   Clients)
        {
            CurrentClients = Clients;
            foreach (Client client in Clients)
            {
                lbxClients.Items.Add(client.ToLine());
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            List<Client> Clients = BusinessLogic.current.GetClientsByFirstName(txtFirstName.Text);
            SetItems(Clients);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            List<Client> Clients = BusinessLogic.current.GetClientsByLastName(txtLastName.Text);
            SetItems(Clients);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ConfirmCallback!=null)
            {
                ConfirmCallback.Invoke(SelectedClient);
            }
            Hide();
        }

        private void lbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = lbxClients.SelectedItem != null;
            btnCopyClient.Enabled = lbxClients.SelectedItem != null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelCallback!=null)
            {
                CancelCallback.Invoke();
            }
            Hide();
        }

        private void btnSortFirstNames_Click(object sender, EventArgs e)
        {
            CurrentClients.Sort();
        }

        private void btnCopyClient_Click(object sender, EventArgs e)
        {
            if (SelectedClient!=null)
            {
                SEN_Clipboard._Client = SelectedClient;
            }
        }

        public  override    void    Reset   ()
        {
            txtClientID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            lbxClients.Items.Clear();

            btnConfirm.Enabled = false;
            btnCopyClient.Enabled = false;

            List<Client> AllClients = BusinessLogic.current.GetAllClients();//Fix this. Why it give error?
            SetItems(AllClients);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SEN_Clipboard._Client!=null)
            {
                txtClientID.Text = SEN_Clipboard._Client.ClientID.ToString();
                txtFirstName.Text = SEN_Clipboard._Client.FirstName;
                txtLastName.Text = SEN_Clipboard._Client.LastName;
            }
        }
    }
}
