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
    public partial class SignFileDialog : Form
    {
        private byte[] hash;
        private readonly Logic.RSA rsa;

        public SignFileDialog(string filePath, Cube.Secure.WinForms.Logic.RSA rsa)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(filePath))
            {
                this.CalculateHashes(filePath);
            }

            this.rsa = rsa;
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
                this.SHA256textBox.Text = this.GetSHA256Hash(filePath);
            }
        }

        private string GetSHA256Hash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    this.hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void copySHA256Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SHA256textBox.Text);
        }

        private void pesteKeyBtn_Click(object sender, EventArgs e)
        {
            this.keyRichTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void importKeyBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openKeyDialog = new OpenFileDialog();

            openKeyDialog.Filter = "Text|*.txt";
            openKeyDialog.RestoreDirectory = true;

            if (openKeyDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openKeyDialog.FileName))
                {
                    this.keyRichTextBox.Text = File.ReadAllText(Path.GetFullPath(openKeyDialog.FileName), Encoding.ASCII);
                }
            }
        }

        private void signFileBtn_Click(object sender, EventArgs e)
        {
            var signature = this.rsa.SignData(this.hash, this.keyRichTextBox.Text);

            SaveFileDialog saveSignatureFileDialog = new SaveFileDialog();

            saveSignatureFileDialog.Filter = "Text|*.txt";
            saveSignatureFileDialog.FileName = $"{Path.GetFileNameWithoutExtension(this.filePathTextBox.Text)}_Signature.txt";
            saveSignatureFileDialog.RestoreDirectory = true;

            if (saveSignatureFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveSignatureFileDialog.FileName))
                {
                    File.WriteAllText(saveSignatureFileDialog.FileName, signature, Encoding.ASCII);
                }
            }
        }

        private string AddSuffix(string filename, string suffix)
        {
            string fDir = Path.GetDirectoryName(filename);
            string fName = Path.GetFileNameWithoutExtension(filename);
            string fExt = Path.GetExtension(filename);
            return Path.Combine(fDir, String.Concat(fName, suffix, fExt));
        }
    }
}
