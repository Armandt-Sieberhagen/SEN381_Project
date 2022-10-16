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
    }
}
