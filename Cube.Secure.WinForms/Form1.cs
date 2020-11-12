using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cube.Secure.WinForms.Logic;

namespace Cube.Secure.WinForms
{
    public partial class Form1 : Form
    {
        private AES aes;
        public AES Aes
        {
            get
            {
                if (this.aes == null)
                {
                    this.aes = new AES();
                }
                return this.aes;
            }
        }
        string currentDirectory = string.Empty;
        List<string> paths = new List<string>();
        List<string> selectedPaths = new List<string>();
        BackgroundWorker worker;
        public Form1()
        {
            InitializeComponent();
            this.worker = new BackgroundWorker();
            this.worker.ProgressChanged += Worker_ProgressChanged;
            //this.worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            this.worker.WorkerReportsProgress = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    this.toolStripProgressBar.Value = 0;
        //}

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar.Value = e.ProgressPercentage;
        }

        private void openDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select your path";
                if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
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

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (this.selectedPaths.Any())
            {
                PasswordDialog passwordDialog = new PasswordDialog("Encypt");
                passwordDialog.StartPosition = FormStartPosition.CenterParent;
                var result = passwordDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
                {
                    var password = passwordDialog.Password;
                    var allFilePaths = this.GetAllFilePaths();

                    DoWorkEventHandler encrypt = (object sender, DoWorkEventArgs e) => 
                    {
                        for (int i = 0; i < allFilePaths.Count; i++)
                        {
                            var file = File.ReadAllBytes(allFilePaths[i]);
                            var encryptedFile = this.Aes.Encrypt(file, password);
                            File.WriteAllBytes(allFilePaths[i], encryptedFile);
                            this.worker.ReportProgress((int)(((float)i / allFilePaths.Count) * 100.0f));
                            this.toolStripProgressBar.Increment(5);
                        }
                    };

                    this.worker.DoWork += encrypt;
                    this.worker.RunWorkerAsync();
                    this.worker.DoWork -= encrypt;
                }
            }
        }


        private void decrypt_Click(object sender, EventArgs e)
        {
            PasswordDialog passwordDialog = new PasswordDialog("Decrypt");
            passwordDialog.StartPosition = FormStartPosition.CenterParent;
            var result = passwordDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
            {
                var password = passwordDialog.Password;
                var allFilePaths = this.GetAllFilePaths();

                Task.Run(() =>
                {
                    foreach (var path in allFilePaths)
                    {
                        var file = File.ReadAllBytes(path);
                        var decryptedFile = this.Aes.Decrypt(file, password);
                        File.WriteAllBytes(path, decryptedFile);
                    }
                });
            }
        }

        private void encryptWithNamesBtn_Click(object sender, EventArgs e)
        {
            PasswordDialog passwordDialog = new PasswordDialog("Encypt");
            passwordDialog.StartPosition = FormStartPosition.CenterParent;
            var result = passwordDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
            {
                var password = passwordDialog.Password;
                var allFilePaths = this.GetAllFilePaths();

                Task.Run(() =>
                {
                    foreach (var path in allFilePaths)
                    {
                        var file = File.ReadAllBytes(path);
                        var encryptedFile = this.Aes.Encrypt(file, password);
                        var encryptedFileName = this.GetEncryptedFileName(path, password);
                        File.WriteAllBytes(encryptedFileName, encryptedFile);
                        File.Delete(path);
                    }
                });

                this.RefreashFileList(this.currentDirectory);
            }
        }

        private void decryptWithNamesBtn_Click(object sender, EventArgs e)
        {
            PasswordDialog passwordDialog = new PasswordDialog("Decrypt");
            passwordDialog.StartPosition = FormStartPosition.CenterParent;
            var result = passwordDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
            {
                var password = passwordDialog.Password;
                var allFilePaths = this.GetAllFilePaths();

                Task.Run(() =>
                {
                    foreach (var path in allFilePaths)
                    {
                        var file = File.ReadAllBytes(path);
                        var decryptedFile = this.Aes.Decrypt(file, password);
                        var decryptedFileName = this.GetDecryptedFileName(path, password);
                        File.WriteAllBytes(decryptedFileName, decryptedFile);
                        File.Delete(path);
                    }
                });

                this.RefreashFileList(this.currentDirectory);
            }
        }

        private void listView_Click(object sender, EventArgs e)
        {
            this.selectedPaths.Clear();
            var names = new List<string>();
            foreach (int index in this.listView.SelectedIndices)
            {
                var fullPath = this.paths[index];
                var name = Path.GetFileName(fullPath);
                names.Add(name);
                this.selectedPaths.Add(fullPath);
                this.ItemNames.Text = $"Names: {string.Join(", ", names)}";
                this.SelectedItems.Text = $"Selected: {this.listView.SelectedIndices.Count}";
            }
        }

        private List<string> GetAllFilePaths()
        {
            var allFilePaths = new List<string>();

            foreach (var path in this.selectedPaths)
            {
                if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
                {
                    allFilePaths.AddRange(Directory.GetFiles(path, "*.*",
                        SearchOption.AllDirectories));
                }
                else
                {
                    allFilePaths.Add(path);
                }
            }

            return allFilePaths;
        }

        private string GetEncryptedFileName(string path, string password)
        {
            var filePath = Path.GetDirectoryName(path);
            var fileName = Path.GetFileName(path);
            var bytesFileName = Encoding.UTF8.GetBytes(fileName);
            var encryptedFileName = Convert.ToBase64String(bytesFileName);

            return filePath + Path.DirectorySeparatorChar + encryptedFileName;
        }

        private string GetDecryptedFileName(string path, string password)
        {
            var filePath = Path.GetDirectoryName(path);
            var fileName = Path.GetFileName(path);
            var bytesFileName = Convert.FromBase64String(fileName);
            var decryptedFileName = Encoding.UTF8.GetString(bytesFileName);

            return filePath + Path.DirectorySeparatorChar + decryptedFileName;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
