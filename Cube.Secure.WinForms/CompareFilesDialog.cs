using Cube.Secure.WinForms.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cube.Secure.WinForms
{
    public partial class CompareFilesDialog : Form
    {
        public CompareFilesDialog(string firstFilePath, string secondFilePath)
        {
            InitializeComponent();
            if(!string.IsNullOrEmpty(firstFilePath))
            {
                this.CalculateFirstHash(firstFilePath);
            }
            if (!string.IsNullOrEmpty(secondFilePath))
            {
                this.CalculateSecondHash(secondFilePath);
            }
        }

        private void CalculateFirstHash(string filePath)
        {
            this.firstFileTextBox.Text = filePath;
            if (File.Exists(filePath))
            {
                this.firstFileSHA256textBox.Text = this.GetSHA256Hash(filePath);
            }
        }

        private void CalculateSecondHash(string filePath)
        {
            this.secondFileTextBox.Text = filePath;
            if (File.Exists(filePath))
            {
                this.secondFileSHA256textBox.Text = this.GetSHA256Hash(filePath);
            }
        }

        private string GetSHA256Hash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void firstFileCopySHA256Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.firstFileSHA256textBox.Text);
        }

        private void secondFileCopySHA256Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.secondFileSHA256textBox.Text);
        }

        private void openFirstFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                var filePath = Path.GetFullPath(openFileDialog.FileName);
                this.CalculateFirstHash(filePath);
            }
        }

        private void openSecondFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                var filePath = Path.GetFullPath(openFileDialog.FileName);
                this.CalculateSecondHash(filePath);
            }
        }

        private void hash_TextChanged(object sender, EventArgs e)
        {
            this.resultLabel.Text = string.Compare(this.firstFileSHA256textBox.Text, this.secondFileSHA256textBox.Text, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? "Files are the same" : "Files are different";
        }
    }
}
