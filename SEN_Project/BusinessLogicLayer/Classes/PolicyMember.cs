using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    class PolicyMember
    {
        public enum PolicyRole
        {
            Head,
            Secondary
        }

        Client person;
        PolicyRole role;
        public Client Person {
            get { return person; }
            set { person = value; }
        }
        public PolicyRole Role {
            get { return role; }
            set { role = value; }
        }
    }
}
