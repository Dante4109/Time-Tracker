using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Mail;



namespace Toss_Time_Tracker
{


    public partial class frmTimeTracker : Form
    {

         
        Stopwatch stopWatch = new Stopwatch();

        /*
        Decalre universal variables 
        These variables are used all throughtout the timetracker UI form
        */ 
        Timer timer1;
        int currentColumn = 6, currentRow = 2, currentSheet = 1;
        string elapsedTime, currentTask, currentDetails, currentDate, startTime, endTime, currentUser = "RZELLER", sendAddress = "rogerjohnmorellizeller@gmail.com",
        tossInternalLogName = "Internal", tossMainLogName = "Main", tossClientLogName = "Client", tossLunchLogName = "Lunch", tossOtherLogName = "Other", taskLogName, backSlash = @"\", dash = "-",
        logFilePath = @"C:\Logs\",
        excelTemplatePath = @"C:\Logs\Templates\",
        excelTemplateName = "TimeSheet-Template.xlsx",
        timeSheetName = "TimeSheet";
        bool paused = false;

        public frmTimeTracker()
        {
            InitializeComponent();
            txtDetails.Select();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            lblTicks.Text = stopWatch.ElapsedTicks.ToString();
            startTracker();
        }

        void timer1_Tick(object sender, EventArgs e)
        {

            lblTicks.Text = stopWatch.ElapsedTicks.ToString();
            txtTimer.Text = "" + stopWatch.Elapsed;
        }


        //Button Controls 
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ResetTracker();
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {

            if (paused != true)
            {
                PauseTracker();
                btnPause.BackColor = Color.Green;
                btnPause.Text = "Resume";
                paused = true;
            }

            else
            {
                timer1.Start();
                stopWatch.Start();
                ObtainStartTime();
                btnPause.BackColor = Color.Red;
                btnPause.Text = "Pause";
                paused = false;
                startTracker();
            }
        }

        private void btnSendLog_Click(object sender, EventArgs e)
        {
            RecordEmailData();
        }


        //Menu Controls 
        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        //Tracker functions 
        private void startTracker()
        {
            timer1.Start();
            stopWatch.Start();
            lblTicks.Text = stopWatch.ElapsedTicks.ToString();
            ObtainStartTime();
            ObtainCurrentDate();
        }

        private void PauseTracker()
        {
            timer1.Stop();
            elapsedTime = txtTimer.Text;
            elapsedTime = elapsedTime.Substring(0, elapsedTime.Length - 8);
            lblTest2.Text = elapsedTime;
            timer1.Dispose();
            stopWatch.Stop();
         

        }

        private void ResetTracker()
        {
            timer1.Stop();
            ObtainCurrentTime();
            stopWatch.Stop();
            stopWatch.Reset();
            ObtainCurrentDate();
            ObtainCurrentTask();
            ObtainCurrentDetails();
            ObtainEndTime();
            CheckTask();
            AdjustCurrentTask();
            RecordLogData();
            //RecordExcelData();
            txtDetails.Text = "";
            cmbTask.Text = "";
            txtTimer.Text = "00:00:00";
            startTracker();
        }


        //Obtain Global Variables  
        private void ObtainUserName()
        {
            //Username = currentUser();
        }

        private void ObtainStartTime()
        {
            DateTime localTime = DateTime.Now;
            startTime = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void ObtainEndTime()
        {
            DateTime localTime = DateTime.Now;
            endTime = DateTime.Now.ToString("h:mm:ss tt");

        }

        private void ObtainCurrentDate()
        {
            DateTime localDate = DateTime.Now;
            currentDate = DateTime.Now.ToString("M-d-yyyy");
        }

        private void ObtainCurrentTime()
        {
            elapsedTime = txtTimer.Text;
            elapsedTime = elapsedTime.Substring(0, elapsedTime.Length - 8);
            lblTest2.Text = elapsedTime;
            timer1.Dispose();
        }

        private void ObtainCurrentTask()
        {
            currentTask = cmbTask.Text;
        }

        private void ObtainCurrentDetails()
        {
            currentDetails = txtDetails.Text;
        }

        private void ObtainSendAddress()
        {
            //sendAddress = txtToAddress.Text;
        }

        //Check States and adjust data 
        private void CheckIfPaused()
        {
            if (paused != true)
            {
                paused = true;
            }
        }

        private void CheckTask()
        {

            switch (currentTask)
            { 
                
                case "Client Work":
                    taskLogName = tossClientLogName;
                    currentRow = 2;
                    break;

                case "Ticket Management":
                    taskLogName = tossInternalLogName;
                    currentRow = 3;
                    break;

                case "Project":
                    taskLogName = tossInternalLogName;
                    currentRow = 3;
                    break;

                case "Lunch":
                    taskLogName = tossLunchLogName;
                    currentRow = 4;
                    break;

                case "Break":
                    taskLogName = tossInternalLogName;
                    currentRow = 3;
                    break;

                case "Meeting":
                    taskLogName = tossInternalLogName;
                    currentRow = 3;
                    break;
                default:
                    taskLogName = tossOtherLogName;
                    currentRow = 5;
                    break;



            }
        }

        private void AdjustCurrentTask() 
        {
            /*
            Needed in order to adjust size of currentTask string to foramt properly for writing to logger 
            CheckTask() must always run before AdjustTask() otherwise the tasklogname will revert to default other
            */
            int slashCount = currentTask.Split('/').Length;
            int requiredLength = 27 - currentTask.Length;
            currentTask = currentTask.PadRight(currentTask.Length + requiredLength, ' ');
        }


        // Update and record Data 
        private void RecordLogData()
        {
            Update_UI_Data(tossMainLogName); //Writes to main log file 
            Update_UI_Data(taskLogName); //Writes to log file matching current task selected 
        }

        private void RecordEmailData()
        {
            Update_Mail_Data();
        }

        private void RecordExcelData()
        {
            Update_Excel_Data();
        }

        private void Update_UI_Data(string currentType)
        {
            
            UI_Data UI_data = new UI_Data()
            {
                logFilePath = logFilePath,
                currentUser = currentUser,
                currentDate = currentDate,
                currentTask = currentTask,
                currentDetails = currentDetails,
                currentType = currentType,

                startTime = startTime,
                endTime = endTime,
                elapsedTime = elapsedTime,
            };

            
            WriteToLog(UI_data);

        }

        private void Update_Mail_Data()
        {
            Mail_Data mail_data = new Mail_Data()
            {
                fromAddressA = "abc@mydomain.com",
                fromAddressB = "Toss Time Tracker",
                toAddress = sendAddress,
                subjectText = "Toss Time Log" + currentDate,
                bodyText = "Please see attachment for time log.",
                attachmentPath = logFilePath + currentUser + backSlash + currentUser + "-" + currentDate + @"\Main\" + currentUser + dash + currentDate + dash + "Main" + ".txt",
                usernameMail = "smtpsender4109@gmail.com",
                passwordMail = "TOSS#2017",
            };

            SendEmail(mail_data);

        }

        private void Update_Excel_Data()
        {
            Excel_Data excel_data = new Excel_Data()
            {
                currentUser = currentUser,
                currentDate = currentDate,
                currentSheet = currentSheet,
                currentColumn = currentColumn,
                currentRow = currentRow,
                excelTemplatePath = excelTemplatePath,
                excelTemplateName = excelTemplateName,
                logFilePath = logFilePath,
                timeSheetName = timeSheetName,
                elapsedTime = elapsedTime
            }; 

            
            WriteToExcel(excel_data);
        }
       
        
        
        //Business logic class method calls for writing data 
        private void WriteToLog(UI_Data UI_data)
        {
            LogWriter writelog = new LogWriter();
            writelog.checkPath(UI_data);
            writelog.WriteToLogFile(UI_data);
        }

        private void SendEmail(Mail_Data mail_data)
        {
            MailSender sendMail = new MailSender();
            sendMail.sendGmail(mail_data);
        }

        private void WriteToExcel(Excel_Data excel_data)
        {
            ExcelWriter excel = new ExcelWriter();
            excel.InitializeExcel(excel_data);
            excel.Write_Name_DateToExcel(excel_data);
            excel.WriteTimeToExcel(excel_data);
            ExcelWriter.checkExcelPath(excel_data);
            ExcelWriter.SaveExcelFile(excel_data);
            ExcelWriter.CloseExcel();
        }


        //Kill Processes
        
        //close excel when done writing to file 
        public static void closeExcel()
        {
            foreach (var process in Process.GetProcessesByName("EXCEL"))
            {
                process.Kill();
                System.Threading.Thread.Sleep(10000);
            }
        }

    }
}


