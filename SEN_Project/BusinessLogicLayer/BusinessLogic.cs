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
            try
            {
                GlobalDataLayer.current.GetCache<T>().Sort();
            }
            catch (Exception)
            {
             
            }
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

        public  void   Delete  <T>(T Item) where T : IDBItem
        {
            DatabaseAccess.current.Delete<T>(Item);
        }

        public void Delete(object _Object)
        {
            Delete<IDBItem>((IDBItem)_Object);
        }

        public  List<MedicalCondition> GetConditionsTreatmentsByID  (int    Index)
        {
            return DatabaseAccess.current.GetConditionsTreatmentsByID(Index);
        }

        public List<Client> GetClientsByFirstName(string Name)
        {
            return DatabaseAccess.current.GetClientsByFirstName(Name);
        }

        public List<Client> GetClientsByLastName(string LastName)
        {
            return DatabaseAccess.current.GetClientsByLastName(LastName);
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
    }
}
