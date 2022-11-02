using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public class MedicalCondition : ILineable, IDBItem
    {
        string name;
        string description;
        List<Treatment> possibleTreatments;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Description {
            get { return description; }
            set { description = value; }
        }
        public List<Treatment> PossibleTreatments {
            get { return possibleTreatments; }
            set { possibleTreatments = value; }
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
            return Name + "\t" + Description + "\t";
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateCondition(Row);
        }
    }
}
