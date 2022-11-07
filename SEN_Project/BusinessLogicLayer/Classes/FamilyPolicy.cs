using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

namespace SEN_Project.BusinessLogicLayer
{
    public class FamilyPolicy : Policy, ILineable, IDBItem
    {
        List<PolicyMember> members;
        public List<PolicyMember> Members {
            get { return members; }
            set { members = value; }
        }

        public  override    string  ToString    ()
        {
            string Result = "Policy ID: \t" + ID.ToString() +
                "\n Policy Name: \t" + DataRef.Name +
                "\n \n Members:" +
                "\n Member Name \t \t \t Member Role \t \t \t Member Client ID";
            foreach (PolicyMember Member in Members)
            {
                Result += "\n " + Member.Person.FullName + "\t \t \t" + Member.Role.ToString() + "\t \t \t" + Member.Person.ClientID;
            }
            return Result;
        }
        public PolicyMember HeadMember {
            get {
                foreach (PolicyMember member in members)
                {
                    if (member.Role==PolicyMember.PolicyRole.Head)
                    {
                        return member;
                    }
                }
                return null;
            }
        }
        public override string ToLine() { return ID.ToString() + '\t' + HeadMember.Person.FullName + '\t' + HeadMember.Person.IDNumber + '\t' + DataRef.Name; }

        public override object Create(DataRow Row)
        {
            return Factory.CreateFamilyPolicy(Row);
        }

        public override string GetValuesString()
        {
            return "'"+DatabaseAccess.current.SearchIndex<PolicyData>(DataRef) + "')";
        }
    }
}
