namespace CSHARP_Chapter_14_Exercise_14._6
{
    partial class TemperatureConversion
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
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblCelsiusOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(104, 25);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(207, 22);
            this.txtFahrenheit.TabIndex = 0;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(22, 28);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(76, 17);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(122, 86);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(95, 32);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(22, 161);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(53, 17);
            this.lblCelsius.TabIndex = 3;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblCelsiusOutput
            // 
            this.lblCelsiusOutput.Location = new System.Drawing.Point(81, 161);
            this.lblCelsiusOutput.Name = "lblCelsiusOutput";
            this.lblCelsiusOutput.Size = new System.Drawing.Size(230, 23);
            this.lblCelsiusOutput.TabIndex = 4;
            // 
            // TemperatureConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 205);
            this.Controls.Add(this.lblCelsiusOutput);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.Name = "TemperatureConversion";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblCelsiusOutput;
    }
}

