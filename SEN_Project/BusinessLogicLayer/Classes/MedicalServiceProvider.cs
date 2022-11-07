using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

namespace SEN_Project.BusinessLogicLayer
{
    public class MedicalServiceProvider : ILineable, IDBItem, IComparable<MedicalServiceProvider>
    {
        string facilityName;
        Address address;
        List<PolicyData> policies;

        public Address MyAddress {
            get { return address; }
            set { address = value; }
        }
        public List<PolicyData> Policies {
            get { return policies; }
            set { policies = value; }
        }
        public string Name {
            get { return facilityName; }
            set { facilityName = value; }
        }

        public string GetSearchString()
        {
            return "Facility_Name='" + Name+"'";
        }

        public string GetValuesString()
        {
            return "'" + Name + "','" + DatabaseAccess.current.SearchIndex<Address>(MyAddress)+"')";
        }

        public string ToLine()
        {
            return Name;
        }

        public override string ToString()
        {
            string Result = "Name: \t" + Name +
                    "\n City: \t" + MyAddress.City+"\n \n";
            foreach (PolicyData data in Policies)
            {
                Result += data.ToLine() + "\n";
            }
            return Result;
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateMedicalServiceProvider(Row);
        }

        public int CompareTo(MedicalServiceProvider other)
        {
            if (other==null)
            {
                return 1;
            }
            return this.Name.CompareTo(other.Name);
        }
    }
}
