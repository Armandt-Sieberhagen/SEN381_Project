using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.DataAccessLayer
{
    class DataManager
    {
        public static DataManager current;
        public DataManager  ()
        {
            current = this;
        }
        public  List<Treatment> AllTreatments;
        public  List<PolicyData> AllPolicyData;

        enum PolicyReadStage
        {
            NotSet,
            Name,
            Price,
            Treatments,
        }

        public  void    Initialize  ()
        {
            AllTreatments = new List<Treatment>();
            AllPolicyData = new List<PolicyData>();

            string[] PolicyLines = FileManager.ReadFromFile(FileManager.PolicyDataFileName);
            PolicyReadStage stage = PolicyReadStage.NotSet;
            string Description =   "";
            float Price = 0;
            string Temp = "";
            List<Treatment> Treatments = new List<Treatment>(); 
            foreach (string Line in PolicyLines)
            {
                switch (stage)
                {
                    case PolicyReadStage.NotSet:
                        if (Line.Trim()=="{")
                        {
                            stage = PolicyReadStage.Name;
                        }
                        break;
                    case PolicyReadStage.Name:
                        Description = Line.Trim();
                        stage = PolicyReadStage.Price;
                        break;
                    case PolicyReadStage.Price:
                        Temp = Line.Trim();
                        Price = float.Parse(Temp);//Add something for if this fails
                        stage = PolicyReadStage.Treatments;
                        break;
                    case PolicyReadStage.Treatments:
                        Temp = Line.Trim();
                        if (Line.Trim()!="[")
                        {
                            if (Line.Trim()=="]")
                            {
                                stage = PolicyReadStage.NotSet;
                                AllPolicyData.Add(Factory.CreatePolicyData(Description, Price,Treatments));
                                Treatments.Clear();
                            }
                            else
                            {
                                Temp = Line.Trim();
                                Treatments.Add(GetTreatmentByDescription(Temp));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public  Treatment GetTreatmentByDescription (string Description)
        {
            if (AllTreatments!=null)
            {
                //Improve this? Maybe use dictionary?
                foreach (Treatment treatment in AllTreatments)
                {
                    if (treatment.Description==Description)
                    {
                        return treatment;
                    }
                }
                Treatment Result = Factory.CreateTreatment(Description);
                AllTreatments.Add(Result);
                return Result;
            }
            AllTreatments = new List<Treatment>();
            AllTreatments.Add(Factory.CreateTreatment(Description));
            return AllTreatments[0];
        }
    }
}
