using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PasswordResetConfirmForm : Form
    {
        private string email;
        private string password;
        private string key;
        private int ticks;
        private int strikes;
        private int clock;

        public PasswordResetConfirmForm(string Email, string Password, string Key)
        {
            InitializeComponent();
            this.email = Email;
            this.password = Password;
            this.key = Key;
            ticks = 0;
            strikes = 3;
            clock = 30;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                FormTools.Prompt(Color.Red, "You have entered too many incorrect validation keys. Please come back in " + (clock - ticks) + " seconds.", "Credential Strike Error", this.Name);
            }
            else
            {
                if (FormTools.IsValidated(key, txtValidationCode.Text))
                {
                    string query = "UPDATE USERS SET Password = @pw WHERE Email_Address = @email";
                    using (MySqlCommand comm = new MySqlCommand(query, Connection.conn))
                    {
                        comm.Connection = Connection.conn;
                        comm.CommandText = query;
                        comm.Parameters.AddWithValue("@pw", FormTools.Hash(password));
                        comm.Parameters.AddWithValue("@email", email);
                        comm.ExecuteNonQuery();
                        email = "";
                        password = "";
                        FormTools.Prompt(this.BackColor, "Credentials successfully sent.", "Success!", this.Name);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    FormTools.Prompt(Color.Red, "Please make sure the validation key entered is correct.", "Validation Key is Invalid", this.Name);
                    strikes--;
                    if (strikes == 0)
                    {
                        timer.Start();
                    }
                }
            }
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

        private void PasswordResetConfirmForm_Load(object sender, EventArgs e)
        {

        }
    }
}