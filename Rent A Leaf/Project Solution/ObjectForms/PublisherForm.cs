using MainLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PublisherForm : Form
    {
        private Publishers publisher;
        private CustomerDetails currentUser;

        public PublisherForm(CustomerDetails c)
        {
            InitializeComponent();
            currentUser = c;
            btnUpdatePub.Visible = false;
        }

        public PublisherForm(CustomerDetails c, Publishers p)
        {
            InitializeComponent();
            currentUser = c;
            publisher = p;
            txtAddressLine1.Text = p.AddressLine1;
            txtAddressLine2.Text = p.AddressLine2;
            txtCity.Text = p.City;
            txtName.Text = p.Name;
            txtPhone.Text = p.PhoneNumber;
            txtPostcode.Text = p.Postcode.ToString();
            txtSuburb.Text = p.Suburb;
            txtURL.Text = p.WebsiteURL;
            btnSubmit.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO PUBLISHERS(Publisher_ID, Name, Address_Line1, Address_Line2, City,  Suburb, Postcode, Phone_Number, Website_URL, Updated_Date) VALUES(NULL, @Name, @AddressLine1, @AddressLine2, @City, @Sub, @Post, @Phone, @URL, @date)";
            UploadData(query, "Created");
        }

        private void btnUpdatePub_Click(object sender, EventArgs e)
        {
            string query = "UPDATE PUBLISHERS SET Name = @Name, Address_Line1 = @AddressLine1, Address_Line2 = @AddressLine2, City = @City, Suburb = @Sub, Postcode = @Post, Phone_Number = @Phone, Website_URL = @URL, Updated_Date = @date WHERE Publisher_ID = '" + publisher.PublisherID + "';";
            UploadData(query, "Updated");
        }

        private void UploadData(string query, string updatedCreated)
        {
            if (txtAddressLine1.Text == null || txtAddressLine1.Text == "" || txtCity.Text == null || txtCity.Text == "" || txtPhone.Text == null || txtPhone.Text == "" || txtName.Text == null || txtName.Text == "" || txtURL.Text == null || txtURL.Text == "")
            {
                FormTools.Prompt(Color.Red, "Please make sure required fields are filled in.", "Empty Field Error", this.Name);
            }
            else
            {
                Publishers publisher = new Publishers(0, txtName.Text, txtAddressLine1.Text, txtAddressLine2.Text, txtSuburb.Text, txtCity.Text, int.Parse(txtPostcode.Text), txtPhone.Text, txtURL.Text, DateTime.Now.ToString());
                using (MySqlCommand comm = new MySqlCommand(query, Connection.conn))
                {
                    comm.Connection = Connection.conn;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@Name", publisher.Name);
                    comm.Parameters.AddWithValue("@AddressLine1", publisher.AddressLine1);
                    comm.Parameters.AddWithValue("@AddressLine2", publisher.AddressLine2);
                    comm.Parameters.AddWithValue("@City", publisher.City);
                    comm.Parameters.AddWithValue("@Sub", publisher.Suburb);
                    comm.Parameters.AddWithValue("@Post", publisher.Postcode);
                    comm.Parameters.AddWithValue("@Phone", publisher.PhoneNumber);
                    comm.Parameters.AddWithValue("@URL", publisher.WebsiteURL);
                    comm.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    comm.ExecuteNonQuery();
                    //}
                }
                FormTools.Prompt(Color.Green, "Publisher " + updatedCreated + " Successfully", "Success", this.Name);
                this.Close();
            }
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            if (currentUser.AccessLevel == 0)
            {
                txtAddressLine1.Enabled = false;
                txtAddressLine2.Enabled = false;
                txtCity.Enabled = false;
                txtName.Enabled = false;
                txtPhone.Enabled = false;
                txtPostcode.Enabled = false;
                txtSuburb.Enabled = false;
                txtURL.Enabled = false;
                btnSubmit.Visible = false;
                btnUpdatePub.Visible = false;
            }
        }
    }
}