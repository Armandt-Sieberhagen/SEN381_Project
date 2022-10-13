using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.DataAccessLayer;
using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.DataLayer
{
    public class GlobalDataLayer
    {
        public static GlobalDataLayer current;
        public static GlobalDataLayer Current => current ?? new GlobalDataLayer();
        public GlobalDataLayer  ()
        {
            current = this;
            ReadProvinces();
        }

        public List<Treatment> AllTreatments;
        public List<PolicyData> AllPolicyData;
        Dictionary<string, string[]> AllProvinces;

        enum PolicyReadStage
        {
            NotSet,
            Name,
            Price,
            Treatments,
        }
        enum ProvinceReadStage
        {
            NotSet,
            Name,
            Province,
        }

        public void Initialize()
        {
            AllTreatments = new List<Treatment>();
            AllPolicyData = new List<PolicyData>();

            string[] PolicyLines = FileManager.ReadFromFile(FileManager.PolicyDataFileName);
            PolicyReadStage stage = PolicyReadStage.NotSet;
            string Description = "";
            float Price = 0;
            string Temp = "";
            List<Treatment> Treatments = new List<Treatment>();
            foreach (string Line in PolicyLines)
            {
                switch (stage)
                {
                    case PolicyReadStage.NotSet:
                        if (Line.Trim() == "{")
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
                        if (Line.Trim() != "[")
                        {
                            if (Line.Trim() == "]")
                            {
                                stage = PolicyReadStage.NotSet;
                                AllPolicyData.Add(Factory.CreatePolicyData(Description, Price, Treatments));
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

        public Treatment GetTreatmentByDescription(string Description)
        {
            if (AllTreatments != null)
            {
                //Improve this? Maybe use dictionary?
                foreach (Treatment treatment in AllTreatments)
                {
                    if (treatment.Description == Description)
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

        public  static string[] ProvinceNames   ()
        {
            string[] Result = new string[Current.AllProvinces.Count];
            for (int i = 0; i < Current.AllProvinces.Count; i++)
            {
                Result[i] = Current.AllProvinces.ElementAt(i).Key;
            }
            return Result;
        }

        public  static string[] CitiesOfProvince    (string Province)
        {
            return Current.AllProvinces[Province];
        }

        void    ReadProvinces   ()
        {
            string[] Lines = FileManager.ReadFromFile(FileManager.ProvinceDataFileName);
            AllProvinces = new Dictionary<string, string[]>();
            List<string> Cities = new List<string>();
            ProvinceReadStage Stage = ProvinceReadStage.NotSet;
            string Name =   "";
            foreach (string Line in Lines)
            {
                switch (Stage)
                {
                    case ProvinceReadStage.NotSet:
                        if (Line.Trim().Length>0)
                        {
                            Stage = ProvinceReadStage.Name;
                            Name = Line.Trim();
                        }
                        break;
                    case ProvinceReadStage.Name:
                        if (Line.Trim()=="{")
                        {
                            Stage = ProvinceReadStage.Province;
                        }
                        break;
                    case ProvinceReadStage.Province:
                        if (Line.Trim()=="}")
                        {
                            Stage = ProvinceReadStage.NotSet;
                            AllProvinces.Add(Name,Cities.ToArray());
                            Cities.Clear();
                            Name = "";
                        }
                        else
                        {
                            Cities.Add(Line);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
