namespace Project
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.btnHold = new System.Windows.Forms.Button();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkEnableEditing = new System.Windows.Forms.CheckBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewBookCopies = new System.Windows.Forms.ListView();
            this.fd = new System.Windows.Forms.OpenFileDialog();
            this.btnEditCopy = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.LB_Description = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnUploadCover = new System.Windows.Forms.Button();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.comboPublisher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDate = new System.Windows.Forms.DateTimePicker();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHold
            // 
            this.btnHold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnHold.Enabled = false;
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Location = new System.Drawing.Point(311, 530);
            this.btnHold.Margin = new System.Windows.Forms.Padding(2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(103, 34);
            this.btnHold.TabIndex = 11;
            this.btnHold.Text = "Place Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAddCopy.FlatAppearance.BorderSize = 0;
            this.btnAddCopy.ForeColor = System.Drawing.Color.White;
            this.btnAddCopy.Location = new System.Drawing.Point(173, 530);
            this.btnAddCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(103, 34);
            this.btnAddCopy.TabIndex = 10;
            this.btnAddCopy.Text = "Add New Copy";
            this.btnAddCopy.UseVisualStyleBackColor = false;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(458, 34);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update and Exit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // checkEnableEditing
            // 
            this.checkEnableEditing.AutoSize = true;
            this.checkEnableEditing.ForeColor = System.Drawing.Color.White;
            this.checkEnableEditing.Location = new System.Drawing.Point(467, 143);
            this.checkEnableEditing.Margin = new System.Windows.Forms.Padding(2);
            this.checkEnableEditing.Name = "checkEnableEditing";
            this.checkEnableEditing.Size = new System.Drawing.Size(94, 17);
            this.checkEnableEditing.TabIndex = 0;
            this.checkEnableEditing.Text = "Enable Editing";
            this.checkEnableEditing.UseVisualStyleBackColor = true;
            this.checkEnableEditing.Visible = false;
            this.checkEnableEditing.CheckedChanged += new System.EventHandler(this.checkEnableEditing_CheckedChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "RFID";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Retailer";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Due Date";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Barcode";
            this.columnHeader0.Width = 100;
            // 
            // listviewBookCopies
            // 
            this.listviewBookCopies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listviewBookCopies.FullRowSelect = true;
            this.listviewBookCopies.GridLines = true;
            this.listviewBookCopies.HideSelection = false;
            this.listviewBookCopies.Location = new System.Drawing.Point(22, 412);
            this.listviewBookCopies.Margin = new System.Windows.Forms.Padding(2);
            this.listviewBookCopies.MultiSelect = false;
            this.listviewBookCopies.Name = "listviewBookCopies";
            this.listviewBookCopies.Size = new System.Drawing.Size(392, 114);
            this.listviewBookCopies.TabIndex = 8;
            this.listviewBookCopies.UseCompatibleStateImageBehavior = false;
            this.listviewBookCopies.View = System.Windows.Forms.View.Details;
            this.listviewBookCopies.Visible = false;
            this.listviewBookCopies.SelectedIndexChanged += new System.EventHandler(this.listviewBookCopies_SelectedIndexChanged);
            // 
            // fd
            // 
            this.fd.FileName = "openFileDialog";
            this.fd.Filter = "JPG files (*.jpg)|*.jpg|JPEG files (*.jpeg*)|*.jpeg*";
            // 
            // btnEditCopy
            // 
            this.btnEditCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnEditCopy.Enabled = false;
            this.btnEditCopy.FlatAppearance.BorderSize = 0;
            this.btnEditCopy.ForeColor = System.Drawing.Color.White;
            this.btnEditCopy.Location = new System.Drawing.Point(23, 530);
            this.btnEditCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCopy.Name = "btnEditCopy";
            this.btnEditCopy.Size = new System.Drawing.Size(103, 34);
            this.btnEditCopy.TabIndex = 9;
            this.btnEditCopy.Text = "Edit Copy";
            this.btnEditCopy.UseVisualStyleBackColor = false;
            this.btnEditCopy.Visible = false;
            this.btnEditCopy.Click += new System.EventHandler(this.btnEditCopy_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(23, 292);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.MaxLength = 1000;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(391, 89);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.ForeColor = System.Drawing.Color.White;
            this.LB_Description.Location = new System.Drawing.Point(20, 277);
            this.LB_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(60, 13);
            this.LB_Description.TabIndex = 56;
            this.LB_Description.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(458, 87);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 34);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(458, 35);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 34);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Black;
            this.pBox.Location = new System.Drawing.Point(275, 33);
            this.pBox.Margin = new System.Windows.Forms.Padding(2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(139, 185);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 55;
            this.pBox.TabStop = false;
            // 
            // btnUploadCover
            // 
            this.btnUploadCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnUploadCover.FlatAppearance.BorderSize = 0;
            this.btnUploadCover.ForeColor = System.Drawing.Color.White;
            this.btnUploadCover.Location = new System.Drawing.Point(275, 222);
            this.btnUploadCover.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadCover.Name = "btnUploadCover";
            this.btnUploadCover.Size = new System.Drawing.Size(139, 34);
            this.btnUploadCover.TabIndex = 6;
            this.btnUploadCover.Text = "Upload Book Cover";
            this.btnUploadCover.UseVisualStyleBackColor = false;
            this.btnUploadCover.Click += new System.EventHandler(this.btnUploadCover_Click);
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(22, 138);
            this.comboGenre.Margin = new System.Windows.Forms.Padding(2);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(203, 21);
            this.comboGenre.TabIndex = 3;
            this.comboGenre.SelectedIndexChanged += new System.EventHandler(this.comboGenre_SelectedIndexChanged);
            // 
            // comboPublisher
            // 
            this.comboPublisher.FormattingEnabled = true;
            this.comboPublisher.ItemHeight = 13;
            this.comboPublisher.Location = new System.Drawing.Point(22, 86);
            this.comboPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.comboPublisher.Name = "comboPublisher";
            this.comboPublisher.Size = new System.Drawing.Size(203, 21);
            this.comboPublisher.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Publisher";
            // 
            // comboDate
            // 
            this.comboDate.CustomFormat = "dd MMM yyy";
            this.comboDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.comboDate.Location = new System.Drawing.Point(22, 241);
            this.comboDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboDate.Name = "comboDate";
            this.comboDate.Size = new System.Drawing.Size(203, 20);
            this.comboDate.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(22, 191);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(202, 20);
            this.txtAuthor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Author Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Date Published";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(581, 590);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkEnableEditing);
            this.Controls.Add(this.listviewBookCopies);
            this.Controls.Add(this.btnEditCopy);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.LB_Description);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.btnUploadCover);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.comboPublisher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDate);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox checkEnableEditing;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ListView listviewBookCopies;
        private System.Windows.Forms.OpenFileDialog fd;
        private System.Windows.Forms.Button btnEditCopy;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button btnUploadCover;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.ComboBox comboPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker comboDate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}