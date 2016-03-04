namespace Chapter_17_Exercise_3
{
    partial class BankAccountInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstName_txt = new System.Windows.Forms.TextBox();
            this.LastName_txt = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.City_txt = new System.Windows.Forms.TextBox();
            this.State_txt = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Enter_btn = new System.Windows.Forms.Button();
            this.SaveAs_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewFileContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.ZipCode_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Yes_rb = new System.Windows.Forms.RadioButton();
            this.No_rb = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "State";
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Location = new System.Drawing.Point(70, 28);
            this.FirstName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.Size = new System.Drawing.Size(106, 20);
            this.FirstName_txt.TabIndex = 8;
            // 
            // LastName_txt
            // 
            this.LastName_txt.Location = new System.Drawing.Point(242, 28);
            this.LastName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.Size = new System.Drawing.Size(112, 20);
            this.LastName_txt.TabIndex = 9;
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(58, 52);
            this.Address_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(296, 20);
            this.Address_txt.TabIndex = 10;
            // 
            // City_txt
            // 
            this.City_txt.Location = new System.Drawing.Point(36, 76);
            this.City_txt.Margin = new System.Windows.Forms.Padding(2);
            this.City_txt.Name = "City_txt";
            this.City_txt.Size = new System.Drawing.Size(117, 20);
            this.City_txt.TabIndex = 11;
            // 
            // State_txt
            // 
            this.State_txt.Location = new System.Drawing.Point(192, 76);
            this.State_txt.Margin = new System.Windows.Forms.Padding(2);
            this.State_txt.Name = "State_txt";
            this.State_txt.Size = new System.Drawing.Size(40, 20);
            this.State_txt.TabIndex = 12;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(269, 122);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(85, 40);
            this.Exit_btn.TabIndex = 19;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Enter_btn
            // 
            this.Enter_btn.Location = new System.Drawing.Point(180, 122);
            this.Enter_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.Size = new System.Drawing.Size(85, 40);
            this.Enter_btn.TabIndex = 18;
            this.Enter_btn.Text = "Enter";
            this.Enter_btn.UseVisualStyleBackColor = true;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // SaveAs_btn
            // 
            this.SaveAs_btn.Location = new System.Drawing.Point(91, 122);
            this.SaveAs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveAs_btn.Name = "SaveAs_btn";
            this.SaveAs_btn.Size = new System.Drawing.Size(85, 40);
            this.SaveAs_btn.TabIndex = 17;
            this.SaveAs_btn.Text = "Save As";
            this.SaveAs_btn.UseVisualStyleBackColor = true;
            this.SaveAs_btn.Click += new System.EventHandler(this.SaveAs_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFileContentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewFileContentsToolStripMenuItem
            // 
            this.viewFileContentsToolStripMenuItem.Name = "viewFileContentsToolStripMenuItem";
            this.viewFileContentsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.viewFileContentsToolStripMenuItem.Text = "View File Contents";
            this.viewFileContentsToolStripMenuItem.Click += new System.EventHandler(this.viewFileContentsToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "\".txt\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ZipCode";
            // 
            // ZipCode_txt
            // 
            this.ZipCode_txt.Location = new System.Drawing.Point(287, 76);
            this.ZipCode_txt.Margin = new System.Windows.Forms.Padding(2);
            this.ZipCode_txt.Name = "ZipCode_txt";
            this.ZipCode_txt.Size = new System.Drawing.Size(68, 20);
            this.ZipCode_txt.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.No_rb);
            this.groupBox1.Controls.Add(this.Yes_rb);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(74, 85);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overdraft Protection";
            // 
            // Yes_rb
            // 
            this.Yes_rb.AutoSize = true;
            this.Yes_rb.Location = new System.Drawing.Point(15, 33);
            this.Yes_rb.Name = "Yes_rb";
            this.Yes_rb.Size = new System.Drawing.Size(43, 17);
            this.Yes_rb.TabIndex = 14;
            this.Yes_rb.Text = "Yes";
            this.Yes_rb.UseVisualStyleBackColor = true;
            // 
            // No_rb
            // 
            this.No_rb.AutoSize = true;
            this.No_rb.Checked = true;
            this.No_rb.Location = new System.Drawing.Point(15, 56);
            this.No_rb.Name = "No_rb";
            this.No_rb.Size = new System.Drawing.Size(39, 17);
            this.No_rb.TabIndex = 15;
            this.No_rb.TabStop = true;
            this.No_rb.Text = "No";
            this.No_rb.UseVisualStyleBackColor = true;
            // 
            // BankAccountInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(369, 192);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ZipCode_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Enter_btn);
            this.Controls.Add(this.SaveAs_btn);
            this.Controls.Add(this.State_txt);
            this.Controls.Add(this.City_txt);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.LastName_txt);
            this.Controls.Add(this.FirstName_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BankAccountInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account Entry";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstName_txt;
        private System.Windows.Forms.TextBox LastName_txt;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.TextBox City_txt;
        private System.Windows.Forms.TextBox State_txt;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Enter_btn;
        private System.Windows.Forms.Button SaveAs_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewFileContentsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ZipCode_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton No_rb;
        private System.Windows.Forms.RadioButton Yes_rb;
    }
}

