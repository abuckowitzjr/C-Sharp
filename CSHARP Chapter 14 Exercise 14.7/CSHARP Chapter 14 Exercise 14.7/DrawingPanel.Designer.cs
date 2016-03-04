namespace CSHARP_Chapter_14_Exercise_14._7
{
    partial class frmDrawingPanel
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
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.Location = new System.Drawing.Point(206, 107);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(292, 250);
            this.pnlDrawing.TabIndex = 0;
            this.pnlDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawing_Paint);
            // 
            // frmDrawingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 486);
            this.Controls.Add(this.pnlDrawing);
            this.Name = "frmDrawingPanel";
            this.Text = "Drawing Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawing;
    }
}

