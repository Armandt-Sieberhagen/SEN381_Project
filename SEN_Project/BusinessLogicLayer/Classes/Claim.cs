using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

namespace SEN_Project.BusinessLogicLayer
{
    public class Claim : ILineable, IDBItem
    {
        public  enum ClaimStatus
        {
            Approved,
            Declined,
            Pending,
        }

        ClaimStatus status;
        Client client;
        ClinicalProcedure procedure;
        Call call;
        Policy policy;
        float price;

        public ClaimStatus Status {
            get { return status; }
            set { status = value; }
        }
        public Client MyClient {
            get { return client; }
            set { client = value; }
        }
        public ClinicalProcedure Procedure {
            get { return procedure; }
            set { procedure = value; }
        }
        public float Price {
            get { return price; }
            set { price = value; }
        }
        public Call _Call {
            get { return call; }
            set { call = value; }
        }
        public Policy _Policy {
            get { return policy; }
            set { policy = value; }
        }
        public string ID => MyClient.ClientID.ToString() +"|"+ Procedure.ID.ToString();

        public string ToLine() { return Procedure.ID.ToString() + '\t' + Price.ToString() + '\t' + Status.ToString(); }

        public  override    string  ToString    ()
        {
            return  "Procedure ID: \t" + Procedure.ID.ToString() +
                    "\n Condition Name: \t" + Procedure.Condition.Name +
                    "\n Treatment Name: \t" + Procedure.ProposedTreatment.Name +
                    "\n Patient Name: \t" + Procedure.Patient.FullName +
                    "\n Price: \t R" + Price;
        }

        public  void    Set (Claim  _Other)
        {
            Status = _Other.Status;
            MyClient = _Other.MyClient;
            Procedure = _Other.Procedure;
            Price = _Other.Price;
        }

        public string GetValuesString()
        {
            return DatabaseAccess.current.SearchIndex<Client>(MyClient) + "','" + DatabaseAccess.current.SearchIndex(Procedure) + "')";
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateClaim(Row);
        }

        public string GetSearchString()
        {
            return "ClientID='" + DatabaseAccess.current.SearchIndex<Client>(MyClient) + "' AND "+
            "ProcedureID='" + DatabaseAccess.current.SearchIndex<ClinicalProcedure>(Procedure) + "'";
        }
    }
}
