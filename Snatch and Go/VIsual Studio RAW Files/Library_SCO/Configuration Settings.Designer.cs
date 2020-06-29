namespace Library_SCO
{
    partial class Configuration_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration_Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_sAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_sDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_sUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_sPassword1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_sPassword2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NM_ePort = new System.Windows.Forms.NumericUpDown();
            this.TB_ePassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_eServer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_ePassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_eUsername = new System.Windows.Forms.TextBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NM_Issue = new System.Windows.Forms.NumericUpDown();
            this.NM_MaxBooks = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_ePort)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Issue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_MaxBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Address";
            // 
            // TB_sAddress
            // 
            this.TB_sAddress.Location = new System.Drawing.Point(15, 62);
            this.TB_sAddress.Name = "TB_sAddress";
            this.TB_sAddress.Size = new System.Drawing.Size(266, 26);
            this.TB_sAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // TB_sDatabase
            // 
            this.TB_sDatabase.Location = new System.Drawing.Point(15, 118);
            this.TB_sDatabase.Name = "TB_sDatabase";
            this.TB_sDatabase.Size = new System.Drawing.Size(266, 26);
            this.TB_sDatabase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // TB_sUsername
            // 
            this.TB_sUsername.Location = new System.Drawing.Point(15, 174);
            this.TB_sUsername.Name = "TB_sUsername";
            this.TB_sUsername.Size = new System.Drawing.Size(266, 26);
            this.TB_sUsername.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // TB_sPassword1
            // 
            this.TB_sPassword1.Location = new System.Drawing.Point(15, 230);
            this.TB_sPassword1.Name = "TB_sPassword1";
            this.TB_sPassword1.PasswordChar = '*';
            this.TB_sPassword1.Size = new System.Drawing.Size(266, 26);
            this.TB_sPassword1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TB_sPassword2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_sAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_sPassword1);
            this.panel1.Controls.Add(this.TB_sDatabase);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_sUsername);
            this.panel1.Location = new System.Drawing.Point(30, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 333);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TB_sPassword2
            // 
            this.TB_sPassword2.Location = new System.Drawing.Point(16, 287);
            this.TB_sPassword2.Name = "TB_sPassword2";
            this.TB_sPassword2.PasswordChar = '*';
            this.TB_sPassword2.Size = new System.Drawing.Size(266, 26);
            this.TB_sPassword2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "SQL Server";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NM_ePort);
            this.panel2.Controls.Add(this.TB_ePassword2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TB_eServer);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TB_ePassword);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.TB_eUsername);
            this.panel2.Location = new System.Drawing.Point(358, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 333);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // NM_ePort
            // 
            this.NM_ePort.Location = new System.Drawing.Point(16, 116);
            this.NM_ePort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NM_ePort.Name = "NM_ePort";
            this.NM_ePort.Size = new System.Drawing.Size(265, 26);
            this.NM_ePort.TabIndex = 14;
            // 
            // TB_ePassword2
            // 
            this.TB_ePassword2.Location = new System.Drawing.Point(16, 287);
            this.TB_ePassword2.Name = "TB_ePassword2";
            this.TB_ePassword2.PasswordChar = '*';
            this.TB_ePassword2.Size = new System.Drawing.Size(266, 26);
            this.TB_ePassword2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email Server";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Server Address";
            // 
            // TB_eServer
            // 
            this.TB_eServer.Location = new System.Drawing.Point(15, 62);
            this.TB_eServer.Name = "TB_eServer";
            this.TB_eServer.Size = new System.Drawing.Size(266, 26);
            this.TB_eServer.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Port Number";
            // 
            // TB_ePassword
            // 
            this.TB_ePassword.Location = new System.Drawing.Point(15, 230);
            this.TB_ePassword.Name = "TB_ePassword";
            this.TB_ePassword.PasswordChar = '*';
            this.TB_ePassword.Size = new System.Drawing.Size(266, 26);
            this.TB_ePassword.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Username";
            // 
            // TB_eUsername
            // 
            this.TB_eUsername.Location = new System.Drawing.Point(15, 174);
            this.TB_eUsername.Name = "TB_eUsername";
            this.TB_eUsername.Size = new System.Drawing.Size(266, 26);
            this.TB_eUsername.TabIndex = 5;
            // 
            // BT_Save
            // 
            this.BT_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Save.Location = new System.Drawing.Point(849, 390);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(108, 48);
            this.BT_Save.TabIndex = 12;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.NM_Issue);
            this.panel3.Controls.Add(this.NM_MaxBooks);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(693, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 333);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // NM_Issue
            // 
            this.NM_Issue.Location = new System.Drawing.Point(52, 93);
            this.NM_Issue.Name = "NM_Issue";
            this.NM_Issue.Size = new System.Drawing.Size(147, 26);
            this.NM_Issue.TabIndex = 15;
            // 
            // NM_MaxBooks
            // 
            this.NM_MaxBooks.Location = new System.Drawing.Point(52, 205);
            this.NM_MaxBooks.Name = "NM_MaxBooks";
            this.NM_MaxBooks.Size = new System.Drawing.Size(147, 26);
            this.NM_MaxBooks.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 32);
            this.label14.TabIndex = 11;
            this.label14.Text = "System Settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Issue Period (Days)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(212, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Maximum Books allowed Out";
            // 
            // Configuration_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Configuration_Settings";
            this.Text = "Configuration Settings";
            this.Load += new System.EventHandler(this.Configuration_Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_ePort)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Issue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_MaxBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_sAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_sDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_sUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_sPassword1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_sPassword2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_ePassword2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_eServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_ePassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_eUsername;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.NumericUpDown NM_ePort;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown NM_MaxBooks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown NM_Issue;
    }
}