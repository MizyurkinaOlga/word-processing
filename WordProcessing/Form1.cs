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
using System.Configuration;

namespace WordProcessing
{
    public partial class Form1 : Form
    {
        char[] punctuationMarks = ConfigurationManager.AppSettings["punctuationMarks"].ToCharArray();
        OpenFileDialog ofd = new OpenFileDialog();
        StreamReader fileStream;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browseFile_Click(object sender, EventArgs e)
        {
            labelFilePreparation.Visible = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathSourceFile.Text = ofd.FileName;
                try
                {
                    if ((fileStream = new StreamReader(ofd.FileName)) != null)
                    {
                        labelFilePreparation.Visible = false;
                        labelDownloaded.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonReadWord_Click(object sender, EventArgs e)
        {
            string textLine;
            while ((textLine = fileStream.ReadLine()) != null)
            {
                int a = 5;
            }

        }
    }
}
