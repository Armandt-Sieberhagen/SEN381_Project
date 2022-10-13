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
        List<ClinicalProcedure> procedures;

        public ClaimStatus Status {
            get { return status; }
            set { status = value; }
        }
        public Client MyClient {
            get { return client; }
            set { client = value; }
        }
        public List<ClinicalProcedure> Procedures {
            get { return procedures; }
            set { procedures = value; }
        }
    }
}
