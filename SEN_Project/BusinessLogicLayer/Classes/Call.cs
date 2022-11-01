using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Call : ILineable, IDBItem
    {
        DateTime startTime;
        DateTime endTime;
        Employee employee;
        public DateTime StartTime {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime {
            get { return endTime; }
            set { endTime = value; }
        }
        public Employee CallTaker
        {
            get { return employee; }
            set { employee = value; }
        }
        public float LengthInSeconds => (float)EndTime.Subtract(StartTime).TotalSeconds;
        public float LengthInMinutes => (float)EndTime.Subtract(StartTime).TotalMinutes;

        public string ToLine => CallTaker + "\t" + StartTime.ToString() + "\t" + EndTime.ToString();

        public string GetSearchString()
        {
            throw new NotImplementedException();
        }

        public string GetValuesString()
        {
            throw new NotImplementedException();
        }

        string ILineable.ToLine()
        {
            throw new NotImplementedException();
        }
    }
}
