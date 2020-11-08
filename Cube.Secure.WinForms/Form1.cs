using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Cube.Secure.WinForms
{
    public partial class Form1 : Form
    {
        string currentDirectory = string.Empty;
        List<string> paths = new List<string>();
        List<string> selectedPaths = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select your path";
                if(folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                {
                    RefreashFileList(folderBrowserDialog.SelectedPath);
                }

            }
        }

        private void RefreashFileList(string path)
        {
            this.currentDirectory = path;
            this.pathTextBox.Text = path;
            this.fileImageList.Images.Clear();
            this.listView.Items.Clear();
            this.paths.Clear();

            this.fileImageList.Images.Add(new Icon(Path.Combine(Environment.CurrentDirectory, @"Assets\", "back.ico")));
            DirectoryInfo currentDirectoryInfo = Directory.GetParent(this.currentDirectory);
            this.paths.Add(currentDirectoryInfo.FullName);
            this.listView.Items.Add(currentDirectoryInfo.Name, 0);

            var directories = Directory.GetDirectories(this.currentDirectory);
            for (int i = 0; i < directories.Length; i++)
            {
                this.fileImageList.Images.Add(new Icon(Path.Combine(Environment.CurrentDirectory, @"Assets\", "blank.ico")));
                DirectoryInfo directoryInfo = new DirectoryInfo(directories[i]);
                this.paths.Add(directoryInfo.FullName);
                this.listView.Items.Add(directoryInfo.Name, 1);
            }

            var files = Directory.GetFiles(this.currentDirectory);
            for (int i = 0; i < files.Length; i++)
            {
                this.fileImageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(files[i]));
                DirectoryInfo directoryInfo = new DirectoryInfo(files[i]);
                this.paths.Add(directoryInfo.FullName);
                this.listView.Items.Add(directoryInfo.Name, this.fileImageList.Images.Count - 1);
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            var selectedPath = this.paths[this.listView.SelectedIndices[0]];
            if (Directory.Exists(selectedPath))
            {
                this.RefreashFileList(selectedPath);
            }
        }

        private void listView_Click(object sender, EventArgs e)
        {
            var names = new List<string>();
            foreach (int index in this.listView.SelectedIndices)
            {
                var fullPath = this.paths[index];
                var name = Path.GetFileName(fullPath);
                names.Add(name);
                //names.Add(fullPath);
                this.selectedPaths.Add(fullPath);
            }

            this.ItemNames.Text = $"Names: {string.Join(", ", names)}";
            this.SelectedItems.Text = $"Selected: {this.listView.SelectedIndices.Count}";
        }
    }
}
