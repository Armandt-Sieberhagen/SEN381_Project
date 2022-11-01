﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Treatment : ILineable, IDBItem
    {
        string description;
        string name;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GetSearchString()
        {
            throw new NotImplementedException();
        }

        public string GetValuesString()
        {
            throw new NotImplementedException();
        }

        public string ToLine()
        {
            return Name;
        }
    }
}
