using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using MainLibrary;

namespace Project
{
    public partial class LoginForm : Form
    {
        private int strikes;
        private int ticks;
        private int clock;
        public CustomerDetails currentUser;

        public LoginForm()
        {
            InitializeComponent();
            ticks = 0;
            strikes = 3;
            clock = 30;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                FormTools.Prompt(Color.Red, "You have entered too many incorrect credentials. Please come back in " + (clock - ticks) + " seconds.", "Credential Strike Error", this.Name);
            }
            else
            {
                if (txtPassword.Text != "" || txtEmail.Text != "")
                {
                    if (FormTools.DBHasValue("SELECT Email_Address FROM USERS WHERE Email_Address = '" + txtEmail.Text + "'"))
                    {
                        string query = "SELECT Password FROM USERS WHERE Email_Address = '" + txtEmail.Text + "'";
                        string password = FormTools.SelectTargetField(query);

                        if (FormTools.IsValidated(password, txtPassword.Text))
                        {
                            int accessLevel = int.Parse(FormTools.SelectTargetField("SELECT Acess_Level FROM USERS WHERE Email_Address = '" + txtEmail.Text + "'"));

                            if (FormTools.SelectTargetField("SELECT Customer_ID FROM USERS WHERE Email_Address = '" + txtEmail.Text + "'") != "")// If user is a customer
                            {
                                int customerID = int.Parse(FormTools.SelectTargetField("SELECT Customer_ID FROM USERS WHERE Email_Address = '" + txtEmail.Text + "'"));
                                string fname = FormTools.SelectTargetField("SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = " + customerID);
                                string lname = FormTools.SelectTargetField("SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = " + customerID);
                                currentUser = new CustomerDetails(customerID, txtEmail.Text, fname, lname, accessLevel);
                            }
                            else if (accessLevel == 1)//If user is a Librarian
                            {
                                currentUser = new CustomerDetails(txtEmail.Text, "Librarian User", accessLevel);
                            }
                            else if (accessLevel == 2)//If user is a Admin
                            {
                                currentUser = new CustomerDetails(txtEmail.Text, "Admin User", accessLevel);
                            }
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            FormTools.Prompt(Color.Red, "Incorrect Email-Address/Password", "Login Error", this.Name);
                            strikes--;
                            if (strikes == 0)
                            {
                                timer.Start();
                            }
                        }
                    }
                    else
                    {
                        FormTools.Prompt(Color.Red, "Incorrect Email-Address/Password", "Login Error", this.Name);
                    }
                }
                else
                {
                    FormTools.Prompt(Color.Red, "Please make sure all fields are filled in!", "Empty Field Error", this.Name);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ticks >= clock)
            {
                strikes = 0;
                ticks = 0;
                clock *= 2;
                timer.Stop();
            }
            else
            {
                ticks++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentUser = new CustomerDetails("random@email.com", "Testing Account", 2);
            this.DialogResult = DialogResult.OK;
        }

        private void btnForgotPw_Click(object sender, EventArgs e)
        {
            using (PasswordResetForm forgotPw = new PasswordResetForm())
            {
                DialogResult result = forgotPw.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (Control control in this.Controls)
                    {
                        control.Enabled = true;
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}