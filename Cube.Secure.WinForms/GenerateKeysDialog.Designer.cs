using System;

namespace Cube.Secure.WinForms
{
    partial class GenerateKeysDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateKeysDialog));
            this.publicKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copyPublicKeyBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.privateKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // publicKeyRichTextBox
            // 
            this.publicKeyRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicKeyRichTextBox.Location = new System.Drawing.Point(12, 27);
            this.publicKeyRichTextBox.Name = "publicKeyRichTextBox";
            this.publicKeyRichTextBox.Size = new System.Drawing.Size(459, 170);
            this.publicKeyRichTextBox.TabIndex = 0;
            this.publicKeyRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Public key";
            // 
            // copyPublicKeyBtn
            // 
            this.copyPublicKeyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyPublicKeyBtn.Location = new System.Drawing.Point(24, 424);
            this.copyPublicKeyBtn.Name = "copyPublicKeyBtn";
            this.copyPublicKeyBtn.Size = new System.Drawing.Size(105, 25);
            this.copyPublicKeyBtn.TabIndex = 3;
            this.copyPublicKeyBtn.Text = "Copy public key";
            this.copyPublicKeyBtn.UseVisualStyleBackColor = true;
            this.copyPublicKeyBtn.Click += new System.EventHandler(this.copyPublicKeyBtn_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(357, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(246, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveKeyBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(135, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy private key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.copyPrivateKeyBtn_Click);
            // 
            // privateKeyRichTextBox
            // 
            this.privateKeyRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privateKeyRichTextBox.Location = new System.Drawing.Point(13, 224);
            this.privateKeyRichTextBox.Name = "privateKeyRichTextBox";
            this.privateKeyRichTextBox.Size = new System.Drawing.Size(459, 170);
            this.privateKeyRichTextBox.TabIndex = 0;
            this.privateKeyRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private key";
            // 
            // GenerateKeysDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.privateKeyRichTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.copyPublicKeyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publicKeyRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateKeysDialog";
            this.Text = "Generate keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.RichTextBox publicKeyRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyPublicKeyBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox privateKeyRichTextBox;
        private System.Windows.Forms.Label label2;
    }
}