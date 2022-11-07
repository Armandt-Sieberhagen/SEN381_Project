using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.DataAccessLayer;

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

        public string GetSearchString()
        {
            return "Condition_ID='" + DatabaseAccess.current.SearchIndex<MedicalCondition>(Condition) +
                    "' AND Service_Provider='" + DatabaseAccess.current.SearchIndex<MedicalServiceProvider>(Facility) +
                    "' AND Proposed_Treatment='" + DatabaseAccess.current.SearchIndex<Treatment>(ProposedTreatment) +
                    "' AND Policy_ID='" + DatabaseAccess.current.SearchIndex<Policy>(PolicySelected) +
                    "' AND Patient='" + DatabaseAccess.current.SearchIndex<Client>(Patient) + "'";
        }
        public string GetValuesString()
        {
            return "'" + DatabaseAccess.current.SearchIndex<MedicalCondition>(Condition) + "','" +
                    DatabaseAccess.current.SearchIndex<MedicalServiceProvider>(Facility) + "','" +
                    DatabaseAccess.current.SearchIndex<Treatment>(ProposedTreatment) + "','"+
                    DatabaseAccess.current.SearchIndex<Policy>(PolicySelected) + "','"+
                    DatabaseAccess.current.SearchIndex<Client>(Patient) + "')";
        }

        public string ToLine()
        {
            return ID.ToString() + "\t" + Patient.FullName + "\t" + Condition.Name + "\t" + ProposedTreatment.Name;
        }

        public object Create(DataRow Row)
        {
            return Factory.CreateClinicalProcedure(Row);
        }
    }
}
