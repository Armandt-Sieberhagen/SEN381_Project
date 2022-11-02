using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

namespace SEN_Project.BusinessLogicLayer
{
    public class Employee : Person, IComparable<Employee>,ILineable, IDBItem
    {
        int id;

        public int EmployeeID { 
            get { return id; }
            set { id = value; }
        }

        public int CompareTo(Employee other)
        {
            if (other==null)
            {
                return 1;
            }
            return EmployeeID.CompareTo(other.EmployeeID);
        }

        public string GetSearchString()
        {
            return "Employee_ID='" + EmployeeID.ToString() + "'";
        }

        public string GetValuesString()
        {
            return "'" + FirstName + "',"+
            "'" + LastName + "'," +
            "'" + IDNumber + "'," +
            "'" + PhoneNumber + "'," +
            "'" + Email + "'," +
            "'" + DatabaseAccess.current.SearchIndex<Address>(PersonAddress) + "')";
        }

        public string ToLine() { return FirstName + '\t' + FullName + '\t' + IDNumber; }

        public  override    string  ToString    ()
        {
            return "Name: \n" + FullName +
                    "\n \n ID: \n" + IDNumber +
                    "\n \n Email: \n" + Email;
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateEmployee(Row);
        }
    }
}
