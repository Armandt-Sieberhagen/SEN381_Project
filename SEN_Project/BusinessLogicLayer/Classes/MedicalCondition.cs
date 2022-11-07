using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public class MedicalCondition : ILineable, IDBItem, IComparable<MedicalCondition>
    {
        string name;
        string description;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Description {
            get { return description; }
            set { description = value; }
        }

        public string GetSearchString()
        {
            return "Condition_Name='" + Name +
                    "' AND Condition_Description='" + Description + "'";
        }

        public string GetValuesString()
        {
            return  "'"+Name+"','"+Description+"')";
        }

        public string ToLine()
        {
            return Name + "\t" + Description + "\t";
        }

        public object Create(DataRow Row) // creates a new medical condition using the factory class
        {
            return Factory.CreateCondition(Row);
        }

        public int CompareTo(MedicalCondition other) //compare medical conditions
        {
            if (other == null)
            {
                return 1;
            }
            return this.Name.CompareTo(other.Name);
        }
    }
}
