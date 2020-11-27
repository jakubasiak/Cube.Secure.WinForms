namespace Cube.Secure.WinForms
{
    partial class CompareTextDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareTextDialog));
            this.closeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.firstTextCopySHA256Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.firstTextSHA256textBox = new System.Windows.Forms.RichTextBox();
            this.firstTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstTextCopyTextBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.firstTextPesteTextBtn = new System.Windows.Forms.Button();
            this.secondTextPesteTextBtn = new System.Windows.Forms.Button();
            this.secondTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondTextCopyTextBtn = new System.Windows.Forms.Button();
            this.secondTextSHA256textBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondTextCopySHA256Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBtn.Location = new System.Drawing.Point(183, 474);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(110, 25);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "First text - SHA256";
            // 
            // firstTextCopySHA256Btn
            // 
            this.firstTextCopySHA256Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstTextCopySHA256Btn.Location = new System.Drawing.Point(386, 16);
            this.firstTextCopySHA256Btn.Name = "firstTextCopySHA256Btn";
            this.firstTextCopySHA256Btn.Size = new System.Drawing.Size(75, 25);
            this.firstTextCopySHA256Btn.TabIndex = 11;
            this.firstTextCopySHA256Btn.Text = "Copy";
            this.firstTextCopySHA256Btn.UseVisualStyleBackColor = true;
            this.firstTextCopySHA256Btn.Click += new System.EventHandler(this.firstTextCopySHA256Btn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.firstTextSHA256textBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.firstTextCopySHA256Btn);
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 70);
            this.panel3.TabIndex = 12;
            // 
            // firstTextSHA256textBox
            // 
            this.firstTextSHA256textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstTextSHA256textBox.Location = new System.Drawing.Point(1, 17);
            this.firstTextSHA256textBox.Name = "firstTextSHA256textBox";
            this.firstTextSHA256textBox.Size = new System.Drawing.Size(377, 50);
            this.firstTextSHA256textBox.TabIndex = 12;
            this.firstTextSHA256textBox.Text = "";
            // 
            // firstTextRichTextBox
            // 
            this.firstTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstTextRichTextBox.Location = new System.Drawing.Point(2, 17);
            this.firstTextRichTextBox.Name = "firstTextRichTextBox";
            this.firstTextRichTextBox.Size = new System.Drawing.Size(375, 110);
            this.firstTextRichTextBox.TabIndex = 12;
            this.firstTextRichTextBox.Text = "";
            this.firstTextRichTextBox.TextChanged += new System.EventHandler(this.firstTextRichTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "First text";
            // 
            // firstTextCopyTextBtn
            // 
            this.firstTextCopyTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstTextCopyTextBtn.Location = new System.Drawing.Point(386, 17);
            this.firstTextCopyTextBtn.Name = "firstTextCopyTextBtn";
            this.firstTextCopyTextBtn.Size = new System.Drawing.Size(75, 25);
            this.firstTextCopyTextBtn.TabIndex = 11;
            this.firstTextCopyTextBtn.Text = "Copy";
            this.firstTextCopyTextBtn.UseVisualStyleBackColor = true;
            this.firstTextCopyTextBtn.Click += new System.EventHandler(this.firstTextCopyTextBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.firstTextPesteTextBtn);
            this.panel6.Controls.Add(this.firstTextRichTextBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.firstTextCopyTextBtn);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(460, 130);
            this.panel6.TabIndex = 12;
            // 
            // firstTextPesteTextBtn
            // 
            this.firstTextPesteTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstTextPesteTextBtn.Location = new System.Drawing.Point(386, 48);
            this.firstTextPesteTextBtn.Name = "firstTextPesteTextBtn";
            this.firstTextPesteTextBtn.Size = new System.Drawing.Size(75, 25);
            this.firstTextPesteTextBtn.TabIndex = 11;
            this.firstTextPesteTextBtn.Text = "Peste";
            this.firstTextPesteTextBtn.UseVisualStyleBackColor = true;
            this.firstTextPesteTextBtn.Click += new System.EventHandler(this.firstTextPesteTextBtn_Click);
            // 
            // secondTextPesteTextBtn
            // 
            this.secondTextPesteTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondTextPesteTextBtn.Location = new System.Drawing.Point(386, 48);
            this.secondTextPesteTextBtn.Name = "secondTextPesteTextBtn";
            this.secondTextPesteTextBtn.Size = new System.Drawing.Size(75, 25);
            this.secondTextPesteTextBtn.TabIndex = 11;
            this.secondTextPesteTextBtn.Text = "Peste";
            this.secondTextPesteTextBtn.UseVisualStyleBackColor = true;
            this.secondTextPesteTextBtn.Click += new System.EventHandler(this.secondTextPesteTextBtn_Click);
            // 
            // secondTextRichTextBox
            // 
            this.secondTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondTextRichTextBox.Location = new System.Drawing.Point(2, 17);
            this.secondTextRichTextBox.Name = "secondTextRichTextBox";
            this.secondTextRichTextBox.Size = new System.Drawing.Size(375, 110);
            this.secondTextRichTextBox.TabIndex = 12;
            this.secondTextRichTextBox.Text = "";
            this.secondTextRichTextBox.TextChanged += new System.EventHandler(this.secondTextRichTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Second text";
            // 
            // secondTextCopyTextBtn
            // 
            this.secondTextCopyTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondTextCopyTextBtn.Location = new System.Drawing.Point(386, 17);
            this.secondTextCopyTextBtn.Name = "secondTextCopyTextBtn";
            this.secondTextCopyTextBtn.Size = new System.Drawing.Size(75, 25);
            this.secondTextCopyTextBtn.TabIndex = 11;
            this.secondTextCopyTextBtn.Text = "Copy";
            this.secondTextCopyTextBtn.UseVisualStyleBackColor = true;
            this.secondTextCopyTextBtn.Click += new System.EventHandler(this.secondTextCopyTextBtn_Click);
            // 
            // secondTextSHA256textBox
            // 
            this.secondTextSHA256textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondTextSHA256textBox.Location = new System.Drawing.Point(1, 17);
            this.secondTextSHA256textBox.Name = "secondTextSHA256textBox";
            this.secondTextSHA256textBox.Size = new System.Drawing.Size(377, 50);
            this.secondTextSHA256textBox.TabIndex = 12;
            this.secondTextSHA256textBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Second text - SHA256";
            // 
            // secondTextCopySHA256Btn
            // 
            this.secondTextCopySHA256Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondTextCopySHA256Btn.Location = new System.Drawing.Point(386, 16);
            this.secondTextCopySHA256Btn.Name = "secondTextCopySHA256Btn";
            this.secondTextCopySHA256Btn.Size = new System.Drawing.Size(75, 25);
            this.secondTextCopySHA256Btn.TabIndex = 11;
            this.secondTextCopySHA256Btn.Text = "Copy";
            this.secondTextCopySHA256Btn.UseVisualStyleBackColor = true;
            this.secondTextCopySHA256Btn.Click += new System.EventHandler(this.secondTextCopySHA256Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.secondTextPesteTextBtn);
            this.panel1.Controls.Add(this.secondTextRichTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.secondTextCopyTextBtn);
            this.panel1.Location = new System.Drawing.Point(12, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 130);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.secondTextSHA256textBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.secondTextCopySHA256Btn);
            this.panel2.Location = new System.Drawing.Point(12, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 70);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(50, 434);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(112, 15);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "Texts are different";
            // 
            // CompareTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.closeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "CompareTextDialog";
            this.Text = "Compare texts";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button firstTextCopySHA256Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox firstTextSHA256textBox;
        private System.Windows.Forms.RichTextBox firstTextRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button firstTextCopyTextBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button firstTextPesteTextBtn;
        private System.Windows.Forms.Button secondTextPesteTextBtn;
        private System.Windows.Forms.RichTextBox secondTextRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button secondTextCopyTextBtn;
        private System.Windows.Forms.RichTextBox secondTextSHA256textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button secondTextCopySHA256Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
    }
}