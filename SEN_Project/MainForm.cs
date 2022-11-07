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
using SEN_Project.PresentationLayer.Conditions;
using SEN_Project.PresentationLayer.Forms;
using SEN_Project.DataAccessLayer;
using SEN_Project.BusinessLogicLayer;
using SEN_Project.DataLayer;
using SEN_Project.PresentationLayer.Forms;
using SEN_Project.PresentationLayer.Treatments;
using SEN_Project.PresentationLayer.CallCentre;
using SEN_Project.PresentationLayer.Tree;

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
        Client currentClient;
        public Client CurrentClient {
            get {
                return currentClient;
            }
            set {
                if (value!=null)
                {
                    //lblClientID.Text = "Client ID: " + value.ClientID;
                    //lblFirstName.Text = "First Name: " +value.FirstName;
                    //lblLastName.Text = "Last Name: "+value.LastName;
                    //lblIdNumber.Text = "ID Number: " + value.IDNumber;
                    //lblPhoneNumber.Text = "Phone Number: " + value.PhoneNumber;
                    //lblEmail.Text = "E-mail: " + value.Email;
                    //rtxtAddress.Text = value.PersonAddress.ToString();
                }
                currentClient = value;
            }
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
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
            //AddClientForm = AddClientForm ?? Factory.GetAddClientForm();
            //AddClientForm.Reset();
            //AddClientForm.CancelCallback = CloseAddClient;
            //AddClientForm.ConfirmCallback = AddClient;
            //AddClientForm.Show();
        }

        //public  void    AddClient   (Client _Client)
        //{
        //    //Do stuff here
        //    BusinessLogic.current.AddClient(_Client);
        //    CloseAddClient();
        //}

        //public  void    SetClient   (Client _Client)
        //{
        //    CurrentClient = _Client;
        //}

        //public  void    CloseAddClient  ()
        //{
        //    //if (AddClientForm!=null)
        //    //{
        //    //    AddClientForm.Hide();
        //    //}
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimulateClient_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCallCentre CallCentre = new frmCallCentre();
            CallCentre.Show();
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BusinessLogic.current.CloseOff();
        }

        private void btnConditionCentre_Click(object sender, EventArgs e)
        {
            frmManagement ManagementForm = Factory.GetManagementForm();
            ManagementForm.AddForm = Factory.GetConditionForm();
            ManagementForm.ModifyForm = Factory.GetConditionForm();
            ManagementForm.DeleteCallback = DeleteCondition;
            List<object> Items = new List<object>();
            List<MedicalCondition> Conditions = BusinessLogic.current.GetAll<MedicalCondition>();
            foreach (MedicalCondition item in Conditions)
            {
                Items.Add((object)item);
            }
            ManagementForm.SetItems(Items);
            ManagementForm.Show();
            Hide();
        }

        public  void    DeleteCondition (object Condition)
        {
            BusinessLogic.current.Delete<MedicalCondition>((MedicalCondition)Condition);
        }

        private void btnTreatmentManagement_Click(object sender, EventArgs e)
        {
            frmManagement ManagementForm = Factory.GetManagementForm();
            ManagementForm.AddForm = Factory.GetTreatmentForm();
            ManagementForm.ModifyForm = Factory.GetTreatmentForm();
            ManagementForm.DeleteCallback = DeleteTreatment;
            List<object> Items = new List<object>();
            List<Treatment> Treatments = BusinessLogic.current.GetAll<Treatment>();
            foreach (Treatment treatment in Treatments)
            {
                Items.Add(treatment);
            }
            ManagementForm.SetItems(Items);
            ManagementForm.Show();
            Hide();
        }

        public void DeleteTreatment(object Condition)
        {
            BusinessLogic.current.Delete<Treatment>((Treatment)Condition);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Tree tree = Factory.GetTreeForm();
            
            tree.Show();
            Hide();
        }

        private void btnPolicy_Click(object sender, EventArgs e)
        {
            frmManagement ManagementForm = Factory.GetManagementForm();
            ManagementForm.AddForm = Factory.GetPolicyDetailsForm();
            ManagementForm.ModifyForm = Factory.GetPolicyDetailsForm();
            ManagementForm.DeleteCallback = DeletePolicy;
            List<object> Items = new List<object>();
            List<PolicyData> Data = BusinessLogic.current.GetAll<PolicyData>();
            foreach (PolicyData data in Data)
            {
                Items.Add(data);
            }
            ManagementForm.SetItems(Items);
            ManagementForm.Show();
            Hide();
        }

        public void DeletePolicy(object Data)
        {
            BusinessLogic.current.Delete<PolicyData>((PolicyData)Data);
        }

        private void btnFacilityManagement_Click(object sender, EventArgs e)
        {
            frmManagement ManagementForm = Factory.GetManagementForm();
            ManagementForm.AddForm = Factory.GetFacilityForm();
            ManagementForm.ModifyForm = Factory.GetFacilityForm();
            ManagementForm.DeleteCallback = DeleteFacility;
            List<object> Items = new List<object>();
            List<MedicalServiceProvider> Data = BusinessLogic.current.GetAll<MedicalServiceProvider>();
            foreach (MedicalServiceProvider data in Data)
            {
                Items.Add(data);
            }
            ManagementForm.SetItems(Items);
            ManagementForm.Show();
            Hide();
        }

        public void DeleteFacility(object Facility)
        {
            BusinessLogic.current.Delete<MedicalServiceProvider>((MedicalServiceProvider)Facility);
        }
    }
}
