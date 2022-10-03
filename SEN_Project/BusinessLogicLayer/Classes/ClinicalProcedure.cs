using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    class ClinicalProcedure
    {
        List<MedicalCondition> conditions;
        List<Treatment> proposedTreatments;
        MedicalServiceProvider facility;

        public List<MedicalCondition> Conditions {
            get { return conditions; }
            set { conditions = value; }
        }
        public List<Treatment> ProposedTreatments {
            get { return proposedTreatments; }
            set { proposedTreatments = value; }
        }
        public MedicalServiceProvider Facility {
            get { return facility; }
            set { facility = value; }
        }
    }
}
