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
    public delegate void TreatmentVoid(Treatment Treatment);
}
