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



        


        public void checkPath(MainDataAcces data)
        {
            
            //Check Path first 
            {
                // This text is added only once to the file
                // Example path C:\\logs\RZELLER-7-17-17\Main Log\RZELLER-7-17-17-Main Log.txt
                if (!File.Exists(data.logPath + data.currentUser + @"\" + data.currentUser + "-" + data.currentDate + @"\" + data.currentType + @"\" + data.currentUser + "-" + data.currentDate + "-" + data.currentType + ".txt"))
                {
                    //Create folder if it does not exist
                    System.IO.Directory.CreateDirectory(data.logPath + data.currentUser + @"\" + data.currentUser + "-" + data.currentDate + @"\" + data.currentType + @"\");

                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(data.logPath + data.currentUser + @"\" + data.currentUser + "-" + data.currentDate + @"\" + data.currentType + @"\" + data.currentUser + "-" + data.currentDate + "-" + data.currentType + ".txt"))
                    {
                        sw.WriteLine("User:" + data.currentUser);


                    }
                }
            }
        }

        public void WriteToLogFile(MainDataAcces data)
        {
            

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(data.logPath + data.currentUser + @"\" + data.currentUser + "-" + data.currentDate + @"\" + data.currentType + @"\" + data.currentUser + "-" + data.currentDate + "-" + data.currentType + ".txt"))
            {
                sw.WriteLine
                 ("-----------------------------------------------------------------"

               + " \n" + "Date: " + data.currentDate + "                   " + "Time: " + data.startTime + " - " + data.endTime +
               "\n" + "Task: " + data.currentTask + "          " + "Time Elapsed: " + data.elapsedTime +
               "\n" + "Work: " + data.currentType + "\n"
               + "Details: " + "\n\n" + data.currentDetails
               //"-----------------------------------------------------------------"
               );
            }

        }
    }
}

