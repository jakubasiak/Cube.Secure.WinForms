using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                PasswordDialog passwordDialog = new PasswordDialog(ActionType.Encrypt);
                passwordDialog.StartPosition = FormStartPosition.CenterParent;
                var result = passwordDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
                {
                    var bw = new BackgroundWorker();
                    bw.WorkerReportsProgress = true;
                    bw.RunWorkerCompleted += (object s, RunWorkerCompletedEventArgs e) =>
                    {
                        this.toolStripProgressBar.Value = 100;
                        bw.Dispose();
                    };
                    bw.ProgressChanged += (object s, ProgressChangedEventArgs e) =>
                    {
                        this.toolStripProgressBar.Value = e.ProgressPercentage;
                    };
                    bw.DoWork += (object s, DoWorkEventArgs e) =>
                    {
                        var password = passwordDialog.Password;
                        var allFilePaths = this.GetAllFilePaths();

                        for (int i = 0; i < allFilePaths.Count; i++)
                        {
                            var file = File.ReadAllBytes(allFilePaths[i]);
                            var encryptedFile = this.Aes.Encrypt(file, password);
                            File.WriteAllBytes(allFilePaths[i], encryptedFile);
                            bw.ReportProgress((int)(((float)i / allFilePaths.Count) * 100.0f));
                        }
                    };

                    bw.RunWorkerAsync();
                }
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            PasswordDialog passwordDialog = new PasswordDialog(ActionType.Decrypt);
            passwordDialog.StartPosition = FormStartPosition.CenterParent;
            var result = passwordDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
            {
                var bw = new BackgroundWorker();
                bw.WorkerReportsProgress = true;
                bw.RunWorkerCompleted += (object s, RunWorkerCompletedEventArgs e) =>
                {
                    this.toolStripProgressBar.Value = 100;
                    bw.Dispose();
                };
                bw.ProgressChanged += (object s, ProgressChangedEventArgs e) =>
                {
                    this.toolStripProgressBar.Value = e.ProgressPercentage;
                };
                bw.DoWork += (object s, DoWorkEventArgs e) =>
                {
                    var password = passwordDialog.Password;
                    var allFilePaths = this.GetAllFilePaths();

                    for (int i = 0; i < allFilePaths.Count; i++)
                    {
                        var file = File.ReadAllBytes(allFilePaths[i]);
                        var decryptedFile = this.Aes.Decrypt(file, password);
                        File.WriteAllBytes(allFilePaths[i], decryptedFile);
                        bw.ReportProgress((int)(((float)i / allFilePaths.Count) * 100.0f));
                    }
                };

                bw.RunWorkerAsync();
            }
        }

        private void encryptWithNamesBtn_Click(object sender, EventArgs e)
        {
            PasswordDialog passwordDialog = new PasswordDialog(ActionType.Encrypt);
            passwordDialog.StartPosition = FormStartPosition.CenterParent;
            var result = passwordDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
            {
                var bw = new BackgroundWorker();
                bw.WorkerReportsProgress = true;
                bw.RunWorkerCompleted += (object s, RunWorkerCompletedEventArgs e) =>
                {
                    this.toolStripProgressBar.Value = 100;
                    this.RefreashFileList(this.currentDirectory);
                    bw.Dispose();
                };
                bw.ProgressChanged += (object s, ProgressChangedEventArgs e) =>
                {
                    this.toolStripProgressBar.Value = e.ProgressPercentage;
                };
                bw.DoWork += (object s, DoWorkEventArgs e) =>
                {
                    var password = passwordDialog.Password;
                    var allFilePaths = this.GetAllFilePaths();

                    for (int i = 0; i < allFilePaths.Count; i++)
                    {
                        var file = File.ReadAllBytes(allFilePaths[i]);
                        var encryptedFile = this.Aes.Encrypt(file, password);
                        var encryptedFileName = this.GetEncryptedFileName(allFilePaths[i], password);
                        File.WriteAllBytes(encryptedFileName, encryptedFile);
                        File.Delete(allFilePaths[i]);
                        bw.ReportProgress((int)(((float)i / allFilePaths.Count) * 100.0f));
                    }
                };

                bw.RunWorkerAsync();
            }
        }

        private void decryptWithNamesBtn_Click(object sender, EventArgs e)
        {
            PasswordDialog passwordDialog = new PasswordDialog(ActionType.Decrypt);
            passwordDialog.StartPosition = FormStartPosition.CenterParent;
            var result = passwordDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(passwordDialog.Password))
            {
                var bw = new BackgroundWorker();
                bw.WorkerReportsProgress = true;
                bw.RunWorkerCompleted += (object s, RunWorkerCompletedEventArgs e) =>
                {
                    this.toolStripProgressBar.Value = 100;
                    this.RefreashFileList(this.currentDirectory);
                    bw.Dispose();
                };
                bw.ProgressChanged += (object s, ProgressChangedEventArgs e) =>
                {
                    this.toolStripProgressBar.Value = e.ProgressPercentage;
                };
                bw.DoWork += (object s, DoWorkEventArgs e) =>
                {
                    var password = passwordDialog.Password;
                    var allFilePaths = this.GetAllFilePaths();

                    for (int i = 0; i < allFilePaths.Count; i++)
                    {
                        var file = File.ReadAllBytes(allFilePaths[i]);
                        var decryptedFile = this.Aes.Decrypt(file, password);
                        var decryptedFileName = this.GetDecryptedFileName(allFilePaths[i], password);
                        File.WriteAllBytes(decryptedFileName, decryptedFile);
                        File.Delete(allFilePaths[i]);
                        bw.ReportProgress((int)(((float)i / allFilePaths.Count) * 100.0f));
                    }
                };

                bw.RunWorkerAsync();
            }
        }

        private void listView_Click(object sender, EventArgs e)
        {
            this.toolStripProgressBar.Value = 0;
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

        private void encryptTextBtn_Click(object sender, EventArgs e)
        {
            ConvertTextDialog convertTextDialog = new ConvertTextDialog(ActionType.Encrypt, this.Aes);
            convertTextDialog.StartPosition = FormStartPosition.CenterParent;
            convertTextDialog.ShowDialog();
        }

        private void decryptTextBtn_Click(object sender, EventArgs e)
        {
            ConvertTextDialog convertTextDialog = new ConvertTextDialog(ActionType.Decrypt, this.Aes);
            convertTextDialog.StartPosition = FormStartPosition.CenterParent;
            convertTextDialog.ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
