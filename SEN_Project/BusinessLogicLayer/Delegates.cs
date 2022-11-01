using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Delegates
    {
    }

    public delegate void EmptyVoid();
    public delegate void StringListVoid(List<string> Items);
    public delegate void AddressVoid(Address address);
    public delegate void ClientVoid(Client client);
    public delegate void ClaimVoid(Claim _Claim);
    public delegate void TreatmentVoid(Treatment _Treatment);
    public delegate void PolicyVoid(Policy _Policy);
    public delegate void EmployeeVoid(Employee _Employee);
    public delegate void ProcedureVoid(ClinicalProcedure _Procedure);
    public delegate void ListItemVoid(int   Index,string    Line);
}
