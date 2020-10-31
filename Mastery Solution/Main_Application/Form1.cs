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

//Written by Spencer Johnson

namespace Main_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma Separated Values|*.csv|Text File|*.txt",
                Title = @"Select the Hundred Names database"
            };

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show(

                    openFileDialog.SafeFileName,
                    @"You Selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFileName.Text = openFileDialog.SafeFileName;

                toolStripStatusLabel1.Text = openFileDialog.FileName;

                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    var oneLineOfText = "";
                    while ((oneLineOfText = sr.ReadLine()) != null)
                    {
                        lbFileOutput.Items.Add(oneLineOfText);
                    }
                }
            }
        }

        
    }
}
