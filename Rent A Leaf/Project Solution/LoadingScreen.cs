using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            string CONSTRING = String.Format("Server={0};Database={1};Uid={2};Pwd={3};", Settings.Default.IPAddress, Settings.Default.Database, Settings.Default.Username, Settings.Default.Password);
            MySqlConnection conn = new MySqlConnection(CONSTRING);
            try
            {
                conn.Open();
                LB2.Text = "Connection Successful";
                Thread.Sleep(2000);
                Connection.conn = conn;

                SendReminderEmail(conn);
            }
            catch (MySqlException ex)
            {
                LB2.Text = "Connection Error: " + ex.Message;
                ///Load Settings Form
            }
        }

        private void LoadingScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Close();
        }

        private static void SendReminderEmail(MySqlConnection conn)
        {
            String sql = "SELECT DISTINCT(r.Customer_ID), (SELECT Email_Address FROM USERS WHERE Customer_ID = r.Customer_ID) AS Email, (SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS FName, (SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = r.Customer_ID) AS LName FROM BOOKSISSUED AS r WHERE Due_Date = '2020-05-15' AND Returned_Date IS NULL;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<CustomerDetails> customerIDs = new List<CustomerDetails>();
            while (rdr.Read())
            {
                customerIDs.Add(new CustomerDetails(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetInt32(4)));
            }
            rdr.Close();
            int a = 0;
            StringBuilder sb = new StringBuilder();
            foreach (CustomerDetails cd in customerIDs)
            {
                sql = String.Format("SELECT i.Issue_Date, i.Due_Date, i.Book_Barcode, (SELECT Book_ID FROM BOOKCOPIES WHERE Book_Barcode = i.Book_Barcode) AS aBook_ID, (SELECT NAME FROM BOOKS WHERE Book_ID = aBook_ID) AS B_Name, (SELECT Author_Name FROM BOOKS WHERE Book_ID=aBook_ID) AS AuthorName, i.Returned_Date FROM BOOKSISSUED AS i WHERE (Customer_ID = {0}) && (i.Returned_Date IS NULL) && (i.Due_Date = '2020-05-15');", cd.CustomerID);
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                sb.Append(String.Format("HI {0} \nThe Following Books are due back within the next 7 days: \n \n", cd.Name));
                while (rdr.Read())
                {
                    string issueDate = rdr.GetString(0);
                    string dDate = rdr.GetString(1);
                    decimal barcode = rdr.GetDecimal(2);
                    string name = rdr.GetString(4);
                    string author = rdr.GetString(5);
                    sb.Append(String.Format("{3} by {4} \n Issued Date: {0} \n Return Date: {1} \n Bar-code: {2} \n \n", issueDate, dDate, barcode.ToString(), name, author));
                    a++;
                }
                sb.Append("If you are unable to get these books back in time, Please login to your account and see if you can renew them. Otherwise get in touch with us \n \nThanks, \n \nThe Library \n \n");
                rdr.Close();
                SendEmail.SendReminderEmail(sb.ToString(), cd);
                sb.Clear();
            }
        }
    }
}