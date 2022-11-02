using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public class PolicyMember : ILineable, IDBItem
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

        public string ToLine()
        {
            throw new NotImplementedException();
        }

        public string GetValuesString()
        {
            throw new NotImplementedException();
        }

        public string GetSearchString()
        {
            throw new NotImplementedException();
        }

        public object Create(DataRow Row)
        {
            return Factory.CreatePolicyMember(Row);
        }
    }
}
