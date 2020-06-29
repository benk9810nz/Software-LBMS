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
    public partial class BookForm : Form
    {
        public bool UploadMode { get; set; }
        public Books book { get; set; }
        public CustomerDetails currentUser { get; set; }
        public Dictionary<int, string> genreDic { get; set; }
        public Dictionary<int, string> PubDic { get; set; }

        public BookForm(CustomerDetails c)
        {
            InitializeComponent();
            book = null;
            currentUser = c;
            this.Height -= 120;
        }

        public BookForm(Books b, CustomerDetails c)
        {
            InitializeComponent();
            book = b;
            currentUser = c;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            GetPublisherValues();
            GetGenreValues();

            //If Viewing Book
            if (book != null)
            {
                checkEnableEditing.Visible = true;
                ToggleView(false);
                comboGenre.SelectedIndex = book.GenreID - 1;
                comboPublisher.SelectedIndex = book.PublisherID - 1;
                txtName.Text = book.Name;
                txtAuthor.Text = book.AuthorName;
                txtDescription.Text = book.Desciption;
                comboDate.Value = DateTime.Parse(book.PublicationDate);
                pBox.Image = BookCoverFTP.DownloadBook(book.BookID.ToString());
                pBox.Refresh();
                btnAdd.Visible = false;
                btnHold.Enabled= false;
                listviewBookCopies.Visible = true;
                btnEditCopy.Visible = true;

                //BT_Copy.Visible = false;
                //Get Book Copies Information
                GetBookCopiesInfo();
            }

            if (currentUser.AccessLevel == 0)
            {
                checkEnableEditing.Visible = false;
                btnAdd.Visible = false;
                btnAddCopy.Visible = false;
                btnEditCopy.Visible = false;
                btnUpdate.Visible = false;
            }
            else
            {
                btnHold.Visible = false;
            }
        }

        private void GetBookCopiesInfo()
        {
            listviewBookCopies.Items.Clear();
            using (MySqlCommand comm = new MySqlCommand(String.Format(

                //"SELECT this.Book_Barcode, this.Book_ID, this.Retailer_ID, this.Purchase_Price, this.RFID_Tag, (SELECT Name FROM RETAILERS WHERE Retailer_ID = this.Retailer_ID) AS Retailer_Name, (SELECT Due_Date FROM BOOKSISSUED WHERE Book_Barcode = this.Book_Barcode AND Returned_Date IS NULL) AS bDue FROM BOOKCOPIES AS this WHERE Book_ID = '{0}';"
                "SELECT " +
                    "b.Book_Barcode, " +
                    "b.Book_ID, " +
                    "b.Retailer_ID, " +
                    "b.Purchase_Price, " +
                    "b.RFID_Tag, " +
                    "r.Name Retailer, " +
                    "i.Due_Date " +
                "FROM " +
                    "BOOKCOPIES AS b " +

                "JOIN RETAILERS AS r " +
                    "ON r.Retailer_ID = b.Retailer_ID " +

                "LEFT JOIN BOOKSISSUED AS i " +
                    "ON i.Book_Barcode = b.Book_Barcode AND Returned_Date IS NULL " +
                
                "WHERE b.Book_ID = '{0}';"

                , book.BookID.ToString()), Connection.conn))
            {
                MySqlDataReader rdr = comm.ExecuteReader();
                while (rdr.Read())
                {
                    BookCopies bc = new BookCopies(rdr.GetDecimal(0), rdr.GetInt32(1), rdr.GetInt32(2), rdr.GetDecimal(3), rdr.GetString(4));
                    //Get Return Date
                    string barcode = bc.BookBarcode.ToString();
                    ListViewItem item = new ListViewItem(bc.BookBarcode.ToString());
                    if (rdr.IsDBNull(6)) //If Book is not currently Out (as in no Null Values)
                    {
                        item.SubItems.Add("Available");
                        item.SubItems.Add("N/A");
                    }
                    else
                    {
                        item.SubItems.Add("Unavailable");
                        item.SubItems.Add(rdr.GetString(6));
                    }
                    item.SubItems.Add(bc.PurchasePrice.ToString());
                    item.SubItems.Add(rdr.GetString(5));
                    item.SubItems.Add(bc.RfidTag);
                    item.Tag = bc;
                    listviewBookCopies.Items.Add(item);
                }
            }
        }

        private void ToggleView(bool v)
        {
            comboGenre.Enabled = v;
            txtName.ReadOnly = !v;
            comboPublisher.Enabled = v;
            txtAuthor.ReadOnly = !v;
            txtDescription.ReadOnly = !v;
            btnUpdate.Visible = v;
            comboDate.Enabled = v;
            btnUploadCover.Visible = v;
        }


        private void GetGenreValues()
        {
            genreDic = new Dictionary<int, string>();
            using (MySqlCommand comm = new MySqlCommand("SELECT Genre_ID, Name FROM GENRES", Connection.conn))
            {
                MySqlDataReader rdr = comm.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    i++;
                    genreDic.Add(rdr.GetInt32(0), rdr.GetString(1));
                }
            }
            comboGenre.DataSource = new BindingSource(genreDic, null);
            comboGenre.ValueMember = "Key";
            comboGenre.DisplayMember = "Value";
        }

        private void GetPublisherValues()
        {
            PubDic = new Dictionary<int, string>();
            using (MySqlCommand comm = new MySqlCommand("SELECT Publisher_ID, Name FROM PUBLISHERS", Connection.conn))
            {
                MySqlDataReader rdr = comm.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    i++;
                    PubDic.Add(rdr.GetInt32(0), rdr.GetString(1));
                }
            }
            comboPublisher.DataSource = new BindingSource(PubDic, null);
            comboPublisher.ValueMember = "Key";
            comboPublisher.DisplayMember = "Value";
        }

        private void btnUploadCover_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Please note only .JPG's are accepted", "Please note Only .JPG's are accepted", MessageBoxButtons.OKCancel);
            if (drs == DialogResult.OK)
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    pBox.ImageLocation = fd.FileName;
                    pBox.Refresh();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                string sql = "SELECT Book_ID FROM BOOKS ORDER BY Book_ID DESC LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                int i = rdr.GetInt32(0) + 1;
                rdr.Close();
                //System.IO.File.Copy(fd.FileName, fp, true);
                MessageBox.Show(BookCoverFTP.UploadBook(fd.FileName, i.ToString()));
                Books book = new Books(i, txtName.Text, txtAuthor.Text, comboDate.Value.Date.ToString("yyyy-MM-dd"), int.Parse(comboGenre.SelectedValue.ToString()), int.Parse(comboPublisher.SelectedValue.ToString()), txtDescription.Text, string.Format("{0}", DateTime.Now)); ;
                sql = "INSERT INTO BOOKS VALUES(NULL, @Name, @Author, @PubDate, @PubID, @GenreID, @Description, @Date);";
                cmd = new MySqlCommand(sql, Connection.conn);
                cmd.Parameters.AddWithValue("@Name", book.Name);
                cmd.Parameters.AddWithValue("@Author", book.AuthorName);
                cmd.Parameters.AddWithValue("@PubDate", book.PublicationDate);
                cmd.Parameters.AddWithValue("@PubID", book.PublisherID);
                cmd.Parameters.AddWithValue("@GenreID", book.GenreID);
                cmd.Parameters.AddWithValue("@Description", book.Desciption);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
                i = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show(i.ToString());
                ClearFields();
            }
        }

        private void ClearFields()
        {
            txtAuthor.Clear();
            txtName.Clear();
            txtDescription.Clear();
            comboGenre.SelectedIndex = 0;
            comboPublisher.SelectedIndex = 0;
            comboDate.Value = DateTime.Now;
            pBox.Image = null;
        }

        public bool CheckValidation()
        {
            if (txtName.Text != "")
            {
                if (txtAuthor.Text != "")
                {
                    if (txtDescription.Text != "")
                    {
                        if (pBox.ImageLocation != null)
                        {
                            return true;
                        }
                    }
                }
            }
            MessageBox.Show("Error - You have not entered all the Fields. Please Recheck");
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Any Text Added/Modified will not be saved", "Changes not Saved", MessageBoxButtons.OKCancel))
            {
                ClearFields();
                this.Close();
            }
        }

        private void listviewBookCopies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewBookCopies.SelectedItems.Count == 1)
            {
                btnEditCopy.Enabled = true;
                btnHold.Enabled = true;
            }
            else
            {
                btnEditCopy.Enabled = false;
                btnHold.Enabled = false;
            }
        }


        private void UpdateDataValues()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Updated_Date FROM BOOKS Where Book_ID =" + book.BookID.ToString(), Connection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            string date = rdr.GetString(0);
            if (date == book.UpdatedDate.ToString())
            {
                rdr.Close();
                Books bk2 = new Books(book.BookID, txtName.Text, txtAuthor.Text, comboDate.Value.Date.ToString("yyyy-MM-dd"), int.Parse(comboGenre.SelectedValue.ToString()), int.Parse(comboPublisher.SelectedValue.ToString()), txtDescription.Text, DateTime.Now.ToString());
                MessageBox.Show(BookCoverFTP.UploadBook(fd.FileName, book.BookID.ToString()));
                String command = "UPDATE BOOKS SET Name = @BookName, Author_Name = @Author, Publication_Date = @PubDate, Publisher_ID = @PubID, Genre_ID = @GenreID, Description = @Desc, Updated_Date = @Edited WHERE Book_ID = @ID;";
                cmd = new MySqlCommand(command, Connection.conn);
                cmd.Parameters.AddWithValue("@ID", bk2.BookID);
                cmd.Parameters.AddWithValue("@BookName", bk2.Name);
                cmd.Parameters.AddWithValue("@Author", bk2.AuthorName);
                cmd.Parameters.AddWithValue("@PubDate", bk2.PublicationDate);
                cmd.Parameters.AddWithValue("@PubID", bk2.PublisherID);
                cmd.Parameters.AddWithValue("@GenreID", bk2.GenreID);
                cmd.Parameters.AddWithValue("@Desc", bk2.Desciption);
                cmd.Parameters.AddWithValue("@Edited", DateTime.Now);
                int i = cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("A User has edited the Book currently, so the current information showed is inaccurate");
            }
        }
        
        private void checkEnableEditing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableEditing.Checked)
            {
                ToggleView(true);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Save?", "Do You Want to save any of your Changes?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    UpdateDataValues();
                    //Save Changes
                }
                ToggleView(false);
            }
        }

        private void comboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGenre.SelectedValue.ToString() == "-100")
            {
                using (GenreForm fm = new GenreForm(currentUser))
                {
                    this.Hide();
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        GetGenreValues();
                        this.Show();
                    }
                }
            } //If New Genre created refresh list
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataValues();
            this.Close();
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            BookCopyForm bookCopyForm = new BookCopyForm(book);
            if (bookCopyForm.ShowDialog() == DialogResult.OK)
            {
                GetBookCopiesInfo(); //Re-retrieve the Book Copies Info if a New One is Added
            }
        }

        private void btnEditCopy_Click(object sender, EventArgs e)
        {
            BookCopyForm bookCopyForm = new BookCopyForm(book, listviewBookCopies.SelectedItems[0].Tag as BookCopies);
            if (bookCopyForm.ShowDialog() == DialogResult.OK)
            {
                GetBookCopiesInfo();
            }
            btnEditCopy.Enabled = false;
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            ListViewItem item = listviewBookCopies.SelectedItems[0];
            MessageBox.Show(item.Text);
            if (item.SubItems[1].Text == "Unavailable") //Check book is currently out
            {
                string sql = "SELECT COUNT(*) FROM BOOKSISSUED WHERE (Book_Barcode = @Barcode) && (Returned_Date IS NULL) && (Customer_ID = @ID);";
                MySqlCommand cmd = new MySqlCommand(sql, Connection.conn);
                cmd.Parameters.AddWithValue("@Barcode", Decimal.Parse(item.SubItems[0].Text));
                cmd.Parameters.AddWithValue("@ID", currentUser.CustomerID);
                IDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                int numBooks = rdr.GetInt32(0); //Get Current Issues
                rdr.Close();

                if (numBooks == 0) //If Customer does not currently have the particular book out
                {
                    sql = "INSERT INTO BOOKSONHOLD VALUES(null, @Barcode, @Date, @CustomerID);";
                    cmd = new MySqlCommand(sql, Connection.conn);
                    cmd.Parameters.AddWithValue("@Barcode", Decimal.Parse(item.SubItems[0].Text));
                    cmd.Parameters.AddWithValue("Date", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@CustomerID", currentUser.CustomerID);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("A Hold has been placed");
                    }
                }
                else
                {
                    MessageBox.Show("You currently have this book out and a Hold can not be placed");
                }
                rdr.Close();
            }
            else
            {
                MessageBox.Show("Hold placement not required. The book is currently available in-store!");
            }
        }
    }
}