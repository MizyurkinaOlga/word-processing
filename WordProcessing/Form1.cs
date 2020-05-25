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

namespace WordProcessing
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        Stream fileStream;

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
                fileStream = ofd.OpenFile();
                labelFilePreparation.Visible = false;
                labelDownloaded.Visible = true;
            }

        }

        private void buttonReadWord_Click(object sender, EventArgs e)
        {
            byte[] tmp = new byte[30];
            fileStream.Read(tmp,0,20);
            label2.Text = System.Text.Encoding.Default.GetString(tmp);
            label2.Visible = true;
        }
    }
}
