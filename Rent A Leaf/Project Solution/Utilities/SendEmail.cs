using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Project
{
    internal static class SendEmail
    {
        private static SmtpClient client;

        private static MimeMessage GetAuthenticateStuff()
        {
            client = new SmtpClient();
            client.Connect("######", 587, SecureSocketOptions.None);
            var msg = new MimeMessage();
            client.Authenticate("######@######.##.##", "######");
            msg.From.Add(new MailboxAddress("The Library", "######@######.##.##"));
            return msg;
        }

        public static bool SendVerificationEmail(string key, string name, string email)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Password Reset Confirmation " + DateTime.Now;
            msg.To.Add(new MailboxAddress(name, email));
            var builder = new BodyBuilder();

            // Set the plain-text version of the message text
            builder.TextBody = string.Format("This is to confirm that you password us currently being reset. " +
                    "Please enter the following code to proceed with resetting your password: " +
                    "\n {0} \n" +
                    "If you were not aware of, or did not initiate this password reset, " +
                    "please contact our customer services desk immediately.", key);

            // Add Message Body
            msg.Body = builder.ToMessageBody();
            client.Send(msg);
            client.Disconnect(true);
            return true;
        }


        public static string SendLibraryInformation(string name, string emailAddress)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Welcome to the Library";
            //1 = Send to Myself
            msg.To.Add(new MailboxAddress(name, emailAddress));

            var builder = new BodyBuilder();

            // Set the plain-text version of the message text
            builder.TextBody = string.Format(@"
            Kia Ora {0}

            Welcome to The Library, thanks for signing up for an account.

            Please find attached information about the Library, including fines and other information.

            We look forward to seeing you around

            --

            The Library", emailAddress);

            // Attach Library Information
            builder.Attachments.Add(@"assets\info.pdf");

            // Add Message Body
            msg.Body = builder.ToMessageBody();

            client.Send(msg);
            client.Disconnect(true);
            return "TRUE";
        }


        public static bool SendReminderEmail(string message, CustomerDetails cd)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Reminder Notice " + DateTime.Now;
            //1 = Send to Myself
            msg.To.Add(new MailboxAddress(cd.Name, cd.EmailAddress));

            var builder = new BodyBuilder();

            // Set the plain-text version of the message text
            builder.TextBody = message;

            // Add Message Body
            msg.Body = builder.ToMessageBody();

            client.Send(msg);
            client.Disconnect(true);
            return true;
        }
    }
}