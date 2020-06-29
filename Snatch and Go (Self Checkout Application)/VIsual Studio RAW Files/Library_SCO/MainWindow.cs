using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using phutils;

namespace Library_SCO
{
    public partial class MainWindow : Form
    {
        int i;
        RFID rfid;
        public Customer CurrentCustomer { get; set; }
        public int CountOfBooks { get; set; }
        public List<Book> Books { get; set; }
        public int Mode { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PBox.Image = imageList1.Images[i];
            i = 0;
            rfid = new RFID();
            rfid.Attach += Rfid_Attach;
            rfid.Detach += Rfid_Detach;
            rfid.Error += Rfid_Error;
            rfid.Tag += Rfid_Tag1;
            rfid.Open();
            Mode = 0;
        }//Login

        public void PanelLoading()
        {
            Books = new List<Book>();
            LB_Name.Text = String.Format("Welcome {0}", CurrentCustomer.Name);
            listView.Columns.Add("Book ID", 80);
            listView.Columns.Add("Book", 200);
            listView.Columns.Add("Author", 150);
            listView.Columns.Add("Return Date", 100);
            CountOfBooks = dbe.GetCount(CurrentCustomer.CustomerID);
            LB_Count.Text = "Remaning number of books you can issue: " + CountOfBooks.ToString();
        }

        private void Rfid_Tag1(object sender, RFIDTagEventArgs e)
        {
            if (Mode == 0)
            {
                TB_RFID.Text = e.Tag.ToString();
                BTTest_Click(sender, e);
            }//If on Login Mode
            else if (Mode == 1)
            {
                TB_Tag.Text = e.Tag.ToString();
                BT_TagFound_Click(sender, e);
            }//If Issuing Mode
            else if (Mode == 2)
            {
                TB_Return.Text = e.Tag.ToString();
                BT_Test_Click(sender, e);

            }
        }

        private void Rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Description);
        }

        private void Rfid_Detach(object sender, DetachEventArgs e)
        {
            
        }

        private void Rfid_Attach(object sender, AttachEventArgs e)
        {
            
        }

        private void BTTest_Click(object sender, EventArgs e)
        {
            {
                CurrentCustomer = dbe.GetUser(TB_RFID.Text);
                TB_RFID.Clear();
                if (CurrentCustomer.Name != "INVALID")
                {
                    if (CurrentCustomer.Banned == 1)
                    {
                        MessageBox.Show("You are not Allowed to Issue Books. Please Contact the Library Staff for more information");
                    }
                    else
                    {
                        MessageBox.Show(CurrentCustomer.Name);
                        PN_Login.Hide();
                        PanelLoading();
                        PN_Issue.Show();
                        Mode = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to Find that user. Please ensure that you are using your ID Card. If this issue continues to occur please contact the Libarians \n " + CurrentCustomer.Email);
                    TB_RFID.Clear();
                }
            }
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_TagFound_Click(object sender, EventArgs e)
        {
            int state = 0;
            Book bk = null;
            if (CountOfBooks <= Settings.Default.MaximumBooks)
            {
                {
                    bk = dbe.GetBookDetails(TB_Tag.Text);
                    if (bk != null)
                    {
                        Customer hCustomer = dbe.GetHoldDetails(bk);
                        if (hCustomer != null)
                        {
                            foreach (Book book in Books)
                            {
                                if (book.Book_ID == bk.Book_ID)
                                {
                                    state = 1;
                                }
                            }
                            if (CurrentCustomer.Age >= bk.Age && state == 0)
                            {
                                MessageBox.Show(bk.Book_Barcode.ToString());
                                ListViewItem item = new ListViewItem(bk.Book_ID.ToString());
                                item.Tag = bk;
                                Books.Add(bk);
                                item.SubItems.Add(bk.Name);
                                item.SubItems.Add(bk.Author);
                                bk.DueDate = System.DateTime.Now.AddDays(Settings.Default.IssuePeriod).ToString("yyyy-MM-dd");
                                item.SubItems.Add(bk.DueDate);
                                listView.Items.Add(item);
                                int i = dbe.IssueBook(bk, CurrentCustomer);
                                MessageBox.Show(i.ToString());
                                CountOfBooks--;
                                LB_Count.Text = "Remaning number of books you can issue: " + CountOfBooks.ToString();
                            }
                            else
                            if (state == 1)
                            {
                                MessageBox.Show("This Book is already issud to you");
                            }
                            else
                            { MessageBox.Show(String.Format("You must be {0} years old to read this book", bk.Age)); }
                        }
                        else
                        {
                            MessageBox.Show("This book is unable to be issued as there is a current hold on it. Please give this book to the Librarians");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Book. Please ensure you are scanning a Book. Please contact the Librarians if this issue continues to occur");
                    }
                    TB_Tag.Clear();
                }

            }
            else
            {
                MessageBox.Show("You have reached your limit on books that can be issued at one time and are unable to issue anymore. See a Libarian for more details");
            }
        }

        private void BT_Logout_Click(object sender, EventArgs e)
        {
            Form fm = new FM_Logout(CurrentCustomer, Books);
            fm.Hide();
            if (Books.Count > 0)
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    PN_Issue.Hide();
                    PN_Login.Show();
                    Mode = 0;
                }
            }
            else
            {
                MessageBox.Show("No Books Issued. You have now been logged out " + CurrentCustomer.Name);
                PN_Issue.Hide();
                PN_Login.Show();
                Mode = 0;
            }
           
        }

        private void PN_Issue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_Test_Click(object sender, EventArgs e)
        {
            Book bk = dbe.GetBookDetails(TB_Return.Text);
            TB_Return.Clear();
            if (bk != null)
            {
                bool found = true;
                foreach (Book book in Books)
                {
                    if (bk.Book_Barcode == book.Book_Barcode)
                    {
                        found = false;
                    }
                }
                if (found)
                {
                    Customer cm = dbe.GetHoldDetails(bk);
                    if (cm != null)
                    {
                        bk.DueDate = cm.HoldDate;
                        SendEmail.Hold(cm, bk);
                    }//If Book is on hold

                    int i = dbe.ReturnBook(bk);
                    if (i > 0)
                    {
                        ListViewItem item = new ListViewItem(bk.Book_ID.ToString());
                        item.SubItems.Add(bk.Name);
                        item.SubItems.Add(bk.Author);
                        item.SubItems.Add(bk.Book_Barcode.ToString());
                        listViewReturning.Items.Add(item);
                        Books.Add(bk);
                    } //Return Book and add to the listview
                    else
                    {
                        MessageBox.Show("An Error has occured. Book might not have been issued");
                    }//If something goes wrong
                }
                else
                {
                    MessageBox.Show("Book has already been returned");
                }
            }
            else
            {
                MessageBox.Show("Book not found. Please contact the Librarians");
            }//
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            PN_Login.Hide();
            PN_Issue.Hide();
            PN_Returns.Show();
            Books = new List<Book>();
            Mode = 2;
        }

        private void BT_ExitMode_Click(object sender, EventArgs e)
        {
            PN_Returns.Hide();
            PN_Login.Show();
            listViewReturning.Clear();
            Mode = 0;
        }
    }
}
