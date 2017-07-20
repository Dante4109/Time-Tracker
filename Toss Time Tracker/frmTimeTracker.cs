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

        //branch test 
        Stopwatch stopWatch = new Stopwatch();

        //Decalre universal variables 
        // These variables are used all throughtout the timetracker frm 
        Timer timer1;
        string elapsedTime, currentTask, currentDetails, currentDate, startTime, endTime, currentUser = "RZELLER", sendAddress = "rogerjohnmorellizeller@gmail.com",
        tossInternalLogName = "Internal", tossMainLogName = "Main", tossClientLogName = "Client", tossLunchLogName = "Lunch", tossOtherLogName = "Other", taskLogName, backSlash = @"\", dash = "-";
        
        bool paused = false; 
        public frmTimeTracker()
        {
            InitializeComponent();
            txtDetails.Select();
        }

        //test for mike

        public static TextBox textBox2; // class atribute

        public frmTimeTracker(TextBox txtUser)
        {
            currentUser = txtUser.Text;
        }

        string logPath = @"C:\Logs\";

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);

            lblTest1.Text = stopWatch.ElapsedTicks.ToString();
            startTracker();

        }





        private void btnPause_Click_1(object sender, EventArgs e)
        {

            if (paused != true)
            {
                pauseTracker();
                btnPause.BackColor = Color.Green;
                btnPause.Text = "Resume";
                paused = true;
            }

            else
            {
                timer1.Start();
                stopWatch.Start();
                obtainStartTime();
                btnPause.BackColor = Color.Red;
                btnPause.Text = "Pause";
                paused = false;
                startTracker();
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            resetTracker();

        }


        void timer1_Tick(object sender, EventArgs e)
        {

            lblTest1.Text = stopWatch.ElapsedTicks.ToString();
            txtTimer.Text = "" + stopWatch.Elapsed;
        }

        private void startTracker()
        {
            timer1.Start();
            stopWatch.Start();
            obtainStartTime();
            obtainCurrentDate();
        }

        private void pauseTracker()
        {
            timer1.Stop();
            elapsedTime = txtTimer.Text;
            elapsedTime = elapsedTime.Substring(0, elapsedTime.Length - 8);
            lblTest2.Text = elapsedTime;
            timer1.Dispose();
            stopWatch.Stop();
         

        }

        private void resetTracker()
        {
            timer1.Stop();
            elapsedTime = txtTimer.Text;
            elapsedTime = elapsedTime.Substring(0, elapsedTime.Length - 8);
            lblTest2.Text = elapsedTime;
            timer1.Dispose();
            stopWatch.Stop();
            stopWatch.Reset();
            obtainCurrentDate();
            obtainCurrentTask();
            obtainCurrentDetails();
            obtainEndTime();
            checkTask();
            adjustCurrentTask();
            writeToLogs();
            txtDetails.Text = "";
            cmbTask.Text = "";
            txtTimer.Text = "00:00:00";
            startTracker();
        }

        private void checkIfPaused()
        {
            if (paused != true)
            {
                paused = true;
            }
        }

        private void getUserName()
        {
            

        }

        private void obtainCurrentDate()
        {
            DateTime localDate = DateTime.Now;
            currentDate = DateTime.Now.ToString("M-d-yyyy");
        }

        private void obtainEndTime()
        {
            DateTime localTime = DateTime.Now;
            endTime = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            sendEmail();
        }

        private void obtainStartTime()
        {
            DateTime localTime = DateTime.Now;
            startTime = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void obtainCurrentTask()
        {
            currentTask = cmbTask.Text;
        }

        private void adjustCurrentTask()
        {
            
            //int spaceCount = currentTask.Split(' ').Length;
            int slashCount = currentTask.Split('/').Length;
            int requiredLength = 27 - currentTask.Length;
            //requiredLength = spaceCount - requiredLength;
            //requiredLength = slashCount - requiredLength;
            currentTask = currentTask.PadRight(currentTask.Length + requiredLength, ' ');


        }

        private void obtainCurrentDetails()
        {
            currentDetails = txtDetails.Text;
        }

        private void writeToLogs()
        {
            string userDateSlash = currentUser + dash + currentDate + backSlash;

            //checkForPath(userDateSlash, tossMainLogName);
            writeToLog();
            writeToLog();

        }

        private void checkTask()
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

        private void writeToLog()
        {
            LogWritter writelog = new LogWritter()
            {
                logPath = logPath,
                currentUser = currentUser,
                currentDate = currentDate,
                currentTask = currentTask,
                currentDetails = currentDetails,
                startTime = startTime,
                endTime = endTime,
                elapsedTime = elapsedTime,

            };

            writelog.WriteToLogFile();
        }

        private void obtainSendAddress()
        {
            //sendAddress = txtToAddress.Text;
        }

        private void sendEmail()
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


