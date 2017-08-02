using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toss_Time_Tracker
{
    class UI_Data
    {
        public string currentUser { get; set; }
        public string currentDate { get; set; }
        public string currentTask { get; set; }
        public string currentDetails { get; set; }
        public string currentType { get; set; }

        public string logPath { get; set; }
        public string excelPath { get; set; }


        public string startTime { get; set; }
        public string endTime { get; set; }
        public string elapsedTime { get; set; }
       }



    class Mail_Data
    {
        public string fromAddressA { get; set; }
        public string fromAddressB { get; set; }
        public string toAddress { get; set; }

        public string subjectText { get; set; }
        public string bodyText { get; set; }
        public string attachmentPath { get; set; }

        public string usernameMail { get; set; }
        public string passwordMail { get; set; }
    }


    class Excel_Data
    {

    }
}


