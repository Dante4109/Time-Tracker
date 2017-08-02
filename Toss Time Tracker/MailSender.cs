using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Toss_Time_Tracker
{
    class MailSender
    {


        public void sendGmail(Mail_Data mail_data)
        {

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(mail_data.fromAddressA, mail_data.fromAddressB);
            mail.To.Add(mail_data.toAddress);
            mail.IsBodyHtml = true;
            mail.Subject = mail_data.subjectText;
            mail.Body = mail_data.bodyText;
            mail.Priority = MailPriority.High;

            if (mail_data.attachmentPath != null)
            {
                mail.Attachments.Add(new Attachment(mail_data.attachmentPath));
            }

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential(mail_data.usernameMail, mail_data.passwordMail);
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mail);
            MessageBox.Show("Maill successfully sent!");

        }
    }
}

