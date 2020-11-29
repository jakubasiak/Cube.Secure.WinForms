using Cube.Secure.WinForms.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cube.Secure.WinForms
{
    public partial class RsaConvertTextDialog : Form
    {
        private readonly ActionType actionType;
        private readonly ICryptoProvider cryptoProvider;

        public RsaConvertTextDialog(ActionType actionType, ICryptoProvider cryptoProvider)
        {
            InitializeComponent();
            this.actionType = actionType;
            this.cryptoProvider = cryptoProvider;
            this.actionBtn.Text = this.actionType == ActionType.Encrypt ? "Encrypt" : "Decrypt";
        }

        private void pesteBtn_Click(object sender, EventArgs e)
        {
            this.keyTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openKeyDialog = new OpenFileDialog();

            openKeyDialog.Filter = "Text|*.txt";
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
                    this.richTextBox.Text = this.cryptoProvider.EncryptString(this.richTextBox.Text, this.keyTextBox.Text, true);
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
                    this.richTextBox.Text = this.cryptoProvider.DecryptString(this.richTextBox.Text, this.keyTextBox.Text, true);
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

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            if(this.actionType == ActionType.Encrypt)
            {
                var byteArray = ZipHelper.Zip(this.richTextBox.Text);
                if (byteArray.Length > 117)
                {
                    this.label2.Text = $"The text is too long for RSA encryption";
                }
                else
                {
                    this.label2.Text = "Text";
                }
            }
        }
    }
}
