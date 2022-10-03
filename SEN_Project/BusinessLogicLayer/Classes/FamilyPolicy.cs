using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    class FamilyPolicy : Policy
    {
        List<PolicyMember> members;
        public List<PolicyMember> Members {
            get { return members; }
            set { members = value; }
        }
    }
}
