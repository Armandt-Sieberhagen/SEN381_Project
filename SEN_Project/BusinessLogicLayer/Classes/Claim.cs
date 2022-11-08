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
        public enum ClaimStatus
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
        public string ID => MyClientCheck() + "|" + ProcedureCheck();

        string ProcedureCheck()
        {
            if (procedure != null)
            {
                return Procedure.ID.ToString();
            }
            else return "";
        }
        string MyClientCheck()
        {
            if (MyClient != null)
            {
                return MyClient.ClientID.ToString();
            }
            else return "";
        }


        public string ToLine() {
            if (Procedure != null)
            {
                return ProcedureCheck() + '\t' + Price.ToString() + '\t' + Status.ToString();
            }
            else
            {
                return "No Procedure" + '\t' + Price.ToString() + '\t' + Status.ToString();
            }
        }


        public  override    string  ToString    ()
        {
            if (Procedure != null)
            {
                return "Procedure ID: \t" + Procedure.ID.ToString() +
                    "\n Condition Name: \t" + Procedure.Condition.Name +
                    "\n Treatment Name: \t" + Procedure.ProposedTreatment.Name +
                    "\n Patient Name: \t" + Procedure.Patient.FullName +
                    "\n Price: \t R" + Price;
            }
            else
            {
                return "Procedure ID: \t" + "No Procedure" +
                    "\n Condition Name: \t" + "No Condition" +
                    "\n Treatment Name: \t" + "No Treatment" +
                    "\n Patient Name: \t" + "No Patient" +
                    "\n Price: \t R" + Price;
            }
            
            
        }

        public  void    Set (Claim  _Other) //sets the value of the current claim
        {
            Status = _Other.Status;
            MyClient = _Other.MyClient;
            Procedure = _Other.Procedure;
            Price = _Other.Price;
        }

        public string GetValuesString() //creates a string to be used as a value in a sql query
        {
            return "'"+DatabaseAccess.current.SearchIndex<Client>(MyClient) + "','" + DatabaseAccess.current.SearchIndex(Procedure) + "')";
        }

        public object Create(DataRow Row) //creates a claim using the factory object
        {
            return Factory.CreateClaim(Row);
        }

        public string GetSearchString() // creates an sql search string
        {
            return "ClientID='" + DatabaseAccess.current.SearchIndex<Client>(MyClient) + "' AND "+
            "ProcedureID='" + DatabaseAccess.current.SearchIndex<ClinicalProcedure>(Procedure) + "'";
        }
    }
}
