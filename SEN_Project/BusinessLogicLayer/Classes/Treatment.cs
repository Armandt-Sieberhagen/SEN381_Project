using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public class Treatment : ILineable, IDBItem
    {
        string description;
        string name;
        List<MedicalCondition> conditionsCovered;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<MedicalCondition> ConditionsCovered
        {
            get { return conditionsCovered; }
            set { conditionsCovered = value; }
        }

        public string GetSearchString()
        {
            return "Treatment_Name='" + Name + "' AND Treatment_Description='" + Description + "'";
        }

        public string GetValuesString()
        {
            return "'" + Name + "','" + Description + "')";
        }

        public string ToLine()
        {
            return Name;
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateTreatment(Row);
        }
    }
}
