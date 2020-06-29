using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_SCO
{
    public partial class Configuration_Settings : Form
    {
        public Configuration_Settings()
        {
            InitializeComponent();
        }

        private void Configuration_Settings_Load(object sender, EventArgs e)
        {
            TB_sAddress.Text = Settings.Default.IPAddress;
            TB_sDatabase.Text = Settings.Default.Database;
            TB_sPassword1.Text = Settings.Default.Password;
            TB_sPassword2.Text = Settings.Default.Password;
            TB_sUsername.Text = Settings.Default.Username;

            TB_ePassword.Text = Settings.Default.SMTPassword;
            TB_ePassword2.Text = Settings.Default.SMTPassword;
            TB_eServer.Text = Settings.Default.SMTPServer;
            TB_eUsername.Text = Settings.Default.SMTPassword;

            NM_ePort.Value = Settings.Default.SMTPPort;
            NM_MaxBooks.Value = Settings.Default.MaximumBooks;
            NM_Issue.Value = Settings.Default.IssuePeriod;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                if (TB_sPassword1.Text == TB_sPassword2.Text)
                {
                    Settings.Default.IPAddress = TB_sAddress.Text;
                    Settings.Default.Database = TB_sDatabase.Text;
                    Settings.Default.Password = TB_sPassword1.Text;
                    Settings.Default.Password = TB_sPassword2.Text;
                    Settings.Default.Username = TB_sUsername.Text;

                    Settings.Default.SMTPassword = TB_ePassword.Text;
                    Settings.Default.SMTPassword = TB_ePassword2.Text;
                    Settings.Default.SMTPServer = TB_eServer.Text;
                    Settings.Default.SMTPassword = TB_eUsername.Text;

                    Settings.Default.SMTPPort = (int)NM_ePort.Value;
                    Settings.Default.MaximumBooks = (int)NM_MaxBooks.Value;
                    Settings.Default.IssuePeriod = (int)NM_Issue.Value;
                }
                else
                {
                    MessageBox.Show("Passwords must match");
                }
            }
            else
            {
                MessageBox.Show("Please ensure that all the fields are filled out");
            }
        }

        private bool CheckValidation()
        {
            if (TB_ePassword.Text != "")
            {
                if (TB_ePassword2.Text != "")
                {
                    if (TB_eServer.Text != "")
                    {
                        if (TB_eUsername.Text != "")
                        {
                            if (TB_sAddress.Text != "")
                            {
                                if (TB_sDatabase.Text != "")
                                {
                                    if (TB_sPassword1.Text != "")
                                    {
                                        if (TB_sPassword2.Text != "")
                                        {
                                            if (TB_sUsername.Text != "")
                                            {
                                                return true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
