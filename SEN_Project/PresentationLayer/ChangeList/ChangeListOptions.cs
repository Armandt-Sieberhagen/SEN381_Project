using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.BusinessLogicLayer;

namespace SEN_Project.PresentationLayer.ChangeList
{
    public class ChangeListOptions
    {
        public List<string> AllOptions;
        public StringListVoid Callback;
        public EmptyVoid CancelCallback;
    }
}
