namespace Cube.Secure.WinForms
{
    partial class HaschTextDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaschTextDialog));
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyMd5Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MD5textBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copySHA1Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SHA1textBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.copySHA256Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SHA256textBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.copySHA384Btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SHA384textBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.copySHA512Btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SHA512textBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.copyTextBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pesteTextBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBtn.Location = new System.Drawing.Point(183, 504);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(110, 25);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "MD5";
            // 
            // copyMd5Btn
            // 
            this.copyMd5Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyMd5Btn.Location = new System.Drawing.Point(386, 17);
            this.copyMd5Btn.Name = "copyMd5Btn";
            this.copyMd5Btn.Size = new System.Drawing.Size(75, 25);
            this.copyMd5Btn.TabIndex = 11;
            this.copyMd5Btn.Text = "Copy";
            this.copyMd5Btn.UseVisualStyleBackColor = true;
            this.copyMd5Btn.Click += new System.EventHandler(this.copyMd5Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.MD5textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.copyMd5Btn);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 70);
            this.panel1.TabIndex = 12;
            // 
            // MD5textBox
            // 
            this.MD5textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MD5textBox.Location = new System.Drawing.Point(2, 17);
            this.MD5textBox.Name = "MD5textBox";
            this.MD5textBox.Size = new System.Drawing.Size(375, 50);
            this.MD5textBox.TabIndex = 12;
            this.MD5textBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "SHA1";
            // 
            // copySHA1Btn
            // 
            this.copySHA1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copySHA1Btn.Location = new System.Drawing.Point(386, 17);
            this.copySHA1Btn.Name = "copySHA1Btn";
            this.copySHA1Btn.Size = new System.Drawing.Size(75, 25);
            this.copySHA1Btn.TabIndex = 11;
            this.copySHA1Btn.Text = "Copy";
            this.copySHA1Btn.UseVisualStyleBackColor = true;
            this.copySHA1Btn.Click += new System.EventHandler(this.copySHA1Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SHA1textBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.copySHA1Btn);
            this.panel2.Location = new System.Drawing.Point(12, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 70);
            this.panel2.TabIndex = 12;
            // 
            // SHA1textBox
            // 
            this.SHA1textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA1textBox.Location = new System.Drawing.Point(2, 17);
            this.SHA1textBox.Name = "SHA1textBox";
            this.SHA1textBox.Size = new System.Drawing.Size(375, 50);
            this.SHA1textBox.TabIndex = 12;
            this.SHA1textBox.Text = "";
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
            this.copySHA256Btn.Location = new System.Drawing.Point(386, 16);
            this.copySHA256Btn.Name = "copySHA256Btn";
            this.copySHA256Btn.Size = new System.Drawing.Size(75, 25);
            this.copySHA256Btn.TabIndex = 11;
            this.copySHA256Btn.Text = "Copy";
            this.copySHA256Btn.UseVisualStyleBackColor = true;
            this.copySHA256Btn.Click += new System.EventHandler(this.copySHA256Btn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.SHA256textBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.copySHA256Btn);
            this.panel3.Location = new System.Drawing.Point(12, 280);
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
            this.SHA256textBox.Size = new System.Drawing.Size(377, 50);
            this.SHA256textBox.TabIndex = 12;
            this.SHA256textBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "SHA384";
            // 
            // copySHA384Btn
            // 
            this.copySHA384Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copySHA384Btn.Location = new System.Drawing.Point(386, 16);
            this.copySHA384Btn.Name = "copySHA384Btn";
            this.copySHA384Btn.Size = new System.Drawing.Size(75, 25);
            this.copySHA384Btn.TabIndex = 11;
            this.copySHA384Btn.Text = "Copy";
            this.copySHA384Btn.UseVisualStyleBackColor = true;
            this.copySHA384Btn.Click += new System.EventHandler(this.copySHA384Btn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.SHA384textBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.copySHA384Btn);
            this.panel4.Location = new System.Drawing.Point(12, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 70);
            this.panel4.TabIndex = 12;
            // 
            // SHA384textBox
            // 
            this.SHA384textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA384textBox.Location = new System.Drawing.Point(0, 17);
            this.SHA384textBox.Name = "SHA384textBox";
            this.SHA384textBox.Size = new System.Drawing.Size(377, 50);
            this.SHA384textBox.TabIndex = 12;
            this.SHA384textBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "SHA512";
            // 
            // copySHA512Btn
            // 
            this.copySHA512Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copySHA512Btn.Location = new System.Drawing.Point(386, 16);
            this.copySHA512Btn.Name = "copySHA512Btn";
            this.copySHA512Btn.Size = new System.Drawing.Size(75, 25);
            this.copySHA512Btn.TabIndex = 11;
            this.copySHA512Btn.Text = "Copy";
            this.copySHA512Btn.UseVisualStyleBackColor = true;
            this.copySHA512Btn.Click += new System.EventHandler(this.copySHA512Btn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.SHA512textBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.copySHA512Btn);
            this.panel5.Location = new System.Drawing.Point(12, 425);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(460, 70);
            this.panel5.TabIndex = 12;
            // 
            // SHA512textBox
            // 
            this.SHA512textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA512textBox.Location = new System.Drawing.Point(1, 17);
            this.SHA512textBox.Name = "SHA512textBox";
            this.SHA512textBox.Size = new System.Drawing.Size(379, 50);
            this.SHA512textBox.TabIndex = 12;
            this.SHA512textBox.Text = "";
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(2, 17);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(375, 101);
            this.richTextBox.TabIndex = 12;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Text";
            // 
            // copyTextBtn
            // 
            this.copyTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyTextBtn.Location = new System.Drawing.Point(386, 17);
            this.copyTextBtn.Name = "copyTextBtn";
            this.copyTextBtn.Size = new System.Drawing.Size(75, 25);
            this.copyTextBtn.TabIndex = 11;
            this.copyTextBtn.Text = "Copy";
            this.copyTextBtn.UseVisualStyleBackColor = true;
            this.copyTextBtn.Click += new System.EventHandler(this.copyTextBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.pesteTextBtn);
            this.panel6.Controls.Add(this.richTextBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.copyTextBtn);
            this.panel6.Location = new System.Drawing.Point(13, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(460, 121);
            this.panel6.TabIndex = 12;
            // 
            // pesteTextBtn
            // 
            this.pesteTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pesteTextBtn.Location = new System.Drawing.Point(386, 48);
            this.pesteTextBtn.Name = "pesteTextBtn";
            this.pesteTextBtn.Size = new System.Drawing.Size(75, 25);
            this.pesteTextBtn.TabIndex = 11;
            this.pesteTextBtn.Text = "Peste";
            this.pesteTextBtn.UseVisualStyleBackColor = true;
            this.pesteTextBtn.Click += new System.EventHandler(this.pesteTextBtn_Click);
            // 
            // HaschTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 541);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "HaschTextDialog";
            this.Text = "Hashes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyMd5Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copySHA1Btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button copySHA256Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button copySHA384Btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button copySHA512Btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox SHA512textBox;
        private System.Windows.Forms.RichTextBox SHA256textBox;
        private System.Windows.Forms.RichTextBox SHA384textBox;
        private System.Windows.Forms.RichTextBox SHA1textBox;
        private System.Windows.Forms.RichTextBox MD5textBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button copyTextBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button pesteTextBtn;
    }
}