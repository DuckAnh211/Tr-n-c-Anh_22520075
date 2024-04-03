using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _22520075_Lab2
{
    public partial class Bai02 : Form
    {
        private readonly string? filePath;

        public Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                richTextBox1.Text = fileContent;
                textBox1.Text = Path.GetFileName(filePath);
                textBox3.Text = filePath;
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSizeInBytes = GetFileSize(filePath);
                string fileSizeString = FormatFileSize(fileSizeInBytes);
                textBox2.Text = fileSizeString;
                string[] lines = fileContent.Split('\n');
                int numberOfLines = lines.Length;
                int numberOfWords = 0;
                int numberOfCharacters = 0;
                foreach (string line in lines)
                {
                    numberOfWords += line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    numberOfCharacters += line.Length;
                }

                textBox4.Text = numberOfLines.ToString();
                textBox5.Text = numberOfWords.ToString();
                textBox6.Text = numberOfCharacters.ToString();

            }
        }

        private long GetFileSize(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }
        private string FormatFileSize(long fileSizeInBytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double fileSize = fileSizeInBytes;

            while (fileSize >= 1024 && order < sizes.Length - 1)
            {
                order++;
                fileSize /= 1024;
            }

            return string.Format("{0:0.##} {1}", fileSize, sizes[order]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
