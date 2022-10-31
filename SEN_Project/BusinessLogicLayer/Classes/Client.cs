using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Client : IComparable<Client>
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
            set { idNumber = value; }
        }
        public Address ClientAddress {
            get { return address; }
            set { address = value; }
        }
        public string Email
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

        public string ToLine => ClientID + '\t' + FirstName + '\t' + LastName + '\t' + IDNumber;
        public string PersonalDetails => $"Client ID: \t " + ClientID + " \n First Name: \t " + FirstName + " \t Last Name: " + LastName + " \n ID Number: \t" + IDNumber;
        public string AddressDetails => ClientAddress.ToString();

        public int CompareTo(Client obj)
        {
            if (obj==null)
            {
                return 1;
            }
            return this.ClientID.CompareTo(obj.ClientID);
        }

        public  int CompareTo   (Client obj, int Mode)
        {
            if (obj == null)
            {
                return 1;
            }
            switch (Mode)
            {
                case 0:
                    return this.FirstName.CompareTo(obj.FirstName);
                case 1:
                    return obj.FirstName.CompareTo(this.FirstName);
                case 2:
                    return this.LastName.CompareTo(obj.LastName);
                case 3:
                    return obj.LastName.CompareTo(this.LastName);
                default:
                    return CompareTo(obj);
            }
        }

        public  void    AddClaim    (Claim  NewClaim)
        {
            if (!ClaimsHistory.Contains(NewClaim))
            {
                ClaimsHistory.Add(NewClaim);
            }
        }

        public  void    ModifyClaim (Claim  _Claim)
        {
            foreach (Claim claim in ClaimsHistory)
            {
                if (claim.ID==_Claim.ID)
                {
                    claim.Set(_Claim);
                    return;
                }
            }
        }

        public  void    RemoveClaim (int    Index)
        {
            if (Index>-1 && Index<ClaimsHistory.Count)
            {
                ClaimsHistory.RemoveAt(Index);
            }
        }
    }
}
