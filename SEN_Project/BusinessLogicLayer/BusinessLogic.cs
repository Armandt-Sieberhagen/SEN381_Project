using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class BusinessLogic
    {
        public static BusinessLogic current;
        public BusinessLogic()
        {
            current = this;
        }

        public  void    CreateClient    (string FirstName,string    LastName,string ID,string PhoneNumber,List<string> _Policies,List<string> Perscriptions,Address _Address,string Email="")
        {
            List<Policy> Policies = new List<Policy>();
            if (_Policies!=null)
            {
                foreach (string PolicyName in _Policies)
                {
                    Policies.Add(GetPolicyByName(PolicyName));
                }
            }
            Client client = Factory.CreateClient(FirstName, LastName, new List<Call>(), Policies, ID, _Address, Email, PhoneNumber, new List<Claim>(), new List<ClinicalProcedure>(), Perscriptions ?? new List<string>());
        }

        public  Policy  GetPolicyByName (string Name)
        {
            //Not implemented yet
            return null;
        }
    }
}
