using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//For when we want to convert DataRows to Objects, and vice versa

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

        public virtual string GetSearchString()
        {
            return "ID='" + ID + "'";
        }

        public virtual string GetValuesString()
        {
            return "";
        }

        public virtual string ToLine() { return "ID \t" + ID.ToString(); }

        public virtual object Create(DataRow Row)
        {
            return null;
        }
    }
}
