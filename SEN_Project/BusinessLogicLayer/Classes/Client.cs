using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

namespace SEN_Project.BusinessLogicLayer
{
    public class Client : Person,IComparable<Client>, ILineable, IDBItem
    {
        int clientID;
        
        List<Call> callHistory;
        Policy policy;
        List<Policy> pastPolicies;
        //List<Policy> futurePolicies;
        List<Claim> claimsHistory;
        List<ClinicalProcedure> clinicalHistory;
        List<string> activePerscriptions;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public List<Call> CallHistory {
            get { return callHistory; }
            set { callHistory = value; }
        }
        public Policy MyPolicy {
            get { return policy; }
            set { policy = value; }
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
        public List<Policy> PastPolicies
        {
            get { return pastPolicies; }
            set { pastPolicies = value; }
        }
        //public List<Policy> FuturePolicies
        //{
        //    get { return futurePolicies; }
        //    set { futurePolicies = value; }
        //}

        public string ToLine() { return ClientID + '\t' + FullName + '\t' + IDNumber; }
        public string PersonalDetails => "Client ID: \t " + ClientID + " \n First Name: \t " + FirstName + " \t Last Name: " + LastName + " \n ID Number: \t" + IDNumber;
        public string AddressDetails => PersonAddress!=null ? PersonAddress.ToString() : "No Address";

        public int CompareTo(Client obj) //compares clients
        {
            if (obj==null)
            {
                return 1;
            }
            return this.ClientID.CompareTo(obj.ClientID);
        }

        public  int CompareTo   (Client obj, int Mode) //compares clients using a mode, for examples first name, last name etc.
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

        public  void    AddClaim    (Claim  NewClaim) // adds a new claim
        {
            if (!ClaimsHistory.Contains(NewClaim))
            {
                ClaimsHistory.Add(NewClaim);
            }
        }

        public  void    ModifyClaim (Claim  _Claim) // modifies the claim
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

        public  void    RemoveClaim (int    Index) //removes claim
        {
            if (Index>-1 && Index<ClaimsHistory.Count)
            {
                ClaimsHistory.RemoveAt(Index);
            }
        }

        public  void    AddCall (Call   _Call)
        {
            if (!CallHistory.Contains(_Call))
            {
                CallHistory.Add(_Call);
            }
        }

        public string GetValuesString()
        {
            return "'" + FirstName + "',"+
            "'" + LastName + "'," +
            "'" + IDNumber + "'," +
            "'" + Email + "'," +
            "'" + PhoneNumber + "'," +
            "'" + DatabaseAccess.current.SearchIndex<Address>(PersonAddress) + "')";
        }

        public string GetSearchString()
        {
            return "FirstName='" + FirstName + "' AND "+
            "LastName='" + LastName + "' AND "+
            "ID_Number='" + IDNumber + "' AND "+
            "Email='" + Email + "' AND "+
            "Phone='" + PhoneNumber + "' AND "+
            "Address_ID='" + DatabaseAccess.current.SearchIndex(PersonAddress).ToString() + "'";
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateClient(Row);
        }
    }
}
