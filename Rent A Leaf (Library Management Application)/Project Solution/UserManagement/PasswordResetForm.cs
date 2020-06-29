using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Project
{
    public partial class PasswordResetForm : Form
    {
        public PasswordResetForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Regex regexPassword = new Regex(@"^(?=.*\d+)(?=.*[a-zA-Z])[0-9a-zA-Z!@#$%]{8,50}$");
            Regex regexEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (!regexPassword.IsMatch(txtPassword.Text))
            {
                FormTools.Prompt(Color.Red, "Password must be 8+ characters long, and contain one capital, lowercase, and number.", "Invalid Password Format", this.Name);
            }
            else if (txtPassword.Text == "" || txtPasswordConfirm.Text == "" || txtEmail.Text == "" || txtEmailConfirm.Text == "")
            {
                FormTools.Prompt(Color.Red, "Please make sure all fields are filled in!", "Empty Field Error", this.Name);
            }
            else if (txtPassword.Text != txtPasswordConfirm.Text || txtEmail.Text != txtEmailConfirm.Text)
            {
                FormTools.Prompt(Color.Red, "Please make sure your credentials match correctly!", "Information Mismatch Error", this.Name);
            }
            else if (!regexEmail.IsMatch(txtEmail.Text))
            {
                FormTools.Prompt(Color.Red, "Please enter a valid email address! (E.g: example@email.com)", "Invalid Email Address", this.Name);
            }
            else
            {
                Random r = new Random();
                string key = "";
                for (int i = 0; i < 6; i++)
                {
                    key += r.Next(0, 9);
                }

                if (FormTools.DBHasValue("SELECT Customer_ID FROM USERS WHERE Email_Address = '" + txtEmail.Text + "';"))
                {
                    int id = int.Parse(FormTools.SelectTargetField("SELECT Customer_ID FROM USERS WHERE Email_Address = '" + txtEmail.Text + "'"));
                    string fname = FormTools.SelectTargetField("SELECT First_Name FROM CUSTOMERS WHERE Customer_ID = '" + string.Format("{0}", id) + "'");
                    string lname = FormTools.SelectTargetField("SELECT Last_Name FROM CUSTOMERS WHERE Customer_ID = '" + string.Format("{0}", id) + "'");

                    SendEmail.SendVerificationEmail(key, string.Format("{0} {1}", fname, lname), txtEmail.Text);
                }
                else
                {
                    SendEmail.SendVerificationEmail(key, "Library User", txtEmail.Text);
                }
                FormTools.Prompt(Color.Green, "Verification email has been sent to " + txtEmail.Text + ".", "Email Sent", this.Name);

                using (PasswordResetConfirmForm reset = new PasswordResetConfirmForm(txtEmail.Text, txtPassword.Text, FormTools.Hash(string.Format(key))))
                {
                    DialogResult result = reset.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (Control control in this.Controls)
                        {
                            control.Enabled = true;
                        }
                    }
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordResetForm_Load(object sender, EventArgs e)
        {

        }
    }
}