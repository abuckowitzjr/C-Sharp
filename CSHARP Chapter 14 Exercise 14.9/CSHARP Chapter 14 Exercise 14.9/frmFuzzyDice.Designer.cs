namespace CSHARP_Chapter_14_Exercise_14._9
{
    partial class frmFuzzyDice
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
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtShippingAddress = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.cbBlack = new System.Windows.Forms.CheckBox();
            this.gbDiceColor = new System.Windows.Forms.GroupBox();
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbBlue = new System.Windows.Forms.CheckBox();
            this.cbGreen = new System.Windows.Forms.CheckBox();
            this.cbYellow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDiceColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOrderNumber.Location = new System.Drawing.Point(31, 29);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(205, 22);
            this.txtOrderNumber.TabIndex = 0;
            this.txtOrderNumber.Text = "Enter Order Number Here";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCustomerName.Location = new System.Drawing.Point(31, 57);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(205, 22);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Text = "Enter Customer Name";
            // 
            // txtShippingAddress
            // 
            this.txtShippingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtShippingAddress.Location = new System.Drawing.Point(31, 85);
            this.txtShippingAddress.Name = "txtShippingAddress";
            this.txtShippingAddress.Size = new System.Drawing.Size(205, 22);
            this.txtShippingAddress.TabIndex = 2;
            this.txtShippingAddress.Text = "Enter Shipping Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSHARP_Chapter_14_Exercise_14._9.Properties.Resources.fuzzydice;
            this.pictureBox1.Location = new System.Drawing.Point(417, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderQuantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOrderQuantity.Location = new System.Drawing.Point(31, 175);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(205, 22);
            this.txtOrderQuantity.TabIndex = 4;
            this.txtOrderQuantity.Text = "Enter Quantity To Order";
            // 
            // cbBlack
            // 
            this.cbBlack.AutoSize = true;
            this.cbBlack.Location = new System.Drawing.Point(27, 31);
            this.cbBlack.Name = "cbBlack";
            this.cbBlack.Size = new System.Drawing.Size(64, 21);
            this.cbBlack.TabIndex = 5;
            this.cbBlack.Text = "Black";
            this.cbBlack.UseVisualStyleBackColor = true;
            // 
            // gbDiceColor
            // 
            this.gbDiceColor.Controls.Add(this.cbYellow);
            this.gbDiceColor.Controls.Add(this.cbRed);
            this.gbDiceColor.Controls.Add(this.cbGreen);
            this.gbDiceColor.Controls.Add(this.cbBlack);
            this.gbDiceColor.Controls.Add(this.cbBlue);
            this.gbDiceColor.Location = new System.Drawing.Point(79, 321);
            this.gbDiceColor.Name = "gbDiceColor";
            this.gbDiceColor.Size = new System.Drawing.Size(122, 177);
            this.gbDiceColor.TabIndex = 6;
            this.gbDiceColor.TabStop = false;
            this.gbDiceColor.Text = "Dice Color";
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Location = new System.Drawing.Point(27, 58);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(56, 21);
            this.cbRed.TabIndex = 7;
            this.cbRed.Text = "Red";
            this.cbRed.UseVisualStyleBackColor = true;
            // 
            // cbBlue
            // 
            this.cbBlue.AutoSize = true;
            this.cbBlue.Location = new System.Drawing.Point(27, 85);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(58, 21);
            this.cbBlue.TabIndex = 8;
            this.cbBlue.Text = "Blue";
            this.cbBlue.UseVisualStyleBackColor = true;
            // 
            // cbGreen
            // 
            this.cbGreen.AutoSize = true;
            this.cbGreen.Location = new System.Drawing.Point(27, 112);
            this.cbGreen.Name = "cbGreen";
            this.cbGreen.Size = new System.Drawing.Size(70, 21);
            this.cbGreen.TabIndex = 9;
            this.cbGreen.Text = "Green";
            this.cbGreen.UseVisualStyleBackColor = true;
            // 
            // cbYellow
            // 
            this.cbYellow.AutoSize = true;
            this.cbYellow.Location = new System.Drawing.Point(27, 139);
            this.cbYellow.Name = "cbYellow";
            this.cbYellow.Size = new System.Drawing.Size(70, 21);
            this.cbYellow.TabIndex = 10;
            this.cbYellow.Text = "Yellow";
            this.cbYellow.UseVisualStyleBackColor = true;
            // 
            // frmFuzzyDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 588);
            this.Controls.Add(this.gbDiceColor);
            this.Controls.Add(this.txtOrderQuantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtShippingAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtOrderNumber);
            this.Name = "frmFuzzyDice";
            this.Text = "Fuzzy Dice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDiceColor.ResumeLayout(false);
            this.gbDiceColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtShippingAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.CheckBox cbBlack;
        private System.Windows.Forms.GroupBox gbDiceColor;
        private System.Windows.Forms.CheckBox cbYellow;
        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbGreen;
        private System.Windows.Forms.CheckBox cbBlue;
    }
}

