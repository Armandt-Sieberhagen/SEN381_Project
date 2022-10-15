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

        public void AddClient(Client _Client)
        {
            int Index = SearchIndex(_Client);
            if (Index!=-1)
            {
                PresentationController.current.ShowError("Client is already in database");
                return;
            }
            AddAddress(_Client.ClientAddress);
            int AddressID = SearchIndex(_Client.ClientAddress);
            string Command = @"INSERT INTO tbl_Clients (FirstName,LastName,ID_Number,Email,Phone,Address_ID) VALUES (";
            Command += "'" + _Client.FirstName + "',";
            Command += "'" + _Client.LastName + "',";
            Command += "'" + _Client.IDNumber + "',";
            Command += "'" + _Client.Email + "',";
            Command += "'" + _Client.PhoneNumber + "',";
            Command += "'" + AddressID + "')";
            if (DatabaseController.current.ExecuteCommand(Command))
            {
                PresentationController.current.ShowSuccess("Client Added!");
            }
            else
            {
                PresentationController.current.ShowError("Client could not be added");
            }
        }

        public  void    AddTreatment    (Treatment _Treatment)
        {
            if (SearchIndex(_Treatment)!=-1)
            {
                PresentationController.current.ShowError("Treatment is already in database");
                return;
            }
            string Command = "INSERT INTO tbl_Treatments (Treatment_Description) VALUES ('" + _Treatment.Description + "')";
            if (DatabaseController.current.ExecuteCommand(Command))
            {
                PresentationController.current.ShowSuccess("Treatment has been added!");
            }
            else
            {
                PresentationController.current.ShowError("Treatment could not be added");
            }
        }

        public void AddAddress(Address _Address)
        {
            //First we check if the address has already been added
            Address _Add = Search(_Address);
            if (_Add == null)
            {
                //If the address is not already in the table yet
                string Command = "INSERT INTO tbl_Addresses (Street,City,Postal_Code,Province) VALUES (";
                Command += "'"+_Address.Street + "',";
                Command += "'"+_Address.City + "',";
                Command += "'"+_Address.PostalCode + "',";
                Command += "'"+_Address.Province + "')";
                DatabaseController.current.ExecuteCommand(Command);
            }
        }

        public DataTable SearchForTable(Address _Address)
        { 
            string Command = @"SELECT * FROM tbl_Addresses WHERE ";
            Command += "Street='" + _Address.Street + "' AND ";
            Command += "City='" + _Address.City + "' AND ";
            Command += "Postal_Code='" + _Address.PostalCode + "' AND ";
            Command += "Province='" + _Address.Province+"'";
            DataTable DT = DatabaseController.current.GetTable(Command);
            return DT;
        }

        public DataTable SearchForTable(Client _Client)
        {
            string Command = @"SELECT * FROM tbl_Clients WHERE ";
            Command += "FirstName='" + _Client.FirstName + "' AND ";
            Command += "LastName='" + _Client.LastName + "' AND ";
            Command += "ID_Number='" + _Client.IDNumber + "' AND ";
            Command += "Email='" + _Client.Email + "' AND ";
            Command += "Phone='" + _Client.PhoneNumber + "' AND ";
            Command += "Address_ID='" + SearchIndex(_Client.ClientAddress).ToString() + "'";
            DataTable DT = DatabaseController.current.GetTable(Command);
            return DT;
        }

        public DataTable SearchForTable(Treatment _Treatment)
        {
            string Command = @"SELECT * FROM tbl_Treatments WHERE ";
            Command += "Treatment_Description='" + _Treatment.Description + "'";
            DataTable DT = DatabaseController.current.GetTable(Command);
            return DT;
        }

        public Address Search(Address _Address)
        {
            DataTable DT = SearchForTable(_Address);
            if (DT != null)
            {
                if (DT.Rows.Count > 1)
                {
                    return Factory.CreateAddress(DT.Rows[0]);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public int SearchIndex(Address _Address)
        {
            DataTable DT = null;
            return (DT = SearchForTable(_Address)) != null ? (DT.Rows[0] != null ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        }

        public int SearchIndex(Client _Client)
        {
            DataTable DT = null;
            return (DT = SearchForTable(_Client)) != null ? (DT.Rows[0] != null ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        }

        public int SearchIndex(Treatment _Treatment)
        {
            DataTable DT = null;
            return (DT = SearchForTable(_Treatment)) != null ? (DT.Rows.Count>0 ? int.Parse(DT.Rows[0][0].ToString()) : -1) : -1;
        }
    }
}
