namespace Project
{
    partial class GenreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenreForm));
            this.BT_Exit = new System.Windows.Forms.Button();
            this.BT_Add = new System.Windows.Forms.Button();
            this.RTF_Description = new System.Windows.Forms.RichTextBox();
            this.LB_Description = new System.Windows.Forms.Label();
            this.NUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.btnUpdateGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Exit
            // 
            this.BT_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.BT_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Exit.ForeColor = System.Drawing.Color.White;
            this.BT_Exit.Location = new System.Drawing.Point(26, 181);
            this.BT_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(141, 34);
            this.BT_Exit.TabIndex = 5;
            this.BT_Exit.Text = "Cancel";
            this.BT_Exit.UseVisualStyleBackColor = false;
            // 
            // BT_Add
            // 
            this.BT_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.BT_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Add.ForeColor = System.Drawing.Color.White;
            this.BT_Add.Location = new System.Drawing.Point(173, 181);
            this.BT_Add.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(141, 34);
            this.BT_Add.TabIndex = 14;
            this.BT_Add.Text = "Add Genre";
            this.BT_Add.UseVisualStyleBackColor = false;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // RTF_Description
            // 
            this.RTF_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTF_Description.Location = new System.Drawing.Point(26, 88);
            this.RTF_Description.Margin = new System.Windows.Forms.Padding(2);
            this.RTF_Description.MaxLength = 3000;
            this.RTF_Description.Name = "RTF_Description";
            this.RTF_Description.Size = new System.Drawing.Size(288, 67);
            this.RTF_Description.TabIndex = 3;
            this.RTF_Description.Text = "";
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.ForeColor = System.Drawing.Color.White;
            this.LB_Description.Location = new System.Drawing.Point(23, 73);
            this.LB_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(60, 13);
            this.LB_Description.TabIndex = 12;
            this.LB_Description.Text = "Description";
            // 
            // NUD
            // 
            this.NUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD.Location = new System.Drawing.Point(172, 38);
            this.NUD.Margin = new System.Windows.Forms.Padding(2);
            this.NUD.Name = "NUD";
            this.NUD.Size = new System.Drawing.Size(144, 20);
            this.NUD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Age Rating";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.ForeColor = System.Drawing.Color.White;
            this.LB_Name.Location = new System.Drawing.Point(23, 22);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(35, 13);
            this.LB_Name.TabIndex = 9;
            this.LB_Name.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Name.Location = new System.Drawing.Point(24, 38);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(140, 20);
            this.TB_Name.TabIndex = 1;
            // 
            // btnUpdateGen
            // 
            this.btnUpdateGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnUpdateGen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdateGen.ForeColor = System.Drawing.Color.White;
            this.btnUpdateGen.Location = new System.Drawing.Point(172, 181);
            this.btnUpdateGen.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateGen.Name = "btnUpdateGen";
            this.btnUpdateGen.Size = new System.Drawing.Size(141, 34);
            this.btnUpdateGen.TabIndex = 4;
            this.btnUpdateGen.Text = "Update Genre";
            this.btnUpdateGen.UseVisualStyleBackColor = false;
            this.btnUpdateGen.Click += new System.EventHandler(this.btnUpdateGen_Click);
            // 
            // GenreForm
            // 
            this.AcceptButton = this.btnUpdateGen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.CancelButton = this.BT_Exit;
            this.ClientSize = new System.Drawing.Size(347, 257);
            this.Controls.Add(this.btnUpdateGen);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.RTF_Description);
            this.Controls.Add(this.LB_Description);
            this.Controls.Add(this.NUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.TB_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(363, 296);
            this.Name = "GenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGenre";
            this.Load += new System.EventHandler(this.GenreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.RichTextBox RTF_Description;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.NumericUpDown NUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button btnUpdateGen;
    }
}