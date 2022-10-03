using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    class GlobalFunctions
    {
        public  static  void CopyList<T> (List<T>    Input,List<T>  Output)
        {
            //Output ??= new List<T>();
            Output = Output == null ? new List<T>() : Output;
            foreach (T t in Input)
            {
                Output.Add(t);
            }
        }
    }
}
