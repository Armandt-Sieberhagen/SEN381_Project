using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.PresentationLayer.Forms.ClientOptions;
using SEN_Project.PresentationLayer.Clients;
using SEN_Project.PresentationLayer.Claims;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa
using SEN_Project.PresentationLayer.Forms.ListSearchForm;

namespace SEN_Project.BusinessLogicLayer
{
    class Factory
    {
        public static Factory current;
        public  Factory ()
        {
            current = this;
        }

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

        public  static  Call    CreateCall  (DateTime   StartTime,DateTime  EndTime)
        {
            Call Result = new Call();
            Result.StartTime = StartTime;
            Result.EndTime = EndTime;

            return Result;
        }

        public  static  Call    CreateCall  (DateTime   StartTime,float LengthInMinutes)
        {
            DateTime EndTime = StartTime.AddMinutes(LengthInMinutes);
            return CreateCall(StartTime, EndTime);
        }

        public  static  Claim   CreateClaim (Client _Client,ClinicalProcedure Procedure,Claim.ClaimStatus Status = Claim.ClaimStatus.Pending)
        {
            Claim Result = new Claim();
            Result.MyClient = _Client;
            Result.Procedure = Procedure;
            Result.Status = Status;

            return Result;
        }
    
        public static ClinicalProcedure   CreateClinicalProcedure (MedicalCondition Condition,Treatment ProposedTreatment,MedicalServiceProvider Facility,MedicalPackage    Package)
        {
            ClinicalProcedure Result = new ClinicalProcedure();
            Result.Condition = Condition;
            Result.ProposedTreatment = ProposedTreatment;
            Result.Facility = Facility;
            Result.Package = Package;

            return Result;
        }

        public static FamilyPolicy    CreateFamilyPolicy  (List<PolicyMember> Members,PolicyData DataRef)
        {
            FamilyPolicy Result = new FamilyPolicy();
            Result.Members = Members;
            Result.DataRef = DataRef;
            return Result;
        }

        public static IndividualPolicy    CreateIndividualPolicy  (Client Member,PolicyData   DataRef)
        {
            IndividualPolicy Result = new IndividualPolicy();
            Result.Member = Member;
            Result.DataRef = DataRef;
            return Result;
        }

        public static MedicalCondition    CreateCondition (string Description,List<Treatment> PossibleTreatments)
        {
            MedicalCondition Result = new MedicalCondition();
            Result.Description = Description;
            Result.PossibleTreatments = PossibleTreatments;
            return Result;
        }

        public static MedicalPackage  CreatePackage   (bool   Available,List<Policy>  Policies,float  Price,List<Treatment>    AdditionalTreatments = null)
        {
            MedicalPackage Result = new MedicalPackage();
            Result.Available = Available;
            Result.Policies = Policies;
            Result.Price = Price;
            Result.AdditionalTreatments = AdditionalTreatments;
            return Result;
        }

        public static MedicalServiceProvider  CreateMedicalServiceProvider    (Address    _Address,List<MedicalPackage>   Packages)
        {
            MedicalServiceProvider Result = new MedicalServiceProvider();
            Result.MyAddress = _Address;
            Result.Packages = Packages;
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

        public static PolicyMember    CreatePolicyMember  (Client Person,PolicyMember.PolicyRole  Role    =   PolicyMember.PolicyRole.Secondary)
        {
            PolicyMember Result = new PolicyMember();
            Result.Person = Person;
            Result.Role = Role;
            return Result;
        }

        public static Treatment   CreateTreatment (string Description)
        {
            Treatment Result = new Treatment();
            Result.Description = Description;
            return Result;
        }

        public  static Client CreateClient (string FirstName, string LastName, List<Call> CallHistory,List<Policy> Policies,string ID,Address address,string Email,string PhoneNumber,List<Claim> claims,List<ClinicalProcedure> Procedures,List<string> ActivePerscriptions)
        {
            Client Result = new Client();

            Result.FirstName = FirstName;
            Result.LastName = LastName;
            Result.CallHistory = CallHistory;
            Result.Policies = Policies;
            Result.IDNumber = ID;
            Result.ClientAddress = address;
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
            return ListSearch();
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
