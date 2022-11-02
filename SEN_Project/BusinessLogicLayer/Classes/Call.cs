using System;
using System.Collections.Generic;
using System.Data;
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

        public object Create(DataRow Row)
        {
            return Factory.CreateCall(Row);
        }

        public string GetSearchString()
        {
            return "Employee_ID='" + CallTaker.EmployeeID.ToString() + "' AND StartTime='" + StartTime.ToString() + "' AND EndTime='" + EndTime.ToString() + "'";
        }

        public string GetValuesString()
        {
            return "'" + CallTaker.EmployeeID.ToString() + "','" + StartTime.ToString() + "'" + EndTime.ToString() + "')";
        }

        public  string ToLine()
        {
            return CallTaker + "\t" + StartTime.ToString() + "\t" + EndTime.ToString();
        }

        public  override    string  ToString    ()
        {
            return "Employee ID: \t" + CallTaker.EmployeeID.ToString() +
                "\n Start Time: \t" + StartTime.ToString() +
                "\n End TimeL \t" + EndTime.ToString();
        }
    }
}
