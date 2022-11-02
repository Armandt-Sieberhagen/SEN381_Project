using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

namespace SEN_Project.BusinessLogicLayer
{
    public interface IDBItem
    {
        string GetValuesString();
        string GetSearchString();
        Object Create(DataRow Row);
    }
}
