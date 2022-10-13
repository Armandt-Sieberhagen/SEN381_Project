using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public  static  Claim   CreateClaim (Client _Client,List<ClinicalProcedure> Procedures,Claim.ClaimStatus Status = Claim.ClaimStatus.Pending)
        {
            Claim Result = new Claim();
            Result.MyClient = _Client;
            Result.Procedures = Procedures;
            Result.Status = Status;

            return Result;
        }
    
        public static ClinicalProcedure   CreateClinicalProcedure (List<MedicalCondition> Conditions,List<Treatment> ProposedTreatments,MedicalServiceProvider Facility)
        {
            ClinicalProcedure Result = new ClinicalProcedure();
            Result.Conditions = Conditions;
            Result.ProposedTreatments = ProposedTreatments;
            Result.Facility = Facility;

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

        public static PolicyData CreatePolicyData (string Description,float   Price,List<Treatment>   TreatmentsCovered)
        {
            PolicyData Result = new PolicyData();
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
    }
}
