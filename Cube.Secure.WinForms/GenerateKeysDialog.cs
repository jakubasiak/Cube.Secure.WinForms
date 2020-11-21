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
    public partial class GenerateKeysDialog : Form
    {
        private readonly RSA rsa;
        private readonly string keyId;
        public GenerateKeysDialog()
        {
            InitializeComponent();
            this.rsa = new RSA();
            this.keyId = this.GenerateId();
            this.publicKeyRichTextBox.Text = this.rsa.GetPublicKey();
            this.privateKeyRichTextBox.Text = this.rsa.GetPrivateKey();
        }

        private void copyPrivateKeyBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.privateKeyRichTextBox.Text);
        }

        private void copyPublicKeyBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.publicKeyRichTextBox.Text);
        }

        private void saveKeyBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveKeysFileDialog = new SaveFileDialog();

            saveKeysFileDialog.Filter = "XML-File | *.xml";
            saveKeysFileDialog.FileName = this.keyId;
            saveKeysFileDialog.RestoreDirectory = true;

            if (saveKeysFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveKeysFileDialog.FileName))
                {
                    File.WriteAllText(this.AddSuffix(Path.GetFullPath(saveKeysFileDialog.FileName), "_Public_Key"), this.publicKeyRichTextBox.Text);
                    File.WriteAllText(this.AddSuffix(Path.GetFullPath(saveKeysFileDialog.FileName), "_Private_Key"), this.privateKeyRichTextBox.Text);
                }
            }
        }

        private string GenerateId()
        {
            return ShortId.Generate(new GenerationOptions() { 
                Length = 8,
                UseNumbers = true,
                UseSpecialCharacters = false
            });
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
