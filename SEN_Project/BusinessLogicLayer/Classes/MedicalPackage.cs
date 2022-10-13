using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class MedicalPackage
    {
        bool available;
        List<Policy> policies;
        List<Treatment> additionalTreatments;
        float price;

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        public List<Policy> Policies {
            get { return policies; }
            set { policies = value; }
        }
        public List<Treatment> AdditionalTreatments {
            get { return additionalTreatments; }
            set { additionalTreatments = value; }
        }
        public float Price {
            get { return price; }
            set { price = value; }
        }

        public List<Treatment> PolicyTreatments {
            get {
                List<Treatment> Result = new List<Treatment>();
                foreach (Policy policy in Policies)
                {
                    foreach (Treatment treatment in policy.DataRef.TreatmentsCovered)
                    {
                        Result.Add(treatment);
                    }
                }
                return Result;
            }
        }
        public List<Treatment> AllTreatments {
            get {
                //Make this better with static copy list function
                List<Treatment> Result = new List<Treatment>();
                foreach (Treatment treatment in PolicyTreatments)
                {
                    Result.Add(treatment);
                }
                foreach (Treatment treatment in AdditionalTreatments)
                {
                    Result.Add(treatment);
                }
                return Result;
            }
        }

        public bool CheckTreatment(Treatment _treatment) {
            return AllTreatments.Contains(_treatment);
        }
    }
}
