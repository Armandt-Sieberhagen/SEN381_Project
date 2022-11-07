﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN_Project.BusinessLogicLayer;
using SEN_Project.PresentationLayer.Addresses;
using SEN_Project.PresentationLayer.Forms.ListSearchForm;

namespace SEN_Project.PresentationLayer.Employees
{
    public partial class frmCreateEmployee : TableForm
    {
        public frmCreateEmployee()
        {
            InitializeComponent();
        }
        public EmployeeVoid ConfirmCallback;
        public EmptyVoid CancelCallback;
        Address _Address;

        private void gbxEmployee_Enter(object sender, EventArgs e)
        {

        }

        private bool EmailValidation()
        {
            if (txtEmail.Text.Contains("@"))
            {
                if (txtEmail.Text.Contains("."))
                {
                    if (txtEmail.Text.Contains(" "))
                    {
                        MessageBox.Show("Email cannot contain spaces");
                        return false;
                    }
                    else return true;
                }
                else
                {
                    MessageBox.Show("Email must contain a .");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Email must contain an @");
                return false;
            }
        }

        Employee GetResult()
        {

            if (txtEmail.Text.Length>0 && txtEmail.Text.Length<20 && EmailValidation())
            {
                if (txtFirstName.Text.Length>0 && txtFirstName.Text.Length<=20)
                {
                    if (txtLastName.Text.Length>0 && txtLastName.Text.Length<=20)
                    {
                        if (txtID.Text.Length>0 && txtID.Text.Length<=13)
                        {
                            if (txtPhoneNumber.Text.Length>0 && txtPhoneNumber.Text.Length<=20)
                            {
                                if (_Address != null)
                                {
                                    string Name = txtFirstName.Text;
                                    string Surname = txtLastName.Text;
                                    string ID = txtID.Text;
                                    string PhoneNumber = txtPhoneNumber.Text;
                                    string Email = txtEmail.Text;
                                    return Factory.CreateEmployee(Name, Surname, ID, PhoneNumber, Email, _Address);
                                }
                                else
                                {
                                    MessageBox.Show("Please select an address");
                                    
                                }
                                MessageBox.Show("Please Enter a valid phone number");
                            }
                            else
                            {
                                MessageBox.Show("Please Enter a valid phone number");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Enter a valid ID number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a valid Last Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a valid First Name");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid Email");
            }
            return null;
           

        }

        /*	Employee_ID INT IDENTITY( 1 ,1 )PRIMARY  KEY,
	FirstName VARCHAR(20)	NOT  NULL,
	LastName VARCHAR(20)	NOT  NULL,
	ID_Number VARCHAR(13)	NOT  NULL,
	Email VARCHAR(20)	NOT  NULL,
	Phone VARCHAR(10)	NOT  NULL,
	Address_ID INT REFERENCES tbl_Addresses(ID)*/

        public void    SetAddress  (Address    _address)
        {
            _Address = _address;
            rtxtAddressInfo.Text = _Address.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Employee Result = GetResult();
            if (ConfirmCallback != null && Result != null)
            {
                ConfirmCallback.Invoke(Result);
            }
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelCallback != null)
            {
                CancelCallback.Invoke();
            }
            Hide();
        }

        private void frmCreateEmployee_Load(object sender, EventArgs e)
        {

        }

        public override  void    Reset   ()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtID.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            rtxtAddressInfo.Clear();
            _Address = null;
        }

        private void btnCreateAddress_Click(object sender, EventArgs e)
        {
            AddressCreator AddressForm = Factory.GetAddressCreator();
            AddressForm.OnConfirm = SetAddress;
            AddressForm.Show();
        }

        private void btnSelectAddress_Click(object sender, EventArgs e)
        {
            frmSearchList AddressSearch = Factory.GetSearchList();
            List<Address> AllAddresses = BusinessLogic.current.GetAllAddresses();
            List<string> Options = new List<string>();
            foreach (Address address in AllAddresses)
            {
                Options.Add(address.ToLine());
            }
            AddressSearch.SetItems(Options);
            AddressSearch.ConfirmCallback = SetAddress;
            AddressSearch.Show();
        }

        public  void    SetAddress (int ID,string   Line)
        {
            SetAddress(BusinessLogic.current.GetAddressByID(ID));
        }
    }
}
