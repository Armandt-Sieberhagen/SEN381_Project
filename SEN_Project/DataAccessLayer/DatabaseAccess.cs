using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.DataLayer;
using SEN_Project.BusinessLogicLayer;
using SEN_Project.PresentationLayer;
using System.Data;
using SEN_Project;

namespace SEN_Project.DataAccessLayer
{
    public class DatabaseAccess
    {
        public static DatabaseAccess current;
        public DatabaseAccess()
        {
            current = this;
        }

        public  void    Add<T>  (T  Item) where T : IDBItem
        {
            if (SearchIndex<T>(Item)==-1)
            {
                string Command = "INSERT INTO " + GlobalDataLayer.current.GetInsertCommand<T>(Item);
                DatabaseController.current.ExecuteCommand(Command);
            }
        }

        public  DataTable   SearchForTable<T>   (T Item) where T: IDBItem
        {
            string Command = @"SELECT * FROM " + GlobalDataLayer.current.GetSearchCommand<T>(Item);
            DataTable DT = DatabaseController.current.GetTable(Command);
            return DT;
        }

        public int SearchIndex<T>(T Item) where T : IDBItem
        {
            DataTable DT = null;
            return (DT = SearchForTable<T>(Item)) != null ? (DT.Rows.Count>0 ? (DT.Rows[0] != null ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1) : -1;
        }

        public  void    Delete<T>   (T  Item) where T: IDBItem
        {
            int Index = SearchIndex<T>(Item);
            if (Index > -1)
            {
                string Command = "DELETE FROM "+ GlobalDataLayer.current.GetTable(typeof(T)) +" WHERE ID='" + Index.ToString() + "'";
                DatabaseController.current.ExecuteCommand(Command);
                //PresentationController.current.ShowSuccess("Record deleted");
            }
        }

        public List<T> GetAll<T>() where T : IDBItem,new()
        {
            string Command = "SELECT * FROM " + GlobalDataLayer.current.GetTable(typeof(T));
            DataTable DT = DatabaseController.current.GetTable(Command);
            List<T> Result = new List<T>();
            T Instance = new T();
            foreach (DataRow row in DT.Rows)
            {
                //Factory.TryCreate<T>(row,Result);
                //Result.Add(Factory.Create<T>(row));
                Result.Add((T)Instance.Create(row));
            }
            return Result;
        }



        //public void Add(Claim _Claim)
        //{
        //    if (SearchIndex(_Claim) != -1)
        //    {
        //        PresentationController.current.ShowError("Claim is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Claims (ClientID,ProcedureID) VALUES ('" + SearchIndex(_Claim.MyClient) + "','" + SearchIndex(_Claim.Procedure) + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Claim has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Claim could not be added");
        //    }
        //}

        //public void Add(ClinicalProcedure _Procedure)
        //{
        //    if (SearchIndex(_Procedure) != -1)
        //    {
        //        PresentationController.current.ShowError("Procedure is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Procedures (Condition_ID,Service_Provider,Proposed_Treatment,Medical_Package) VALUES ('";
        //    Command += SearchIndex(_Procedure.Condition) + "','";
        //    Command += SearchIndex(_Procedure.Facility) + "','";
        //    Command += SearchIndex(_Procedure.ProposedTreatment) + "','";
        //    //Command += SearchIndex(_Procedure.Package) + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Procedure has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Procedure could not be added");
        //    }
        //}
        //public bool Add(Employee _Employee)
        //{
        //    if (SearchIndex(_Employee) != -1)
        //    {
        //        return false;
        //    }
        //    string Command = "INSERT INTO tbl_Employees (FirstName,LastName,ID,PhoneNumber,Email,Address_ID) VALUES ('";
        //    Command += "'" + _Employee.FirstName + "',";
        //    Command += "'" + _Employee.LastName + "',";
        //    Command += "'" + _Employee.IDNumber + "',";
        //    Command += "'" + _Employee.PhoneNumber + "',";
        //    Command += "'" + _Employee.Email + "',";
        //    Command += "'" + _Employee + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public void Add(FamilyPolicy _Policy)
        //{
        //    if (SearchIndex(_Policy) != -1)
        //    {
        //        PresentationController.current.ShowError("Policy is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Family_Policies (Data_ID) VALUES ('" + SearchIndex(_Policy.DataRef) + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Policy has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Policy could not be added");
        //    }
        //}
        //public void Add(IndividualPolicy _Policy)
        //{
        //    if (SearchIndex(_Policy) != -1)
        //    {
        //        PresentationController.current.ShowError("Policy is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Individual_Policies (Data_ID,Client_ID) VALUES ('" + SearchIndex(_Policy.DataRef) + "','" + SearchIndex(_Policy.Member) + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Policy has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Policy could not be added");
        //    }
        //}
        //public void Add(MedicalCondition _Condition)
        //{
        //    if (SearchIndex(_Condition) != -1)
        //    {
        //        PresentationController.current.ShowError("Condition is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Conditions (Condition_Description) VALUES ('" + _Condition.Description + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Condition has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Condition could not be added");
        //    }
        //}

        //public void Add(MedicalServiceProvider _Facility)
        //{
        //    if (SearchIndex(_Facility) != -1)
        //    {
        //        PresentationController.current.ShowError("Facility is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Service_Providers (Address_ID) VALUES ('" + SearchIndex(_Facility.MyAddress) + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Facility has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Facility could not be added");
        //    }
        //}
        //public void Add(PolicyData _Data)
        //{
        //    if (SearchIndex(_Data) != -1)
        //    {
        //        PresentationController.current.ShowError("Policy Data is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Policy_Data (PolicyName,Policy_Description,Price) VALUES ('";
        //    Command += _Data.Name + "','" + _Data.Description + "','" + _Data.Price + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Policy Data has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Policy Data could not be added");
        //    }
        //}
        //public void Add(PolicyMember _Member)
        //{
        //    if (SearchIndex(_Member) != -1)
        //    {
        //        PresentationController.current.ShowError("Member is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Policy_Members (MemberRole,Client_ID) VALUES ('";
        //    Command += _Member.Role + "','" + SearchIndex(_Member.Person) + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Member has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Member could not be added");
        //    }
        //}
        //public void Add(Treatment _Treatment)
        //{
        //    if (SearchIndex(_Treatment) != -1)
        //    {
        //        PresentationController.current.ShowError("Treatment is already in database");
        //        return;
        //    }
        //    string Command = "INSERT INTO tbl_Treatments (Treatment_Description) VALUES ('" + _Treatment.Description + "')";
        //    if (DatabaseController.current.ExecuteCommand(Command))
        //    {
        //        PresentationController.current.ShowSuccess("Treatment has been added!");
        //    }
        //    else
        //    {
        //        PresentationController.current.ShowError("Treatment could not be added");
        //    }
        //}

        //public void Delete(Address _Address)
        //{
        //    int Index = SearchIndex(_Address);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Addresses WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(Call _Call)
        //{
        //    int Index = SearchIndex(_Call);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Calls WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(Claim _Claim)
        //{
        //    int Index = SearchIndex(_Claim);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Claims WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(Client _Client)
        //{
        //    int Index = SearchIndex(_Client);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Clients WHERE Client_ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(ClinicalProcedure _Procedure)
        //{
        //    int Index = SearchIndex(_Procedure);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Procedures WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(FamilyPolicy _Policy)
        //{
        //    int Index = SearchIndex(_Policy);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Family_Policies WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(IndividualPolicy _Policy)
        //{
        //    int Index = SearchIndex(_Policy);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Individual_Policies WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(MedicalCondition _Condition)
        //{
        //    int Index = SearchIndex(_Condition);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Conditions WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}

        //public void Delete(MedicalServiceProvider _Facility)
        //{
        //    int Index = SearchIndex(_Facility);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Service_Providers WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(PolicyData _Data)
        //{
        //    int Index = SearchIndex(_Data);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Policy_Data WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(PolicyMember _Member)
        //{
        //    int Index = SearchIndex(_Member);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Policy_Members WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}
        //public void Delete(Treatment _Treatment)
        //{
        //    int Index = SearchIndex(_Treatment);
        //    if (Index > -1)
        //    {
        //        string Command = "DELETE FROM tbl_Treatments WHERE ID='" + Index.ToString() + "'";
        //        DatabaseController.current.ExecuteCommand(Command);
        //        PresentationController.current.ShowSuccess("Record deleted");
        //    }
        //}

        //public DataTable SearchForTable(Address _Address)
        //{
        //    string Command = @"SELECT * FROM tbl_Addresses WHERE ";
        //    Command += "Street='" + _Address.Street + "' AND ";
        //    Command += "City='" + _Address.City + "' AND ";
        //    Command += "Postal_Code='" + _Address.PostalCode + "' AND ";
        //    Command += "Province='" + _Address.Province + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}

        //public DataTable SearchForTable(Call _Call)
        //{
        //    string Command = @"SELECT * FROM tbl_Calls WHERE ";
        //    Command += "StartTime='" + _Call.StartTime + "' AND ";
        //    Command += "EndTime='" + _Call.EndTime + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(Claim _Claim)
        //{
        //    string Command = @"SELECT * FROM tbl_Claims WHERE ";
        //    Command += "ClientID='" + SearchIndex(_Claim.MyClient) + "' AND ";
        //    Command += "ProcedureID='" + SearchIndex(_Claim.Procedure) + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(Employee _employee)
        //{
        //    string Command = @"SELECT * FROM tbl_Employees WHERE ";
        //    Command += "Employee_ID='" + _employee.EmployeeID;
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(Treatment _Treatment)
        //{
        //    string Command = @"SELECT * FROM tbl_Treatments WHERE ";
        //    Command += "Treatment_Description='" + _Treatment.Description + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(MedicalCondition _Condition)
        //{
        //    string Command = @"SELECT * FROM tbl_Conditions WHERE ";
        //    Command += "Condition_Description='" + _Condition.Description + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(ClinicalProcedure _Procedure)
        //{
        //    string Command = @"SELECT * FROM tbl_Procedures WHERE ";
        //    Command += "Condition_ID='" + SearchIndex(_Procedure.Condition) + "' AND ";
        //    Command += "Service_Provider='" + SearchIndex(_Procedure.Facility) + "' AND ";
        //    Command += "Proposed_Treatment='" + SearchIndex(_Procedure.ProposedTreatment) + "' AND ";
        //    //Command += "Medical_Package='" + SearchIndex(_Procedure.Package) + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(MedicalServiceProvider _Facility)
        //{
        //    string Command = @"SELECT * FROM tbl_Service_Providers WHERE ";
        //    Command += "Address_ID='" + SearchIndex(_Facility.MyAddress) + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        ////public DataTable SearchForTable(MedicalPackage _Package)
        ////{
        ////    string Command = @"SELECT * FROM tbl_Packages WHERE ";
        ////    Command += "Available='" + _Package.Available + "' AND ";
        ////    Command += "Price='" + _Package.Price + "'";
        ////    DataTable DT = DatabaseController.current.GetTable(Command);
        ////    return DT;
        ////}
        //public DataTable SearchForTable(FamilyPolicy _Policy)
        //{
        //    string Command = @"SELECT * FROM tbl_Family_Policies WHERE ";
        //    Command += "Data_ID='" + SearchIndex(_Policy.DataRef) + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(PolicyData _Data)
        //{
        //    string Command = @"SELECT * FROM tbl_Policy_Data WHERE ";
        //    Command += "PolicyName='" + _Data.Name + "' AND ";
        //    Command += "Policy_Description='" + _Data.Description + "' AND ";
        //    Command += "Price='" + _Data.Price + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(IndividualPolicy _Policy)
        //{
        //    string Command = @"SELECT * FROM tbl_Individual_Policies WHERE ";
        //    Command += "Data_ID='" + SearchIndex(_Policy.DataRef) + "' AND ";
        //    Command += "Client_ID='" + SearchIndex(_Policy.Member) + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}
        //public DataTable SearchForTable(PolicyMember _Member)
        //{
        //    string Command = @"SELECT * FROM tbl_Policy_Members WHERE ";
        //    Command += "MemberRole='" + _Member.Role + "' AND ";
        //    Command += "Client_ID='" + SearchIndex(_Member.Person) + "'";
        //    DataTable DT = DatabaseController.current.GetTable(Command);
        //    return DT;
        //}

        //public Address Search(Address _Address)
        //{
        //    DataTable DT = SearchForTable(_Address);
        //    if (DT != null)
        //    {
        //        if (DT.Rows.Count > 1)
        //        {
        //            return Factory.CreateAddress(DT.Rows[0]);
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public int SearchIndex(Address _Address)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Address)) != null ? (DT.Rows[0] != null ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(Client _Client)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Client)) != null ? (DT.Rows[0] != null ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(Employee _Employee)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Employee)) != null ? (DT.Rows[0] != null ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(Treatment _Treatment)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Treatment)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(MedicalCondition _Condition)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Condition)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(Call _Call)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Call)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(ClinicalProcedure _Procedure)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Procedure)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(MedicalServiceProvider _Facility)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Facility)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        ///*public int SearchIndex(MedicalPackage _Package)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Package)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}*/
        //public int SearchIndex(Claim _Claim)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Claim)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(FamilyPolicy _Policy)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Policy)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(PolicyData _Data)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Data)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(IndividualPolicy _Policy)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Policy)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}
        //public int SearchIndex(PolicyMember _Member)
        //{
        //    DataTable DT = null;
        //    return (DT = SearchForTable(_Member)) != null ? (DT.Rows.Count > 0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        //}

        public  List<Client>    GetAllClients   ()
        {
            string Command = "SELECT * FROM tbl_Clients";
            DataTable DT = DatabaseController.current.GetTable(Command);
            List<Client>    Result  =   new List<Client>();
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateClient(row));
            }
            return Result;
        }

        public  List<Client>    GetClientsByID  (string ID)
        {
            List<Client> Result = new List<Client>();
            string Command = "SELECT * FROM tbl_Clients WHERE Client_ID LIKE '" + ID + "%'";
            DataTable DT = DatabaseController.current.GetTable(Command);
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateClient(row));
            }
            return Result;
        }

        public  List<Client>    GetClientsByFirstName   (string FirstName)
        {
            List<Client> Result = new List<Client>();
            string Command = "SELECT * FROM tbl_Clients WHERE FirstName LIKE '" + FirstName + "%'";
            DataTable DT = DatabaseController.current.GetTable(Command);
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateClient(row));
            }
            return Result;
        }

        public List<Client> GetClientsByLastName(string LastName)
        {
            List<Client> Result = new List<Client>();
            string Command = "SELECT * FROM tbl_Clients WHERE LastName LIKE '" + LastName + "%'";
            DataTable DT = DatabaseController.current.GetTable(Command);
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateClient(row));
            }
            return Result;
        }

        public  List<Policy>    GetAllPolicies  ()
        {
            string Command = "SELECT * FROM tbl_Individual_Policies";
            DataTable DT = DatabaseController.current.GetTable(Command);
            List<Policy> Result = new List<Policy>();
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateIndividualPolicy(row));
            }

            Command = "SELECT * FROM tbl_Family_Policies";
            DT = DatabaseController.current.GetTable(Command);
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateFamilyPolicy(row));
            }
            return Result;
        }

        public List<Address> GetAllAddresses()
        {
            string Command = "SELECT * FROM tbl_Addresses";
            DataTable DT = DatabaseController.current.GetTable(Command);
            List<Address> Result = new List<Address>();
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateAddress(row));
            }
            return Result;
        }

        public  List<Employee>  GetAllEmployees ()
        {
            string Command = "SELECT * FROM tbl_Employees";
            DataTable DT = DatabaseController.current.GetTable(Command);
            List<Employee> Result = new List<Employee>();
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateEmployee(row));
            }
            return Result;
        }

        public List<Call> GetAllCalls()
        {
            string Command = "SELECT * FROM tbl_Calls";
            DataTable DT = DatabaseController.current.GetTable(Command);
            List<Call> Result = new List<Call>();
            foreach (DataRow row in DT.Rows)
            {
                Result.Add(Factory.CreateCall(row));
            }
            return Result;
        }
    }
}
