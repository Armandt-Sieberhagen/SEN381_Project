using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

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
        int polId;
        public Client Person {
            get { return person; }
            set { person = value; }
        }
        public PolicyRole Role {
            get { return role; }
            set { role = value; }
        }
        public int PolicyID {
            get { return polId; }
            set { polId = value; }
        }
        

        public string ToLine()
        {
            return Person.FullName + "\t" + Role.ToString();
        }

        public override string ToString()
        {
            return "Member Name: \t" + Person.FullName + "\n Role: \t" + Role.ToString();
        }

        public string GetValuesString()
        {
            return "'" + (int)Role + "','" + DatabaseAccess.current.SearchIndex<Client>(Person)+"')";
        }

        public string GetSearchString()
        {
            return "Client_ID='" + DatabaseAccess.current.SearchIndex<Client>(Person) + "'";
        }

        public object Create(DataRow Row)
        {
            return Factory.CreatePolicyMember(Row);
        }
    }
}
