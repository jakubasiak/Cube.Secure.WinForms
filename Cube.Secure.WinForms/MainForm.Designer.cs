using System;
using System.Drawing;
using System.IO;

namespace Cube.Secure.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.fileImageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.SelectedItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.ItemNames = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptWithNamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptWithNamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeysMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsaEncryptTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsaDecryptTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.encryptWithNamesBtn = new System.Windows.Forms.Button();
            this.decryptWithNamesBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptTextBtn = new System.Windows.Forms.Button();
            this.encryptTextBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.decryptTextRsaBtn = new System.Windows.Forms.Button();
            this.encryptTextRsaBtn = new System.Windows.Forms.Button();
            this.generateKeysBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hybridDecryptTextBtn = new System.Windows.Forms.Button();
            this.hybridEncryptTextBtn = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(644, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openDirectory_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(6, 22);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(150, 25);
            this.encryptBtn.TabIndex = 1;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(6, 53);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(150, 25);
            this.decryptBtn.TabIndex = 2;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.fileImageList;
            this.listView.Location = new System.Drawing.Point(13, 74);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(619, 487);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.Click += new System.EventHandler(this.listView_Click);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // fileImageList
            // 
            this.fileImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.fileImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.fileImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.SelectedItems,
            this.ItemNames});
            this.statusStrip.Location = new System.Drawing.Point(0, 576);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(812, 24);
            this.statusStrip.TabIndex = 4;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.toolStripProgressBar.MarqueeAnimationSpeed = 10;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // SelectedItems
            // 
            this.SelectedItems.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SelectedItems.Margin = new System.Windows.Forms.Padding(10, 3, 1, 2);
            this.SelectedItems.Name = "SelectedItems";
            this.SelectedItems.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.SelectedItems.Size = new System.Drawing.Size(77, 19);
            this.SelectedItems.Text = "Selected: 0";
            // 
            // ItemNames
            // 
            this.ItemNames.Name = "ItemNames";
            this.ItemNames.Size = new System.Drawing.Size(47, 19);
            this.ItemNames.Text = "Names:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(812, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openDirectory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptMenuItem,
            this.decryptMenuItem,
            this.encryptWithNamesMenuItem,
            this.decryptWithNamesMenuItem,
            this.encryptTextMenuItem,
            this.decryptTextMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem2.Text = "AES";
            // 
            // encryptMenuItem
            // 
            this.encryptMenuItem.Name = "encryptMenuItem";
            this.encryptMenuItem.Size = new System.Drawing.Size(198, 22);
            this.encryptMenuItem.Text = "Encrypt";
            this.encryptMenuItem.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decryptMenuItem
            // 
            this.decryptMenuItem.Name = "decryptMenuItem";
            this.decryptMenuItem.Size = new System.Drawing.Size(198, 22);
            this.decryptMenuItem.Text = "Decrypt";
            this.decryptMenuItem.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encryptWithNamesMenuItem
            // 
            this.encryptWithNamesMenuItem.Name = "encryptWithNamesMenuItem";
            this.encryptWithNamesMenuItem.Size = new System.Drawing.Size(198, 22);
            this.encryptWithNamesMenuItem.Text = "Encrypt with file names";
            this.encryptWithNamesMenuItem.Click += new System.EventHandler(this.encryptWithNamesBtn_Click);
            // 
            // decryptWithNamesMenuItem
            // 
            this.decryptWithNamesMenuItem.Name = "decryptWithNamesMenuItem";
            this.decryptWithNamesMenuItem.Size = new System.Drawing.Size(198, 22);
            this.decryptWithNamesMenuItem.Text = "Decrypt with file names";
            this.decryptWithNamesMenuItem.Click += new System.EventHandler(this.decryptWithNamesBtn_Click);
            // 
            // encryptTextMenuItem
            // 
            this.encryptTextMenuItem.Name = "encryptTextMenuItem";
            this.encryptTextMenuItem.Size = new System.Drawing.Size(198, 22);
            this.encryptTextMenuItem.Text = "Encrypt text";
            this.encryptTextMenuItem.Click += new System.EventHandler(this.encryptTextBtn_Click);
            // 
            // decryptTextMenuItem
            // 
            this.decryptTextMenuItem.Name = "decryptTextMenuItem";
            this.decryptTextMenuItem.Size = new System.Drawing.Size(198, 22);
            this.decryptTextMenuItem.Text = "Decrypt text";
            this.decryptTextMenuItem.Click += new System.EventHandler(this.decryptTextBtn_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateKeysMenuItem,
            this.rsaEncryptTextMenuItem,
            this.rsaDecryptTextMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem3.Text = "RSA";
            // 
            // generateKeysMenuItem
            // 
            this.generateKeysMenuItem.Name = "generateKeysMenuItem";
            this.generateKeysMenuItem.Size = new System.Drawing.Size(147, 22);
            this.generateKeysMenuItem.Text = "Generate keys";
            this.generateKeysMenuItem.Click += new System.EventHandler(this.generateKeysBtn_Click);
            // 
            // rsaEncryptTextMenuItem
            // 
            this.rsaEncryptTextMenuItem.Name = "rsaEncryptTextMenuItem";
            this.rsaEncryptTextMenuItem.Size = new System.Drawing.Size(147, 22);
            this.rsaEncryptTextMenuItem.Text = "Encrypt text";
            this.rsaEncryptTextMenuItem.Click += new System.EventHandler(this.encryptTextRsaBtn_Click);
            // 
            // rsaDecryptTextMenuItem
            // 
            this.rsaDecryptTextMenuItem.Name = "rsaDecryptTextMenuItem";
            this.rsaDecryptTextMenuItem.Size = new System.Drawing.Size(147, 22);
            this.rsaDecryptTextMenuItem.Text = "Decrypt text";
            this.rsaDecryptTextMenuItem.Click += new System.EventHandler(this.decryptTextRsaBtn_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(13, 43);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(619, 23);
            this.pathTextBox.TabIndex = 6;
            // 
            // encryptWithNamesBtn
            // 
            this.encryptWithNamesBtn.Location = new System.Drawing.Point(6, 84);
            this.encryptWithNamesBtn.Name = "encryptWithNamesBtn";
            this.encryptWithNamesBtn.Size = new System.Drawing.Size(150, 25);
            this.encryptWithNamesBtn.TabIndex = 1;
            this.encryptWithNamesBtn.Text = "Encrypt with file names";
            this.encryptWithNamesBtn.UseVisualStyleBackColor = true;
            this.encryptWithNamesBtn.Click += new System.EventHandler(this.encryptWithNamesBtn_Click);
            // 
            // decryptWithNamesBtn
            // 
            this.decryptWithNamesBtn.Location = new System.Drawing.Point(6, 115);
            this.decryptWithNamesBtn.Name = "decryptWithNamesBtn";
            this.decryptWithNamesBtn.Size = new System.Drawing.Size(150, 25);
            this.decryptWithNamesBtn.TabIndex = 1;
            this.decryptWithNamesBtn.Text = "Decrypt with file names";
            this.decryptWithNamesBtn.UseVisualStyleBackColor = true;
            this.decryptWithNamesBtn.Click += new System.EventHandler(this.decryptWithNamesBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.decryptTextBtn);
            this.groupBox1.Controls.Add(this.encryptTextBtn);
            this.groupBox1.Controls.Add(this.decryptWithNamesBtn);
            this.groupBox1.Controls.Add(this.encryptBtn);
            this.groupBox1.Controls.Add(this.encryptWithNamesBtn);
            this.groupBox1.Controls.Add(this.decryptBtn);
            this.groupBox1.Location = new System.Drawing.Point(638, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AES";
            // 
            // decryptTextBtn
            // 
            this.decryptTextBtn.Location = new System.Drawing.Point(6, 177);
            this.decryptTextBtn.Name = "decryptTextBtn";
            this.decryptTextBtn.Size = new System.Drawing.Size(150, 25);
            this.decryptTextBtn.TabIndex = 1;
            this.decryptTextBtn.Text = "Decrypt text";
            this.decryptTextBtn.UseVisualStyleBackColor = true;
            this.decryptTextBtn.Click += new System.EventHandler(this.decryptTextBtn_Click);
            // 
            // encryptTextBtn
            // 
            this.encryptTextBtn.Location = new System.Drawing.Point(6, 146);
            this.encryptTextBtn.Name = "encryptTextBtn";
            this.encryptTextBtn.Size = new System.Drawing.Size(150, 25);
            this.encryptTextBtn.TabIndex = 1;
            this.encryptTextBtn.Text = "Encrypt text";
            this.encryptTextBtn.UseVisualStyleBackColor = true;
            this.encryptTextBtn.Click += new System.EventHandler(this.encryptTextBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.decryptTextRsaBtn);
            this.groupBox2.Controls.Add(this.encryptTextRsaBtn);
            this.groupBox2.Controls.Add(this.generateKeysBtn);
            this.groupBox2.Location = new System.Drawing.Point(638, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 118);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSA";
            // 
            // decryptTextRsaBtn
            // 
            this.decryptTextRsaBtn.Location = new System.Drawing.Point(6, 84);
            this.decryptTextRsaBtn.Name = "decryptTextRsaBtn";
            this.decryptTextRsaBtn.Size = new System.Drawing.Size(150, 25);
            this.decryptTextRsaBtn.TabIndex = 2;
            this.decryptTextRsaBtn.Text = "Decrypt text";
            this.decryptTextRsaBtn.UseVisualStyleBackColor = true;
            this.decryptTextRsaBtn.Click += new System.EventHandler(this.decryptTextRsaBtn_Click);
            // 
            // encryptTextRsaBtn
            // 
            this.encryptTextRsaBtn.Location = new System.Drawing.Point(6, 53);
            this.encryptTextRsaBtn.Name = "encryptTextRsaBtn";
            this.encryptTextRsaBtn.Size = new System.Drawing.Size(150, 25);
            this.encryptTextRsaBtn.TabIndex = 2;
            this.encryptTextRsaBtn.Text = "Encrypt text";
            this.encryptTextRsaBtn.UseVisualStyleBackColor = true;
            this.encryptTextRsaBtn.Click += new System.EventHandler(this.encryptTextRsaBtn_Click);
            // 
            // generateKeysBtn
            // 
            this.generateKeysBtn.Location = new System.Drawing.Point(6, 22);
            this.generateKeysBtn.Name = "generateKeysBtn";
            this.generateKeysBtn.Size = new System.Drawing.Size(150, 25);
            this.generateKeysBtn.TabIndex = 1;
            this.generateKeysBtn.Text = "Generate keys";
            this.generateKeysBtn.UseVisualStyleBackColor = true;
            this.generateKeysBtn.Click += new System.EventHandler(this.generateKeysBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hybridDecryptTextBtn);
            this.groupBox3.Controls.Add(this.hybridEncryptTextBtn);
            this.groupBox3.Location = new System.Drawing.Point(638, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 146);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hybrid RSA + AES";
            // 
            // hybridDecryptTextBtn
            // 
            this.hybridDecryptTextBtn.Location = new System.Drawing.Point(7, 54);
            this.hybridDecryptTextBtn.Name = "hybridDecryptTextBtn";
            this.hybridDecryptTextBtn.Size = new System.Drawing.Size(149, 25);
            this.hybridDecryptTextBtn.TabIndex = 0;
            this.hybridDecryptTextBtn.Text = "Decrypt text";
            this.hybridDecryptTextBtn.UseVisualStyleBackColor = true;
            this.hybridDecryptTextBtn.Click += new System.EventHandler(this.hybridDecryptTextBtn_Click);
            // 
            // hybridEncryptTextBtn
            // 
            this.hybridEncryptTextBtn.Location = new System.Drawing.Point(7, 23);
            this.hybridEncryptTextBtn.Name = "hybridEncryptTextBtn";
            this.hybridEncryptTextBtn.Size = new System.Drawing.Size(149, 25);
            this.hybridEncryptTextBtn.TabIndex = 0;
            this.hybridEncryptTextBtn.Text = "Encrypt text";
            this.hybridEncryptTextBtn.UseVisualStyleBackColor = true;
            this.hybridEncryptTextBtn.Click += new System.EventHandler(this.hybridEncryptTextBtn_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(812, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ImageList fileImageList;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ToolStripStatusLabel SelectedItems;
        private System.Windows.Forms.ToolStripStatusLabel ItemNames;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem encryptMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptMenuItem;
        private System.Windows.Forms.Button encryptWithNamesBtn;
        private System.Windows.Forms.Button decryptWithNamesBtn;
        private System.Windows.Forms.ToolStripMenuItem encryptWithNamesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptWithNamesMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button decryptTextBtn;
        private System.Windows.Forms.Button encryptTextBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem encryptTextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptTextMenuItem;
        private System.Windows.Forms.Button generateKeysBtn;
        private System.Windows.Forms.Button decryptTextRsaBtn;
        private System.Windows.Forms.Button encryptTextRsaBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generateKeysMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rsaEncryptTextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rsaDecryptTextMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button hybridDecryptTextBtn;
        private System.Windows.Forms.Button hybridEncryptTextBtn;
    }
}

