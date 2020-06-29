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
    public partial class BookCopyForm : Form
    {
        public Books bk { get; set; }
        public BookCopies bc { get; set; }

        public BookCopyForm(Books book)
        {
            InitializeComponent();
            bk = book;
            bc = null;
            btnUpdate.Visible = false;
        }

        public BookCopyForm(Books book, BookCopies bookC)
        {
            InitializeComponent();
            bk = book;
            bc = bookC;
            btnAdd.Visible = false;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanItemForm scanItemForm = new ScanItemForm(2);// Scan in Bar-code
            scanItemForm.ShowDialog();
            txtBarcode.Text = scanItemForm.returnValue;
            scanItemForm.Close();
        }

        private void btnRFID_Click(object sender, EventArgs e)// Scan in RFID
        {
            ScanItemForm scanItemForm = new ScanItemForm(1);
            scanItemForm.ShowDialog();
            txtRFID.Text = scanItemForm.returnValue;
            scanItemForm.Close();
        }

        private void BookCopyForm_Load(object sender, EventArgs e)
        {
            if (bc != null)
            {
                txtBarcode.Text = bc.BookBarcode.ToString();
                txtRFID.Text = bc.RfidTag;
                numericPrice.Value = bc.PurchasePrice;
                comboRetailer.SelectedItem = bc.RetailerID;
            }
            Dictionary<int, string> retailerDic = new Dictionary<int, string>();
            using (MySqlCommand comm = new MySqlCommand("SELECT Retailer_ID, Name FROM RETAILERS", Connection.conn))
            {
                MySqlDataReader rdr = comm.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    i++;
                    retailerDic.Add(rdr.GetInt32(0), rdr.GetString(1));
                }
            }
            comboRetailer.DataSource = new BindingSource(retailerDic, null);
            comboRetailer.ValueMember = "Key";
            comboRetailer.DisplayMember = "Value";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                int retailerID = int.Parse(FormTools.SelectTargetField("SELECT Retailer_ID FROM RETAILERS WHERE Name = '" + comboRetailer.Text + "';"));
                BookCopies bc = new BookCopies(Decimal.Parse(txtBarcode.Text), bk.BookID,retailerID, numericPrice.Value, txtRFID.Text);
                string sql = "INSERT INTO BOOKCOPIES VALUES(@Barcode, @ID, @Retailer, @Price, @RFID, @Date)";
                using (MySqlCommand comm = new MySqlCommand(sql, Connection.conn))
                {
                    comm.Parameters.AddWithValue("@Barcode", bc.BookBarcode);
                    comm.Parameters.AddWithValue("@ID", bc.BookID);
                    comm.Parameters.AddWithValue("@Retailer", bc.RetailerID);
                    comm.Parameters.AddWithValue("@Price", bc.PurchasePrice);
                    comm.Parameters.AddWithValue("@RFID", bc.RfidTag);
                    comm.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
                    if (comm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Book Copy Added");
                    }
                    else
                    {
                        MessageBox.Show("An Error has Occurred. Please Contact the System Administrator");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Ensure you have Entered all the fields");
            }
        }

        private bool checkValidation()
        {
            if (txtBarcode.Text != "" && txtBarcode.Text != null)
            {
                if (txtRFID.Text != "" && txtRFID.Text != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                int retailerID = int.Parse(FormTools.SelectTargetField("SELECT Retailer_ID FROM RETAILERS WHERE Name = '" + comboRetailer.Text + "';"));
                BookCopies bc = new BookCopies(Decimal.Parse(txtBarcode.Text), bk.BookID, retailerID, numericPrice.Value, txtRFID.Text);
                string sql = "UPDATE BOOKCOPIES SET Book_Barcode = @Barcode, Book_ID = @ID, Retailer_ID = @Retailer, Purchase_Price = @Price, RFID_Tag = @RFID, Updated_Date = @Date WHERE Book_Barcode = '" + bc.BookBarcode + "';";
                using (MySqlCommand comm = new MySqlCommand(sql, Connection.conn))
                {
                    comm.Parameters.AddWithValue("@Barcode", bc.BookBarcode);
                    comm.Parameters.AddWithValue("@ID", bc.BookID);
                    comm.Parameters.AddWithValue("@Retailer", bc.RetailerID);
                    comm.Parameters.AddWithValue("@Price", bc.PurchasePrice);
                    comm.Parameters.AddWithValue("@RFID", bc.RfidTag);
                    comm.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
                    if (comm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Book Copy Added");
                    }
                    else
                    {
                        MessageBox.Show("An Error has Occurred. Please Contact the System Administrator");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Ensure you have Entered all the fields");
            }
        }
    }
}