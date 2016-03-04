using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSHARP_Simple_Event_Example
{
    public partial class SimpleEventExample : Form
    {
        public SimpleEventExample()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked");
        }
    }
}
