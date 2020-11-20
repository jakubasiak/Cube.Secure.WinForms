using Cube.Secure.WinForms.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cube.Secure.WinForms
{
    public partial class ConvertTextDialog : Form
    {
        private readonly ActionType actionType;
        private readonly ICryptoProvider cryptoProvider;

        public ConvertTextDialog(ActionType actionType, ICryptoProvider cryptoProvider)
        {
            InitializeComponent();
            this.actionBtn.Text = actionType == ActionType.Encrypt ? "Encrypt" : "Decrypt";
            this.actionBtn.Focus();
            this.actionType = actionType;
            this.cryptoProvider = cryptoProvider;
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if(this.actionType == ActionType.Encrypt && !string.IsNullOrEmpty(this.richTextBox1.Text) && !string.IsNullOrEmpty(this.passwordTextBox.Text))
            {
                try
                {
                    this.richTextBox1.Text = this.cryptoProvider.EncryptString(this.richTextBox1.Text, this.passwordTextBox.Text);
                }
                catch (Exception)
                {
                    this.richTextBox1.Text = "Can not encrypt the text";
                }
            }
            if (this.actionType == ActionType.Decrypt && !string.IsNullOrEmpty(this.richTextBox1.Text) && !string.IsNullOrEmpty(this.passwordTextBox.Text))
            {
                try
                {
                    this.richTextBox1.Text = this.cryptoProvider.DecryptString(this.richTextBox1.Text, this.passwordTextBox.Text);
                }
                catch (Exception)
                {
                    this.richTextBox1.Text = "Can not decrypt the text";
                }
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
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
            System.Windows.Forms.Clipboard.SetText(this.richTextBox1.Text);
        }
    }
}
