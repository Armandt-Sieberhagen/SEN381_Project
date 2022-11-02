using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public class PolicyData : ILineable, IDBItem
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

        public string GetSearchString()
        {
            throw new NotImplementedException();
        }

        public string GetValuesString()
        {
            throw new NotImplementedException();
        }

        public string ToLine() { return Name + '\t' + Price + '\t' + Available; }

        public  override    string  ToString    ()
        {
            string Result = "Name: \t" + Name +
                "\n Price: \t R" + Price.ToString() +
                "\n Available: \t" + Available.ToString() +
                "\n \n Description: \n" + Description +
                "\n \n Treatments Covered: \n";
            foreach (Treatment treatment in TreatmentsCovered)
            {
                Result += treatment.Name + "\n";
            }
            return Result;
        }

        public object Create(DataRow Row)
        {
            return Factory.CreatePolicyData(Row);
        }
    }
}
