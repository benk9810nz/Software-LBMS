namespace Library_SCO
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_RFID = new System.Windows.Forms.TextBox();
            this.BTTest = new System.Windows.Forms.Button();
            this.PBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Return = new System.Windows.Forms.Button();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.PN_Login = new System.Windows.Forms.Panel();
            this.PN_Issue = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_Logout = new System.Windows.Forms.Button();
            this.LB_Count = new System.Windows.Forms.Label();
            this.LB_2 = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.BT_TagFound = new System.Windows.Forms.Button();
            this.TB_Tag = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.PN_Returns = new System.Windows.Forms.Panel();
            this.BT_ExitApp = new System.Windows.Forms.Button();
            this.BT_ExitMode = new System.Windows.Forms.Button();
            this.listViewReturning = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.BT_ReturnBook = new System.Windows.Forms.Button();
            this.TB_Return = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            this.PN_Login.SuspendLayout();
            this.PN_Issue.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PN_Returns.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NoTag.png");
            this.imageList1.Images.SetKeyName(1, "TagFound.png");
            this.imageList1.Images.SetKeyName(2, "TagError.png");
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(283, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 4;
            // 
            // TB_RFID
            // 
            this.TB_RFID.Location = new System.Drawing.Point(801, 282);
            this.TB_RFID.Name = "TB_RFID";
            this.TB_RFID.Size = new System.Drawing.Size(100, 26);
            this.TB_RFID.TabIndex = 7;
            // 
            // BTTest
            // 
            this.BTTest.Location = new System.Drawing.Point(787, 392);
            this.BTTest.Name = "BTTest";
            this.BTTest.Size = new System.Drawing.Size(114, 73);
            this.BTTest.TabIndex = 6;
            this.BTTest.Text = "Maual Login";
            this.BTTest.UseVisualStyleBackColor = true;
            this.BTTest.Click += new System.EventHandler(this.BTTest_Click);
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(306, 263);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(232, 235);
            this.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox.TabIndex = 5;
            this.PBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 220);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome\r\n\r\nPlease Present your ID Card onto the Reader \r\nPad Attached";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BT_Return
            // 
            this.BT_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Return.Location = new System.Drawing.Point(3, 674);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(128, 75);
            this.BT_Return.TabIndex = 5;
            this.BT_Return.Text = "Return Mode";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // BT_Exit
            // 
            this.BT_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Exit.Location = new System.Drawing.Point(1330, 3);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(142, 66);
            this.BT_Exit.TabIndex = 10;
            this.BT_Exit.Text = "Exit Application";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // PN_Login
            // 
            this.PN_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PN_Login.Controls.Add(this.BT_Return);
            this.PN_Login.Controls.Add(this.BT_Exit);
            this.PN_Login.Controls.Add(this.TB_RFID);
            this.PN_Login.Controls.Add(this.PBox);
            this.PN_Login.Controls.Add(this.BTTest);
            this.PN_Login.Controls.Add(this.label1);
            this.PN_Login.Location = new System.Drawing.Point(3, 49);
            this.PN_Login.Name = "PN_Login";
            this.PN_Login.Size = new System.Drawing.Size(1475, 752);
            this.PN_Login.TabIndex = 11;
            // 
            // PN_Issue
            // 
            this.PN_Issue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PN_Issue.Controls.Add(this.panel3);
            this.PN_Issue.Location = new System.Drawing.Point(12, 12);
            this.PN_Issue.Name = "PN_Issue";
            this.PN_Issue.Size = new System.Drawing.Size(1474, 749);
            this.PN_Issue.TabIndex = 12;
            this.PN_Issue.Visible = false;
            this.PN_Issue.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Issue_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.BT_Logout);
            this.panel3.Controls.Add(this.LB_Count);
            this.panel3.Controls.Add(this.LB_2);
            this.panel3.Controls.Add(this.LB_Name);
            this.panel3.Controls.Add(this.BT_TagFound);
            this.panel3.Controls.Add(this.TB_Tag);
            this.panel3.Controls.Add(this.listView);
            this.panel3.Location = new System.Drawing.Point(11, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1463, 744);
            this.panel3.TabIndex = 10;
            // 
            // BT_Logout
            // 
            this.BT_Logout.Location = new System.Drawing.Point(1099, 436);
            this.BT_Logout.Name = "BT_Logout";
            this.BT_Logout.Size = new System.Drawing.Size(177, 132);
            this.BT_Logout.TabIndex = 15;
            this.BT_Logout.Text = "Logout";
            this.BT_Logout.UseVisualStyleBackColor = true;
            this.BT_Logout.Click += new System.EventHandler(this.BT_Logout_Click);
            // 
            // LB_Count
            // 
            this.LB_Count.AutoSize = true;
            this.LB_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Count.ForeColor = System.Drawing.Color.White;
            this.LB_Count.Location = new System.Drawing.Point(40, 684);
            this.LB_Count.Name = "LB_Count";
            this.LB_Count.Size = new System.Drawing.Size(1058, 59);
            this.LB_Count.TabIndex = 14;
            this.LB_Count.Text = "Remaining number of books you can issue:";
            // 
            // LB_2
            // 
            this.LB_2.AutoSize = true;
            this.LB_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LB_2.Location = new System.Drawing.Point(209, 88);
            this.LB_2.Name = "LB_2";
            this.LB_2.Size = new System.Drawing.Size(1079, 52);
            this.LB_2.TabIndex = 13;
            this.LB_2.Text = "Please Tap a Book onto the Scanner to Issue the Book";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LB_Name.Location = new System.Drawing.Point(516, 22);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(206, 52);
            this.LB_Name.TabIndex = 12;
            this.LB_Name.Text = "Welcome";
            // 
            // BT_TagFound
            // 
            this.BT_TagFound.Location = new System.Drawing.Point(1099, 260);
            this.BT_TagFound.Name = "BT_TagFound";
            this.BT_TagFound.Size = new System.Drawing.Size(177, 132);
            this.BT_TagFound.TabIndex = 11;
            this.BT_TagFound.Text = "Manual Issue";
            this.BT_TagFound.UseVisualStyleBackColor = true;
            this.BT_TagFound.Click += new System.EventHandler(this.BT_TagFound_Click);
            // 
            // TB_Tag
            // 
            this.TB_Tag.Location = new System.Drawing.Point(1116, 201);
            this.TB_Tag.Name = "TB_Tag";
            this.TB_Tag.Size = new System.Drawing.Size(145, 26);
            this.TB_Tag.TabIndex = 10;
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(31, 154);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1039, 491);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // PN_Returns
            // 
            this.PN_Returns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PN_Returns.Controls.Add(this.BT_ExitApp);
            this.PN_Returns.Controls.Add(this.BT_ExitMode);
            this.PN_Returns.Controls.Add(this.listViewReturning);
            this.PN_Returns.Controls.Add(this.label2);
            this.PN_Returns.Controls.Add(this.BT_ReturnBook);
            this.PN_Returns.Controls.Add(this.TB_Return);
            this.PN_Returns.Location = new System.Drawing.Point(3, 24);
            this.PN_Returns.Name = "PN_Returns";
            this.PN_Returns.Size = new System.Drawing.Size(1466, 753);
            this.PN_Returns.TabIndex = 11;
            this.PN_Returns.Visible = false;
            // 
            // BT_ExitApp
            // 
            this.BT_ExitApp.Location = new System.Drawing.Point(1242, 3);
            this.BT_ExitApp.Name = "BT_ExitApp";
            this.BT_ExitApp.Size = new System.Drawing.Size(119, 66);
            this.BT_ExitApp.TabIndex = 9;
            this.BT_ExitApp.Text = "Exit Application";
            this.BT_ExitApp.UseVisualStyleBackColor = true;
            this.BT_ExitApp.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // BT_ExitMode
            // 
            this.BT_ExitMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_ExitMode.Location = new System.Drawing.Point(12, 664);
            this.BT_ExitMode.Name = "BT_ExitMode";
            this.BT_ExitMode.Size = new System.Drawing.Size(136, 68);
            this.BT_ExitMode.TabIndex = 8;
            this.BT_ExitMode.Text = "Exit Returning Mode";
            this.BT_ExitMode.UseVisualStyleBackColor = true;
            this.BT_ExitMode.Click += new System.EventHandler(this.BT_ExitMode_Click);
            // 
            // listViewReturning
            // 
            this.listViewReturning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewReturning.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewReturning.GridLines = true;
            this.listViewReturning.HideSelection = false;
            this.listViewReturning.Location = new System.Drawing.Point(254, 131);
            this.listViewReturning.Name = "listViewReturning";
            this.listViewReturning.Size = new System.Drawing.Size(704, 379);
            this.listViewReturning.TabIndex = 5;
            this.listViewReturning.UseCompatibleStateImageBehavior = false;
            this.listViewReturning.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Barcode";
            this.columnHeader4.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1104, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please place the book to be returned on the Scanner";
            // 
            // BT_ReturnBook
            // 
            this.BT_ReturnBook.Location = new System.Drawing.Point(988, 319);
            this.BT_ReturnBook.Name = "BT_ReturnBook";
            this.BT_ReturnBook.Size = new System.Drawing.Size(137, 76);
            this.BT_ReturnBook.TabIndex = 7;
            this.BT_ReturnBook.Text = "Manual Return";
            this.BT_ReturnBook.UseVisualStyleBackColor = true;
            this.BT_ReturnBook.Click += new System.EventHandler(this.BT_Test_Click);
            // 
            // TB_Return
            // 
            this.TB_Return.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Return.Location = new System.Drawing.Point(1002, 228);
            this.TB_Return.Name = "TB_Return";
            this.TB_Return.Size = new System.Drawing.Size(111, 26);
            this.TB_Return.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1490, 768);
            this.Controls.Add(this.PN_Returns);
            this.Controls.Add(this.PN_Issue);
            this.Controls.Add(this.PN_Login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Snatch and Go";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            this.PN_Login.ResumeLayout(false);
            this.PN_Login.PerformLayout();
            this.PN_Issue.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PN_Returns.ResumeLayout(false);
            this.PN_Returns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_RFID;
        private System.Windows.Forms.Button BTTest;
        private System.Windows.Forms.PictureBox PBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Return;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Panel PN_Login;
        private System.Windows.Forms.Panel PN_Issue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_Logout;
        private System.Windows.Forms.Label LB_Count;
        private System.Windows.Forms.Label LB_2;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Button BT_TagFound;
        private System.Windows.Forms.TextBox TB_Tag;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel PN_Returns;
        private System.Windows.Forms.ListView listViewReturning;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_ReturnBook;
        private System.Windows.Forms.TextBox TB_Return;
        private System.Windows.Forms.Button BT_ExitMode;
        private System.Windows.Forms.Button BT_ExitApp;
    }
}

