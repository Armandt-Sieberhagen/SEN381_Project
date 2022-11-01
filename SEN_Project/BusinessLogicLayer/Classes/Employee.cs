using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Employee : Person, IComparable<Employee>
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

        public string ToLine => FirstName + '\t' + FullName + '\t' + IDNumber;

        public  override    string  ToString    ()
        {
            return "Name: \n" + FullName +
                    "\n \n ID: \n" + IDNumber +
                    "\n \n Email: \n" + Email;
        }
    }
}
