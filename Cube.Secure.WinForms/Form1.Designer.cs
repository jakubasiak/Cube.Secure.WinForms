using System;
using System.Drawing;
using System.IO;

namespace Cube.Secure.WinForms
{
    partial class Form1
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.encryptWithNamesBtn = new System.Windows.Forms.Button();
            this.decryptWithNamesBtn = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openDirectory_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(638, 74);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(150, 25);
            this.encryptBtn.TabIndex = 1;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(638, 105);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(150, 25);
            this.decryptBtn.TabIndex = 2;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // listView
            // 
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
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.TabIndex = 4;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 18);
            this.toolStripProgressBar.Step = 1;
            // 
            // SelectedItems
            // 
            this.SelectedItems.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SelectedItems.Name = "SelectedItems";
            this.SelectedItems.Size = new System.Drawing.Size(67, 19);
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
            this.toolStripMenuItem2});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
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
            this.decryptWithNamesMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem2.Text = "Cryptography";
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
            // pathTextBox
            // 
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(13, 43);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(619, 23);
            this.pathTextBox.TabIndex = 6;
            // 
            // encryptWithNamesBtn
            // 
            this.encryptWithNamesBtn.Location = new System.Drawing.Point(638, 136);
            this.encryptWithNamesBtn.Name = "encryptWithNamesBtn";
            this.encryptWithNamesBtn.Size = new System.Drawing.Size(150, 25);
            this.encryptWithNamesBtn.TabIndex = 1;
            this.encryptWithNamesBtn.Text = "Encrypt with file names";
            this.encryptWithNamesBtn.UseVisualStyleBackColor = true;
            this.encryptWithNamesBtn.Click += new System.EventHandler(this.encryptWithNamesBtn_Click);
            // 
            // decryptWithNamesBtn
            // 
            this.decryptWithNamesBtn.Location = new System.Drawing.Point(638, 167);
            this.decryptWithNamesBtn.Name = "decryptWithNamesBtn";
            this.decryptWithNamesBtn.Size = new System.Drawing.Size(150, 25);
            this.decryptWithNamesBtn.TabIndex = 1;
            this.decryptWithNamesBtn.Text = "Decrypt with file names";
            this.decryptWithNamesBtn.UseVisualStyleBackColor = true;
            this.decryptWithNamesBtn.Click += new System.EventHandler(this.decryptWithNamesBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.decryptWithNamesBtn);
            this.Controls.Add(this.encryptWithNamesBtn);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
    }
}

