using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Claim
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
        int id;
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
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public float Price {
            get { return price; }
            set { price = value; }
        }

        public string ToLine => ID.ToString() + '\t' + Procedure.ID.ToString() + '\t' + Price.ToString() + '\t' + Status.ToString();

        public  override    string  ToString    ()
        {
            return "Claim ID: \t" + ID.ToString() +
                    "\n Procedure ID: \t" + Procedure.ID.ToString() +
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
    }
}
