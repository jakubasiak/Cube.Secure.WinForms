using Cube.Secure.WinForms.Logic;
using shortid;
using shortid.Configuration;
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
    public partial class KeysDialog : Form
    {
        public string Key
        {
            get { return this.keyRichTextBox.Text; }
        }

        public KeysDialog(ActionType actionType)
        {
            InitializeComponent();
            this.actionBtn.Text = actionType == ActionType.Encrypt ? "Encrypt" : "Decrypt";
            this.actionBtn.Focus();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.actionBtn.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.cancelBtn.PerformClick();
            }
        }

        private void pesteKeyBtn_Click(object sender, EventArgs e)
        {
            this.keyRichTextBox.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void importKeyBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openKeyDialog = new OpenFileDialog();

            openKeyDialog.Filter = "XML-File | *.xml";
            openKeyDialog.RestoreDirectory = true;

            if (openKeyDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openKeyDialog.FileName))
                {
                    this.keyRichTextBox.Text = File.ReadAllText(Path.GetFullPath(openKeyDialog.FileName), Encoding.ASCII);
                }
            }
        }
    }
}
