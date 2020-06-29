namespace Project
{
    partial class ScanItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanItemForm));
            this.PN_Barcode = new System.Windows.Forms.Panel();
            this.LB_1 = new System.Windows.Forms.Label();
            this.TB_Barcode = new System.Windows.Forms.TextBox();
            this.PN_RFID = new System.Windows.Forms.Panel();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.LB_2 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.BT_Save_1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.PN_Barcode.SuspendLayout();
            this.PN_RFID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Barcode
            // 
            this.PN_Barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Barcode.Controls.Add(this.LB_1);
            this.PN_Barcode.Controls.Add(this.TB_Barcode);
            this.PN_Barcode.Location = new System.Drawing.Point(21, 21);
            this.PN_Barcode.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Barcode.Name = "PN_Barcode";
            this.PN_Barcode.Size = new System.Drawing.Size(256, 83);
            this.PN_Barcode.TabIndex = 4;
            this.PN_Barcode.Visible = false;
            // 
            // LB_1
            // 
            this.LB_1.AutoSize = true;
            this.LB_1.ForeColor = System.Drawing.Color.Silver;
            this.LB_1.Location = new System.Drawing.Point(11, 16);
            this.LB_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_1.Name = "LB_1";
            this.LB_1.Size = new System.Drawing.Size(175, 13);
            this.LB_1.TabIndex = 2;
            this.LB_1.Text = "Please Scan or Enter Your Barcode";
            // 
            // TB_Barcode
            // 
            this.TB_Barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Barcode.Location = new System.Drawing.Point(13, 36);
            this.TB_Barcode.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Barcode.Name = "TB_Barcode";
            this.TB_Barcode.Size = new System.Drawing.Size(227, 20);
            this.TB_Barcode.TabIndex = 0;
            // 
            // PN_RFID
            // 
            this.PN_RFID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PN_RFID.Controls.Add(this.pBox);
            this.PN_RFID.Controls.Add(this.LB_2);
            this.PN_RFID.Controls.Add(this.TB_ID);
            this.PN_RFID.Location = new System.Drawing.Point(20, 22);
            this.PN_RFID.Margin = new System.Windows.Forms.Padding(2);
            this.PN_RFID.Name = "PN_RFID";
            this.PN_RFID.Size = new System.Drawing.Size(256, 247);
            this.PN_RFID.TabIndex = 6;
            this.PN_RFID.Visible = false;
            // 
            // pBox
            // 
            this.pBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox.Location = new System.Drawing.Point(50, 68);
            this.pBox.Margin = new System.Windows.Forms.Padding(2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(150, 150);
            this.pBox.TabIndex = 3;
            this.pBox.TabStop = false;
            // 
            // LB_2
            // 
            this.LB_2.AutoSize = true;
            this.LB_2.ForeColor = System.Drawing.Color.Silver;
            this.LB_2.Location = new System.Drawing.Point(11, 16);
            this.LB_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_2.Name = "LB_2";
            this.LB_2.Size = new System.Drawing.Size(228, 13);
            this.LB_2.TabIndex = 2;
            this.LB_2.Text = "Tap your ID Card or Enter the RFID Tag Below";
            // 
            // TB_ID
            // 
            this.TB_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ID.Location = new System.Drawing.Point(13, 35);
            this.TB_ID.Margin = new System.Windows.Forms.Padding(2);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(227, 20);
            this.TB_ID.TabIndex = 0;
            // 
            // BT_Save_1
            // 
            this.BT_Save_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Save_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.BT_Save_1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Save_1.ForeColor = System.Drawing.Color.White;
            this.BT_Save_1.Location = new System.Drawing.Point(162, 103);
            this.BT_Save_1.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Save_1.Name = "BT_Save_1";
            this.BT_Save_1.Size = new System.Drawing.Size(114, 31);
            this.BT_Save_1.TabIndex = 5;
            this.BT_Save_1.Text = "Save";
            this.BT_Save_1.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NoTag.png");
            this.imageList1.Images.SetKeyName(1, "TagFound.png");
            this.imageList1.Images.SetKeyName(2, "TagError.png");
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(20, 103);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 31);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ScanItemForm
            // 
            this.AcceptButton = this.BT_Save_1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(297, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.PN_Barcode);
            this.Controls.Add(this.PN_RFID);
            this.Controls.Add(this.BT_Save_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanItemForm_FormClosing);
            this.Load += new System.EventHandler(this.ScanItemForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanItemForm_KeyDown);
            this.PN_Barcode.ResumeLayout(false);
            this.PN_Barcode.PerformLayout();
            this.PN_RFID.ResumeLayout(false);
            this.PN_RFID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PN_Barcode;
        private System.Windows.Forms.Label LB_1;
        private System.Windows.Forms.TextBox TB_Barcode;
        private System.Windows.Forms.Panel PN_RFID;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label LB_2;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Button BT_Save_1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCancel;
    }
}