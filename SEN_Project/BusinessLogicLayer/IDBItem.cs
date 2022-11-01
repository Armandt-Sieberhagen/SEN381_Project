using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public interface IDBItem
    {
        string GetValuesString();
        string GetSearchString();
    }
}
