using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Chapter_17_Exercise_3
{
    public partial class DisplayFile : Form
    {
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input;

        public DisplayFile()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if(result == DialogResult.OK)
            {
                Display_txt.Clear();

                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        input = new FileStream(fileName, 
                            FileMode.Open, FileAccess.Read);

                        

                        Open_btn.Enabled = false;

                        DataSerializable data = (DataSerializable)reader.Deserialize(input);
                        Display_txt.Text = data.LastName + ", " + data.FirstName + ": " + Convert.ToString(data.ID) + " " + data.Class + " " + data.Grade;  
                    }
                    catch(IOException)
                    {
                        MessageBox.Show("Error Reading From File", "File Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
