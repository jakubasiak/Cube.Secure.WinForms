namespace Cube.Secure.WinForms
{
    partial class RsaConvertTextDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RsaConvertTextDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.RichTextBox();
            this.pesteBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.copyTextBtn = new System.Windows.Forms.Button();
            this.pesteTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Location = new System.Drawing.Point(13, 308);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(479, 113);
            this.keyTextBox.TabIndex = 1;
            this.keyTextBox.Text = "";
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTextBox_KeyDown);
            // 
            // pesteBtn
            // 
            this.pesteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pesteBtn.Location = new System.Drawing.Point(13, 428);
            this.pesteBtn.Name = "pesteBtn";
            this.pesteBtn.Size = new System.Drawing.Size(75, 25);
            this.pesteBtn.TabIndex = 2;
            this.pesteBtn.Text = "Peste key";
            this.pesteBtn.UseMnemonic = false;
            this.pesteBtn.UseVisualStyleBackColor = true;
            this.pesteBtn.Click += new System.EventHandler(this.pesteBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.importBtn.Location = new System.Drawing.Point(94, 428);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 25);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "Import key";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // actionBtn
            // 
            this.actionBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.actionBtn.Location = new System.Drawing.Point(337, 428);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(75, 25);
            this.actionBtn.TabIndex = 2;
            this.actionBtn.Text = "Encrypt";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(417, 428);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 25);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text";
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 23);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(480, 264);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // copyTextBtn
            // 
            this.copyTextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyTextBtn.Location = new System.Drawing.Point(175, 428);
            this.copyTextBtn.Name = "copyTextBtn";
            this.copyTextBtn.Size = new System.Drawing.Size(75, 25);
            this.copyTextBtn.TabIndex = 5;
            this.copyTextBtn.Text = "Copy text";
            this.copyTextBtn.UseVisualStyleBackColor = true;
            this.copyTextBtn.Click += new System.EventHandler(this.copyTextBtn_Click);
            // 
            // pesteTextBtn
            // 
            this.pesteTextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pesteTextBtn.Location = new System.Drawing.Point(256, 428);
            this.pesteTextBtn.Name = "pesteTextBtn";
            this.pesteTextBtn.Size = new System.Drawing.Size(75, 25);
            this.pesteTextBtn.TabIndex = 5;
            this.pesteTextBtn.Text = "Peste text";
            this.pesteTextBtn.UseVisualStyleBackColor = true;
            this.pesteTextBtn.Click += new System.EventHandler(this.pesteTextBtn_Click);
            // 
            // RsaConvertTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 461);
            this.Controls.Add(this.pesteTextBtn);
            this.Controls.Add(this.copyTextBtn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.pesteBtn);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(520, 500);
            this.Name = "RsaConvertTextDialog";
            this.Text = "Enter the key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox keyTextBox;
        private System.Windows.Forms.Button pesteBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button copyTextBtn;
        private System.Windows.Forms.Button pesteTextBtn;
    }
}