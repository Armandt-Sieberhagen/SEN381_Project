using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.DataAccessLayer;
using SEN_Project.DataLayer;

namespace SEN_Project.BusinessLogicLayer
{
    public class BusinessLogic
    {
        public static BusinessLogic current;
        public BusinessLogic()
        {
            current = this;
        }

        public  Client    CreateClient    (string FirstName,string    LastName,string ID,string PhoneNumber,string _Policy,List<string> Perscriptions,Address _Address,string Email="")
        {
            Client client = Factory.CreateClient(FirstName, LastName, new List<Call>(), GetPolicyByName(_Policy), ID, _Address, Email, PhoneNumber, new List<Claim>(), new List<ClinicalProcedure>(), Perscriptions ?? new List<string>());
            return client;
        }

        public void Add<T>(T Item) where T : IDBItem
        {
            DatabaseAccess.current.Add<T>(Item);
        }

        public List<T> GetAll<T>() where T : IDBItem,new()
        {
            if (GlobalDataLayer.current.GetCache<T>() == null ? true : GlobalDataLayer.current.GetCache<T>().Count == 0)
            {
                //GlobalDataLayer.current.GetCache<T>() = new List<T>();
                GlobalDataLayer.current.SetCache<T>(DatabaseAccess.current.GetAll<T>());
            }
            GlobalDataLayer.current.GetCache<T>().Sort();
            return GlobalDataLayer.current.GetCache<T>();
        }

        public T GetByID<T>(int ID) where T : IDBItem
        {
            List<T> Cache = GlobalDataLayer.current.GetCache<T>();
            if (ID >= 0 && ID < Cache.Count)
            {
                return Cache[ID];
            }
            return default(T);
        }

        public  void    AddClient   (Client _Client)
        {
            DatabaseAccess.current.Add(_Client);
        }

        public  void    AddTreatment    (Treatment  _Treatment)
        {
            DatabaseAccess.current.Add(_Treatment);
        }

        public void AddAddress(Address _Address)
        {
            DatabaseAccess.current.Add(_Address);
        }

        public  void    Delete  (Address _Address)
        {
            DatabaseAccess.current.Delete(_Address);
        }

        public  Policy  GetPolicyByName (string Name)
        {
            //Not implemented yet
            return null;
        }

        public  List<Client>    GetAllClients   ()
        {
            return DatabaseAccess.current.GetAllClients();
        }

        public  List<Client>    GetClientsByID  (string ID)
        {
            return DatabaseAccess.current.GetClientsByID(ID);
        }

        public List<Client> GetClientsByFirstName(string Name)
        {
            return DatabaseAccess.current.GetClientsByFirstName(Name);
        }

        public List<Client> GetClientsByLastName(string LastName)
        {
            return DatabaseAccess.current.GetClientsByLastName(LastName);
        }

        public  List<Policy>    GetAllPolicies  ()
        {
            return DatabaseAccess.current.GetAllPolicies();
        }

        public  List<Address>   GetAllAddresses ()
        {
            return DatabaseAccess.current.GetAllAddresses();
        }

        public  Address GetAddressByID  (int    ID)
        {
            List<Address> AllAddresses = GetAllAddresses();
            if (ID>=0 && ID<AllAddresses.Count)
            {
                return AllAddresses[ID];
            }
            else
            {
                return null;
            }
        }

        public  List<Employee>  GetAllEmployees ()
        {
            if (GlobalDataLayer.current.AllEmployees==null)
            {
                GlobalDataLayer.current.AllEmployees = new List<Employee>();
                GlobalDataLayer.current.AllEmployees = DatabaseAccess.current.GetAllEmployees();
            }
            GlobalDataLayer.current.AllEmployees.Sort();
            return GlobalDataLayer.current.AllEmployees;
        }


        public List<Call> GetAllCalls()
        {
            if (GlobalDataLayer.current.AllCalls == null)
            {
                GlobalDataLayer.current.AllCalls = new List<Call>();
                GlobalDataLayer.current.AllCalls = DatabaseAccess.current.GetAllCalls();
            }
            GlobalDataLayer.current.AllCalls.Sort();
            return GlobalDataLayer.current.AllCalls;
        }

        public  Employee    GetEmployeeByID (int    ID)
        {
            List<Employee> AllEmployees = GetAllEmployees();
            if (ID>=0  && ID<AllEmployees.Count)
            {
                return AllEmployees[ID];
            }
            return null;
        }

        public  void    CloseOff   ()
        {
            if (GlobalDataLayer.current.AllEmployees!=null)
            {
                foreach (Employee emp in GlobalDataLayer.current.AllEmployees)
                {
                    DatabaseAccess.current.Add(emp);
                }
            }
        }

        public  Call    GetCallByID (int    ID)
        {
            List<Call> AllCalls = GetAllCalls();
            if (ID>=0 && ID<AllCalls.Count)
            {
                return AllCalls[ID];
            }
            return null;
        }
    }
}
