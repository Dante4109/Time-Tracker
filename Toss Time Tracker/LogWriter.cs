using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toss_Time_Tracker
{
    class LogWriter
    {

        public string logPath { get; set; }
        public string currentUser { get; set; }
        public string currentDate { get; set; }
        public string currentTask { get; set; }
        public string currentDetails { get; set; }
        public string currentType { get; set; }

        public string startTime { get; set; }
        public string endTime { get; set; }
        public string elapsedTime { get; set; }




        public void checkPath()
        {
            //Check Path first 
            {
                // This text is added only once to the file
                // Example path C:\\logs\RZELLER-7-17-17\Main Log\RZELLER-7-17-17-Main Log.txt
                if (!File.Exists(logPath + currentUser + @"\" + currentUser + "-" + currentDate + @"\" + currentType + @"\" + currentUser + "-" + currentDate + "-" + currentType + ".txt"))
                {
                    //Create folder if it does not exist
                    System.IO.Directory.CreateDirectory(logPath + currentUser + @"\" + currentUser + "-" + currentDate + @"\" + currentType + @"\");

                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(logPath + currentUser + @"\" + currentUser + "-" + currentDate + @"\" + currentType + @"\" + currentUser + "-" + currentDate + "-" + currentType + ".txt"))
                    {
                        sw.WriteLine("User:" + currentUser);


                    }
                }
            }
        }

        public void WriteToLogFile()
        {
            

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(logPath + currentUser + @"\" + currentUser + "-" + currentDate + @"\" + currentType + @"\" + currentUser + "-" + currentDate + "-" + currentType + ".txt"))
            {
                sw.WriteLine
                 ("-----------------------------------------------------------------"

               + " \n" + "Date: " + currentDate + "                   " + "Time: " + startTime + " - " + endTime +
               "\n" + "Task: " + currentTask + "          " + "Time Elapsed: " + elapsedTime +
               "\n" + "Work: " + currentType + "\n"
               + "Details: " + "\n\n" + currentDetails
               //"-----------------------------------------------------------------"
               );
            }

        }
    }
}

