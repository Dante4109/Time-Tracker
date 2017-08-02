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



        


        public void checkPath(UI_Data UI_data)
        {
            
            //Check Path first 
            {
                // This text is added only once to the file
                // Example path C:\\logs\RZELLER-7-17-17\Main Log\RZELLER-7-17-17-Main Log.txt
                if (!File.Exists(UI_data.logPath + UI_data.currentUser + @"\" + UI_data.currentUser + "-" + UI_data.currentDate + @"\" + UI_data.currentType + @"\" + UI_data.currentUser + "-" + UI_data.currentDate + "-" + UI_data.currentType + ".txt"))
                {
                    //Create folder if it does not exist
                    System.IO.Directory.CreateDirectory(UI_data.logPath + UI_data.currentUser + @"\" + UI_data.currentUser + "-" + UI_data.currentDate + @"\" + UI_data.currentType + @"\");

                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(UI_data.logPath + UI_data.currentUser + @"\" + UI_data.currentUser + "-" + UI_data.currentDate + @"\" + UI_data.currentType + @"\" + UI_data.currentUser + "-" + UI_data.currentDate + "-" + UI_data.currentType + ".txt"))
                    {
                        sw.WriteLine("User:" + UI_data.currentUser);


                    }
                }
            }
        }

        public void WriteToLogFile(UI_Data UI_data)
        {
            

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(UI_data.logPath + UI_data.currentUser + @"\" + UI_data.currentUser + "-" + UI_data.currentDate + @"\" + UI_data.currentType + @"\" + UI_data.currentUser + "-" + UI_data.currentDate + "-" + UI_data.currentType + ".txt"))
            {
                sw.WriteLine
                 ("-----------------------------------------------------------------"

               + " \n" + "Date: " + UI_data.currentDate + "                   " + "Time: " + UI_data.startTime + " - " + UI_data.endTime +
               "\n" + "Task: " + UI_data.currentTask + "          " + "Time Elapsed: " + UI_data.elapsedTime +
               "\n" + "Work: " + UI_data.currentType + "\n"
               + "Details: " + "\n\n" + UI_data.currentDetails
               //"-----------------------------------------------------------------"
               );
            }

        }
    }
}

