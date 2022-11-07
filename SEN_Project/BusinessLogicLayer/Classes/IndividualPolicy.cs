using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

namespace SEN_Project.BusinessLogicLayer
{
    public class IndividualPolicy : Policy, ILineable, IDBItem
    {
        Client member;
        public Client Member
        {
            get { return member; }
            set { member = value; }
        }

        public  override    string    ToString    ()
        {
            return "Policy ID: \t" + ID.ToString() +
                "\n Policy Name: \t" + DataRef.Name +
                "\n Member Name: " + Member.FullName +
                "\n Client ID: " + Member.ClientID.ToString();
        }

        public override string ToLine() { return ID.ToString() + '\t' + Member.FullName + '\t' + Member.IDNumber + '\t' + DataRef.Name; }

        public override object Create(DataRow Row) // creates a new policy using the factory class
        {
            return Factory.CreateIndividualPolicy(Row);
        }

        public override string GetValuesString()
        {
            return "'" + DatabaseAccess.current.SearchIndex<PolicyData>(DataRef) + "','" + DatabaseAccess.current.SearchIndex<Client>(Member)+"')";
        }
    }
}
