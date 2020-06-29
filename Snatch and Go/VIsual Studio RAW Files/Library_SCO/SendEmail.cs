using MailKit;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_SCO
{
    internal static class SendEmail
    {
        private static SmtpClient client;
        private static MimeMessage GetAuthenticateStuff()
        {
            client = new SmtpClient();
            client.Connect(Settings.Default.SMTPServer, Settings.Default.SMTPPort, SecureSocketOptions.None);
            var msg = new MimeMessage();
            client.Authenticate(Settings.Default.SMTPUsername, Settings.Default.SMTPassword);
            msg.From.Add(new MailboxAddress("The Library", Settings.Default.SMTPUsername));
            return msg;
        }

        public static string SendReceipt(Customer customer, List<Book> books)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Your Recept " + DateTime.Now.ToString("yyy-MM-dd");
            //1 = Send to Myself
            msg.To.Add(new MailboxAddress(customer.Name, customer.Email));
            var builder = new BodyBuilder();

            StringBuilder SB = new StringBuilder();
            SB.Append(String.Format("Kia Ora {0} \n \nPlease find below for your Receipt of the Books you issued today \n \n", customer.Name));
            foreach (Book bk in books)
            {
                SB.Append(String.Format("{0} by {1} \nDue Date: {2} \n \n", bk.Name, bk.Author, bk.DueDate));
            }
            SB.Append("Thanks for coming to the Library. We look forward to seeing you again. \n \n -- \n \n The Library");
            // Set the plain-text version of the message text
            builder.TextBody = string.Format(SB.ToString());

            // Add Message Body
            msg.Body = builder.ToMessageBody();

            client.Send(msg);
            client.Disconnect(true);
            return "TRUE";
        }

        public static string Hold(Customer customer, Book bk)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Hold avaliable to pickup " + DateTime.Now.ToString("yyy-MM-dd");
            //1 = Send to Myself
            msg.To.Add(new MailboxAddress(customer.Name, customer.Email));
            var builder = new BodyBuilder();

            StringBuilder SB = new StringBuilder();
            SB.Append(String.Format("Kia Ora {0} \n \n Great news, you have a hold to pickup \n \n", customer.Name));
            SB.Append(String.Format("{0} by {1} \nHold Placed on: {2}\n \n", bk.Name, bk.Author, customer.HoldDate));
            SB.Append("We look forward to seeing you. \n \n -- \n \n The Library");
            // Set the plain-text version of the message text
            builder.TextBody = string.Format(SB.ToString());

            // Add Message Body
            msg.Body = builder.ToMessageBody();

            client.Send(msg);
            client.Disconnect(true);
            HoldLibrary(customer, bk);
            return "TRUE";
        }
        public static string HoldLibrary(Customer customer, Book bk)
        {
            MimeMessage msg = GetAuthenticateStuff();
            msg.Subject = "Hold avaliable to pickup " + DateTime.Now.ToString("yyy-MM-dd");
            //1 = Send to Myself
            msg.To.Add(new MailboxAddress("The Library", "library@benking.co.nz"));
            var builder = new BodyBuilder();

            StringBuilder SB = new StringBuilder();
            SB.Append(String.Format("New Hold for {0} to pickup", customer.Name));
            SB.Append(String.Format("{0} by {1} \nHold Placed on: \n \n", bk.Name, bk.Author, customer.HoldDate));
            SB.Append("This Notification has been automatically sent by the Self-Checkout Application");
            // Set the plain-text version of the message text
            builder.TextBody = string.Format(SB.ToString());

            // Add Message Body
            msg.Body = builder.ToMessageBody();

            client.Send(msg);
            client.Disconnect(true);
            return "TRUE";
        }
    }
}
