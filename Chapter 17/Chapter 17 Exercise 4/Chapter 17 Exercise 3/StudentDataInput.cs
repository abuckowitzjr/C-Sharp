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
    
    public partial class StudentDataInput : Form
    {
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        
        public StudentDataInput()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {
                    ((TextBox)guiControl).Clear();
                }
            }
        }

        private void SaveAs_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string FileName;

            using (SaveFileDialog FileChooser = new SaveFileDialog())
            {
                FileChooser.CheckFileExists = false;
                result = FileChooser.ShowDialog();
                FileName = FileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (FileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        output = new FileStream(FileName,
                            FileMode.OpenOrCreate, FileAccess.Write);
                        SaveAs_btn.Enabled = false;
                        Enter_btn.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            string FirstName = FirstName_txt.Text;
            string LastName = LastName_txt.Text;
            int ID = Int32.Parse(ID_txt.Text);
            string Class = Class_txt.Text;
            string Grade = Grade_txt.Text;

            DataSerializable data = new DataSerializable();

            if (FirstName != string.Empty && LastName != string.Empty && ID != null &&
                Class != string.Empty && Grade != string.Empty)
            {
                try
                {
                    data.FirstName = FirstName;
                    data.LastName = LastName;
                    data.ID = ID;
                    data.Class = Class;
                    data.Grade = Grade;

                    formatter.Serialize(output, data);
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            ClearTextBoxes();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {

            if (output != null)
            {
                try
                {
                    output.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            Application.Exit();
        }

        private void viewFileContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                try
                {
                    output.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                Enter_btn.Enabled = false;
            }
            DisplayFile display = new DisplayFile();
            display.ShowDialog(this);
        }
    }
}