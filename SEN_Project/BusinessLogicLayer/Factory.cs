using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.PresentationLayer.Forms.ClientOptions;
using SEN_Project.DataLayer;
using SEN_Project.DataAccessLayer;
using SEN_Project.PresentationLayer.Clients;
using SEN_Project.PresentationLayer.Claims;
using SEN_Project.PresentationLayer.PolicyForms;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.PresentationLayer.Forms.ListSearchForm;
using SEN_Project.PresentationLayer.Employees;
using SEN_Project.PresentationLayer.Addresses;
using SEN_Project.PresentationLayer.Procedure;

namespace SEN_Project.BusinessLogicLayer
{
    class Factory
    {
        public static Factory current;
        public  Factory ()
        {
            current = this;
        }

        //public static void TryCreate<T>(DataRow Row, List<T> Output) where T : class, IDBItem,ILineable
        //{
        //    switch (typeof(T).Name)
        //    {
        //        case "Address":
        //            Output.Add((T)CreateAddress(Row));
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public static T Create<T>(DataRow Row) where T : IDBItem
        //{
        //    return default(T);
        //}

        //public  static T   Create<T>(DataRow   Row) where T : Address,IDBItem
        //{
        //    return (T)CreateAddress(Row);
        //}

        public  static  Address CreateAddress  (string Street=null,string   City=null,string Province=null,string PostalCode=null)
        {
            Address Result = new Address();

            //Add validation stuffs??
            Result.Street = Street;
            Result.City = City;
            Result.Province = Province;
            Result.PostalCode = PostalCode;

            return Result;
        }
        public static Address CreateAddress(DataRow Row)
        {
            Address Result = new Address();
            //Add validation stuffs??
            Result.Street = Row[1].ToString();
            Result.City = Row[2].ToString();
            Result.Province = Row[3].ToString();
            Result.PostalCode = Row[4].ToString();

            return Result;
        }

        public  static  Call    CreateCall  (DateTime   StartTime,DateTime  EndTime,Employee    employee)
        {
            Call Result = new Call();
            Result.StartTime = StartTime;
            Result.EndTime = EndTime;
            Result.CallTaker = employee;
            return Result;
        }
        public  static  Call    CreateCall  (DateTime   StartTime,float LengthInMinutes,Employee employee)
        {
            DateTime EndTime = StartTime.AddMinutes(LengthInMinutes);
            return CreateCall(StartTime, EndTime, employee);
        }
        public static Call CreateCall(DataRow Row)
        {
            Employee employee = BusinessLogic.current.GetEmployeeByID(int.Parse(Row[1].ToString()));//Add Validation
            DateTime StartTime = DateTime.Parse(Row[2].ToString());
            DateTime EndTime = DateTime.Parse(Row[3].ToString());
            return CreateCall(StartTime, EndTime, employee);
        }

        public  static  Claim   CreateClaim (Client _Client,ClinicalProcedure Procedure,Claim.ClaimStatus Status = Claim.ClaimStatus.Pending)
        {
            Claim Result = new Claim();
            Result.MyClient = _Client;
            Result.Procedure = Procedure;
            Result.Status = Status;

            return Result;
        }
        public static Claim CreateClaim(DataRow Row)
        {
            Claim Result = new Claim();
            Result.MyClient = BusinessLogic.current.GetByID<Client>(int.Parse(Row[0].ToString()));
            Result.Procedure = BusinessLogic.current.GetByID<ClinicalProcedure>(int.Parse(Row[1].ToString()));
            Result.Price = float.Parse(Row[2].ToString());
            Result.Status = (Claim.ClaimStatus)int.Parse(Row[3].ToString());

            return Result;
        }

        public static ClinicalProcedure   CreateClinicalProcedure (MedicalCondition Condition,Treatment ProposedTreatment,MedicalServiceProvider Facility,Policy pol,Client _Patient)
        {
            ClinicalProcedure Result = new ClinicalProcedure();
            Result.Condition = Condition;
            Result.ProposedTreatment = ProposedTreatment;
            Result.Facility = Facility;
            Result.PolicySelected = pol;
            Result.Patient = _Patient;
            //Result.Package = Package;

            return Result;
        }
        public static ClinicalProcedure CreateClinicalProcedure(DataRow Row)
        {
            ClinicalProcedure Result = new ClinicalProcedure();
            Result.Condition = BusinessLogic.current.GetByID<MedicalCondition>(int.Parse(Row[1].ToString()));
            Result.ProposedTreatment = BusinessLogic.current.GetByID<Treatment>(int.Parse(Row[3].ToString()));
            Result.Facility = BusinessLogic.current.GetByID<MedicalServiceProvider>(int.Parse(Row[2].ToString()));
            Result.PolicySelected = BusinessLogic.current.GetByID<Policy>(int.Parse(Row[4].ToString()));
            Result.Patient = BusinessLogic.current.GetByID<Client>(int.Parse(Row[5].ToString()));
            //Result.Package = Package;

            return Result;
        }

        public  static  Employee    CreateEmployee  (string FName,string    LName,string ID,string Phone,string Email,Address _Address)
        {
            Employee Result = new Employee();

            Result.FirstName = FName;
            Result.LastName = LName;
            Result.IDNumber = ID;
            Result.PhoneNumber = Phone;
            Result.Email = Email;
            Result.PersonAddress = _Address;

            List<Employee>  AllEmployees = BusinessLogic.current.GetAllEmployees();
            if (!AllEmployees.Contains(Result))
            {
                AllEmployees.Add(Result);
            }

            return Result;
        }
        public static Employee CreateEmployee(DataRow Row)
        {
            Employee Result = new Employee();

            Result.EmployeeID = int.Parse(Row[0].ToString());//Add exception handling here!!!****
            Result.FirstName = Row[1].ToString();
            Result.LastName = Row[2].ToString();
            Result.IDNumber = Row[3].ToString();
            Result.PhoneNumber = Row[4].ToString();
            Result.Email = Row[5].ToString();
            Result.PersonAddress = BusinessLogic.current.GetAddressByID(int.Parse(Row[6].ToString()));//Add exception handling here!!!****

            List<Employee> AllEmployees = BusinessLogic.current.GetAllEmployees();
            if (!AllEmployees.Contains(Result))
            {
                AllEmployees.Add(Result);
            }

            return Result;
        }

        public static FamilyPolicy    CreateFamilyPolicy  (List<PolicyMember> Members,PolicyData DataRef)
        {
            FamilyPolicy Result = new FamilyPolicy();
            Result.Members = Members;
            Result.DataRef = DataRef;
            return Result;
        }
        public static FamilyPolicy CreateFamilyPolicy(DataRow Row)
        {
            FamilyPolicy Result = new FamilyPolicy();
            Result.Members = BusinessLogic.current.GetByID<FamilyPolicy>(int.Parse(Row[0].ToString())).Members;
            Result.DataRef = BusinessLogic.current.GetByID<PolicyData>(int.Parse(Row[1].ToString()));
            return Result;
        }

        public static IndividualPolicy    CreateIndividualPolicy  (Client Member,PolicyData   DataRef)
        {
            IndividualPolicy Result = new IndividualPolicy();
            Result.Member = Member;
            Result.DataRef = DataRef;
            return Result;
        }
        public static IndividualPolicy CreateIndividualPolicy(DataRow Row)
        {
            IndividualPolicy Result = new IndividualPolicy();
            Result.Member = BusinessLogic.current.GetByID<Client>(int.Parse(Row[2].ToString()));
            Result.DataRef = BusinessLogic.current.GetByID<PolicyData>(int.Parse(Row[1].ToString()));
            return Result;
        }

        public static MedicalCondition    CreateCondition (string Name,string Description,List<Treatment> PossibleTreatments)
        {
            MedicalCondition Result = new MedicalCondition();
            Result.Name = Name;
            Result.Description = Description;
            Result.PossibleTreatments = PossibleTreatments;
            return Result;
        }
        public static MedicalCondition CreateCondition(DataRow Row)
        {
            MedicalCondition Result = new MedicalCondition();
            Result.Name = Row[1].ToString();
            Result.Description = Row[2].ToString();
            //Implement this Result.PossibleTreatments = PossibleTreatments;
            return Result;
        }

        //public static MedicalPackage  CreatePackage   (bool   Available,List<Policy>  Policies,float  Price,List<Treatment>    AdditionalTreatments = null)
        //{
        //    MedicalPackage Result = new MedicalPackage();
        //    Result.Available = Available;
        //    Result.Policies = Policies;
        //    Result.Price = Price;
        //    Result.AdditionalTreatments = AdditionalTreatments;
        //    return Result;
        //}

        public static MedicalServiceProvider  CreateMedicalServiceProvider    (Address    _Address,List<Policy>   Policies)
        {
            MedicalServiceProvider Result = new MedicalServiceProvider();
            Result.MyAddress = _Address;
            Result.Policies = Policies;
            return Result;
        }
        public static MedicalServiceProvider CreateMedicalServiceProvider(DataRow Row)
        {
            MedicalServiceProvider Result = new MedicalServiceProvider();
            //Result.MyAddress = _Address;
            //Result.Policies = Policies;
            return Result;
        }

        public static PolicyData CreatePolicyData (string Name,string Description,float   Price,List<Treatment>   TreatmentsCovered)
        {
            PolicyData Result = new PolicyData();
            Result.Name = Name;
            Result.Description = Description;
            Result.Price = Price;
            Result.TreatmentsCovered = TreatmentsCovered;
            return Result;
        }
        public static PolicyData CreatePolicyData(DataRow Row)
        {
            PolicyData Result = new PolicyData();
            //Result.Name = Name;
            //Result.Description = Description;
            //Result.Price = Price;
            //Result.TreatmentsCovered = TreatmentsCovered;
            return Result;
        }

        public static PolicyMember    CreatePolicyMember  (Client Person,PolicyMember.PolicyRole  Role    =   PolicyMember.PolicyRole.Secondary)
        {
            PolicyMember Result = new PolicyMember();
            Result.Person = Person;
            Result.Role = Role;
            return Result;
        }
        public static PolicyMember CreatePolicyMember(DataRow row)
        {
            PolicyMember Result = new PolicyMember();
            //Result.Person = Person;
            //Result.Role = Role;
            return Result;
        }

        public static Treatment   CreateTreatment (string Description)
        {
            Treatment Result = new Treatment();
            Result.Description = Description;
            return Result;
        }
        public static Treatment CreateTreatment(DataRow row)
        {
            Treatment Result = new Treatment();
            return Result;
        }

        public static Client CreateClient(string FirstName, string LastName, List<Call> CallHistory, Policy _Policy, string ID, Address address, string Email, string PhoneNumber, List<Claim> claims, List<ClinicalProcedure> Procedures, List<string> ActivePerscriptions)
        {
            Client Result = new Client();

            Result.FirstName = FirstName;
            Result.LastName = LastName;
            Result.CallHistory = CallHistory;
            Result.MyPolicy = _Policy;
            Result.IDNumber = ID;
            Result.PersonAddress = address;
            Result.Email = Email;
            Result.PhoneNumber = PhoneNumber;
            Result.ClaimsHistory = claims;
            Result.ClinicalHistory = Procedures;
            Result.ActivePerscriptions = ActivePerscriptions;

            return Result;
        }

        public static Client CreateClient(DataRow Row)
        {
            Client Result = new Client();

            Result.FirstName = Row[1].ToString();
            Result.LastName = Row[1].ToString();
            //Result.CallHistory = GetCa;
            //Result.Policies = Policies;
            //Result.IDNumber = ID;
            //Result.ClientAddress = address;
            //Result.Email = Email;
            //Result.PhoneNumber = PhoneNumber;
            //Result.ClaimsHistory = claims;
            //Result.ClinicalHistory = Procedures;
            //Result.ActivePerscriptions = ActivePerscriptions;

            return Result;
        }

        static  frmAddClient    ClientForm;
        public  static  frmAddClient GetAddClientForm    ()
        {
            if (ClientForm!=null)
            {
                ClientForm.Reset();
            }
            else
            {
                ClientForm = new frmAddClient();
            }
            return ClientForm;
        }
        static frmSearchClient SearchClient;
        public static frmSearchClient GetSearchClient()
        {
            if (SearchClient != null)
            {
                SearchClient.Reset();
            }
            else
            {
                SearchClient = new frmSearchClient();
            }
            return SearchClient;
        }
        static frmClaim ClaimForm;
        public static frmClaim GetClaimForm()
        {
            if (ClaimForm != null)
            {
                ClaimForm.Reset();
            }
            else
            {
                ClaimForm = new frmClaim();
            }
            return ClaimForm;
        }
        static frmViewPastClaims PastClaimsForm;
        public static frmViewPastClaims GetPastClaimsForm()
        {
            if (PastClaimsForm != null)
            {
                PastClaimsForm.Reset();
            }
            else
            {
                PastClaimsForm = new frmViewPastClaims();
            }
            return PastClaimsForm;
        }
        static frmSearchList ListSearch;
        public  static  frmSearchList   GetSearchList   ()
        {
            if (ListSearch!=null)
            {
                ListSearch.Reset();
            }
            else
            {
                ListSearch = new frmSearchList();
            }
            return ListSearch;
        }
        static frmChoosePolicy PolicyForm;
        public static frmChoosePolicy GetPolicyForm()
        {
            if (PolicyForm != null)
            {
                PolicyForm.Reset();
            }
            else
            {
                PolicyForm = new frmChoosePolicy();
            }
            return PolicyForm;
        }
        static frmCreateEmployee CreateEmployeeForm;
        public  static frmCreateEmployee GetCreateEmployeeForm()
        {
            if (CreateEmployeeForm != null)
            {
                CreateEmployeeForm.Reset();
            }
            else
            {
                CreateEmployeeForm = new frmCreateEmployee();
            }
            return CreateEmployeeForm;
        }
        static AddressCreator AddressCreatorForm;
        public static AddressCreator GetAddressCreator()
        {
            if (AddressCreatorForm != null)
            {
                AddressCreatorForm.Reset();
            }
            else
            {
                AddressCreatorForm = new AddressCreator();
            }
            return AddressCreatorForm;
        }
        static frmProcedure ProcedureForm;
        public static frmProcedure GetProcedureForm()
        {
            if (ProcedureForm != null)
            {
                ProcedureForm.Reset();
            }
            else
            {
                ProcedureForm = new frmProcedure();
            }
            return ProcedureForm;
        }

        public  static  Client  GetRandomClient ()
        {
            string[] FirstNames = new string[] { "John", "Sam", "Peter" };
            string[] LastNames = new string[] { "Smith", "O`Neil", "Jackson" };

            Random Rand = new Random();
            string FirstName = FirstNames[Rand.Next(FirstNames.Length)];
            string LastName = LastNames[Rand.Next(LastNames.Length)];
            string ID = "";
            for (int i = 0; i < 13; i++)
            {
                ID += Rand.Next(10).ToString();
            }
            string Phone = "";
            for (int i = 0; i < 10; i++)
            {
                Phone += Rand.Next(10).ToString();
            }
            string email = "";
            if (Rand.Next(2)==0)
            {
                email = FirstName + LastName + "@gmail.com";
            }








            return null;
        }
    }
}
