using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.PresentationLayer;
using SEN_Project.DataAccessLayer;
using SEN_Project.BusinessLogicLayer;
using SEN_Project.DataLayer;
using SEN_Project.PresentationLayer.Forms.ClientOptions;

namespace SEN_Project
{
    public partial class Form1 : Form
    {
        public static Form1 current;
        public Form1()
        {
            current = this;
            InitializeComponent();
        }
        frmAddClient AddClientForm;
        Client currentClient;
        public Client CurrentClient {
            get {
                return currentClient;
            }
            set {
                if (value!=null)
                {
                    lblClientID.Text = "Client ID: " + value.ClientID;
                    lblFirstName.Text = "First Name: " +value.FirstName;
                    lblLastName.Text = "Last Name: "+value.LastName;
                    lblIdNumber.Text = "ID Number: " + value.IDNumber;
                    lblPhoneNumber.Text = "Phone Number: " + value.PhoneNumber;
                    lblEmail.Text = "E-mail: " + value.Email;
                    rtxtAddress.Text = value.ClientAddress.ToString();
                }
                currentClient = value;
            }
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            PresentationController.current.CurrentState = PresentationController.State.Database;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new BusinessLogic();
            new GlobalDataLayer().Initialize();
            new PresentationController();
            new DatabaseController();
            new DatabaseAccess();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm = AddClientForm ?? Factory.GetAddClientForm();
            AddClientForm.Reset();
            AddClientForm.CancelCallback = CloseAddClient;
            AddClientForm.ConfirmCallback = AddClient;
            AddClientForm.Show();
        }

        public  void    AddClient   (Client _Client)
        {
            //Do stuff here
            BusinessLogic.current.AddClient(_Client);
            CloseAddClient();
        }

        public  void    SetClient   (Client _Client)
        {
            CurrentClient = _Client;
        }

        public  void    CloseAddClient  ()
        {
            if (AddClientForm!=null)
            {
                AddClientForm.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimulateClient_Click(object sender, EventArgs e)
        {
            SetClient(Factory.GetRandomClient());
        }
    }
}
