namespace Project
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.comboKey = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelTableSelect = new System.Windows.Forms.Label();
            this.labelKeySelect = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewBooksOnHold = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewBooksIssued = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewAllBookCopies = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddPublisher = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRetailers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewRetailers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddRetailer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.btnAddRec = new System.Windows.Forms.Button();
            this.btnViewRec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(133, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search by field value here...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(52, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboTable
            // 
            this.comboTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboTable.FormattingEnabled = true;
            this.comboTable.ItemHeight = 13;
            this.comboTable.Items.AddRange(new object[] {
            "",
            "Books",
            "Genres",
            "Publishers"});
            this.comboTable.Location = new System.Drawing.Point(444, 92);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(193, 21);
            this.comboTable.TabIndex = 3;
            this.comboTable.Text = "Table Selected";
            this.comboTable.SelectedIndexChanged += new System.EventHandler(this.comboTable_SelectedIndexChanged);
            // 
            // comboKey
            // 
            this.comboKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboKey.Enabled = false;
            this.comboKey.FormattingEnabled = true;
            this.comboKey.ItemHeight = 13;
            this.comboKey.Location = new System.Drawing.Point(444, 115);
            this.comboKey.Name = "comboKey";
            this.comboKey.Size = new System.Drawing.Size(193, 21);
            this.comboKey.TabIndex = 4;
            this.comboKey.Text = "Key Selected";
            this.comboKey.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.Location = new System.Drawing.Point(52, 174);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 100;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(585, 272);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // labelTableSelect
            // 
            this.labelTableSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTableSelect.AutoSize = true;
            this.labelTableSelect.ForeColor = System.Drawing.Color.Silver;
            this.labelTableSelect.Location = new System.Drawing.Point(441, 76);
            this.labelTableSelect.Name = "labelTableSelect";
            this.labelTableSelect.Size = new System.Drawing.Size(29, 13);
            this.labelTableSelect.TabIndex = 10;
            this.labelTableSelect.Text = "Filter";
            // 
            // labelKeySelect
            // 
            this.labelKeySelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelKeySelect.AutoSize = true;
            this.labelKeySelect.Enabled = false;
            this.labelKeySelect.ForeColor = System.Drawing.Color.Silver;
            this.labelKeySelect.Location = new System.Drawing.Point(368, 123);
            this.labelKeySelect.Name = "labelKeySelect";
            this.labelKeySelect.Size = new System.Drawing.Size(70, 13);
            this.labelKeySelect.TabIndex = 11;
            this.labelKeySelect.Text = "Key Selected";
            this.labelKeySelect.Visible = false;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.ForeColor = System.Drawing.Color.Silver;
            this.labelResults.Location = new System.Drawing.Point(49, 158);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(79, 13);
            this.labelResults.TabIndex = 12;
            this.labelResults.Text = "Search Results";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCurrentUser,
            this.menuBooks,
            this.menuGenres,
            this.menuPublishers,
            this.menuRetailers,
            this.menuCustomers,
            this.menuUsers});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(690, 30);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuCurrentUser
            // 
            this.menuCurrentUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuCurrentUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuViewDetails,
            this.menuResetPassword});
            this.menuCurrentUser.Image = global::Project.Properties.Resources.abstract_user_flat_2;
            this.menuCurrentUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuCurrentUser.Name = "menuCurrentUser";
            this.menuCurrentUser.Size = new System.Drawing.Size(109, 28);
            this.menuCurrentUser.Text = "Please Login";
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(155, 22);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuViewDetails
            // 
            this.menuViewDetails.Name = "menuViewDetails";
            this.menuViewDetails.Size = new System.Drawing.Size(155, 22);
            this.menuViewDetails.Text = "View Details";
            this.menuViewDetails.Click += new System.EventHandler(this.menuViewDetails_Click);
            // 
            // menuResetPassword
            // 
            this.menuResetPassword.Name = "menuResetPassword";
            this.menuResetPassword.Size = new System.Drawing.Size(155, 22);
            this.menuResetPassword.Text = "Reset Password";
            this.menuResetPassword.Click += new System.EventHandler(this.resetPassword_Click);
            // 
            // menuBooks
            // 
            this.menuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewBooks,
            this.menuAddBook,
            this.menuViewBooksOnHold,
            this.menuViewBooksIssued,
            this.menuViewAllBookCopies});
            this.menuBooks.Name = "menuBooks";
            this.menuBooks.Size = new System.Drawing.Size(51, 28);
            this.menuBooks.Text = "Books";
            // 
            // menuViewBooks
            // 
            this.menuViewBooks.Name = "menuViewBooks";
            this.menuViewBooks.Size = new System.Drawing.Size(185, 22);
            this.menuViewBooks.Text = "View Books";
            this.menuViewBooks.Click += new System.EventHandler(this.viewBook_Click);
            // 
            // menuAddBook
            // 
            this.menuAddBook.Name = "menuAddBook";
            this.menuAddBook.Size = new System.Drawing.Size(185, 22);
            this.menuAddBook.Text = "Add Book";
            this.menuAddBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // menuViewBooksOnHold
            // 
            this.menuViewBooksOnHold.Name = "menuViewBooksOnHold";
            this.menuViewBooksOnHold.Size = new System.Drawing.Size(185, 22);
            this.menuViewBooksOnHold.Text = "View Books on Hold";
            this.menuViewBooksOnHold.Click += new System.EventHandler(this.viewBooksOnHoldToolStripMenuItem_Click);
            // 
            // menuViewBooksIssued
            // 
            this.menuViewBooksIssued.Name = "menuViewBooksIssued";
            this.menuViewBooksIssued.Size = new System.Drawing.Size(185, 22);
            this.menuViewBooksIssued.Text = "View Books Issued";
            this.menuViewBooksIssued.Click += new System.EventHandler(this.menuViewBooksIssued_Click);
            // 
            // menuViewAllBookCopies
            // 
            this.menuViewAllBookCopies.Name = "menuViewAllBookCopies";
            this.menuViewAllBookCopies.Size = new System.Drawing.Size(185, 22);
            this.menuViewAllBookCopies.Text = "View All Book Copies";
            this.menuViewAllBookCopies.Click += new System.EventHandler(this.menuViewAllBookCopies_Click);
            // 
            // menuGenres
            // 
            this.menuGenres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewGenres,
            this.menuAddGenre});
            this.menuGenres.Name = "menuGenres";
            this.menuGenres.Size = new System.Drawing.Size(55, 28);
            this.menuGenres.Text = "Genres";
            // 
            // menuViewGenres
            // 
            this.menuViewGenres.Name = "menuViewGenres";
            this.menuViewGenres.Size = new System.Drawing.Size(138, 22);
            this.menuViewGenres.Text = "View Genres";
            this.menuViewGenres.Click += new System.EventHandler(this.viewGenre_Click);
            // 
            // menuAddGenre
            // 
            this.menuAddGenre.Name = "menuAddGenre";
            this.menuAddGenre.Size = new System.Drawing.Size(138, 22);
            this.menuAddGenre.Text = "Add Genre";
            this.menuAddGenre.Click += new System.EventHandler(this.addGenre_Click);
            // 
            // menuPublishers
            // 
            this.menuPublishers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewPublishers,
            this.menuAddPublisher});
            this.menuPublishers.Name = "menuPublishers";
            this.menuPublishers.Size = new System.Drawing.Size(73, 28);
            this.menuPublishers.Text = "Publishers";
            // 
            // menuViewPublishers
            // 
            this.menuViewPublishers.Name = "menuViewPublishers";
            this.menuViewPublishers.Size = new System.Drawing.Size(156, 22);
            this.menuViewPublishers.Text = "View Publishers";
            this.menuViewPublishers.Click += new System.EventHandler(this.viewPublisher_Click);
            // 
            // menuAddPublisher
            // 
            this.menuAddPublisher.Name = "menuAddPublisher";
            this.menuAddPublisher.Size = new System.Drawing.Size(156, 22);
            this.menuAddPublisher.Text = "Add Publisher";
            this.menuAddPublisher.Click += new System.EventHandler(this.addPublisher_Click);
            // 
            // menuRetailers
            // 
            this.menuRetailers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewRetailers,
            this.menuAddRetailer});
            this.menuRetailers.Name = "menuRetailers";
            this.menuRetailers.Size = new System.Drawing.Size(63, 28);
            this.menuRetailers.Text = "Retailers";
            // 
            // menuViewRetailers
            // 
            this.menuViewRetailers.Name = "menuViewRetailers";
            this.menuViewRetailers.Size = new System.Drawing.Size(146, 22);
            this.menuViewRetailers.Text = "View Retailers";
            this.menuViewRetailers.Click += new System.EventHandler(this.viewRetailer_Click);
            // 
            // menuAddRetailer
            // 
            this.menuAddRetailer.Name = "menuAddRetailer";
            this.menuAddRetailer.Size = new System.Drawing.Size(146, 22);
            this.menuAddRetailer.Text = "Add Retailer";
            this.menuAddRetailer.Click += new System.EventHandler(this.addRetailer_Click);
            // 
            // menuCustomers
            // 
            this.menuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewCustomers,
            this.menuAddCustomer});
            this.menuCustomers.Name = "menuCustomers";
            this.menuCustomers.Size = new System.Drawing.Size(76, 28);
            this.menuCustomers.Text = "Customers";
            // 
            // menuViewCustomers
            // 
            this.menuViewCustomers.Name = "menuViewCustomers";
            this.menuViewCustomers.Size = new System.Drawing.Size(159, 22);
            this.menuViewCustomers.Text = "View Customers";
            this.menuViewCustomers.Click += new System.EventHandler(this.viewCustomer_Click);
            // 
            // menuAddCustomer
            // 
            this.menuAddCustomer.Name = "menuAddCustomer";
            this.menuAddCustomer.Size = new System.Drawing.Size(159, 22);
            this.menuAddCustomer.Text = "Add Customer";
            this.menuAddCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // menuUsers
            // 
            this.menuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewUsers,
            this.menuAddUser});
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.Size = new System.Drawing.Size(47, 28);
            this.menuUsers.Text = "Users";
            // 
            // menuViewUsers
            // 
            this.menuViewUsers.Name = "menuViewUsers";
            this.menuViewUsers.Size = new System.Drawing.Size(130, 22);
            this.menuViewUsers.Text = "View Users";
            this.menuViewUsers.Click += new System.EventHandler(this.viewUser_Click);
            // 
            // menuAddUser
            // 
            this.menuAddUser.Name = "menuAddUser";
            this.menuAddUser.Size = new System.Drawing.Size(130, 22);
            this.menuAddUser.Text = "Add User";
            this.menuAddUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Silver;
            this.labelName.Location = new System.Drawing.Point(12, 39);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 15;
            // 
            // btnAddRec
            // 
            this.btnAddRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAddRec.ForeColor = System.Drawing.Color.White;
            this.btnAddRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRec.Location = new System.Drawing.Point(444, 452);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(193, 33);
            this.btnAddRec.TabIndex = 5;
            this.btnAddRec.Text = "Add New Record";
            this.btnAddRec.UseVisualStyleBackColor = false;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            // 
            // btnViewRec
            // 
            this.btnViewRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnViewRec.ForeColor = System.Drawing.Color.White;
            this.btnViewRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewRec.Location = new System.Drawing.Point(52, 452);
            this.btnViewRec.Name = "btnViewRec";
            this.btnViewRec.Size = new System.Drawing.Size(193, 33);
            this.btnViewRec.TabIndex = 6;
            this.btnViewRec.Text = "View/Update Record";
            this.btnViewRec.UseVisualStyleBackColor = false;
            this.btnViewRec.Click += new System.EventHandler(this.btnViewRec_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(690, 529);
            this.Controls.Add(this.btnViewRec);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboKey);
            this.Controls.Add(this.comboTable);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelKeySelect);
            this.Controls.Add(this.labelTableSelect);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAddRec);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(706, 479);
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library ++";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.ComboBox comboKey;
        private System.Windows.Forms.Button btnAddRec;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTableSelect;
        private System.Windows.Forms.Label labelKeySelect;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ToolStripMenuItem menuCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuResetPassword;
        private System.Windows.Forms.ToolStripMenuItem menuBooks;
        private System.Windows.Forms.ToolStripMenuItem menuPublishers;
        private System.Windows.Forms.ToolStripMenuItem menuRetailers;
        private System.Windows.Forms.ToolStripMenuItem menuUsers;
        private System.Windows.Forms.ToolStripMenuItem menuGenres;
        private System.Windows.Forms.ToolStripMenuItem menuViewBooks;
        private System.Windows.Forms.ToolStripMenuItem menuAddBook;
        private System.Windows.Forms.ToolStripMenuItem menuViewGenres;
        private System.Windows.Forms.ToolStripMenuItem menuAddGenre;
        private System.Windows.Forms.ToolStripMenuItem menuViewPublishers;
        private System.Windows.Forms.ToolStripMenuItem menuAddPublisher;
        private System.Windows.Forms.ToolStripMenuItem menuViewRetailers;
        private System.Windows.Forms.ToolStripMenuItem menuAddRetailer;
        private System.Windows.Forms.ToolStripMenuItem menuCustomers;
        private System.Windows.Forms.ToolStripMenuItem menuViewCustomers;
        private System.Windows.Forms.ToolStripMenuItem menuAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuViewUsers;
        private System.Windows.Forms.ToolStripMenuItem menuAddUser;
        private System.Windows.Forms.ToolStripMenuItem menuViewDetails;
        private System.Windows.Forms.Button btnViewRec;
        private System.Windows.Forms.ToolStripMenuItem menuViewBooksOnHold;
        private System.Windows.Forms.ToolStripMenuItem menuViewBooksIssued;
        private System.Windows.Forms.ToolStripMenuItem menuViewAllBookCopies;
    }
}

