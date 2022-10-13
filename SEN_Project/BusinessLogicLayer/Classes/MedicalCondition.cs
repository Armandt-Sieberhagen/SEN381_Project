using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class MedicalCondition
    {
        string description;
        List<Treatment> possibleTreatments;

        public string Description {
            get { return description; }
            set { description = value; }
        }
        public List<Treatment> PossibleTreatments {
            get { return possibleTreatments; }
            set { possibleTreatments = value; }
        }
    }
}
