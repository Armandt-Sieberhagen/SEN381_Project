using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
