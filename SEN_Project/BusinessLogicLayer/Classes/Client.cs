using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Client
    {
        int clientID;
        string firstName;
        string lastName;
        List<Call> callHistory;
        List<Policy> policies;
        string idNumber;
        Address address;
        string email;
        string phoneNumber;
        List<Claim> claimsHistory;
        List<ClinicalProcedure> clinicalHistory;
        List<string> activePerscriptions;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FullName => FirstName + " " + LastName;
        public List<Call> CallHistory {
            get { return callHistory; }
            set { callHistory = value; }
        }
        public List<Policy> Policies {
            get { return policies; }
            set { policies = value; }
        }
        public string IDNumber {
            get { return idNumber; }
            set { idNumber = value;}
        }
        public Address ClientAddress {
            get { return address; }
            set { address = value; }
        }
        public  string  Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public List<Claim> ClaimsHistory
        {
            get { return claimsHistory; }
            set { claimsHistory = value; }
        }
        public List<ClinicalProcedure> ClinicalHistory
        {
            get { return clinicalHistory; }
            set { clinicalHistory = value; }
        }
        public List<string> ActivePerscriptions
        {
            get { return activePerscriptions; }
            set { activePerscriptions = value; }
        }
    }
}
