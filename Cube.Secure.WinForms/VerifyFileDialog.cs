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
    public partial class VerifyFileDialog : Form
    {
        private byte[] hash;
        private readonly Logic.RSA rsa;

        public VerifyFileDialog(string filePath, Cube.Secure.WinForms.Logic.RSA rsa)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(filePath))
            {
                this.CalculateHashes(filePath);
                var defaultSignatureFileName = this.GetSignatureDefaultFileName(filePath);
                if (File.Exists(defaultSignatureFileName))
                {
                    this.signatureTextBox.Text = defaultSignatureFileName;
                }
            }

            this.rsa = rsa;
        }

        private void openSignatureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSignatureDialog = new OpenFileDialog();
            openSignatureDialog.Multiselect = false;
            openSignatureDialog.Filter = "Text|*.txt";
            openSignatureDialog.RestoreDirectory = true;

            if (openSignatureDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openSignatureDialog.FileName))
            {
                var filePath = Path.GetFullPath(openSignatureDialog.FileName);
                this.signatureTextBox.Text = filePath;
            }
            this.resultLabel.Text = string.Empty;
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
            this.resultLabel.Text = string.Empty;
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
            this.resultLabel.Text = string.Empty;
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
            this.resultLabel.Text = string.Empty;
        }

        private string GetSignatureDefaultFileName(string filename)
        {
            string fDir = Path.GetDirectoryName(filename);
            string fName = Path.GetFileNameWithoutExtension(filename);
            return Path.Combine(fDir, String.Concat(fName, "_Signature", ".txt"));
        }

        private void verifyFileBtn_Click(object sender, EventArgs e)
        {
            if(File.Exists(this.signatureTextBox.Text) && !string.IsNullOrEmpty(this.keyRichTextBox.Text) && hash.Length > 0)
            {
                var signature = File.ReadAllText(this.signatureTextBox.Text, Encoding.ASCII);
                try
                {
                    var result = this.rsa.VerifySignature(hash, signature, this.keyRichTextBox.Text);
                    this.resultLabel.Text = result ? "Positive verification" : "Negative verification";
                }
                catch (Exception ex)
                {
                    this.resultLabel.Text = ex.Message;
                }
            }
        }
    }
}
