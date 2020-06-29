using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using MainLibrary;
using System.Drawing;
using System.Collections.Generic;

namespace Project
{
    public partial class MainForm : Form
    {
        public CustomerDetails currentUser;
        private string tableName = "BOOKS";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadingScreen loadingScreen = new LoadingScreen();
            loadingScreen.Show();

            if (Connection.conn != null)
            {
                ValidateLogin(false, false);
                Login();
                this.Enabled = true;
                this.Opacity = 1.0;
                this.ShowInTaskbar = true;
                loadingScreen.Visible = false;
                loadingScreen.Hide();
            }
        }

        public void Login()
        {
            using (LoginForm login = new LoginForm())
            {
                DialogResult result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentUser = login.currentUser;
                    login.currentUser = null;
                    login.Close();
                    menuCurrentUser.Text = currentUser.EmailAddress;
                    labelName.Text = string.Format("Welcome {0}!", currentUser.Name);

                    if (currentUser.AccessLevel == 0)
                    {
                        ValidateLogin(false, true);
                        btnViewRec.Text = "View Record";
                    }
                    else
                    {
                        ValidateLogin(true, true);
                        string[] dropdownTables = { "Retailers", "Customers", "Users" };
                        comboTable.Items.AddRange(dropdownTables);
                        btnViewRec.Text = "View/Update Record";
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    menuLogout.Text = "Login";
                    menuLogout.Click -= logout_Click;
                    menuLogout.Click += login_Click;

                    login.Close();
                }
            }
        }

        private void ValidateLogin(bool notCustomer, bool loggedIn)
        {
            menuAddPublisher.Visible = notCustomer;
            menuRetailers.Visible = notCustomer;
            menuCustomers.Visible = notCustomer;
            menuAddGenre.Visible = notCustomer;
            menuAddBook.Visible = notCustomer;
            menuViewAllBookCopies.Visible = notCustomer;
            menuViewBooksIssued.Visible = notCustomer;
            btnAddRec.Visible = notCustomer;
            menuUsers.Visible = notCustomer;
            menuResetPassword.Visible = loggedIn;
            labelTableSelect.Visible = loggedIn;
            menuViewDetails.Visible = loggedIn;
            menuPublishers.Visible = loggedIn;
            menuGenres.Visible = loggedIn;
            comboTable.Visible = loggedIn;
            btnSearch.Visible = loggedIn;
            txtSearch.Visible = loggedIn;
            menuBooks.Visible = loggedIn;
            btnViewRec.Visible = loggedIn;
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            comboTable.Items.Clear();
            string[] dropdownTables = { "", "Books", "Genres", "Publishers" };
            comboTable.Items.AddRange(dropdownTables);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Connection.conn != null)
            {
                currentUser = null;
                Connection.conn.Close();
                Connection.conn.Dispose();
            }
        }

        public void UpdateDataGridView(string table, string key, string value)
        {
            string query;
            query = @"SELECT * FROM " + table + ";";
            if (comboKey.Items.Contains(key))
            {
                query = @"SELECT " + key + " FROM " + table + ";";

                if (txtSearch.Text != "" && txtSearch.Text != "Search by field value here..." && txtSearch.Text != null)
                {
                    query = @"SELECT * FROM " + table + " WHERE " + key + " LIKE '%" + value + "%' OR " + key + " = '" + value + "';";
                }
            }
            if (query != "")
            {
                FillDataViewer(query, table);
            }
        }

        public void FillDataViewer(string query, string table)
        {
            tableName = table;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connection.conn);
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView.DataSource = data.Tables[0];
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                dataGridView.Rows[i].Tag = dataGridView.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void comboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dynamically Set Available Keys Based on Selected Table
            comboKey.Text = null;
            comboKey.Items.Clear();
            if (!comboTable.SelectedIndex.Equals(0))
            {
                comboKey.Visible = true;
                comboKey.Enabled = true;
                labelKeySelect.Visible = true;
                comboKey.Items.Add("View All");

                switch (comboTable.SelectedItem)
                {
                    case "Books":
                        tableName = "BOOKS";
                        comboKey.Items.Add("Book_ID");
                        comboKey.Items.Add("Name");
                        comboKey.Items.Add("Author_Name");
                        comboKey.Items.Add("Publication_Date");
                        comboKey.Items.Add("Publisher_ID");
                        comboKey.Items.Add("Genre_ID");
                        comboKey.Items.Add("Description");
                        comboKey.Items.Add("Updated_Date");
                        break;

                    case "Genres":
                        tableName = "GENRES";
                        comboKey.Items.Add("Genre_ID");
                        comboKey.Items.Add("Name");
                        comboKey.Items.Add("Description");
                        comboKey.Items.Add("Minimum_Age");
                        comboKey.Items.Add("Updated_Date");
                        break;

                    case "Publishers":
                        tableName = "PUBLISHERS";
                        comboKey.Items.Add("Publisher_ID");
                        comboKey.Items.Add("Name");
                        comboKey.Items.Add("Address_Line1");
                        comboKey.Items.Add("Address_Line2");
                        comboKey.Items.Add("Suburb");
                        comboKey.Items.Add("City");
                        comboKey.Items.Add("Postcode");
                        comboKey.Items.Add("Website_URL");
                        comboKey.Items.Add("Updated_Date");
                        break;

                    case "Retailers":
                        tableName = "RETAILERS";
                        comboKey.Items.Add("Retailer_ID");
                        comboKey.Items.Add("Name");
                        comboKey.Items.Add("Address_Line1");
                        comboKey.Items.Add("Address_Line2");
                        comboKey.Items.Add("City");
                        comboKey.Items.Add("Phone_Number");
                        comboKey.Items.Add("Website_URL");
                        comboKey.Items.Add("Email_Address");
                        comboKey.Items.Add("Updated_Date");
                        break;

                    case "Customers":
                        tableName = "CUSTOMERS";
                        comboKey.Items.Add("Customer_ID");
                        comboKey.Items.Add("First_Name");
                        comboKey.Items.Add("Last_Name");
                        comboKey.Items.Add("Address_Line1");
                        comboKey.Items.Add("Address_Line2");
                        comboKey.Items.Add("City");
                        comboKey.Items.Add("Phone_Number");
                        comboKey.Items.Add("DOB");
                        comboKey.Items.Add("Blocked");
                        comboKey.Items.Add("Updated_Date");
                        break;

                    case "Users":
                        tableName = "USERS";
                        comboKey.Items.Add("Email_Address");
                        comboKey.Items.Add("Password");
                        comboKey.Items.Add("RFID_Tag");
                        comboKey.Items.Add("Customer_ID");
                        comboKey.Items.Add("Access_Level");
                        comboKey.Items.Add("Barred");
                        comboKey.Items.Add("Updated_Date");
                        break;
                }
                btnAddRec.Text = "Add to " + comboTable.Text;
            }
            else
            {
                comboKey.Visible = false;
                comboKey.Enabled = false;
                labelKeySelect.Visible = false;
            }
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            if (tableName == "BOOKS")
            {
                BookForm addBook = new BookForm(currentUser);
                addBook.Show();
            }
            else if (tableName == "GENRES")
            {
                GenreForm addGenre = new GenreForm(currentUser);
                addGenre.Show();
            }
            else if (tableName == "PUBLISHERS")
            {
                PublisherForm addPublisher = new PublisherForm(currentUser);
                addPublisher.Show();
            }
            else if (tableName == "CUSTOMERS")
            {
                CustomerForm addCustomer = new CustomerForm(currentUser, true);
                addCustomer.Show();
            }
            else if (tableName == "RETAILERS")
            {
                RetailerForm addRetailer = new RetailerForm(currentUser);
                addRetailer.Show();
            }
            else if (tableName == "USERS")
            {
                UserForm addUser = new UserForm(true, false, currentUser);
                addUser.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(tableName, comboKey.Text, txtSearch.Text);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(currentUser);
            bookForm.Show();
        }

        private void addGenre_Click(object sender, EventArgs e)
        {
            GenreForm genreForm = new GenreForm(currentUser);
            genreForm.Show();
        }

        private void addPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm publisherForm = new PublisherForm(currentUser);
            publisherForm.Show();
        }

        private void addRetailer_Click(object sender, EventArgs e)
        {
            RetailerForm retailerForm = new RetailerForm(currentUser);
            retailerForm.Show();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(true, false, currentUser);
            userForm.Show();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(currentUser, true);
            customerForm.Show();
        }

        private void viewBook_Click(object sender, EventArgs e)
        {
            FillDataViewer(@"SELECT * FROM BOOKS", "BOOKS");
            btnAddRec.Text = "Add to Books";
        }

        private void viewGenre_Click(object sender, EventArgs e)
        {
            FillDataViewer(@"SELECT * FROM GENRES", "GENRES");
            btnAddRec.Text = "Add to Genres";
        }

        private void viewPublisher_Click(object sender, EventArgs e)
        {
            FillDataViewer(@"SELECT * FROM PUBLISHERS", "PUBLISHERS");
            btnAddRec.Text = "Add to Publishers";
        }

        private void viewRetailer_Click(object sender, EventArgs e)
        {
            FillDataViewer(@"SELECT * FROM RETAILERS", "RETAILERS");
            btnAddRec.Text = "Add to Retailers";
        }

        private void viewCustomer_Click(object sender, EventArgs e)
        {
            FillDataViewer(@"SELECT * FROM CUSTOMERS", "CUSTOMERS");
            btnAddRec.Text = "Add to Customers";
        }

        private void viewUser_Click(object sender, EventArgs e)
        {
            FillDataViewer(@"SELECT * FROM USERS", "USERS");
            btnAddRec.Text = "Add to Users";
        }

        private void menuViewBooksIssued_Click(object sender, EventArgs e)
        {
            FillDataViewer("SELECT * FROM BOOKSISSUED", "BOOKSISSUED");
        }

        private void menuViewAllBookCopies_Click(object sender, EventArgs e)
        {
            FillDataViewer("SELECT * FROM BOOKCOPIES", "BOOKCOPIES");
        }

        private void viewBooksOnHoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentUser.AccessLevel == 0)
            {
                FillDataViewer(@"SELECT * FROM BOOKSONHOLD WHERE Customer_ID = '" + currentUser.CustomerID + "';", "BOOKSONHOLD");
                CustomerForm customerForm = new CustomerForm(currentUser);
                customerForm.Show();
            }
            else
            {
                FillDataViewer(@"SELECT * FROM BOOKSONHOLD", "BOOKSONHOLD");
            }
        }

        private void resetPassword_Click(object sender, EventArgs e)
        {
            PasswordResetForm passwordResetForm = new PasswordResetForm();
            passwordResetForm.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            comboKey.Visible = false;
            menuCurrentUser.Text = "Please Login";
            labelName.Text = "";
            menuLogout.Text = "Login";
            menuLogout.Click -= logout_Click;
            menuLogout.Click += login_Click;
            ValidateLogin(false, false);
        }

        private void login_Click(object sender, EventArgs e)
        {
            menuLogout.Click -= login_Click;
            menuLogout.Click += logout_Click;
            menuLogout.Text = "Logout";
            Login();
        }

        private void menuViewDetails_Click(object sender, EventArgs e)
        {
            if (currentUser.AccessLevel == 0)
            {
                using (CustomerForm customerForm = new CustomerForm(currentUser, false))
                {
                    DialogResult result = customerForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        customerForm.Show();
                        currentUser = customerForm.currentUser;
                        labelName.Text = string.Format("Welcome {0}!", currentUser.Name);
                        menuCurrentUser.Text = currentUser.EmailAddress;
                    }
                }
            }
            else
            {
                UserForm user = new UserForm(false, false, currentUser);
                user.Show();
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }

        private void btnViewRec_Click(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            if (dataGridView.Rows.Count > 0)
            {
                List<string> values = new List<string>();
                for (int i = 0; i < dataGridView.Rows[0].Cells.Count; i++)
                {
                    values.Add(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[i].Value.ToString());
                }

                //switch (dataGridView.Columns[0].Name)
                switch (tableName)
                {
                    case "BOOKS":
                        BookForm bookForm = new BookForm(new Books(int.Parse(values[0]), values[1], values[2], values[3], int.Parse(values[5]), int.Parse(values[4]), values[6], values[7]), currentUser);
                        bookForm.Show();
                        break;

                    case "GENRES":
                        GenreForm genreForm = new GenreForm(currentUser, new Genres(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), values[3]));
                        genreForm.Show();
                        break;

                    case "PUBLISHERS":
                        PublisherForm publisherForm = new PublisherForm(currentUser, new Publishers(int.Parse(values[0]), values[1], values[2], values[3], values[4], values[5], int.Parse(values[6]), values[7], values[8], values[9]));
                        publisherForm.Show();
                        break;

                    case "RETAILERS":
                        Retailers retailer = new Retailers(int.Parse(values[0]), values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8]);
                        RetailerForm retailerForm = new RetailerForm(currentUser, retailer);
                        retailerForm.Show();
                        break;

                    case "CUSTOMERS":
                        CustomerForm customerForm = new CustomerForm(new CustomerDetails(int.Parse(values[0]), FormTools.SelectTargetField("SELECT Email_Address FROM USERS WHERE Customer_ID = '" + values[0] + "';"), values[1], values[2], int.Parse(FormTools.SelectTargetField("SELECT Acess_Level FROM USERS WHERE Customer_ID = '" + values[0] + "';"))), false);
                        customerForm.Show();
                        break;

                    case "USERS":
                        UserForm userForm = new UserForm(false, false, new CustomerDetails(values[1], "", int.Parse(values[5])));
                        userForm.Show();
                        break;

                    case "BOOKCOPIES":
                        Books book = new Books(int.Parse(values[1]),
                            FormTools.SelectTargetField("SELECT Name FROM BOOKS WHERE Book_ID = '" + values[1] + "';"),
                            FormTools.SelectTargetField("SELECT Author_Name FROM BOOKS WHERE Book_ID = '" + values[1] + "';"),
                            FormTools.SelectTargetField("SELECT Publication_Date FROM BOOKS WHERE Book_ID = '" + values[1] + "';"),
                            int.Parse(FormTools.SelectTargetField("SELECT Genre_ID FROM BOOKS WHERE Book_ID = '" + values[1] + "';")),
                            int.Parse(FormTools.SelectTargetField("SELECT Publisher_ID FROM BOOKS WHERE Book_ID = '" + values[1] + "';")),
                            FormTools.SelectTargetField("SELECT Description FROM BOOKS WHERE Book_ID = '" + values[1] + "';"),
                            FormTools.SelectTargetField("SELECT Updated_Date FROM BOOKS WHERE Book_ID = '" + values[1] + "';")
                        );

                        BookCopyForm bookCopies = new BookCopyForm(book, new BookCopies(decimal.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), decimal.Parse(values[3]), values[4]));
                        bookCopies.Show();
                        break;

                }
            }
        }
    }
}