using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Project.BusinessLogicLayer
{
    public class Call
    {
        DateTime startTime;
        DateTime endTime;
        public DateTime StartTime {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime {
            get { return endTime; }
            set { endTime = value; }
        }
        public float LengthInSeconds => (float)EndTime.Subtract(StartTime).TotalSeconds;
        public float LengthInMinutes => (float)EndTime.Subtract(StartTime).TotalMinutes;
    }
}
