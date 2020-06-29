using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Library_SCO
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }

        public void ConnectToDatabase()
        {
            MySqlConnection conn = new MySqlConnection(String.Format("Server={0};Database={1};Uid={2};Pwd={3};", Settings.Default.IPAddress, Settings.Default.Database, Settings.Default.Username, Settings.Default.Password));
            try
            {
                conn.Open();
                Connection.connection = conn;
                MainWindow fm = new MainWindow();
                this.Visible = false;
                fm.ShowDialog();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect the specified MySQL Database. Please check that the connection details are correct | Error Message: " + ex.Message);
                Configuration_Settings fm = new Configuration_Settings();
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    ConnectToDatabase();
                }
            }
        }
    }
}
