using MainLibrary;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserForm : Form
    {
        private CustomerDetails CurrentUser;
        private bool AddingNewUser;
        private bool UserIsCustomer;

        public UserForm(bool addingNewUser, bool userIsCustomer, CustomerDetails currentUser)
        {
            this.CurrentUser = currentUser;
            this.AddingNewUser = addingNewUser;
            this.UserIsCustomer = userIsCustomer;
            InitializeComponent();

            if (AddingNewUser && UserIsCustomer)// Adding a new user who is a customer
            {
                txtConfirmEmail.Text = currentUser.EmailAddress;
                txtEmail.Text = currentUser.EmailAddress;
                txtConfirmEmail.Enabled = false;
                txtEmail.Enabled = false;
                comboClearance.Enabled = false;
                comboClearance.SelectedIndex = 0;
                labelClearanceWarning.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (AddingNewUser && !UserIsCustomer)
            {
            }
            else if (!AddingNewUser)// Updating existing user
            {
                txtConfirmEmail.Text = currentUser.EmailAddress;
                txtEmail.Text = currentUser.EmailAddress;
                txtPassword.Enabled = false;
                txtPasswordConfirm.Enabled = false;
                txtPassword.BackColor = Color.FromArgb(0, 96, 96);
                txtPasswordConfirm.BackColor = Color.FromArgb(0, 96, 96);
                btnAddUser.Visible = false;
                comboClearance.SelectedIndex = CurrentUser.AccessLevel;
                txtRFID.Text = FormTools.SelectTargetField(@"SELECT RFID_Tag FROM USERS WHERE Email_Address = '" + CurrentUser.EmailAddress + "';");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.AccessLevel < 2)
            {
                comboClearance.Items.RemoveAt(2);
            }
            if (CurrentUser.AccessLevel < 1)
            {
                comboClearance.Items.Remove(1);
                comboClearance.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Regex regexEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            Regex regexPassword = new Regex(@"^(?=.*\d+)(?=.*[a-zA-Z])[0-9a-zA-Z!@#$%]{8,50}$");

            if (!regexPassword.IsMatch(txtPassword.Text))
            {
                FormTools.Prompt(Color.Red, "Password must be 8+ characters long, and contain one capital, lowercase, and number.", "Invalid Password Format", this.Name);
            }
            else if (!regexEmail.IsMatch(txtConfirmEmail.Text) && txtEmail.Enabled)
            {
                FormTools.Prompt(Color.Red, "Please enter a valid Email Address.", "Invalid Email", this.Name);
            }
            else if (txtPassword.Text == "" || txtPasswordConfirm.Text == "" || ((txtConfirmEmail.Text == "" || txtEmail.Text == "") && txtEmail.Enabled))
            {
                FormTools.Prompt(Color.Red, "Please make sure all fields are filled in!", "Empty Field Error", this.Name);
            }
            else if (txtPassword.Text != txtPasswordConfirm.Text || (txtEmail.Text != txtConfirmEmail.Text && txtEmail.Enabled))
            {
                FormTools.Prompt(Color.Red, "Please make sure your credentials match correctly!", "Information Mismatch Error", this.Name);
            }
            else if (int.Parse(FormTools.SelectTargetField("SELECT COUNT(Email_Address) FROM USERS WHERE Email_Address = '" + txtEmail.Text + "';")) >= 1)
            {
                FormTools.Prompt(Color.Red, "This email has already been taken. Please choose another one.", "Existing Email Address", this.Name);
            }
            else
            {
                string sql;
                if (UserIsCustomer)
                {
                    sql = "INSERT INTO USERS(Email_Address, Password ,RFID_Tag, Customer_ID, Acess_Level, Updated_Date) VALUES(@email, @password, @rfid, @customerID, @accessLevel, @date)";
                }
                else
                {
                    sql = "INSERT INTO USERS(Email_Address, Password ,RFID_Tag, Acess_Level, Updated_Date) VALUES(@email, @password, @rfid, @accessLevel, @date)";
                }
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                //cmd.Parameters.AddWithValue("@uid", int.Parse(FormTools.SelectTargetField("SELECT MAX(User_ID) FROM USERS")) + 1);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", FormTools.Hash(txtPassword.Text));
                cmd.Parameters.AddWithValue("@rfid", txtRFID.Text);

                if (UserIsCustomer)//Adding new user who is NOT a customer
                {
                    cmd.Parameters.AddWithValue("@customerID", CurrentUser.CustomerID);
                }

                cmd.Parameters.AddWithValue("@accessLevel", comboClearance.SelectedIndex);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.ExecuteNonQuery();

                if (AddingNewUser)
                {
                    if (UserIsCustomer)
                    {
                        SendEmail.SendLibraryInformation(FormTools.SelectTargetField("SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = '" + CurrentUser.CustomerID + "';") + " " + FormTools.SelectTargetField("SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = '" + CurrentUser.CustomerID + "';"), txtEmail.Text);
                    }
                    else if (comboClearance.SelectedIndex == 2)
                    {
                        SendEmail.SendLibraryInformation("Librarian", txtEmail.Text);
                    }
                    else if (comboClearance.SelectedIndex == 3)
                    {
                        SendEmail.SendLibraryInformation("Admin", txtEmail.Text);
                    }
                }
                FormTools.Prompt(Color.Green, "User Added Successfully", "Success", this.Name);
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Regex regexEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (txtConfirmEmail.Text == null || txtConfirmEmail.Text == "" || txtEmail.Text == null || txtEmail.Text == "")
            {
                FormTools.Prompt(Color.Red, "Please make sure required fields are filled in.", "Empty Field Error", this.Name);
            }
            else if (txtEmail.Text != txtConfirmEmail.Text)
            {
                FormTools.Prompt(Color.Red, "Please make sure username/password are confirmed.", "Confirmation Mismatch Error", this.Name);
            }
            else if (!regexEmail.IsMatch(txtConfirmEmail.Text))
            {
                FormTools.Prompt(Color.Red, "Please enter a valid Email Address.", "Invalid Email", this.Name);
            }
            else if (int.Parse(FormTools.SelectTargetField("SELECT COUNT(Email_Address) FROM USERS WHERE Email_Address = '" + txtEmail.Text + "';")) >= 1 && txtEmail.Text != CurrentUser.EmailAddress)
            {
                FormTools.Prompt(Color.Red, "This email has already been taken. Please choose another one.", "Existing Email Address", this.Name);
            }
            else
            {
                string sql = "UPDATE USERS SET Email_Address = @email, RFID_Tag = @rfid, Acess_Level = @accessLevel, Updated_Date = @date WHERE Email_Address = '" + CurrentUser.EmailAddress + "';";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@rfid", txtRFID.Text);
                cmd.Parameters.AddWithValue("@accessLevel", comboClearance.SelectedIndex);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                int i = cmd.ExecuteNonQuery();
                FormTools.Prompt(Color.Green, "User Updated Successfully", "Success", this.Name);
                this.Close();
            }
        }

        private void btnScanRFID_Click(object sender, EventArgs e)
        {
            ScanItemForm scanItemForm = new ScanItemForm(1);
            scanItemForm.ShowDialog();
            txtRFID.Text = scanItemForm.returnValue;
            scanItemForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}