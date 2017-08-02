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

        //Decalre universal variables 
        // These variables are used all throughtout the timetracker UI form 
        Timer timer1;
        string elapsedTime, currentTask, currentDetails, currentDate, startTime, endTime, currentUser = "RZELLER", sendAddress = "rogerjohnmorellizeller@gmail.com",
        tossInternalLogName = "Internal", tossMainLogName = "Main", tossClientLogName = "Client", tossLunchLogName = "Lunch", tossOtherLogName = "Other", taskLogName, backSlash = @"\", dash = "-",
        logPath = @"C:\Logs\";
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
            SendEmail();
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
            RecordData();
            txtDetails.Text = "";
            cmbTask.Text = "";
            txtTimer.Text = "00:00:00";
            startTracker();
        }

        private void CheckIfPaused()
        {
            if (paused != true)
            {
                paused = true;
            }
        }

        private void GetUserName()
        {
            //Insert code here 
        }

        private void ObtainCurrentDate()
        {
            DateTime localDate = DateTime.Now;
            currentDate = DateTime.Now.ToString("M-d-yyyy");
        }

        private void ObtainEndTime()
        {
            DateTime localTime = DateTime.Now;
            endTime = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void ObtainStartTime()
        {
            DateTime localTime = DateTime.Now;
            startTime = DateTime.Now.ToString("h:mm:ss tt");
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

        private void AdjustCurrentTask()
        {
            
            //int spaceCount = currentTask.Split(' ').Length;
            int slashCount = currentTask.Split('/').Length;
            int requiredLength = 27 - currentTask.Length;
            //requiredLength = spaceCount - requiredLength;
            //requiredLength = slashCount - requiredLength;
            currentTask = currentTask.PadRight(currentTask.Length + requiredLength, ' ');


        }

        private void ObtainCurrentDetails()
        {
            currentDetails = txtDetails.Text;
        }

        private void RecordData()
        {
            UpdateData(tossMainLogName); //Writes to main log file 
            UpdateData(taskLogName); //Writes to log file matching current task selected 
        }

        private void UpdateData(string currentType)
        {
            
            MainDataAcces data = new MainDataAcces()
            {
                logPath = logPath,
                currentUser = currentUser,
                currentDate = currentDate,
                currentTask = currentTask,
                currentDetails = currentDetails,
                currentType = currentType,

                startTime = startTime,
                endTime = endTime,
                elapsedTime = elapsedTime,
            };

            
            WriteToLog(data);

        }

        

        private void CheckTask()
        {

            switch (currentTask)
            { 
                
                case "Client Work":
                    taskLogName = tossClientLogName;
                    break;

                case "Ticket Management":
                    taskLogName = tossInternalLogName;
                    break;

                case "Project":
                    taskLogName = tossInternalLogName;
                    break;

                case "Lunch":
                    taskLogName = tossLunchLogName;
                    break;

                case "Break":
                    taskLogName = tossInternalLogName;
                    break;

                case "Meeting":
                    taskLogName = tossInternalLogName;
                    break;
                default:
                    taskLogName = tossOtherLogName;
                    break;



            }
        }

        private void WriteToLog(MainDataAcces data)
        {
            LogWriter writelog = new LogWriter();


            writelog.checkPath(data);
            writelog.WriteToLogFile(data);
        }

        private void ObtainSendAddress()
        {
            //sendAddress = txtToAddress.Text;
        }

        private void SendEmail()
        {

            // assign values to mail method 
            MailSender mail = new MailSender()
            {
                fromAddressA = "abc@mydomain.com",
                fromAddressB = "Toss Time Tracker",
                toAddress = sendAddress,
                subjectText = "Toss Time Log" + currentDate,
                bodyText = "Please see attachment for time log.",
                attachmentPath = logPath + currentUser + backSlash + currentUser + "-" + currentDate + @"\Main\" + currentUser + dash + currentDate + dash + "Main" + ".txt",
                usernameMail = "smtpsender4109@gmail.com",
                passwordMail = "TOSS#2017",
           };

            mail.sendGmail();







        }


    }

}


