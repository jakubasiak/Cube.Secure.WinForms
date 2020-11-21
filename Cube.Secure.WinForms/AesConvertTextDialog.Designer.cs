namespace Cube.Secure.WinForms
{
    partial class AesConvertTextDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AesConvertTextDialog));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyTextBtn = new System.Windows.Forms.Button();
            this.pesteTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 338);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 397);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(460, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBtn.Location = new System.Drawing.Point(362, 426);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(110, 25);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // actionBtn
            // 
            this.actionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actionBtn.Location = new System.Drawing.Point(246, 426);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(110, 25);
            this.actionBtn.TabIndex = 2;
            this.actionBtn.Text = "Encrypt";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text";
            // 
            // copyTextBtn
            // 
            this.copyTextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyTextBtn.Location = new System.Drawing.Point(12, 426);
            this.copyTextBtn.Name = "copyTextBtn";
            this.copyTextBtn.Size = new System.Drawing.Size(110, 25);
            this.copyTextBtn.TabIndex = 3;
            this.copyTextBtn.Text = "Copy text";
            this.copyTextBtn.UseVisualStyleBackColor = true;
            this.copyTextBtn.Click += new System.EventHandler(this.copyTextBtn_Click);
            // 
            // pesteTextBtn
            // 
            this.pesteTextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pesteTextBtn.Location = new System.Drawing.Point(128, 426);
            this.pesteTextBtn.Name = "pesteTextBtn";
            this.pesteTextBtn.Size = new System.Drawing.Size(110, 25);
            this.pesteTextBtn.TabIndex = 6;
            this.pesteTextBtn.Text = "Peste text";
            this.pesteTextBtn.UseVisualStyleBackColor = true;
            this.pesteTextBtn.Click += new System.EventHandler(this.pesteTextBtn_Click);
            // 
            // AesConvertTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pesteTextBtn);
            this.Controls.Add(this.copyTextBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "AesConvertTextDialog";
            this.Text = "Enter text and password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyTextBtn;
        private System.Windows.Forms.Button pesteTextBtn;
    }
}