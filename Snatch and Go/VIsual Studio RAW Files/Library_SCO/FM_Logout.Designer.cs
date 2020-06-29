namespace Library_SCO
{
    partial class FM_Logout
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
            this.LB_Bye = new System.Windows.Forms.Label();
            this.LB_Receipt = new System.Windows.Forms.Label();
            this.BT_Yes = new System.Windows.Forms.Button();
            this.BT_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Bye
            // 
            this.LB_Bye.AutoSize = true;
            this.LB_Bye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Bye.ForeColor = System.Drawing.Color.White;
            this.LB_Bye.Location = new System.Drawing.Point(247, 37);
            this.LB_Bye.Name = "LB_Bye";
            this.LB_Bye.Size = new System.Drawing.Size(154, 32);
            this.LB_Bye.TabIndex = 0;
            this.LB_Bye.Text = "Bye Name";
            // 
            // LB_Receipt
            // 
            this.LB_Receipt.AutoSize = true;
            this.LB_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Receipt.ForeColor = System.Drawing.Color.White;
            this.LB_Receipt.Location = new System.Drawing.Point(248, 171);
            this.LB_Receipt.Name = "LB_Receipt";
            this.LB_Receipt.Size = new System.Drawing.Size(264, 29);
            this.LB_Receipt.TabIndex = 1;
            this.LB_Receipt.Text = "Do you want a Receipt?";
            // 
            // BT_Yes
            // 
            this.BT_Yes.Location = new System.Drawing.Point(72, 266);
            this.BT_Yes.Name = "BT_Yes";
            this.BT_Yes.Size = new System.Drawing.Size(216, 93);
            this.BT_Yes.TabIndex = 2;
            this.BT_Yes.Text = "Yes";
            this.BT_Yes.UseVisualStyleBackColor = true;
            this.BT_Yes.Click += new System.EventHandler(this.BT_Yes_Click);
            // 
            // BT_No
            // 
            this.BT_No.Location = new System.Drawing.Point(488, 266);
            this.BT_No.Name = "BT_No";
            this.BT_No.Size = new System.Drawing.Size(216, 93);
            this.BT_No.TabIndex = 3;
            this.BT_No.Text = "No";
            this.BT_No.UseVisualStyleBackColor = true;
            this.BT_No.Click += new System.EventHandler(this.BT_No_Click);
            // 
            // FM_Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_No);
            this.Controls.Add(this.BT_Yes);
            this.Controls.Add(this.LB_Receipt);
            this.Controls.Add(this.LB_Bye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FM_Logout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FM_Logout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FM_Logout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Bye;
        private System.Windows.Forms.Label LB_Receipt;
        private System.Windows.Forms.Button BT_Yes;
        private System.Windows.Forms.Button BT_No;
    }
}