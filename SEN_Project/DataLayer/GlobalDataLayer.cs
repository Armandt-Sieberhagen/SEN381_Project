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
            DataCaches = new Dictionary<Type, DBListItem>();
            DataCaches.Add(typeof(Address), new DbList<Address>());
            DataCaches.Add(typeof(Call), new DbList<Call>());
            DataCaches.Add(typeof(Claim), new DbList<Claim>());
            DataCaches.Add(typeof(Client), new DbList<Client>());
            DataCaches.Add(typeof(ClinicalProcedure), new DbList<ClinicalProcedure>());
            DataCaches.Add(typeof(Employee), new DbList<Employee>());
            DataCaches.Add(typeof(FamilyPolicy), new DbList<FamilyPolicy>());
            DataCaches.Add(typeof(IndividualPolicy), new DbList<IndividualPolicy>());
            DataCaches.Add(typeof(MedicalCondition), new DbList<MedicalCondition>());
            //DataCaches.Add(typeof(MedicalPackage), new DbList<MedicalPackage>());
            DataCaches.Add(typeof(MedicalServiceProvider), new DbList<MedicalServiceProvider>());
            DataCaches.Add(typeof(PolicyData), new DbList<PolicyData>());
            DataCaches.Add(typeof(Policy), new DbList<Policy>());
            DataCaches.Add(typeof(PolicyMember), new DbList<PolicyMember>());
            DataCaches.Add(typeof(Treatment), new DbList<Treatment>());

            TableNames = new Dictionary<Type, string>();
            TableNames.Add(typeof(Address), "tbl_Addresses");
            TableNames.Add(typeof(Call), "tbl_Calls");
            TableNames.Add(typeof(Claim), "tbl_Claims");
            TableNames.Add(typeof(Client), "tbl_Clients");
            TableNames.Add(typeof(ClinicalProcedure),"tbl_Procedures");
            TableNames.Add(typeof(Employee), "tbl_Employees");
            TableNames.Add(typeof(FamilyPolicy), "tbl_Family_Policies");
            TableNames.Add(typeof(IndividualPolicy), "tbl_Individual_Policies");
            TableNames.Add(typeof(MedicalCondition), "tbl_Conditions");
            //TableNames.Add(typeof(MedicalPackage), "tbl_Packages");
            TableNames.Add(typeof(MedicalServiceProvider), "tbl_Service_Providers");
            TableNames.Add(typeof(PolicyData), "tbl_Policy_Data");
            TableNames.Add(typeof(PolicyMember), "tbl_Policy_Members");
            TableNames.Add(typeof(Treatment), "tbl_Treatments");

            InsertCommands = new Dictionary<Type, string>();
            InsertCommands.Add(typeof(Address), "(Street,City,Postal_Code,Province) VALUES (");
            InsertCommands.Add(typeof(Call), "(StartTime,EndTime,Employee_ID) VALUES (");
            InsertCommands.Add(typeof(Claim), "(ClientID,ProcedureID) VALUES (");
            InsertCommands.Add(typeof(Client), "(FirstName,LastName,ID_Number,Email,Phone,Address_ID) VALUES (");
            InsertCommands.Add(typeof(ClinicalProcedure), "(Condition_ID,Service_Provider,Proposed_Treatment,Policy_ID,Patient) VALUES (");
            InsertCommands.Add(typeof(Employee), "(FirstName,LastName,ID_Number,Phone,Email,Address_ID) VALUES (");
            InsertCommands.Add(typeof(FamilyPolicy), "(Data_ID) VALUES (");
            InsertCommands.Add(typeof(IndividualPolicy), "(Data_ID,Client_ID) VALUES (");
            InsertCommands.Add(typeof(MedicalCondition), "(Condition_Name,Condition_Description) VALUES (");
            //InsertCommands.Add(typeof(MedicalPackage), "(Available,Price) VALUES (");
            InsertCommands.Add(typeof(MedicalServiceProvider), "(Address_ID) VALUES (");
            InsertCommands.Add(typeof(PolicyData), "(PolicyName,Policy_Description,Price) VALUES (");
            InsertCommands.Add(typeof(PolicyMember), "(MemberRole,Client_ID) VALUES (");
            InsertCommands.Add(typeof(Treatment), "(Treatment_Name,Treatment_Description) VALUES (");

            ReadProvinces();
        }
        public Dictionary<Type, DBListItem> DataCaches;
        public Dictionary<Type, string> TableNames;
        public Dictionary<Type, string> InsertCommands;
        public  class DBListItem
        {

        }

        public class DbList<T> : DBListItem
        {
            public List<T> MyList;

            public DbList() {
                MyList = new List<T>();
            }
        }

        public  List<T> GetCache<T>() where T: IDBItem
        {
            if (DataCaches.ContainsKey(typeof(T)))
            {
                return ((DbList<T>)DataCaches[typeof(T)]).MyList;
            }
            return null;
        }

        public  void    SetCache<T>(List<T> Values) where T:IDBItem
        {
            if (DataCaches.ContainsKey(typeof(T)))
            {
                ((DbList<T>)DataCaches[typeof(T)]).MyList   =   Values;
            }
        }

        public  string  GetTable    (Type   T)
        {
            return TableNames[T];
        }

        public  string  GetInsertCommand<T> (T Item) where T : IDBItem
        {
            return TableNames[typeof(T)] + " " + InsertCommands[typeof(T)] + Item.GetValuesString(); 
        }

        public string GetSearchCommand<T>(T Item) where T : IDBItem {
            if (Item==null)
            {
                return "";
            }
            return TableNames[typeof(T)] + " WHERE " + Item.GetSearchString();
        }

        public List<Treatment> AllTreatments;
        public List<PolicyData> AllPolicyData;
        public List<Employee> AllEmployees;
        public List<Call> AllCalls;
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

            //string[] PolicyLines = FileManager.ReadFromFile(FileManager.PolicyDataFileName);
            //PolicyReadStage stage = PolicyReadStage.NotSet;
            //string Description = "";
            //float Price = 0;
            //string Temp = "";
            //List<Treatment> Treatments = new List<Treatment>();
            //foreach (string Line in PolicyLines)
            //{
            //    switch (stage)
            //    {
            //        case PolicyReadStage.NotSet:
            //            if (Line.Trim() == "{")
            //            {
            //                stage = PolicyReadStage.Name;
            //            }
            //            break;
            //        case PolicyReadStage.Name:
            //            Description = Line.Trim();
            //            stage = PolicyReadStage.Price;
            //            break;
            //        case PolicyReadStage.Price:
            //            Temp = Line.Trim();
            //            Price = float.Parse(Temp);//Add something for if this fails
            //            stage = PolicyReadStage.Treatments;
            //            break;
            //        case PolicyReadStage.Treatments:
            //            Temp = Line.Trim();
            //            if (Line.Trim() != "[")
            //            {
            //                if (Line.Trim() == "]")
            //                {
            //                    stage = PolicyReadStage.NotSet;
            //                    AllPolicyData.Add(Factory.CreatePolicyData(Description, Price, Treatments));
            //                    Treatments.Clear();
            //                }
            //                else
            //                {
            //                    Temp = Line.Trim();
            //                    Treatments.Add(GetTreatmentByDescription(Temp));
            //                }
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }

        //public Treatment GetTreatmentByDescription(string Description)
        //{
        //    //if (AllTreatments != null)
        //    //{
        //    //    //Improve this? Maybe use dictionary?
        //    //    foreach (Treatment treatment in AllTreatments)
        //    //    {
        //    //        if (treatment.Description == Description)
        //    //        {
        //    //            return treatment;
        //    //        }
        //    //    }
        //    //    Treatment Result = Factory.CreateTreatment(Description);
        //    //    AllTreatments.Add(Result);
        //    //    return Result;
        //    //}
        //    //AllTreatments = new List<Treatment>();
        //    //AllTreatments.Add(Factory.CreateTreatment(Description));
        //    //return AllTreatments[0];
        //}

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
