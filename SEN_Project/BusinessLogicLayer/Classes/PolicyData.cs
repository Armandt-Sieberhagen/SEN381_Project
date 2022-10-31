using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class PolicyData
    {
        string policyName;
        string description;
        float price;
        List<Treatment> treatmentsCovered;
        bool available;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Name
        {
            get { return policyName; }
            set { policyName = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public List<Treatment> TreatmentsCovered
        {
            get { return treatmentsCovered; }
            set { treatmentsCovered = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        public bool CheckTreatment(Treatment _Value)
        {
            return TreatmentsCovered.Contains(_Value);
        }
    }
}
