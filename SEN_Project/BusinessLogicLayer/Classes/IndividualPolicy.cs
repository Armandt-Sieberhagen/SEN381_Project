using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    class IndividualPolicy : Policy
    {
        Client member;
        public Client Member
        {
            get { return member; }
            set { member = value; }
        }
    }
}
