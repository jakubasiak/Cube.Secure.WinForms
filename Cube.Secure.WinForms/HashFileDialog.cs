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
    public partial class HaschFileDialog : Form
    {
        public HaschFileDialog(string filePath)
        {
            InitializeComponent();
            if(!string.IsNullOrEmpty(filePath))
            {
                this.CalculateHashes(filePath);
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                var filePath = Path.GetFullPath(openFileDialog.FileName);
                this.CalculateHashes(filePath);
            }
        }

        private void CalculateHashes(string filePath)
        {
            this.filePathTextBox.Text = filePath;
            if (File.Exists(filePath))
            {
                this.MD5textBox.Text = this.GetMD5Hash(filePath);
                this.SHA1textBox.Text = this.GetSHA1Hash(filePath);
                this.SHA256textBox.Text = this.GetSHA256Hash(filePath);
                this.SHA384textBox.Text = this.GetSHA384Hash(filePath);
                this.SHA512textBox.Text = this.GetSHA512Hash(filePath);
            }
        }

        private string GetMD5Hash(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void copyMd5Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.MD5textBox.Text);
        }

        private string GetSHA1Hash(string filePath)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = sha1.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void copySHA1Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA1textBox.Text);
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

        private void copySHA256Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA256textBox.Text);
        }

        private string GetSHA384Hash(string filePath)
        {
            using (var sha384 = SHA384.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = sha384.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void copySHA384Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA384textBox.Text);
        }

        private string GetSHA512Hash(string filePath)
        {
            using (var sha512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = sha512.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void copySHA512Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA512textBox.Text);
        }
    }
}
