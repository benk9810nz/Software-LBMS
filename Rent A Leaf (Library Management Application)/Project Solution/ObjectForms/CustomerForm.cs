using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MainLibrary;

namespace Project
{
    public partial class CustomerForm : Form
    {
        public bool passwd;
        public string RFID_Tag;
        public CustomerDetails currentUser;

        public CustomerForm(CustomerDetails user, bool addingCustomer)
        {
            InitializeComponent();
            currentUser = user;

            if (addingCustomer)
            {
                TC1.TabPages.Remove(TAB_Holds);
                TC1.TabPages.Remove(TAB_Previous);
                TC1.TabPages.Remove(TAB_Issues);
                btnUpdate.Visible = false;
                CB_Edit.Visible = false;
            }
            else
            {
                TB_FName.Text = FormTools.SelectTargetField("SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';");
                TB_LName.Text = FormTools.SelectTargetField("SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';");
                TB_A1.Text = FormTools.SelectTargetField("SELECT Address_Line1 FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';");
                TB_A2.Text = FormTools.SelectTargetField("SELECT Address_Line2 FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';");
                TB_City.Text = FormTools.SelectTargetField("SELECT City FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';");
                TB_Phone.Text = FormTools.SelectTargetField("SELECT Phone_Number FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';");
                dateTimePicker1.Value = DateTime.Parse(FormTools.SelectTargetField("SELECT DOB FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';"));
                txtEmail.Text = currentUser.EmailAddress;
                txtEmailConfirm.Text = currentUser.EmailAddress;
                //TB_Password.Text = FormTools.SelectTargetField("SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = '" + currentUser.CustomerID + "';");
                ChangeFields(true);
                btnAdd.Visible = false;
            }
        }

        public CustomerForm(CustomerDetails c)
        {
            InitializeComponent();
            currentUser = c;
            TC1.TabPages.Remove(TAB_Details);
            TC1.TabPages.Remove(TAB_Previous);
            TC1.TabPages.Remove(TAB_Issues);
        }

        private void ChangeFields(bool toggle)
        {
            TB_FName.ReadOnly = toggle;
            TB_LName.ReadOnly = toggle;
            TB_A1.ReadOnly = toggle;
            TB_A2.ReadOnly = toggle;
            TB_City.ReadOnly = toggle;
            TB_Phone.ReadOnly = toggle;
            dateTimePicker1.Enabled = !toggle;
            txtEmail.ReadOnly = toggle;
            txtEmailConfirm.ReadOnly = toggle;
        }

        private bool CheckValidation()
        {
            Regex regexEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (
                TB_FName.Text == "" ||
                TB_LName.Text == "" ||
                TB_A1.Text == "" ||
                TB_A2.Text == "" ||
                TB_City.Text == "" ||
                TB_Phone.Text == "" ||
                txtEmail.Text == ""
                )
            {
                FormTools.Prompt(Color.Red, "Please make sure required fields are filled in.", "Empty Field Error", this.Name);
                return false;
            }
            else if (int.Parse(FormTools.SelectTargetField("SELECT COUNT(Email_Address) FROM USERS WHERE Email_Address = '" + txtEmail.Text + "';")) >= 1 && txtEmail.Text != currentUser.EmailAddress)
            {
                FormTools.Prompt(Color.Red, "This email has already been taken. Please choose another one.", "Existing Email Address", this.Name);
                return false;
            }
            else if (!regexEmail.IsMatch(txtEmail.Text) && !regexEmail.IsMatch(txtEmailConfirm.Text))
            {
                FormTools.Prompt(Color.Red, "Please enter a valid Email Address.", "Invalid Email", this.Name);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddToDatabase()
        {
            MainLibrary.Customers customer = new MainLibrary.Customers(0, TB_FName.Text, TB_LName.Text, TB_A1.Text, TB_A2.Text, TB_City.Text, TB_Phone.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), string.Format("{0}", DateTime.Now));
            string sql = "INSERT INTO CUSTOMERS VALUES(NULL, @FName, @LName, @A1, @A2, @City, @Phone, @DOB, @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            cmd.Parameters.AddWithValue("@Fname", customer.FirstName);
            cmd.Parameters.AddWithValue("@LName", customer.LastName);
            cmd.Parameters.AddWithValue("@A1", customer.AddressLine1);
            cmd.Parameters.AddWithValue("@A2", customer.AddressLine2);
            cmd.Parameters.AddWithValue("@City", customer.City);
            cmd.Parameters.AddWithValue("@Phone", customer.PhoneNumber);
            cmd.Parameters.AddWithValue("@DOB", customer.DOB);
            cmd.Parameters.AddWithValue("@Date", customer.UpdatedDate);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Customer Added");

                sql = "SELECT MAX(Customer_ID) FROM CUSTOMERS"; //Will be the last one added
                cmd = new MySqlCommand(sql, Connection.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int id = 0;
                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                }
                rdr.Close();

                CustomerDetails customerDetails = new CustomerDetails(id, txtEmailConfirm.Text, customer.FirstName, customer.LastName, 0);
                UserForm userForm = new UserForm(true, true, customerDetails);
                userForm.Show();

                i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Added User to Database");
                }//Add User to the Database
            }// Add Customer to the Database
        }

        public void ClearFields()
        {
            TB_FName.Clear();
            TB_LName.Clear();
            TB_A1.Clear();
            TB_A2.Clear();
            TB_City.Clear();
            TB_Phone.Clear();
            txtEmail.Clear();
            passwd = false;
        }

        private void GetIssues()
        {
            LV_Issues.Items.Clear();
            string sql = String.Format("SELECT i.Issue_Number, i.Issue_Date, i.Due_Date, i.Book_Barcode, (SELECT Book_ID FROM BOOKCOPIES WHERE Book_Barcode = i.Book_Barcode) AS aBook_ID, (SELECT NAME FROM BOOKS WHERE Book_ID = aBook_ID) AS B_Name, (SELECT Author_Name FROM BOOKS WHERE Book_ID=aBook_ID) AS AuthorName, i.Returned_Date FROM BOOKSISSUED AS i WHERE (Customer_ID = {0}) && (i.Returned_Date IS NULL);", currentUser.CustomerID);
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr.GetString(0));
                item.SubItems.Add(rdr.GetString(1));
                item.SubItems.Add(rdr.GetString(2));
                DateTime dt = DateTime.Parse(rdr.GetString(2));
                double i = (dt - DateTime.Now).TotalDays; //Calculate Days Remaining
                item.SubItems.Add(Math.Ceiling(i).ToString());
                item.SubItems.Add(rdr.GetString(5));
                item.SubItems.Add(rdr.GetString(6));
                item.SubItems.Add(rdr.GetString(3));
                item.Tag = rdr.GetInt32(4);
                LV_Issues.Items.Add(item);
                if (i < 0)
                {
                    item.BackColor = Color.Red;
                }
                if (i < 7 && i >= 0)
                {
                    item.BackColor = Color.LightGray;
                }
            }
            rdr.Close();
        }

        private void GetPastHolds()
        {
            LV_Past.Items.Clear();
            string sql = String.Format("SELECT i.Issue_Number, i.Issue_Date, i.Returned_Date, i.Book_Barcode, (SELECT Book_ID FROM BOOKCOPIES WHERE Book_Barcode = i.Book_Barcode) AS aBook_ID, (SELECT NAME FROM BOOKS WHERE Book_ID = aBook_ID) AS B_Name, (SELECT Author_Name FROM BOOKS WHERE Book_ID=aBook_ID) AS AuthorName FROM BOOKSISSUED AS i WHERE (Customer_ID = {0}) && (i.Returned_Date IS NOT NULL);", currentUser.CustomerID);
           
            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr.GetString(1));
                item.SubItems.Add(rdr.GetString(2));
                //item.SubItems.Add(rdr.GetDecimal(3).ToString());
                //item.SubItems.Add(rdr.GetString(5));
                //item.SubItems.Add(rdr.GetString(6));
                LV_Past.Items.Add(item);
            }
            rdr.Close();
        }

        public void GetHolds()
        {
            LV_Holds.Items.Clear();
            string sql = String.Format("" +
                "SELECT " +
                    "h.Hold_ID, " +
                    "h.Book_Barcode, " +
                    "h.Date, " +
                    "h.Customer_ID , " +
                    "(SELECT " +
                        "Book_ID " +
                    "FROM " +
                        "BOOKCOPIES " +
                    "WHERE " +
                        "Book_Barcode = h.Book_Barcode) " +
                    "AS " +
                        "bcBook_ID, " +
                        "(SELECT NAME FROM BOOKS WHERE Book_ID = bcBook_ID) " +
                        "AS" +
                            " NAME, " +
                            "(SELECT " +
                                "Author_Name " +
                            "FROM " +
                                "BOOKS " +
                            "WHERE " +
                                "Book_ID = bcBook_ID) " +
                            "AS " +
                                "Author " +
                            "FROM " +
                                "BOOKSONHOLD " +
                            "AS " +
                                "h " +
                            "WHERE " +
                            "Customer_ID = {0};", currentUser.CustomerID);

            MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr.GetString(0));
                item.SubItems.Add(rdr.GetDecimal(1).ToString());
                item.SubItems.Add(rdr.GetString(5));
                item.SubItems.Add(rdr.GetString(6));
                item.SubItems.Add(rdr.GetString(2));
                LV_Holds.Items.Add(item);
            }
            rdr.Close();
        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            AlterCustomer();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                if (FormTools.SelectTargetField("SELECT Email_Address FROM USERS WHERE Email_Address = '" + txtEmailConfirm.Text + ";'") == txtEmailConfirm.Text)
                {
                    FormTools.Prompt(Color.Red, "This email has already been taken. Please choose another one.", "Existing Email Address", this.Name);
                }
                else
                {
                    AddToDatabase();
                    FormTools.Prompt(Color.Green, "Customer details updated successfully", "Success!", this.Name);
                    this.Close();
                }
            }
        }

        private void BT_Renew_Click(object sender, EventArgs e)
        {
            //Renew Book

            ListViewItem lv = LV_Issues.SelectedItems[0];
            int Book_ID = ((int)lv.Tag);

            if (int.Parse(lv.SubItems[3].Text) < 0)
            {
                FormTools.Prompt(Color.Red, "This book is currently overdue and cannot be renewed. Please return the book to the Library.", "Overdue Book-Renew Error", this.Name);
            }
            else
            {
                //string sql = String.Format("SELECT COUNT(*) FROM BOOKSONHOLD WHERE Book_Barcode = (SELECT Book_Barcode FROM BOOKCOPIES WHERE Book_ID = {0})", Book_ID);
                string sql = String.Format(
                    "SELECT " +
                        "COUNT(holds.Book_Barcode) " +
                    "FROM " +
                        "BOOKSONHOLD AS holds " +

                    "LEFT JOIN BOOKCOPIES AS copies " +
                        "ON copies.Book_Barcode = holds.Book_Barcode " +

                    "WHERE copies.Book_ID = '{0}';", Book_ID
                );
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                int holds = rdr.GetInt32(0);
                if (holds > 0)
                {
                    FormTools.Prompt(Color.Red, "Book cannot be renewed as it has been placed on hold by another customer.", "Book has already been Reserved", this.Name);
                }
                else
                {
                    DateTime dueDate = DateTime.Parse(lv.SubItems[2].Text); // Due Date
                    rdr.Close();

                    DateTime issueDate = DateTime.Parse(lv.SubItems[1].Text); //Issue Date

                    if ((dueDate - DateTime.Now).TotalDays >= 0)
                    { 
                        if ((dueDate - DateTime.Now).TotalDays <= 28)
                        {
                            sql = String.Format("UPDATE BOOKSISSUED SET Due_Date = '{0}' WHERE Issue_Number = {1}", (dueDate.AddDays(28)).ToString("yyyy-MM-dd"), lv.Text);
                            cmd = new MySqlCommand(sql, Connection.conn);
                            int i = cmd.ExecuteNonQuery();
                            if (i == 1)
                            {
                                FormTools.Prompt(Color.Green, "The book has been successfully renewed. The due date has been extended to " + (dueDate.AddDays(28).ToString()) + " days.", "Book Successfully Renewed", this.Name);
                            }
                            else
                            {
                                FormTools.Prompt(Color.Red, "An Error has occurred. Please contact the Library for assistance", "Unknown Book-Renew Error", this.Name);
                            }
                        }
                        else
                        {
                            FormTools.Prompt(Color.Red, "You already have a month issued with this book. If you need, you can renew this at a later date.", "Book is newly Issued", this.Name);
                        }
                    }
                    else
                    {
                        FormTools.Prompt(Color.Red, "This book is currently overdue and cannot be renewed. Please return the book to the Library.", "Overdue Book-Renew Error", this.Name);
                    }
                }
                rdr.Close();
            }
        }

        private void TC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC1.SelectedTab == TC1.TabPages[1])
            {
                GetIssues();
            }
            if (TC1.SelectedTab == TC1.TabPages[2])
            {
                GetPastHolds();
            }
            if (TC1.SelectedTab == TC1.TabPages[3])
            {
                GetHolds();
            }
        }

        private void LV_Issues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Issues.SelectedItems.Count > 0)
            {
                BT_Renew.Enabled = true;
            }
        }

        private void CB_Edit_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFields(!CB_Edit.Checked);
        }

        public void AlterCustomer()
        {
            if (CheckValidation())
            {
                MainLibrary.Customers customer = new MainLibrary.Customers(0, TB_FName.Text, TB_LName.Text, TB_A1.Text, TB_A2.Text, TB_City.Text, TB_Phone.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), DateTime.Now.ToString());
                string sql = "UPDATE CUSTOMERS SET First_Name = @FName, Last_Name = @LName, Address_Line1 = @A1, Address_Line2 = @A2, City = @City, Phone_Number = @Phone, DOB = @DOB, Updated_Date = @Date WHERE Customer_ID = @ID ";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                cmd.Parameters.AddWithValue("@Fname", customer.FirstName);
                cmd.Parameters.AddWithValue("@LName", customer.LastName);
                cmd.Parameters.AddWithValue("@A1", customer.AddressLine1);
                cmd.Parameters.AddWithValue("@A2", customer.AddressLine2);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@Phone", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@DOB", customer.DOB);
                cmd.Parameters.AddWithValue("@Date", customer.UpdatedDate);
                cmd.Parameters.AddWithValue("@ID", currentUser.CustomerID);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Customer Updated");
                    currentUser.Name = TB_FName.Text + " " + TB_LName.Text;
                    currentUser.EmailAddress = txtEmail.Text;
                    DialogResult = DialogResult.OK;
                    cmd.CommandText = sql;
                    sql = "UPDATE USERS SET Email_Address = @Email, Updated_Date = @Date WHERE Customer_ID = @CID";
                    cmd = new MySqlCommand(sql, Connection.conn);
                    cmd.Parameters.AddWithValue("@Email", txtEmailConfirm.Text);
                    cmd.Parameters.AddWithValue("@Date", customer.UpdatedDate);
                    cmd.Parameters.AddWithValue("@CID", currentUser.CustomerID);
                    i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Updated User");
                    }//Add User to the Database
                }// Add Customer to the Database
            }
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            PasswordResetForm passwordResetForm = new PasswordResetForm();
            passwordResetForm.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void LV_Holds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}