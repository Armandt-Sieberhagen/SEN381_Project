using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Person
    {
        string firstName;
        string lastName;
        string idNumber;
        Address address;
        string email;
        string phoneNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FullName => FirstName + " " + LastName;
        public string IDNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }
        public Address PersonAddress
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
