using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cube.Secure.WinForms
{
    public partial class PasswordDialog : Form
    {
        public string Password
        {
            get { return this.passwordTextBox.Text; }
        }

        public PasswordDialog(string actionName)
        {
            InitializeComponent();
            this.actionBtn.Text = actionName;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
