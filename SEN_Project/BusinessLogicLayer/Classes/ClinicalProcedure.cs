using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class ClinicalProcedure
    {
        MedicalCondition condition;
        Treatment proposedTreatment;
        MedicalServiceProvider facility;
        MedicalPackage package;
        Client patient;
        int id;

        public MedicalCondition Condition {
            get { return condition; }
            set { condition = value; }
        }
        public Treatment ProposedTreatment {
            get { return proposedTreatment; }
            set { proposedTreatment = value; }
        }
        public MedicalServiceProvider Facility {
            get { return facility; }
            set { facility = value; }
        }
        public MedicalPackage Package
        {
            get { return package; }
            set { package = value; }
        }
        public Client Patient
        {
            get { return patient; }
            set { patient = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
