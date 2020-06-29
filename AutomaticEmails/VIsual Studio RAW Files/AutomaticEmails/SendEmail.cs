using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.IO;

namespace AutomaticEmails
{
    internal static class SendEmail
    {
        private static SmtpClient client;
        private static MimeMessage GetAuthenticateStuff()
        {
            client = new SmtpClient();
            client.Connect(Settings.Default.SMTPServer, Settings.Default.SMTPPort, SecureSocketOptions.None);
            var msg = new MimeMessage();
            client.Authenticate(Settings.Default.SMTPEmail, Settings.Default.SMTPPassword);
            msg.From.Add(new MailboxAddress("The Library", Settings.Default.SMTPEmail));
            return msg;
        }

        public static void SendReminderEmail(string message, CustomerDetails cd, Stream mStream)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Reminder Notice " + DateTime.Now;
            //1 = Send to Myself
            msg.To.Add(new MailboxAddress(cd.Name, cd.EmailAddress));

            var builder = new BodyBuilder
            {

                // Set the plain-text version of the message text
                TextBody = message
            };
            builder.Attachments.Add("reminder.ics", mStream);
            // Add Message Body
            msg.Body = builder.ToMessageBody();
         
            client.Send(msg);
            client.Disconnect(true);
        }
        public static void SendOverdueEmail(string message, CustomerDetails cd)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Overdue Notice: " + DateTime.Now.ToString("yyy-MM-dd");
            //1 = Send to Myself
            msg.To.Add(new MailboxAddress(cd.Name, cd.EmailAddress));

            var builder = new BodyBuilder();

            // Set the plain-text version of the message text
            builder.TextBody = message;
            // Add Message Body
            msg.Body = builder.ToMessageBody();

            client.Send(msg);
            client.Disconnect(true);
        }
    }
}
