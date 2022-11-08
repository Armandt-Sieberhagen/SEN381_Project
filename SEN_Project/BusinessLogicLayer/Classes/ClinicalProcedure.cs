using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public class ClinicalProcedure : ILineable,IDBItem
    {
        MedicalCondition condition;
        Treatment proposedTreatment;
        MedicalServiceProvider facility;
        Policy policy;
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
        public Policy PolicySelected
        {
            get { return policy; }
            set { policy = value; }
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

        public string GetSearchString() //creates an SQL search string which can be used
        {
            return "";
        }

        public string GetValuesString() //creates an SQL values string which can be used
        {
            return "";
        }
       

        public string ToLine()
        {
            return ID.ToString() + "\t" + Patient.FullName + "\t" + Condition.Name + "\t" + ProposedTreatment.Name;
        }

        public object Create(DataRow Row) // creates a new procedure using the factory class
        {
            return Factory.CreateClinicalProcedure(Row);
        }
    }
}
