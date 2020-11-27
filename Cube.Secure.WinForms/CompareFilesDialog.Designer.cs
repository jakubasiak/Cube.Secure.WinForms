namespace Cube.Secure.WinForms
{
    partial class CompareFilesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareFilesDialog));
            this.closeBtn = new System.Windows.Forms.Button();
            this.openFirstFileBtn = new System.Windows.Forms.Button();
            this.firstFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstFileCopySHA256Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.firstFileSHA256textBox = new System.Windows.Forms.RichTextBox();
            this.secondFileTextBox = new System.Windows.Forms.TextBox();
            this.openSecondFileBtn = new System.Windows.Forms.Button();
            this.secondFileSHA256textBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondFileCopySHA256Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBtn.Location = new System.Drawing.Point(185, 294);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(110, 25);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // openFirstFileBtn
            // 
            this.openFirstFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFirstFileBtn.Location = new System.Drawing.Point(398, 25);
            this.openFirstFileBtn.Name = "openFirstFileBtn";
            this.openFirstFileBtn.Size = new System.Drawing.Size(75, 25);
            this.openFirstFileBtn.TabIndex = 7;
            this.openFirstFileBtn.Text = "Open file";
            this.openFirstFileBtn.UseVisualStyleBackColor = true;
            this.openFirstFileBtn.Click += new System.EventHandler(this.openFirstFileBtn_Click);
            // 
            // firstFileTextBox
            // 
            this.firstFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstFileTextBox.Enabled = false;
            this.firstFileTextBox.Location = new System.Drawing.Point(12, 26);
            this.firstFileTextBox.Name = "firstFileTextBox";
            this.firstFileTextBox.Size = new System.Drawing.Size(378, 23);
            this.firstFileTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "First file - SHA256";
            // 
            // firstFileCopySHA256Btn
            // 
            this.firstFileCopySHA256Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstFileCopySHA256Btn.Location = new System.Drawing.Point(386, 16);
            this.firstFileCopySHA256Btn.Name = "firstFileCopySHA256Btn";
            this.firstFileCopySHA256Btn.Size = new System.Drawing.Size(75, 25);
            this.firstFileCopySHA256Btn.TabIndex = 11;
            this.firstFileCopySHA256Btn.Text = "Copy";
            this.firstFileCopySHA256Btn.UseVisualStyleBackColor = true;
            this.firstFileCopySHA256Btn.Click += new System.EventHandler(this.firstFileCopySHA256Btn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.firstFileSHA256textBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.firstFileCopySHA256Btn);
            this.panel3.Location = new System.Drawing.Point(12, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 70);
            this.panel3.TabIndex = 12;
            // 
            // firstFileSHA256textBox
            // 
            this.firstFileSHA256textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstFileSHA256textBox.Location = new System.Drawing.Point(1, 17);
            this.firstFileSHA256textBox.Name = "firstFileSHA256textBox";
            this.firstFileSHA256textBox.Size = new System.Drawing.Size(377, 50);
            this.firstFileSHA256textBox.TabIndex = 12;
            this.firstFileSHA256textBox.Text = "";
            this.firstFileSHA256textBox.TextChanged += new System.EventHandler(this.hash_TextChanged);
            // 
            // secondFileTextBox
            // 
            this.secondFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondFileTextBox.Enabled = false;
            this.secondFileTextBox.Location = new System.Drawing.Point(12, 159);
            this.secondFileTextBox.Name = "secondFileTextBox";
            this.secondFileTextBox.Size = new System.Drawing.Size(378, 23);
            this.secondFileTextBox.TabIndex = 8;
            // 
            // openSecondFileBtn
            // 
            this.openSecondFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openSecondFileBtn.Location = new System.Drawing.Point(398, 158);
            this.openSecondFileBtn.Name = "openSecondFileBtn";
            this.openSecondFileBtn.Size = new System.Drawing.Size(75, 25);
            this.openSecondFileBtn.TabIndex = 7;
            this.openSecondFileBtn.Text = "Open file";
            this.openSecondFileBtn.UseVisualStyleBackColor = true;
            this.openSecondFileBtn.Click += new System.EventHandler(this.openSecondFileBtn_Click);
            // 
            // secondFileSHA256textBox
            // 
            this.secondFileSHA256textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondFileSHA256textBox.Location = new System.Drawing.Point(1, 17);
            this.secondFileSHA256textBox.Name = "secondFileSHA256textBox";
            this.secondFileSHA256textBox.Size = new System.Drawing.Size(377, 50);
            this.secondFileSHA256textBox.TabIndex = 12;
            this.secondFileSHA256textBox.Text = "";
            this.secondFileSHA256textBox.TextChanged += new System.EventHandler(this.hash_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Second file - SHA256";
            // 
            // secondFileCopySHA256Btn
            // 
            this.secondFileCopySHA256Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondFileCopySHA256Btn.Location = new System.Drawing.Point(386, 16);
            this.secondFileCopySHA256Btn.Name = "secondFileCopySHA256Btn";
            this.secondFileCopySHA256Btn.Size = new System.Drawing.Size(75, 25);
            this.secondFileCopySHA256Btn.TabIndex = 11;
            this.secondFileCopySHA256Btn.Text = "Copy";
            this.secondFileCopySHA256Btn.UseVisualStyleBackColor = true;
            this.secondFileCopySHA256Btn.Click += new System.EventHandler(this.secondFileCopySHA256Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.secondFileSHA256textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.secondFileCopySHA256Btn);
            this.panel1.Location = new System.Drawing.Point(12, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 70);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "First file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Second file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(50, 265);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(106, 15);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "Files are different";
            // 
            // CompareFilesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openSecondFileBtn);
            this.Controls.Add(this.secondFileTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.firstFileTextBox);
            this.Controls.Add(this.openFirstFileBtn);
            this.Controls.Add(this.closeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 370);
            this.Name = "CompareFilesDialog";
            this.Text = "Compare files";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button openFirstFileBtn;
        private System.Windows.Forms.TextBox firstFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button firstFileCopySHA256Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox firstFileSHA256textBox;
        private System.Windows.Forms.TextBox secondFileTextBox;
        private System.Windows.Forms.Button openSecondFileBtn;
        private System.Windows.Forms.RichTextBox secondFileSHA256textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button secondFileCopySHA256Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultLabel;
    }
}