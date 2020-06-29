namespace Project
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAB_Previous = new System.Windows.Forms.TabPage();
            this.LV_Past = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAB_Holds = new System.Windows.Forms.TabPage();
            this.LV_Holds = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Renew = new System.Windows.Forms.Button();
            this.TC1 = new System.Windows.Forms.TabControl();
            this.TAB_Details = new System.Windows.Forms.TabPage();
            this.txtEmailConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.CB_Edit = new System.Windows.Forms.CheckBox();
            this.DOB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.LBPhone = new System.Windows.Forms.Label();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.LB_City = new System.Windows.Forms.Label();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.LB_A2 = new System.Windows.Forms.Label();
            this.TB_A2 = new System.Windows.Forms.TextBox();
            this.LB_3 = new System.Windows.Forms.Label();
            this.TB_A1 = new System.Windows.Forms.TextBox();
            this.LB_LName = new System.Windows.Forms.Label();
            this.TB_LName = new System.Windows.Forms.TextBox();
            this.LB_FName = new System.Windows.Forms.Label();
            this.TB_FName = new System.Windows.Forms.TextBox();
            this.TAB_Issues = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LV_Issues = new System.Windows.Forms.ListView();
            this.TAB_Previous.SuspendLayout();
            this.TAB_Holds.SuspendLayout();
            this.TC1.SuspendLayout();
            this.TAB_Details.SuspendLayout();
            this.TAB_Issues.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Author";
            this.columnHeader16.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(2, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Overdue";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Issue Date";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Return Date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Day\'s until Due";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Author";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Barcode";
            this.columnHeader6.Width = 150;
            // 
            // TAB_Previous
            // 
            this.TAB_Previous.Controls.Add(this.LV_Past);
            this.TAB_Previous.Location = new System.Drawing.Point(4, 22);
            this.TAB_Previous.Margin = new System.Windows.Forms.Padding(2);
            this.TAB_Previous.Name = "TAB_Previous";
            this.TAB_Previous.Padding = new System.Windows.Forms.Padding(2);
            this.TAB_Previous.Size = new System.Drawing.Size(751, 236);
            this.TAB_Previous.TabIndex = 2;
            this.TAB_Previous.Text = "Previous Issues";
            this.TAB_Previous.UseVisualStyleBackColor = true;
            // 
            // LV_Past
            // 
            this.LV_Past.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Past.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.LV_Past.FullRowSelect = true;
            this.LV_Past.GridLines = true;
            this.LV_Past.HideSelection = false;
            this.LV_Past.Location = new System.Drawing.Point(5, 6);
            this.LV_Past.Margin = new System.Windows.Forms.Padding(2);
            this.LV_Past.MultiSelect = false;
            this.LV_Past.Name = "LV_Past";
            this.LV_Past.Size = new System.Drawing.Size(742, 215);
            this.LV_Past.TabIndex = 0;
            this.LV_Past.UseCompatibleStateImageBehavior = false;
            this.LV_Past.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Issue Date";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Returned Date";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Book Barcode";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Name";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Author";
            this.columnHeader12.Width = 150;
            // 
            // TAB_Holds
            // 
            this.TAB_Holds.Controls.Add(this.LV_Holds);
            this.TAB_Holds.Location = new System.Drawing.Point(4, 22);
            this.TAB_Holds.Margin = new System.Windows.Forms.Padding(2);
            this.TAB_Holds.Name = "TAB_Holds";
            this.TAB_Holds.Padding = new System.Windows.Forms.Padding(2);
            this.TAB_Holds.Size = new System.Drawing.Size(751, 236);
            this.TAB_Holds.TabIndex = 3;
            this.TAB_Holds.Text = "Holds";
            this.TAB_Holds.UseVisualStyleBackColor = true;
            // 
            // LV_Holds
            // 
            this.LV_Holds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Holds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.LV_Holds.FullRowSelect = true;
            this.LV_Holds.GridLines = true;
            this.LV_Holds.HideSelection = false;
            this.LV_Holds.Location = new System.Drawing.Point(4, 6);
            this.LV_Holds.Margin = new System.Windows.Forms.Padding(2);
            this.LV_Holds.Name = "LV_Holds";
            this.LV_Holds.Size = new System.Drawing.Size(743, 213);
            this.LV_Holds.TabIndex = 0;
            this.LV_Holds.UseCompatibleStateImageBehavior = false;
            this.LV_Holds.View = System.Windows.Forms.View.Details;
            this.LV_Holds.SelectedIndexChanged += new System.EventHandler(this.LV_Holds_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Hold_ID";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Book_Barcode";
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Name";
            this.columnHeader15.Width = 150;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Date Placed";
            this.columnHeader17.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(2, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due within 7 Days";
            // 
            // BT_Renew
            // 
            this.BT_Renew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Renew.Enabled = false;
            this.BT_Renew.Location = new System.Drawing.Point(650, 181);
            this.BT_Renew.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Renew.Name = "BT_Renew";
            this.BT_Renew.Size = new System.Drawing.Size(99, 40);
            this.BT_Renew.TabIndex = 17;
            this.BT_Renew.Text = "Renew Book";
            this.BT_Renew.UseVisualStyleBackColor = true;
            this.BT_Renew.Click += new System.EventHandler(this.BT_Renew_Click);
            // 
            // TC1
            // 
            this.TC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC1.Controls.Add(this.TAB_Details);
            this.TC1.Controls.Add(this.TAB_Issues);
            this.TC1.Controls.Add(this.TAB_Previous);
            this.TC1.Controls.Add(this.TAB_Holds);
            this.TC1.Location = new System.Drawing.Point(11, 11);
            this.TC1.Margin = new System.Windows.Forms.Padding(2);
            this.TC1.Name = "TC1";
            this.TC1.SelectedIndex = 0;
            this.TC1.Size = new System.Drawing.Size(759, 262);
            this.TC1.TabIndex = 3;
            this.TC1.SelectedIndexChanged += new System.EventHandler(this.TC1_SelectedIndexChanged);
            // 
            // TAB_Details
            // 
            this.TAB_Details.Controls.Add(this.txtEmailConfirm);
            this.TAB_Details.Controls.Add(this.label1);
            this.TAB_Details.Controls.Add(this.btnUpdate);
            this.TAB_Details.Controls.Add(this.CB_Edit);
            this.TAB_Details.Controls.Add(this.DOB);
            this.TAB_Details.Controls.Add(this.dateTimePicker1);
            this.TAB_Details.Controls.Add(this.btnCancel);
            this.TAB_Details.Controls.Add(this.btnAdd);
            this.TAB_Details.Controls.Add(this.txtEmail);
            this.TAB_Details.Controls.Add(this.LB_Email);
            this.TAB_Details.Controls.Add(this.LBPhone);
            this.TAB_Details.Controls.Add(this.TB_Phone);
            this.TAB_Details.Controls.Add(this.LB_City);
            this.TAB_Details.Controls.Add(this.TB_City);
            this.TAB_Details.Controls.Add(this.LB_A2);
            this.TAB_Details.Controls.Add(this.TB_A2);
            this.TAB_Details.Controls.Add(this.LB_3);
            this.TAB_Details.Controls.Add(this.TB_A1);
            this.TAB_Details.Controls.Add(this.LB_LName);
            this.TAB_Details.Controls.Add(this.TB_LName);
            this.TAB_Details.Controls.Add(this.LB_FName);
            this.TAB_Details.Controls.Add(this.TB_FName);
            this.TAB_Details.Location = new System.Drawing.Point(4, 22);
            this.TAB_Details.Margin = new System.Windows.Forms.Padding(2);
            this.TAB_Details.Name = "TAB_Details";
            this.TAB_Details.Padding = new System.Windows.Forms.Padding(2);
            this.TAB_Details.Size = new System.Drawing.Size(751, 236);
            this.TAB_Details.TabIndex = 0;
            this.TAB_Details.Text = "Information";
            this.TAB_Details.UseVisualStyleBackColor = true;
            // 
            // txtEmailConfirm
            // 
            this.txtEmailConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmailConfirm.Location = new System.Drawing.Point(516, 123);
            this.txtEmailConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailConfirm.Name = "txtEmailConfirm";
            this.txtEmailConfirm.Size = new System.Drawing.Size(220, 20);
            this.txtEmailConfirm.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Confirm Email Address";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(573, 187);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // CB_Edit
            // 
            this.CB_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CB_Edit.AutoSize = true;
            this.CB_Edit.Location = new System.Drawing.Point(306, 197);
            this.CB_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Edit.Name = "CB_Edit";
            this.CB_Edit.Size = new System.Drawing.Size(179, 17);
            this.CB_Edit.TabIndex = 4;
            this.CB_Edit.Text = "Enable Edditing Personal Details";
            this.CB_Edit.UseVisualStyleBackColor = true;
            this.CB_Edit.CheckedChanged += new System.EventHandler(this.CB_Edit_CheckedChanged);
            // 
            // DOB
            // 
            this.DOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(17, 105);
            this.DOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(66, 13);
            this.DOB.TabIndex = 39;
            this.DOB.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 120);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(20, 187);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(573, 187);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 35);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(516, 72);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // LB_Email
            // 
            this.LB_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_Email.AutoSize = true;
            this.LB_Email.Location = new System.Drawing.Point(513, 57);
            this.LB_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(73, 13);
            this.LB_Email.TabIndex = 32;
            this.LB_Email.Text = "Email Address";
            // 
            // LBPhone
            // 
            this.LBPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBPhone.AutoSize = true;
            this.LBPhone.Location = new System.Drawing.Point(513, 8);
            this.LBPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBPhone.Name = "LBPhone";
            this.LBPhone.Size = new System.Drawing.Size(78, 13);
            this.LBPhone.TabIndex = 31;
            this.LBPhone.Text = "Phone Number";
            // 
            // TB_Phone
            // 
            this.TB_Phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Phone.Location = new System.Drawing.Point(516, 23);
            this.TB_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(220, 20);
            this.TB_Phone.TabIndex = 11;
            // 
            // LB_City
            // 
            this.LB_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_City.AutoSize = true;
            this.LB_City.Location = new System.Drawing.Point(262, 108);
            this.LB_City.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(24, 13);
            this.LB_City.TabIndex = 29;
            this.LB_City.Text = "City";
            // 
            // TB_City
            // 
            this.TB_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_City.Location = new System.Drawing.Point(265, 123);
            this.TB_City.Margin = new System.Windows.Forms.Padding(2);
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(220, 20);
            this.TB_City.TabIndex = 10;
            // 
            // LB_A2
            // 
            this.LB_A2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_A2.AutoSize = true;
            this.LB_A2.Location = new System.Drawing.Point(262, 57);
            this.LB_A2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_A2.Name = "LB_A2";
            this.LB_A2.Size = new System.Drawing.Size(77, 13);
            this.LB_A2.TabIndex = 27;
            this.LB_A2.Text = "Address Line 2";
            // 
            // TB_A2
            // 
            this.TB_A2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_A2.Location = new System.Drawing.Point(265, 72);
            this.TB_A2.Margin = new System.Windows.Forms.Padding(2);
            this.TB_A2.Name = "TB_A2";
            this.TB_A2.Size = new System.Drawing.Size(220, 20);
            this.TB_A2.TabIndex = 9;
            // 
            // LB_3
            // 
            this.LB_3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_3.AutoSize = true;
            this.LB_3.Location = new System.Drawing.Point(262, 9);
            this.LB_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_3.Name = "LB_3";
            this.LB_3.Size = new System.Drawing.Size(77, 13);
            this.LB_3.TabIndex = 25;
            this.LB_3.Text = "Address Line 1";
            // 
            // TB_A1
            // 
            this.TB_A1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_A1.Location = new System.Drawing.Point(265, 23);
            this.TB_A1.Margin = new System.Windows.Forms.Padding(2);
            this.TB_A1.Name = "TB_A1";
            this.TB_A1.Size = new System.Drawing.Size(220, 20);
            this.TB_A1.TabIndex = 8;
            // 
            // LB_LName
            // 
            this.LB_LName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_LName.AutoSize = true;
            this.LB_LName.Location = new System.Drawing.Point(17, 57);
            this.LB_LName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LName.Name = "LB_LName";
            this.LB_LName.Size = new System.Drawing.Size(58, 13);
            this.LB_LName.TabIndex = 23;
            this.LB_LName.Text = "Last Name";
            // 
            // TB_LName
            // 
            this.TB_LName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_LName.Location = new System.Drawing.Point(20, 72);
            this.TB_LName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_LName.Name = "TB_LName";
            this.TB_LName.Size = new System.Drawing.Size(220, 20);
            this.TB_LName.TabIndex = 6;
            // 
            // LB_FName
            // 
            this.LB_FName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_FName.AutoSize = true;
            this.LB_FName.Location = new System.Drawing.Point(17, 9);
            this.LB_FName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_FName.Name = "LB_FName";
            this.LB_FName.Size = new System.Drawing.Size(57, 13);
            this.LB_FName.TabIndex = 21;
            this.LB_FName.Text = "First Name";
            // 
            // TB_FName
            // 
            this.TB_FName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_FName.Location = new System.Drawing.Point(20, 23);
            this.TB_FName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_FName.Name = "TB_FName";
            this.TB_FName.Size = new System.Drawing.Size(220, 20);
            this.TB_FName.TabIndex = 5;
            // 
            // TAB_Issues
            // 
            this.TAB_Issues.Controls.Add(this.BT_Renew);
            this.TAB_Issues.Controls.Add(this.panel1);
            this.TAB_Issues.Controls.Add(this.LV_Issues);
            this.TAB_Issues.Location = new System.Drawing.Point(4, 22);
            this.TAB_Issues.Margin = new System.Windows.Forms.Padding(2);
            this.TAB_Issues.Name = "TAB_Issues";
            this.TAB_Issues.Padding = new System.Windows.Forms.Padding(2);
            this.TAB_Issues.Size = new System.Drawing.Size(751, 236);
            this.TAB_Issues.TabIndex = 1;
            this.TAB_Issues.Text = "Current Issues";
            this.TAB_Issues.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(649, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 172);
            this.panel1.TabIndex = 4;
            // 
            // LV_Issues
            // 
            this.LV_Issues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Issues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LV_Issues.FullRowSelect = true;
            this.LV_Issues.GridLines = true;
            this.LV_Issues.HideSelection = false;
            this.LV_Issues.Location = new System.Drawing.Point(6, 5);
            this.LV_Issues.Margin = new System.Windows.Forms.Padding(2);
            this.LV_Issues.MultiSelect = false;
            this.LV_Issues.Name = "LV_Issues";
            this.LV_Issues.Size = new System.Drawing.Size(639, 214);
            this.LV_Issues.TabIndex = 16;
            this.LV_Issues.UseCompatibleStateImageBehavior = false;
            this.LV_Issues.View = System.Windows.Forms.View.Details;
            this.LV_Issues.SelectedIndexChanged += new System.EventHandler(this.LV_Issues_SelectedIndexChanged);
            // 
            // CustomerForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(781, 287);
            this.Controls.Add(this.TC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(795, 311);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.TAB_Previous.ResumeLayout(false);
            this.TAB_Holds.ResumeLayout(false);
            this.TC1.ResumeLayout(false);
            this.TAB_Details.ResumeLayout(false);
            this.TAB_Details.PerformLayout();
            this.TAB_Issues.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage TAB_Previous;
        private System.Windows.Forms.ListView LV_Past;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TabPage TAB_Holds;
        private System.Windows.Forms.ListView LV_Holds;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_Renew;
        private System.Windows.Forms.TabControl TC1;
        private System.Windows.Forms.TabPage TAB_Details;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox CB_Edit;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LBPhone;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Label LB_City;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.Label LB_A2;
        private System.Windows.Forms.TextBox TB_A2;
        private System.Windows.Forms.Label LB_3;
        private System.Windows.Forms.TextBox TB_A1;
        private System.Windows.Forms.Label LB_LName;
        private System.Windows.Forms.TextBox TB_LName;
        private System.Windows.Forms.Label LB_FName;
        private System.Windows.Forms.TextBox TB_FName;
        private System.Windows.Forms.TabPage TAB_Issues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView LV_Issues;
        private System.Windows.Forms.TextBox txtEmailConfirm;
        private System.Windows.Forms.Label label1;
    }
}