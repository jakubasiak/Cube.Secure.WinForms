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
    public partial class HaschTextDialog : Form
    {
        public HaschTextDialog()
        {
            InitializeComponent();
        }

        private void CalculateHashes()
        {
            var textBytes = Encoding.UTF8.GetBytes(this.richTextBox.Text);
            this.MD5textBox.Text = this.GetMD5Hash(textBytes);
            this.SHA1textBox.Text = this.GetSHA1Hash(textBytes);
            this.SHA256textBox.Text = this.GetSHA256Hash(textBytes);
            this.SHA384textBox.Text = this.GetSHA384Hash(textBytes);
            this.SHA512textBox.Text = this.GetSHA512Hash(textBytes);        
        }

        private string GetMD5Hash(byte[] textBytes)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(textBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        private void copyMd5Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.MD5textBox.Text);
        }

        private string GetSHA1Hash(byte[] textBytes)
        {
            using (var sha1 = SHA1.Create())
            {
                var hash = sha1.ComputeHash(textBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        private void copySHA1Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA1textBox.Text);
        }

        private string GetSHA256Hash(byte[] textBytes)
        {
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(textBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        private void copySHA256Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA256textBox.Text);
        }

        private string GetSHA384Hash(byte[] textBytes)
        {
            using (var sha384 = SHA384.Create())
            {
                var hash = sha384.ComputeHash(textBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        private void copySHA384Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA384textBox.Text);
        }

        private string GetSHA512Hash(byte[] textBytes)
        {
            using (var sha512 = SHA512.Create())
            {
                var hash = sha512.ComputeHash(textBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        private void copySHA512Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA512textBox.Text);
        }

        private void copyTextBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.richTextBox.Text);
        }

        private void pesteTextBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            this.CalculateHashes();
        }
    }
}
