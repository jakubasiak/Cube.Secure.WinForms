using System;

namespace Cube.Secure.WinForms
{
    partial class KeysDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeysDialog));
            this.pesteKeyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.importKeyBtn = new System.Windows.Forms.Button();
            this.keyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pesteKeyBtn
            // 
            this.pesteKeyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pesteKeyBtn.Location = new System.Drawing.Point(12, 202);
            this.pesteKeyBtn.Name = "pesteKeyBtn";
            this.pesteKeyBtn.Size = new System.Drawing.Size(110, 25);
            this.pesteKeyBtn.TabIndex = 3;
            this.pesteKeyBtn.Text = "Peste key";
            this.pesteKeyBtn.UseVisualStyleBackColor = true;
            this.pesteKeyBtn.Click += new System.EventHandler(this.pesteKeyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cancelBtn.Location = new System.Drawing.Point(352, 202);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(110, 25);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // actionBtn
            // 
            this.actionBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.actionBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionBtn.Location = new System.Drawing.Point(244, 202);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(105, 25);
            this.actionBtn.TabIndex = 3;
            this.actionBtn.Text = "Encrypt";
            this.actionBtn.UseVisualStyleBackColor = true;
            // 
            // importKeyBtn
            // 
            this.importKeyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.importKeyBtn.Location = new System.Drawing.Point(128, 202);
            this.importKeyBtn.Name = "importKeyBtn";
            this.importKeyBtn.Size = new System.Drawing.Size(110, 25);
            this.importKeyBtn.TabIndex = 3;
            this.importKeyBtn.Text = "Import key";
            this.importKeyBtn.UseVisualStyleBackColor = true;
            this.importKeyBtn.Click += new System.EventHandler(this.importKeyBtn_Click);
            // 
            // keyRichTextBox
            // 
            this.keyRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyRichTextBox.Location = new System.Drawing.Point(12, 23);
            this.keyRichTextBox.MinimumSize = new System.Drawing.Size(450, 170);
            this.keyRichTextBox.Name = "keyRichTextBox";
            this.keyRichTextBox.Size = new System.Drawing.Size(450, 170);
            this.keyRichTextBox.TabIndex = 0;
            this.keyRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // KeysDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyRichTextBox);
            this.Controls.Add(this.importKeyBtn);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.pesteKeyBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 278);
            this.Name = "KeysDialog";
            this.Text = "Generate keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button pesteKeyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Button importKeyBtn;
        private System.Windows.Forms.RichTextBox keyRichTextBox;
        private System.Windows.Forms.Label label2;
    }
}