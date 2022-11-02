using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public class MedicalServiceProvider : ILineable, IDBItem
    {
        Address address;
        List<Policy> policies;

        public Address MyAddress {
            get { return address; }
            set { address = value; }
        }
        public List<Policy> Policies {
            get { return policies; }
            set { policies = value; }
        }

        public string GetSearchString()
        {
            throw new NotImplementedException();
        }

        public string GetValuesString()
        {
            throw new NotImplementedException();
        }

        public string ToLine()
        {
            throw new NotImplementedException();
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateMedicalServiceProvider(Row);
        }
    }
}
