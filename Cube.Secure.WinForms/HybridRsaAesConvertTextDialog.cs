using Cube.Secure.WinForms.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cube.Secure.WinForms
{
    public partial class HybridRsaAesConvertTextDialog : Form
    {
        private readonly ActionType actionType;
        private readonly RSA rsaCryptoProvider;
        private readonly AES aesCryptoProvider;

        public HybridRsaAesConvertTextDialog(ActionType actionType, RSA rsaCryptoProvider, AES aesCryptoProvider)
        {
            InitializeComponent();
            this.actionType = actionType;
            this.rsaCryptoProvider = rsaCryptoProvider;
            this.aesCryptoProvider = aesCryptoProvider;
            this.actionBtn.Text = this.actionType == ActionType.Encrypt ? "Encrypt" : "Decrypt";
        }

        private void pesteBtn_Click(object sender, EventArgs e)
        {
            this.keyTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openKeyDialog = new OpenFileDialog();

            openKeyDialog.Filter = "XML-File | *.xml";
            openKeyDialog.RestoreDirectory = true;

            if (openKeyDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openKeyDialog.FileName))
                {
                    this.keyTextBox.Text = File.ReadAllText(Path.GetFullPath(openKeyDialog.FileName), Encoding.ASCII);
                }
            }
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (this.actionType == ActionType.Encrypt && !string.IsNullOrEmpty(this.richTextBox.Text) && !string.IsNullOrEmpty(this.keyTextBox.Text))
            {
                try
                {
                    var key = Guid.NewGuid();
                    var textBytes = Encoding.Unicode.GetBytes(this.richTextBox.Text);
                    var encryptedKey = this.rsaCryptoProvider.Encrypt(key.ToByteArray(), this.keyTextBox.Text);
                    var encryptedText = this.aesCryptoProvider.Encrypt(textBytes, key.ToString());
                    var concatedKeyAndText = encryptedKey.Concat(encryptedText).ToArray();
                    this.richTextBox.Text = Convert.ToBase64String(concatedKeyAndText);
                }
                catch (Exception ex)
                {
                    this.richTextBox.Text = "Can not encrypt the text";
                }
            }
            if (this.actionType == ActionType.Decrypt && !string.IsNullOrEmpty(this.richTextBox.Text) && !string.IsNullOrEmpty(this.keyTextBox.Text))
            {
                try
                {
                    var concatedKeyAndText = Convert.FromBase64String(this.richTextBox.Text);
                    var encryptedKey = concatedKeyAndText.Take(128).ToArray();
                    var encryptedText = concatedKeyAndText.Skip(128).ToArray();
                    var key = this.rsaCryptoProvider.Decrypt(encryptedKey, this.keyTextBox.Text);
                    var textBytes = this.aesCryptoProvider.Decrypt(encryptedText, new Guid(key).ToString());
                    this.richTextBox.Text = Encoding.Unicode.GetString(textBytes);
                }
                catch (Exception ex)
                {
                    this.richTextBox.Text = "Can not decrypt the text";
                }
            }
        }

        private void keyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.actionBtn.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.closeBtn.PerformClick();
            }
        }

        private void copyTextBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.richTextBox.Text);
        }

        private void pesteTextBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }
    }
}
