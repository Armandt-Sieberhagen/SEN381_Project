using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public  abstract class Policy
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
        public virtual string ToLine => "ID \t"+ID.ToString();
    }
}
