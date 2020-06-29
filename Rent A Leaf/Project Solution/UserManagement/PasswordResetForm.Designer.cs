namespace Project
{
    partial class PasswordResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetForm));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPasswordConfrim = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmailConfirm = new System.Windows.Forms.Label();
            this.txtEmailConfirm = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.brnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 32);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.Silver;
            this.labelEmail.Location = new System.Drawing.Point(12, 15);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email Address";
            // 
            // labelPasswordConfrim
            // 
            this.labelPasswordConfrim.AutoSize = true;
            this.labelPasswordConfrim.ForeColor = System.Drawing.Color.Silver;
            this.labelPasswordConfrim.Location = new System.Drawing.Point(12, 185);
            this.labelPasswordConfrim.Name = "labelPasswordConfrim";
            this.labelPasswordConfrim.Size = new System.Drawing.Size(119, 13);
            this.labelPasswordConfrim.TabIndex = 2;
            this.labelPasswordConfrim.Text = "Confrirm New Password";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(15, 201);
            this.txtPasswordConfirm.MaxLength = 255;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(338, 20);
            this.txtPasswordConfirm.TabIndex = 3;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            this.txtPasswordConfirm.WordWrap = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 150);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(338, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.Silver;
            this.labelPassword.Location = new System.Drawing.Point(12, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "New Password";
            // 
            // labelEmailConfirm
            // 
            this.labelEmailConfirm.AutoSize = true;
            this.labelEmailConfirm.ForeColor = System.Drawing.Color.Silver;
            this.labelEmailConfirm.Location = new System.Drawing.Point(14, 63);
            this.labelEmailConfirm.Name = "labelEmailConfirm";
            this.labelEmailConfirm.Size = new System.Drawing.Size(114, 13);
            this.labelEmailConfirm.TabIndex = 7;
            this.labelEmailConfirm.Text = "Confrirm Email Address";
            // 
            // txtEmailConfirm
            // 
            this.txtEmailConfirm.Location = new System.Drawing.Point(15, 79);
            this.txtEmailConfirm.MaxLength = 255;
            this.txtEmailConfirm.Name = "txtEmailConfirm";
            this.txtEmailConfirm.Size = new System.Drawing.Size(338, 20);
            this.txtEmailConfirm.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(17, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // brnSubmit
            // 
            this.brnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.brnSubmit.ForeColor = System.Drawing.Color.White;
            this.brnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnSubmit.Location = new System.Drawing.Point(205, 299);
            this.brnSubmit.Name = "brnSubmit";
            this.brnSubmit.Size = new System.Drawing.Size(148, 41);
            this.brnSubmit.TabIndex = 4;
            this.brnSubmit.Text = "Submit";
            this.brnSubmit.UseVisualStyleBackColor = false;
            this.brnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // PasswordResetForm
            // 
            this.AcceptButton = this.brnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(365, 352);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.brnSubmit);
            this.Controls.Add(this.labelEmailConfirm);
            this.Controls.Add(this.txtEmailConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.labelPasswordConfrim);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Forgotten Password";
            this.Load += new System.EventHandler(this.PasswordResetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPasswordConfrim;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmailConfirm;
        private System.Windows.Forms.TextBox txtEmailConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button brnSubmit;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.TextBox txtPassword;
    }
}