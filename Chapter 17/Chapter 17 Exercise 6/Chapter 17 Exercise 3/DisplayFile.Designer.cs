namespace Chapter_17_Exercise_3
{
    partial class DisplayFile
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
            this.Display_txt = new System.Windows.Forms.TextBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Open_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display_txt
            // 
            this.Display_txt.Location = new System.Drawing.Point(9, 10);
            this.Display_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_txt.Multiline = true;
            this.Display_txt.Name = "Display_txt";
            this.Display_txt.ReadOnly = true;
            this.Display_txt.Size = new System.Drawing.Size(615, 113);
            this.Display_txt.TabIndex = 0;
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(319, 127);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(131, 31);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(184, 127);
            this.Open_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(131, 31);
            this.Open_btn.TabIndex = 2;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // DisplayFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(635, 163);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Display_txt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DisplayFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display_txt;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Open_btn;
    }
}