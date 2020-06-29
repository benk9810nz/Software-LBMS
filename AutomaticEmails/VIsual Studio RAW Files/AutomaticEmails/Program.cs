using Ical.Net;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace AutomaticEmails
{
    class Program
    {
        public static DateTime dt { get; set; }
        public static string Output { get; set; }
        static void Main(string[] args)
        {
            string CONSTRING = String.Format("Server={0};Database={1};Uid={2};Pwd={3};", Settings.Default.IPAddress, Settings.Default.Database, Settings.Default.Username, Settings.Default.Password);
            MySqlConnection conn = new MySqlConnection(CONSTRING);
            conn.Open();
            SendReminderNotification(conn); //Process Reminder Notficiations
            SendOverdueNotification(conn); //Process Overdue Notifications
            SendBlockedNotification(conn); //Send Blocked Email
            Console.WriteLine("Application successfully finished and Reminder Messages have been sent");
            Console.ReadLine();
        }//Anything in here will be done by the program


        private static void SendReminderNotification(MySqlConnection conn)
        {
            String sql = "SELECT DISTINCT(r.Customer_ID), (SELECT Email_Address FROM USERS WHERE Customer_ID = r.Customer_ID) AS Email, (SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS FName, (SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS LName, (SELECT Phone_Number FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS PhoneNo FROM BOOKSISSUED AS r WHERE Due_Date = @Date AND Returned_Date IS NULL;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.AddDays(Settings.Default.ReminderPeriod).ToString("yyyy-MM-dd"));
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<CustomerDetails> customerIDs = new List<CustomerDetails>();
            while (rdr.Read())
            {
                decimal phoneNo;
                if (rdr.IsDBNull(4))
                {
                    phoneNo = 0;
                }
                else
                {
                    phoneNo = rdr.GetDecimal(4);
                }
                customerIDs.Add(new CustomerDetails(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), phoneNo));
            }
            rdr.Close();
            int a = 0;
            StringBuilder sb = new StringBuilder();
            foreach (CustomerDetails cd in customerIDs)
            {
                sql = String.Format("SELECT i.Issue_Date, i.Due_Date, i.Book_Barcode, (SELECT Book_ID FROM BOOKCOPIES WHERE Book_Barcode = i.Book_Barcode) AS aBook_ID, (SELECT NAME FROM BOOKS WHERE Book_ID = aBook_ID) AS B_Name, (SELECT Author_Name FROM BOOKS WHERE Book_ID=aBook_ID) AS AuthorName, i.Returned_Date FROM BOOKSISSUED AS i WHERE (Customer_ID = {0}) && (i.Returned_Date IS NULL) && (i.Due_Date = @Date);", cd.CustomerID);
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.AddDays(Settings.Default.ReminderPeriod).ToString("yyyy-MM-dd"));
                rdr = cmd.ExecuteReader();
                sb.Append(String.Format("HI {0} \nThe Following Books are due back in {1} days time: \n \n", cd.Name, Settings.Default.ReminderPeriod.ToString()));
                while (rdr.Read())
                {
                    string issueDate = rdr.GetString(0);
                    string dDate = rdr.GetString(1);
                    dt = Convert.ToDateTime(rdr.GetString(1));
                    decimal barcode = rdr.GetDecimal(2);
                    string name = rdr.GetString(4);
                    string author = rdr.GetString(5);
                    sb.Append(String.Format("{3} by {4} \n Issued Date: {0} \n Due Date: {1} \n Barcode: {2} \n \n", issueDate, dDate, barcode.ToString(), name, author));
                    a++;
                }
                sb.Append("If you are unable to get these books back in time, Please login to your account and see if you can renew them. Otherwise get in touch with us \n \nThanks, \n \nThe Library \n \n");
                rdr.Close();
                MemoryStream ms = GenerateCalEvent();
                SendEmail.SendReminderEmail(sb.ToString(), cd, ms);
                if (cd.PhoneNo != 0)
                {
                    ReminderText.SendText(cd.PhoneNo, String.Format("Hi {0}! \nYou have books due back in {1} days \nSee your Email for more Info \nRegards \nThe Library \n \n--DO NOT REPLY--", cd.Name, Settings.Default.ReminderPeriod.ToString()));
                }//If a Phone Number exists on account send them a SMS Message
                Output = sb.ToString();
                sb.Clear();
            }
        }

        private static void SendOverdueNotification(MySqlConnection conn)
        {
            String sql = "SELECT DISTINCT(r.Customer_ID), (SELECT Email_Address FROM USERS WHERE Customer_ID = r.Customer_ID) AS Email, (SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS FName, (SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS LName, (SELECT Phone_Number FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS PhoneNo FROM BOOKSISSUED AS r WHERE Due_Date = @Date AND Returned_Date IS NULL;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<CustomerDetails> customerIDs = new List<CustomerDetails>();
            while (rdr.Read())
            {
                decimal phoneNo;
                if (rdr.IsDBNull(4))
                {
                    phoneNo = 0;
                }
                else
                {
                    phoneNo = rdr.GetDecimal(4);
                }
                customerIDs.Add(new CustomerDetails(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), phoneNo));
            }
            rdr.Close();
            int a = 0;
            StringBuilder sb = new StringBuilder();
            foreach (CustomerDetails cd in customerIDs)
            {
                sql = String.Format("SELECT i.Issue_Date, i.Due_Date, i.Book_Barcode, (SELECT Book_ID FROM BOOKCOPIES WHERE Book_Barcode = i.Book_Barcode) AS aBook_ID, (SELECT NAME FROM BOOKS WHERE Book_ID = aBook_ID) AS B_Name, (SELECT Author_Name FROM BOOKS WHERE Book_ID=aBook_ID) AS AuthorName, i.Returned_Date FROM BOOKSISSUED AS i WHERE (Customer_ID = {0}) && (i.Returned_Date IS NULL) && (i.Due_Date = @Date);", cd.CustomerID);
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
                rdr = cmd.ExecuteReader();
                sb.Append(String.Format("HI {0} \nThe Following Books are now Overdue and will incure a fine of 20 cents per item, per day:\n \n", cd.Name));
                while (rdr.Read())
                {
                    string issueDate = rdr.GetString(0);
                    string dDate = rdr.GetString(1);
                    dt = Convert.ToDateTime(rdr.GetString(1));
                    decimal barcode = rdr.GetDecimal(2);
                    string name = rdr.GetString(4);
                    string author = rdr.GetString(5);
                    sb.Append(String.Format("{3} by {4} \n Issued Date: {0} \n Due Date: {1} \n Barcode: {2} \n \n", issueDate, dDate, barcode.ToString(), name, author));
                    a++;
                }
                sb.Append("Please ensure you get these back promptly to ensure that you are not charged a Lost Fee. Any issues please get in touch with us \n \nThanks, \n \nThe Library \n \n--DO NOT REPLY");
                rdr.Close();
                MemoryStream ms = GenerateCalEvent();
                SendEmail.SendOverdueEmail(sb.ToString(), cd);
                if (cd.PhoneNo != 0)
                {
                    ReminderText.SendText(cd.PhoneNo, String.Format("Hi {0}! \nYou have Overdue Books. \nSee your Email for more Info. \nRegards \nThe Library \n \n--DO NOT REPLY--", cd.Name));
                }//If a Phone Number exists on account send them a SMS Message
                Output = sb.ToString();
                sb.Clear();
            }
        }

        private static void SendBlockedNotification(MySqlConnection conn)
        {
            String sql = "SELECT DISTINCT(r.Customer_ID), (SELECT Email_Address FROM USERS WHERE Customer_ID = r.Customer_ID) AS Email, (SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS FName, (SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS LName, (SELECT Phone_Number FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS PhoneNo FROM BOOKSISSUED AS r WHERE Due_Date = @Date AND Returned_Date IS NULL;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.AddDays(-Settings.Default.BlockedPeriod).ToString("yyyy-MM-dd"));
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<CustomerDetails> customerIDs = new List<CustomerDetails>();
            while (rdr.Read())
            {
                decimal phoneNo;
                if (rdr.IsDBNull(4))
                {
                    phoneNo = 0;
                }
                else
                {
                    phoneNo = rdr.GetDecimal(4);
                }
                customerIDs.Add(new CustomerDetails(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), phoneNo));
            }
            rdr.Close();
            int a = 0;
            StringBuilder sb = new StringBuilder();
            foreach (CustomerDetails cd in customerIDs)
            {
                sql = String.Format("SELECT i.Issue_Date, i.Due_Date, i.Book_Barcode, (SELECT Book_ID FROM BOOKCOPIES WHERE Book_Barcode = i.Book_Barcode) AS aBook_ID, (SELECT NAME FROM BOOKS WHERE Book_ID = aBook_ID) AS B_Name, (SELECT Author_Name FROM BOOKS WHERE Book_ID=aBook_ID) AS AuthorName, i.Returned_Date FROM BOOKSISSUED AS i WHERE (Customer_ID = {0}) && (i.Returned_Date IS NULL) && (i.Due_Date = @Date);", cd.CustomerID);
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.AddDays(-Settings.Default.BlockedPeriod).ToString("yyyy-MM-dd"));
                rdr = cmd.ExecuteReader();
                sb.Append(String.Format("HI {0} \n Unfortuatly due to how the following books have been overdue for {1} days, you are now blocked from issuing any new books. \n \nThis block will remain in place on your account until you return all overdue books and talk to the Libarians in person:\n \n", cd.Name, Settings.Default.BlockedPeriod.ToString()));
                while (rdr.Read())
                {
                    string issueDate = rdr.GetString(0);
                    string dDate = rdr.GetString(1);
                    dt = Convert.ToDateTime(rdr.GetString(1));
                    decimal barcode = rdr.GetDecimal(2);
                    string name = rdr.GetString(4);
                    string author = rdr.GetString(5);
                    sb.Append(String.Format("{3} by {4} \n Issued Date: {0} \n Due Date: {1} \n Barcode: {2} \n \n", issueDate, dDate, barcode.ToString(), name, author));
                    a++;
                }
                sb.Append("Please return these books as soon as possible to ensure that you are not charged a Lost Book Fee. Any issues please get in touch with us \n \nThanks, \n \nThe Library \n \n");
                rdr.Close();
                MemoryStream ms = GenerateCalEvent();
                SendEmail.SendOverdueEmail(sb.ToString(), cd);
                if (cd.PhoneNo != 0)
                {
                    ReminderText.SendText(cd.PhoneNo, String.Format("Hi {0}! \nYou have had books overdue for more then {1} days. \nYou are now blocked from issuing new books \nSee your Email for more Info. \nRegards \nThe Library \n \n--DO NOT REPLY--", cd.Name, Settings.Default.BlockedPeriod.ToString()));
                }//If a Phone Number exists on account send them a SMS Message
                Output = sb.ToString();
                sb.Clear();
                sql = "UPDATE USERS SET BANNED = 1 WHERE Customer_ID = @ID";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", cd.CustomerID);
                int i = cmd.ExecuteNonQuery();
            }
        }

        public static MemoryStream GenerateCalEvent()
        {
            var calendar = new Ical.Net.Calendar();
            calendar.Events.Add(new Ical.Net.CalendarComponents.CalendarEvent
            {
                Class = "PUBLIC",
                Summary = "Books Due Back",
                Created = new CalDateTime(DateTime.Now),
                Description = Output,
                Start = new CalDateTime(dt),
                End = new CalDateTime(dt.AddDays(1)),
                Sequence = 0,
                Uid = Guid.NewGuid().ToString(),
                Location = "The Library",
            });
            var serializer = new CalendarSerializer(new SerializationContext());
            var serializedCalendar = serializer.SerializeToString(calendar);
            var bytesCalendar = Encoding.UTF8.GetBytes(serializedCalendar);
            MemoryStream ms = new MemoryStream(bytesCalendar);
            return ms;
        } //Create the Reminder Email's Calendar File
    }
}
