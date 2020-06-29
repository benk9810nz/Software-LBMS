namespace Project
{
    partial class PublisherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherForm));
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.labelAddressLine2 = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.labelAddressLine1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.labelSuburb = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdatePub = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.Silver;
            this.labelPhoneNumber.Location = new System.Drawing.Point(16, 231);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(125, 13);
            this.labelPhoneNumber.TabIndex = 84;
            this.labelPhoneNumber.Text = "Phone Number (required)";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(16, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 41);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // labelCity
            // 
            this.labelCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelCity.ForeColor = System.Drawing.Color.Silver;
            this.labelCity.Location = new System.Drawing.Point(15, 185);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(71, 13);
            this.labelCity.TabIndex = 82;
            this.labelCity.Text = "City (required)";
            // 
            // labelPostcode
            // 
            this.labelPostcode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPostcode.ForeColor = System.Drawing.Color.Silver;
            this.labelPostcode.Location = new System.Drawing.Point(253, 231);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(52, 13);
            this.labelPostcode.TabIndex = 81;
            this.labelPostcode.Text = "Postcode";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSuburb.Location = new System.Drawing.Point(253, 201);
            this.txtSuburb.MaxLength = 255;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(228, 20);
            this.txtSuburb.TabIndex = 6;
            this.txtSuburb.WordWrap = false;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCity.Location = new System.Drawing.Point(16, 201);
            this.txtCity.MaxLength = 255;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(224, 20);
            this.txtCity.TabIndex = 5;
            this.txtCity.WordWrap = false;
            // 
            // labelAddressLine2
            // 
            this.labelAddressLine2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAddressLine2.AutoSize = true;
            this.labelAddressLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelAddressLine2.ForeColor = System.Drawing.Color.Silver;
            this.labelAddressLine2.Location = new System.Drawing.Point(15, 140);
            this.labelAddressLine2.Name = "labelAddressLine2";
            this.labelAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.labelAddressLine2.TabIndex = 78;
            this.labelAddressLine2.Text = "Address Line 2";
            // 
            // labelURL
            // 
            this.labelURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelURL.AutoSize = true;
            this.labelURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelURL.ForeColor = System.Drawing.Color.Silver;
            this.labelURL.Location = new System.Drawing.Point(167, 12);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(118, 13);
            this.labelURL.TabIndex = 77;
            this.labelURL.Text = "Website URL (required)";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(170, 28);
            this.txtURL.MaxLength = 255;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(311, 20);
            this.txtURL.TabIndex = 2;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressLine1.Location = new System.Drawing.Point(14, 110);
            this.txtAddressLine1.MaxLength = 255;
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(467, 20);
            this.txtAddressLine1.TabIndex = 3;
            this.txtAddressLine1.WordWrap = false;
            // 
            // labelAddressLine1
            // 
            this.labelAddressLine1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAddressLine1.AutoSize = true;
            this.labelAddressLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelAddressLine1.ForeColor = System.Drawing.Color.Silver;
            this.labelAddressLine1.Location = new System.Drawing.Point(13, 94);
            this.labelAddressLine1.Name = "labelAddressLine1";
            this.labelAddressLine1.Size = new System.Drawing.Size(124, 13);
            this.labelAddressLine1.TabIndex = 75;
            this.labelAddressLine1.Text = "Address Line 1 (required)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(328, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 41);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Add New Publisher";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressLine2.Location = new System.Drawing.Point(14, 156);
            this.txtAddressLine2.MaxLength = 255;
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(467, 20);
            this.txtAddressLine2.TabIndex = 4;
            this.txtAddressLine2.WordWrap = false;
            // 
            // labelSuburb
            // 
            this.labelSuburb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSuburb.AutoSize = true;
            this.labelSuburb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelSuburb.ForeColor = System.Drawing.Color.Silver;
            this.labelSuburb.Location = new System.Drawing.Point(253, 185);
            this.labelSuburb.Name = "labelSuburb";
            this.labelSuburb.Size = new System.Drawing.Size(41, 13);
            this.labelSuburb.TabIndex = 71;
            this.labelSuburb.Text = "Suburb";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelName.ForeColor = System.Drawing.Color.Silver;
            this.labelName.Location = new System.Drawing.Point(11, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(128, 13);
            this.labelName.TabIndex = 76;
            this.labelName.Text = "Publisher Name (required)";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Location = new System.Drawing.Point(14, 28);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnUpdatePub
            // 
            this.btnUpdatePub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatePub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnUpdatePub.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePub.Location = new System.Drawing.Point(328, 331);
            this.btnUpdatePub.Name = "btnUpdatePub";
            this.btnUpdatePub.Size = new System.Drawing.Size(148, 41);
            this.btnUpdatePub.TabIndex = 9;
            this.btnUpdatePub.Text = "Update Publisher";
            this.btnUpdatePub.UseVisualStyleBackColor = false;
            this.btnUpdatePub.Click += new System.EventHandler(this.btnUpdatePub_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(16, 247);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(253, 247);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(228, 20);
            this.txtPostcode.TabIndex = 8;
            // 
            // PublisherForm
            // 
            this.AcceptButton = this.btnUpdatePub;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(491, 384);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnUpdatePub);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPostcode);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.labelAddressLine2);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.labelAddressLine1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.labelSuburb);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(507, 423);
            this.Name = "PublisherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPublisher";
            this.Load += new System.EventHandler(this.PublisherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostcode;
        protected System.Windows.Forms.TextBox txtSuburb;
        protected System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label labelAddressLine2;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox txtURL;
        protected System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label labelAddressLine1;
        private System.Windows.Forms.Button btnSubmit;
        protected System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label labelSuburb;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdatePub;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPostcode;
    }
}