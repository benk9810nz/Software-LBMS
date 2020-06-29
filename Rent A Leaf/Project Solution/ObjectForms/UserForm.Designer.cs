namespace Project
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.labelConfirmEmail = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmEmail = new System.Windows.Forms.TextBox();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboClearance = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.labelPasswordConfrim = new System.Windows.Forms.Label();
            this.labelClearanceWarning = new System.Windows.Forms.Label();
            this.btnScanRFID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfirmEmail
            // 
            this.labelConfirmEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfirmEmail.AutoSize = true;
            this.labelConfirmEmail.ForeColor = System.Drawing.Color.Silver;
            this.labelConfirmEmail.Location = new System.Drawing.Point(12, 61);
            this.labelConfirmEmail.Name = "labelConfirmEmail";
            this.labelConfirmEmail.Size = new System.Drawing.Size(158, 13);
            this.labelConfirmEmail.TabIndex = 27;
            this.labelConfirmEmail.Text = "Confirm Email Address (required)";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.Silver;
            this.labelEmail.Location = new System.Drawing.Point(12, 9);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(120, 13);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Email Address (required)";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(15, 25);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmEmail.Location = new System.Drawing.Point(15, 77);
            this.txtConfirmEmail.MaxLength = 255;
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Size = new System.Drawing.Size(223, 20);
            this.txtConfirmEmail.TabIndex = 2;
            // 
            // txtRFID
            // 
            this.txtRFID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRFID.Location = new System.Drawing.Point(15, 128);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(223, 20);
            this.txtRFID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(15, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "RFID Tag";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(264, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Clearance";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(333, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 41);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(15, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 41);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboClearance
            // 
            this.comboClearance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboClearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClearance.Items.AddRange(new object[] {
            "Customer",
            "Librarian",
            "Admin"});
            this.comboClearance.Location = new System.Drawing.Point(267, 127);
            this.comboClearance.MaxDropDownItems = 3;
            this.comboClearance.Name = "comboClearance";
            this.comboClearance.Size = new System.Drawing.Size(220, 21);
            this.comboClearance.TabIndex = 7;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.Location = new System.Drawing.Point(333, 206);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(148, 41);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(267, 25);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.Silver;
            this.labelPassword.Location = new System.Drawing.Point(264, 9);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 13);
            this.labelPassword.TabIndex = 43;
            this.labelPassword.Text = "New Password";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(267, 77);
            this.txtPasswordConfirm.MaxLength = 255;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(220, 20);
            this.txtPasswordConfirm.TabIndex = 6;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            this.txtPasswordConfirm.WordWrap = false;
            // 
            // labelPasswordConfrim
            // 
            this.labelPasswordConfrim.AutoSize = true;
            this.labelPasswordConfrim.ForeColor = System.Drawing.Color.Silver;
            this.labelPasswordConfrim.Location = new System.Drawing.Point(264, 61);
            this.labelPasswordConfrim.Name = "labelPasswordConfrim";
            this.labelPasswordConfrim.Size = new System.Drawing.Size(119, 13);
            this.labelPasswordConfrim.TabIndex = 41;
            this.labelPasswordConfrim.Text = "Confrirm New Password";
            // 
            // labelClearanceWarning
            // 
            this.labelClearanceWarning.AutoSize = true;
            this.labelClearanceWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClearanceWarning.ForeColor = System.Drawing.Color.Red;
            this.labelClearanceWarning.Location = new System.Drawing.Point(264, 151);
            this.labelClearanceWarning.Name = "labelClearanceWarning";
            this.labelClearanceWarning.Size = new System.Drawing.Size(225, 13);
            this.labelClearanceWarning.TabIndex = 44;
            this.labelClearanceWarning.Text = "Only Change If You Know What You\'re Doing!";
            // 
            // btnScanRFID
            // 
            this.btnScanRFID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnScanRFID.ForeColor = System.Drawing.Color.Silver;
            this.btnScanRFID.Location = new System.Drawing.Point(15, 154);
            this.btnScanRFID.Name = "btnScanRFID";
            this.btnScanRFID.Size = new System.Drawing.Size(117, 23);
            this.btnScanRFID.TabIndex = 4;
            this.btnScanRFID.Text = "Scan RFID Tag";
            this.btnScanRFID.UseVisualStyleBackColor = false;
            this.btnScanRFID.Click += new System.EventHandler(this.btnScanRFID_Click);
            // 
            // UserForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 263);
            this.Controls.Add(this.btnScanRFID);
            this.Controls.Add(this.labelClearanceWarning);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.labelPasswordConfrim);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.comboClearance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelConfirmEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmEmail);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelConfirmEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmEmail;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboClearance;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordConfrim;
        private System.Windows.Forms.Label labelClearanceWarning;
        private System.Windows.Forms.Button btnScanRFID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
    }
}