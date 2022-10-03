using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    abstract class Policy
    {
        PolicyData dataRef;
        public PolicyData DataRef {
            get { return dataRef; }
            set { dataRef = value; }
        }
    }
}
