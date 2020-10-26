using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace PayrollSystem
{
    public class clsBusinessLayer
    {
        public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
        string Subject, string Body)
        {
            try
            {
                // Create new mailmessage object
                MailMessage MyMailMessage = new MailMessage();
                // Set from address
                MyMailMessage.From = new MailAddress(Sender);
                // Set to address
                MyMailMessage.To.Add(new MailAddress(Recipient));
                // Check blind carbon copy
                if (bcc != null && bcc != string.Empty)
                {
                    // Add bcc recipients
                    MyMailMessage.Bcc.Add(new MailAddress(bcc));
                }
                // Check carbon copy
                if (cc != null && cc != string.Empty)
                {
                    // Add cc recipients
                    MyMailMessage.CC.Add(new MailAddress(cc));
                }
                // Define subject
                MyMailMessage.Subject = Subject;
                // Define body
                MyMailMessage.Body = Body;
                // Sets isbodyhtml to true
                MyMailMessage.IsBodyHtml = true;
                // set mail priority to normal
                MyMailMessage.Priority = MailPriority.Normal;
                // Create Smtp client
                SmtpClient MySmtpClient = new SmtpClient("localhost");
                //SMTP Port = 25;
                //Generic IP host = "127.0.0.1";
                // Send mail message
                MySmtpClient.Send(MyMailMessage);
                // return true
                return true;
            }
            catch (Exception ex)
            {
                // return false
                return false;
            }
        }  
    }
}