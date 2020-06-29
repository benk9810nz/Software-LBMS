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
    public partial class FM_Logout : Form
    {
        private Customer Customer { get; set; }
        public List<Book> ListBooks { get; set; }

        public FM_Logout(Customer customer, List<Book> listbooks)
        {
            this.ListBooks = listbooks;
            this.Customer = customer;
            InitializeComponent();
        }

        private void FM_Logout_Load(object sender, EventArgs e)
        {
            LB_Bye.Text = "Bye " + Customer.Name;

        }

        private void BT_Yes_Click(object sender, EventArgs e)
        {
            SendEmail.SendReceipt(Customer, ListBooks);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BT_No_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
