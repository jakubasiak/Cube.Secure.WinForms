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
    public partial class CompareTextDialog : Form
    {
        public CompareTextDialog()
        {
            InitializeComponent();
        }

        private void CalculateFirstHash()
        {
            var textBytes = Encoding.UTF8.GetBytes(this.firstTextRichTextBox.Text);
            this.firstTextSHA256textBox.Text = this.GetSHA256Hash(textBytes);      
        }

        private void CalculateSecondHash()
        {
            var textBytes = Encoding.UTF8.GetBytes(this.secondTextRichTextBox.Text);
            this.secondTextSHA256textBox.Text = this.GetSHA256Hash(textBytes);
        }

        private string GetSHA256Hash(byte[] textBytes)
        {
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(textBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        private void firstTextCopySHA256Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.firstTextSHA256textBox.Text);
        }

        private void secondTextCopySHA256Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.secondTextSHA256textBox.Text);
        }

        private void firstTextCopyTextBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.firstTextRichTextBox.Text);
        }

        private void firstTextPesteTextBtn_Click(object sender, EventArgs e)
        {
            this.firstTextRichTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void secondTextCopyTextBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.secondTextRichTextBox.Text);
        }

        private void secondTextPesteTextBtn_Click(object sender, EventArgs e)
        {
            this.secondTextRichTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void firstTextRichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.CalculateFirstHash();
            this.resultLabel.Text = string.Compare(this.firstTextSHA256textBox.Text, this.secondTextSHA256textBox.Text, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? "Texts are the same" : "Texts are different";
        }

        private void secondTextRichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.CalculateSecondHash();
            this.resultLabel.Text = string.Compare(this.firstTextSHA256textBox.Text, this.secondTextSHA256textBox.Text, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? "Texts are the same" : "Texts are different";
        }
    }
}
