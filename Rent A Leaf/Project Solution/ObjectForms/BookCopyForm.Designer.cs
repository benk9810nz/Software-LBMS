namespace Project
{
    partial class BookCopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCopyForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRetailer = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.comboRetailer = new System.Windows.Forms.ComboBox();
            this.btnRFID = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(195, 178);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Book Copy";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.Color.Silver;
            this.labelPrice.Location = new System.Drawing.Point(192, 109);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 13);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Book Price";
            // 
            // labelRetailer
            // 
            this.labelRetailer.AutoSize = true;
            this.labelRetailer.ForeColor = System.Drawing.Color.Silver;
            this.labelRetailer.Location = new System.Drawing.Point(31, 109);
            this.labelRetailer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRetailer.Name = "labelRetailer";
            this.labelRetailer.Size = new System.Drawing.Size(43, 13);
            this.labelRetailer.TabIndex = 13;
            this.labelRetailer.Text = "Retailer";
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Location = new System.Drawing.Point(195, 124);
            this.numericPrice.Margin = new System.Windows.Forms.Padding(2);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(148, 20);
            this.numericPrice.TabIndex = 6;
            // 
            // comboRetailer
            // 
            this.comboRetailer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRetailer.FormattingEnabled = true;
            this.comboRetailer.ItemHeight = 13;
            this.comboRetailer.Location = new System.Drawing.Point(34, 124);
            this.comboRetailer.Margin = new System.Windows.Forms.Padding(2);
            this.comboRetailer.Name = "comboRetailer";
            this.comboRetailer.Size = new System.Drawing.Size(148, 21);
            this.comboRetailer.TabIndex = 10;
            // 
            // btnRFID
            // 
            this.btnRFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnRFID.ForeColor = System.Drawing.Color.White;
            this.btnRFID.Location = new System.Drawing.Point(34, 61);
            this.btnRFID.Margin = new System.Windows.Forms.Padding(2);
            this.btnRFID.Name = "btnRFID";
            this.btnRFID.Size = new System.Drawing.Size(114, 22);
            this.btnRFID.TabIndex = 3;
            this.btnRFID.Text = "Read RFID Tag";
            this.btnRFID.UseVisualStyleBackColor = false;
            this.btnRFID.Click += new System.EventHandler(this.btnRFID_Click);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(34, 33);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(114, 22);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan New Barcode";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(153, 33);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(190, 20);
            this.txtBarcode.TabIndex = 2;
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(153, 63);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(190, 20);
            this.txtRFID.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(34, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(195, 178);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Book Copy";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BookCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(381, 253);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRetailer);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.comboRetailer);
            this.Controls.Add(this.btnRFID);
            this.Controls.Add(this.btnScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookCopyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookCopy";
            this.Load += new System.EventHandler(this.BookCopyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRetailer;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.ComboBox comboRetailer;
        private System.Windows.Forms.Button btnRFID;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
    }
}