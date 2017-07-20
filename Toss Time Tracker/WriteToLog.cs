using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toss_Time_Tracker
{
    class WriteToLog
    {

        public string logPath { get; set; }
        public string currentUser { get; set; }
        public string currentDate { get; set; }
        public string currentTask { get; set; }
        public string currentDetails { get; set; }

        public string startTime { get; set; }
        public string endTime { get; set; }
        public string elapsedTime { get; set; }

  

        public void WriteToLogFile()
        {

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(logPath + currentUser + "-" + currentDate + ".txt"))
            {
                sw.WriteLine
                 ("-----------------------------------------------------------------"

               + " \n" + "Date: " + currentDate + "                 " + "Time: " + startTime + " - " + endTime +
                  "\n" + "Task: " + currentTask + "                 " + "Time Elapsed: " + elapsedTime +
               "\n" + "Details: " + currentDetails + "\n" 
                                                          
               );
            }

        }

        }
    }

