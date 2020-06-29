using MainLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class RetailerForm : Form
    {
        private Retailers retailer;
        private CustomerDetails CurrentUser;

        public RetailerForm(CustomerDetails c)
        {
            InitializeComponent();
            CurrentUser = c;
            btnUpdateRet.Visible = false;
        }

        public RetailerForm(CustomerDetails c, Retailers r)
        {
            InitializeComponent();
            CurrentUser = c;
            this.retailer = r;
            txtAddressLine1.Text = r.AddressLine1;
            txtAddressLine2.Text = r.AddressLine2;
            txtCity.Text = r.City;
            txtName.Text = r.Name;
            txtPhoneNumber.Text = r.PhoneNumber;
            txtURL.Text = r.WebsiteURL;
            btnSubmit.Visible = false;
            txtEmail.Text = r.EmailAddress;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO RETAILERS(Retailer_ID, Name, Address_Line1, Address_Line2, City, Phone_Number, Website_URL, Email_Address, Updated_Date) VALUES(NULL, @Name, @AddressLine1, @AddressLine2, @City, @PhoneNumber, @URL, @email, @date)";
            DataUpload(query, "Created");
        }

        private void btnUpdateRet_Click(object sender, EventArgs e)
        {
            string query = "UPDATE RETAILERS SET Name = @Name, Address_Line1 = @AddressLine1, Address_Line2 = @AddressLine2, City = @City, Phone_Number = @PhoneNumber, Website_URL = @URL, Email_Address = @email, Updated_Date = @date WHERE Retailer_ID = '" + retailer.RetailerID + "';";
            DataUpload(query, "Updated");
        }

        private void DataUpload(string query, string updatedCreated)
        {
            if (txtAddressLine1.Text == null || txtAddressLine1.Text == "" || txtCity.Text == null || txtCity.Text == "" || txtPhoneNumber.Text == null || txtPhoneNumber.Text == "" || txtName.Text == null || txtName.Text == "" || txtURL.Text == null || txtURL.Text == "")
            {
                FormTools.Prompt(Color.Red, "Please make sure required fields are filled in.", "Empty Field Error", this.Name);
            }
            else
            {
                Retailers retailer = new Retailers(0, txtName.Text, txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtPhoneNumber.Text, txtURL.Text, txtEmail.Text, DateTime.Now.ToString());
                using (MySqlCommand comm = new MySqlCommand(query, Connection.conn))
                {
                    comm.Connection = Connection.conn;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@Name", retailer.Name);
                    comm.Parameters.AddWithValue("@AddressLine1", retailer.AddressLine1);
                    comm.Parameters.AddWithValue("@AddressLine2", retailer.AddressLine2);
                    comm.Parameters.AddWithValue("@City", retailer.City);
                    comm.Parameters.AddWithValue("@PhoneNumber", retailer.PhoneNumber);
                    comm.Parameters.AddWithValue("@URL", retailer.WebsiteURL);
                    comm.Parameters.AddWithValue("@email", retailer.EmailAddress);
                    comm.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    int i = comm.ExecuteNonQuery();
                }
                FormTools.Prompt(Color.Green, "Retailer " + updatedCreated + " Successfully", "Success", this.Name);
                this.Close();
            }
        }

        private void RetailerForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.AccessLevel < 2)
            {
                txtAddressLine1.Enabled = false;
                txtAddressLine2.Enabled = false;
                txtCity.Enabled = false;
                txtName.Enabled = false;
                txtURL.Enabled = false;
                txtEmail.Enabled = false;
                txtPhoneNumber.Enabled = false;
                btnSubmit.Visible = false;
                btnUpdateRet.Visible = false;
            }

        }
    }
}