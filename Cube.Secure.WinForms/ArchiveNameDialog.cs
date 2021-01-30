using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cube.Secure.WinForms
{
    public partial class ArchiveNameDialog : Form
    {
        public string ArchiveName
        {
            get { return this.archiveNameTextBox.Text; }
        }

        public ArchiveNameDialog()
        {
            InitializeComponent();
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
    }
}
