namespace Cube.Secure.WinForms
{
    partial class VerifyFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyFileDialog));
            this.openFileBtn = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.copySHA256Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SHA256textBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.verifyFileBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openSignatureNyn = new System.Windows.Forms.Button();
            this.signatureTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileBtn.Location = new System.Drawing.Point(358, 43);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(112, 25);
            this.openFileBtn.TabIndex = 7;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(11, 43);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(341, 23);
            this.filePathTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "SHA256";
            // 
            // copySHA256Btn
            // 
            this.copySHA256Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copySHA256Btn.Location = new System.Drawing.Point(348, 15);
            this.copySHA256Btn.Name = "copySHA256Btn";
            this.copySHA256Btn.Size = new System.Drawing.Size(112, 25);
            this.copySHA256Btn.TabIndex = 11;
            this.copySHA256Btn.Text = "Copy";
            this.copySHA256Btn.UseVisualStyleBackColor = true;
            this.copySHA256Btn.Click += new System.EventHandler(this.copySHA256Btn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.SHA256textBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.copySHA256Btn);
            this.panel3.Location = new System.Drawing.Point(10, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 70);
            this.panel3.TabIndex = 12;
            // 
            // SHA256textBox
            // 
            this.SHA256textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA256textBox.Location = new System.Drawing.Point(1, 17);
            this.SHA256textBox.Name = "SHA256textBox";
            this.SHA256textBox.Size = new System.Drawing.Size(341, 50);
            this.SHA256textBox.TabIndex = 12;
            this.SHA256textBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Private key";
            // 
            // keyRichTextBox
            // 
            this.keyRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyRichTextBox.Location = new System.Drawing.Point(11, 163);
            this.keyRichTextBox.MinimumSize = new System.Drawing.Size(450, 170);
            this.keyRichTextBox.Name = "keyRichTextBox";
            this.keyRichTextBox.Size = new System.Drawing.Size(461, 220);
            this.keyRichTextBox.TabIndex = 0;
            this.keyRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(129, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Import key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.importKeyBtn_Click);
            // 
            // verifyFileBtn
            // 
            this.verifyFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verifyFileBtn.Location = new System.Drawing.Point(244, 424);
            this.verifyFileBtn.Name = "verifyFileBtn";
            this.verifyFileBtn.Size = new System.Drawing.Size(112, 25);
            this.verifyFileBtn.TabIndex = 3;
            this.verifyFileBtn.Text = "Verify file";
            this.verifyFileBtn.UseVisualStyleBackColor = true;
            this.verifyFileBtn.Click += new System.EventHandler(this.verifyFileBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(359, 424);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 25);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(11, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Peste key";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.pesteKeyBtn_Click);
            // 
            // openSignatureNyn
            // 
            this.openSignatureNyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openSignatureNyn.Location = new System.Drawing.Point(358, 12);
            this.openSignatureNyn.Name = "openSignatureNyn";
            this.openSignatureNyn.Size = new System.Drawing.Size(112, 25);
            this.openSignatureNyn.TabIndex = 7;
            this.openSignatureNyn.Text = "Open signature";
            this.openSignatureNyn.UseVisualStyleBackColor = true;
            this.openSignatureNyn.Click += new System.EventHandler(this.openSignatureBtn_Click);
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signatureTextBox.Enabled = false;
            this.signatureTextBox.Location = new System.Drawing.Point(12, 14);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(340, 23);
            this.signatureTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(51, 390);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 14;
            // 
            // VerifyFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signatureTextBox);
            this.Controls.Add(this.openSignatureNyn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.verifyFileBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keyRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.openFileBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "VerifyFileDialog";
            this.Text = "Verify file";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button copySHA256Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox SHA256textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox keyRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verifyFileBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button openSignatureNyn;
        private System.Windows.Forms.TextBox signatureTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
    }
}