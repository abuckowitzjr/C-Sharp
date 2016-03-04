using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSHARP_Chapter_14_Exercise_14._7
{
    public partial class frmDrawingPanel : Form
    {
        bool shouldPaint = false; 
        private Color m_Color;
        private Size m_Size;
        private int mouse_x;
        private int mouse_y;

        //public DrawingPanel()
        //{
        //    InitializeComponent();
        //}

        private void pnlDrawing_MouseDown(object sender, MouseEventArgs e)
        {
        shouldPaint = true;
        }

        private void pnlDrawing_MouseUp(object sender, MouseEventArgs e)
        {
        shouldPaint = false;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        m_Color = Color.Red;
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        m_Color = Color.Blue;
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        m_Color = Color.Green;
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        m_Color = Color.Black;
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        m_Size = new Size(4,4);
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        m_Size = new Size(6, 6);
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        m_Size = new Size(12, 12);
        }

        private void pnlDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void pnlDrawing_Paint(object sender, PaintEventArgs e)
        {
        if (shouldPaint)
            {
            Graphics graphics = CreateGraphics();
            graphics.FillEllipse(new SolidBrush(m_Color), mouse_x, mouse_y, m_Size.Width, m_Size.Height);
            graphics.Dispose();
            }
        }
    }
}
