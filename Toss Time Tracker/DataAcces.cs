using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toss_Time_Tracker
{
    class MainDataAcces
    {

        
        public string currentUser { get; set; }
        public string currentDate { get; set; }
        public string currentTask { get; set; }
        public string currentDetails { get; set; }
        public string currentType { get; set; }

        public string logPath { get; set; }


        public string startTime { get; set; }
        public string endTime { get; set; }
        public string elapsedTime { get; set; }
    }
}
