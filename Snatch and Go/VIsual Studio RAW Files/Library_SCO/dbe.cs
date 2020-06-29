using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Library_SCO
{
    class dbe
    {
        public string CONSTRING = String.Format("Server={0};Database={1};Uid={2};Pwd={3};",Settings.Default.IPAddress, Settings.Default.Database, Settings.Default.Username, Settings.Default.Password);
        // public const string CONSTRING = "Server=127.0.0.1;Database=library;Uid=root;Pwd=;";
        public static Customer GetUser(string rfid)
        {
            MySqlConnection conn = Connection.connection;
            string sql = string.Format("SELECT COUNT(*) FROM USERS WHERE RFID_Tag = '{0}'", rfid);
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = comm.ExecuteReader();
            rdr.Read();
            int count = rdr.GetInt32(0);
            rdr.Close();
            if (count > 0)
            {
                sql = string.Format("SELECT Customer_ID, Banned, Email_Address FROM USERS WHERE RFID_Tag = '{0}'", rfid);
                comm = new MySqlCommand(sql, conn);
                rdr = comm.ExecuteReader();
                rdr.Read();
                    int id = rdr.GetInt32(0);
                    int blocked = rdr.GetInt32(1);
                    string email = rdr.GetString(2);
                    sql = String.Format("SELECT First_Name, DOB FROM CUSTOMERS WHERE Customer_ID = '{0}'", id);
                    rdr.Close();
                    comm = new MySqlCommand(sql, conn);
                    rdr = comm.ExecuteReader();
                    rdr.Read();
                    string name = rdr.GetString(0);
                    string date = rdr.GetString(1);
                    rdr.Close();
                    return new Customer(id, name, date, blocked, email);   
            }
            else
                return new Customer(0, "INVALID", "2020-01-20", 0, " ");

        }

        public static Book GetBookDetails(string rfid)
        {
            MySqlConnection conn = Connection.connection;
            Book bk = new Book();
            string sql = string.Format("SELECT COUNT(*) FROM BOOKCOPIES WHERE RFID_Tag = '{0}'", rfid);
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = comm.ExecuteReader();
            rdr.Read();
            int count = rdr.GetInt32(0);
            rdr.Close();
            if (count > 0)
            {
                sql = string.Format("SELECT Book_Barcode, Book_ID FROM BOOKCOPIES WHERE RFID_Tag = '{0}'", rfid);
                comm = new MySqlCommand(sql, conn);
                rdr = comm.ExecuteReader();
                rdr.Read();
                bk.Book_Barcode = rdr.GetDecimal(0);
                bk.Book_ID = rdr.GetInt32(1);
                rdr.Close();
                sql = String.Format("SELECT Name, Author_Name, Genre_ID FROM BOOKS WHERE Book_ID = '{0}'", bk.Book_ID);
                comm = new MySqlCommand(sql, conn);
                rdr = comm.ExecuteReader();
                rdr.Read();
                bk.Name = rdr.GetString(0);
                bk.Author = rdr.GetString(1);
                int genre = rdr.GetInt32(2);
                rdr.Close();
                sql = String.Format("SELECT Minimum_Age FROM GENRES WHERE Genre_ID = '{0}'", genre);
                comm = new MySqlCommand(sql, conn);
                rdr = comm.ExecuteReader();
                rdr.Read();
                bk.Age = rdr.GetInt32(0);
                rdr.Close();
                return bk;
            }
            else
            {
                return null;
            }
        }

        public static int IssueBook(Book bk, Customer cm)
        {
            MySqlConnection conn = Connection.connection;

            int rows = 0;
            string sql = "INSERT INTO BOOKSISSUED values(@Issue_Number, @Customer_ID,@Issue_Date,@Due_Date, @Returned_Date, @Book_Barcode);";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("Issue_Number", null);
                cmd.Parameters.AddWithValue("Customer_ID", cm.CustomerID);
                cmd.Parameters.AddWithValue("Issue_Date", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("Due_Date", bk.DueDate.ToString());
                cmd.Parameters.AddWithValue("Returned_Date", null);
                cmd.Parameters.AddWithValue("Book_Barcode", bk.Book_Barcode);
                rows = cmd.ExecuteNonQuery();
            }
            return rows;
        }

        public static Customer GetHoldDetails(Book bk)
        {
            MySqlConnection conn = Connection.connection;
            int foundId = -1;
            MySqlDataReader rdr = null;

            string sql = "SELECT COUNT(*) FROM BOOKSONHOLD WHERE Book_Barcode = @Barcode;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("Barcode", bk.Book_Barcode);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                foundId = rdr.GetInt32(0);
                rdr.Close();
            cmd.Parameters.Clear();
            
            if (foundId == 0)
            {
                return null;
            }//if no book on hold return false;
            else
            {
                Customer cmt = null;
                sql = "SELECT MIN(Hold_ID), Customer_ID, DATE FROM BOOKSONHOLD WHERE Book_Barcode = @Barcode";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Barcode", bk.Book_Barcode);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                int cId = rdr.GetInt32(1);
                string date = rdr.GetString(2);
                rdr.Close();
                cmd.Parameters.Clear();

                sql = "SELECT First_Name, Last_Name, (SELECT Email_Address FROM USERS WHERE Customer_ID = @ID) AS Email FROM CUSTOMERS WHERE Customer_ID = @ID";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", cId);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                Customer customer = new Customer(cId, string.Format("{0} {1}", rdr.GetString(0), rdr.GetString(1)), date, 0, rdr.GetString(2));
                rdr.Close();
                return customer;
            }
        }

        public static int GetCount(int id)
        {
            MySqlConnection conn = Connection.connection;
            string SQL = "SELECT COUNT(*) FROM BOOKSISSUED WHERE Customer_ID = @ID AND Returned_Date IS NULL";
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int remaningBooks = Settings.Default.MaximumBooks - rdr.GetInt32(0);
            rdr.Close();
            return remaningBooks;
        }

        internal static int ReturnBook(Book bk)
        {
            MySqlConnection conn = Connection.connection;
            string SQL = "SELECT Max(Issue_Number) FROM BOOKSISSUED WHERE Book_Barcode = @Barcode";
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Barcode", bk.Book_Barcode);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int issueNum = rdr.GetInt32(0);
            rdr.Close(); //Basically read the last book issued

            conn = Connection.connection;
            SQL = "UPDATE BOOKSISSUED SET Returned_DATE = @Date WHERE BOOK_Barcode = @Barcode AND Issue_Number = @Issue;";
            cmd = new MySqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Barcode", bk.Book_Barcode);
            cmd.Parameters.AddWithValue("@Issue", issueNum);
            int result = cmd.ExecuteNonQuery();
            return result; //Set the last book issued as returned
        }
    }
}
