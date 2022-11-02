using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Address : ILineable, IDBItem
    {
        public Address() { }

        string street;
        string city;
        string province;
        string postalCode;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public override string ToString()
        {
            return "Street: \t" + Street +
        "\n Postal Code: \t" + PostalCode +
        "\n City: \t" + City +
        "\n Province: \t" + Province;
        }

        public string GetValuesString()
        {
            return "'" + Street + "'," +
            "'" + City + "'," +
            "'" + PostalCode + "'," +
            "'" + Province + "')";
        }

        public string GetSearchString()
        {
            return "Street='" + Street + "' AND " +
            "City='" + City + "' AND " +
             "Postal_Code='" + PostalCode + "' AND " +
             "Province='" + Province + "'";
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateAddress(Row);
        }

        public string ToLine() { return Street + '\t' + PostalCode + '\t' + City + '\t' + Province; }
    }
}
