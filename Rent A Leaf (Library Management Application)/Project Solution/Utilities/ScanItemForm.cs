using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using phutils;

namespace Project
{
    public partial class ScanItemForm : Form
    {
        public string returnValue;
        private RFID rfid;

        public ScanItemForm(int i)
        {
            InitializeComponent();
            if (i == 1)
            {
                PN_RFID.Visible = true;
                this.Height += 247;
            }
            else
            {
                PN_Barcode.Visible = true;
            }
        }

        private void ScanItem_Load(object sender, EventArgs e)
        {
            rfid = new RFID();
            rfid.Attach += Rfid_Attach;
            rfid.Detach += Rfid_Detach;
            rfid.Error += Rfid_Error;
            rfid.Tag += Rfid_Tag1;
            rfid.open();
        }

        private void Rfid_Tag1(object sender, TagEventArgs e)
        {
            MessageBox.Show(e.Tag.ToString());
            TB_ID.Text = e.Tag.ToString();
            pBox.Image = imageList1.Images[1];
            System.Threading.Thread.Sleep(200);
            returnValue = e.Tag.ToString();
            BT_Save_1_Click(sender, e);
        }

        private void Rfid_Tag(object sender, TagEventArgs e)
        {
            
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

        private void BT_Save_1_Click(object sender, EventArgs e)
        {
            if (TB_Barcode.Text == "" && TB_ID.Text != "")
            {
                returnValue = TB_ID.Text;
                this.Hide();
            }
            else if (TB_ID.Text == "" && TB_Barcode.Text != "")
            {
                returnValue = TB_Barcode.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have not entered a Value in, or Tapped an RFID Tag");
            }
        }

        private void ScanItemForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Save_1_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            returnValue = "";
            this.Hide();
        }

        private void ScanItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid = null;
        }

        private void ScanItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}