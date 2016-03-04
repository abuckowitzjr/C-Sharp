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

namespace Chapter_17_Exercise_3
{
    
    public partial class BankAccountInput : Form
    {
        private StreamWriter fileWriter;
        
        public BankAccountInput()
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
                FileChooser.DefaultExt = ".txt";
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
                        FileStream output = new FileStream(FileName, FileMode.OpenOrCreate,
                            FileAccess.Write);
                        fileWriter = new StreamWriter(output);
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
            string Address = Address_txt.Text;
            string City = City_txt.Text;
            string State = State_txt.Text;
            string ZipCode = ZipCode_txt.Text;
            bool OverdraftProtection = false;

            if (Yes_rb.Checked == true)
                OverdraftProtection = true;

            if (FirstName != string.Empty && LastName != string.Empty && Address != string.Empty &&
                City != string.Empty && State != string.Empty && ZipCode != string.Empty)
            {
                try
                {
                    if (OverdraftProtection == true)
                    {
                    fileWriter.WriteLine(LastName + ", " + FirstName + ": " +
                        Address + ", " + City + ", " + State + "  " + ZipCode + "     Overdraft Protection: " + "Yes");
                    }
                    else
                    {
                        fileWriter.WriteLine(LastName + ", " + FirstName + ": " +
                        Address + ", " + City + ", " + State + "  " + ZipCode + "     Overdraft Protection: " + "No");
                    }
                }
                catch (IOException)
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
            No_rb.Checked = true;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {

            if (fileWriter != null)
            {
                try
                {
                    fileWriter.Close();
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
            if (fileWriter != null)
            {
                try
                {
                    fileWriter.Close();
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