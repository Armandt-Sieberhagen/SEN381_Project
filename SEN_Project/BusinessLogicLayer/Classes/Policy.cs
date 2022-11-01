using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public  abstract class Policy : ILineable,IDBItem
    {
        int id;
        PolicyData dataRef;
        public PolicyData DataRef {
            get { return dataRef; }
            set { dataRef = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string GetSearchString()
        {
            throw new NotImplementedException();
        }

        public string GetValuesString()
        {
            throw new NotImplementedException();
        }

        public virtual string ToLine() { return "ID \t" + ID.ToString(); }
    }
}
