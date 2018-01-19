namespace RSADemo
{
    partial class RSAWindow
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
            this.PlainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PlainTextLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.EncryptedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptedTextLabel = new System.Windows.Forms.Label();
            this.DecryptedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DecryotedTextLabel = new System.Windows.Forms.Label();
            this.KeysLabel = new System.Windows.Forms.Label();
            this.GenerateKeysButton = new System.Windows.Forms.Button();
            this.pLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.nRichTextBox = new System.Windows.Forms.RichTextBox();
            this.phiLabel = new System.Windows.Forms.Label();
            this.phiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.lLabel = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.eRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dRichTextBox = new System.Windows.Forms.RichTextBox();
            this.eLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.PrimeGenerationCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PlainRichTextBox
            // 
            this.PlainRichTextBox.Location = new System.Drawing.Point(11, 259);
            this.PlainRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlainRichTextBox.Name = "PlainRichTextBox";
            this.PlainRichTextBox.Size = new System.Drawing.Size(762, 109);
            this.PlainRichTextBox.TabIndex = 0;
            this.PlainRichTextBox.Text = "";
            // 
            // PlainTextLabel
            // 
            this.PlainTextLabel.AutoSize = true;
            this.PlainTextLabel.Location = new System.Drawing.Point(11, 242);
            this.PlainTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlainTextLabel.Name = "PlainTextLabel";
            this.PlainTextLabel.Size = new System.Drawing.Size(50, 13);
            this.PlainTextLabel.TabIndex = 1;
            this.PlainTextLabel.Text = "Plain text";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(784, 259);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(2);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(100, 25);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // EncryptedRichTextBox
            // 
            this.EncryptedRichTextBox.Location = new System.Drawing.Point(13, 385);
            this.EncryptedRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EncryptedRichTextBox.Name = "EncryptedRichTextBox";
            this.EncryptedRichTextBox.Size = new System.Drawing.Size(760, 97);
            this.EncryptedRichTextBox.TabIndex = 3;
            this.EncryptedRichTextBox.Text = "";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(784, 385);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(100, 25);
            this.DecryptButton.TabIndex = 4;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptedTextLabel
            // 
            this.EncryptedTextLabel.AutoSize = true;
            this.EncryptedTextLabel.Location = new System.Drawing.Point(11, 369);
            this.EncryptedTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EncryptedTextLabel.Name = "EncryptedTextLabel";
            this.EncryptedTextLabel.Size = new System.Drawing.Size(75, 13);
            this.EncryptedTextLabel.TabIndex = 5;
            this.EncryptedTextLabel.Text = "Encrypted text";
            // 
            // DecryptedRichTextBox
            // 
            this.DecryptedRichTextBox.Location = new System.Drawing.Point(13, 500);
            this.DecryptedRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DecryptedRichTextBox.Name = "DecryptedRichTextBox";
            this.DecryptedRichTextBox.Size = new System.Drawing.Size(762, 93);
            this.DecryptedRichTextBox.TabIndex = 6;
            this.DecryptedRichTextBox.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(784, 500);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 25);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DecryotedTextLabel
            // 
            this.DecryotedTextLabel.AutoSize = true;
            this.DecryotedTextLabel.Location = new System.Drawing.Point(13, 484);
            this.DecryotedTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DecryotedTextLabel.Name = "DecryotedTextLabel";
            this.DecryotedTextLabel.Size = new System.Drawing.Size(76, 13);
            this.DecryotedTextLabel.TabIndex = 8;
            this.DecryotedTextLabel.Text = "Decrypted text";
            // 
            // KeysLabel
            // 
            this.KeysLabel.AutoSize = true;
            this.KeysLabel.Location = new System.Drawing.Point(9, 7);
            this.KeysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KeysLabel.Name = "KeysLabel";
            this.KeysLabel.Size = new System.Drawing.Size(30, 13);
            this.KeysLabel.TabIndex = 9;
            this.KeysLabel.Text = "Keys";
            // 
            // GenerateKeysButton
            // 
            this.GenerateKeysButton.Location = new System.Drawing.Point(765, 24);
            this.GenerateKeysButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateKeysButton.Name = "GenerateKeysButton";
            this.GenerateKeysButton.Size = new System.Drawing.Size(118, 35);
            this.GenerateKeysButton.TabIndex = 10;
            this.GenerateKeysButton.Text = "Generate keys";
            this.GenerateKeysButton.UseVisualStyleBackColor = true;
            this.GenerateKeysButton.Click += new System.EventHandler(this.GenerateKeysButton_Click);
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(9, 25);
            this.pLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(17, 13);
            this.pLabel.TabIndex = 11;
            this.pLabel.Text = "P:";
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Location = new System.Drawing.Point(9, 55);
            this.qLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(18, 13);
            this.qLabel.TabIndex = 12;
            this.qLabel.Text = "Q:";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(29, 24);
            this.pTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(655, 20);
            this.pTextBox.TabIndex = 13;
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(29, 55);
            this.qTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(655, 20);
            this.qTextBox.TabIndex = 14;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(9, 99);
            this.nLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(18, 13);
            this.nLabel.TabIndex = 15;
            this.nLabel.Text = "N:";
            // 
            // nRichTextBox
            // 
            this.nRichTextBox.Location = new System.Drawing.Point(30, 86);
            this.nRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nRichTextBox.Name = "nRichTextBox";
            this.nRichTextBox.Size = new System.Drawing.Size(853, 34);
            this.nRichTextBox.TabIndex = 16;
            this.nRichTextBox.Text = "";
            // 
            // phiLabel
            // 
            this.phiLabel.AutoSize = true;
            this.phiLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.phiLabel.Location = new System.Drawing.Point(10, 136);
            this.phiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(20, 13);
            this.phiLabel.TabIndex = 17;
            this.phiLabel.Text = "Ph";
            // 
            // phiRichTextBox
            // 
            this.phiRichTextBox.Location = new System.Drawing.Point(30, 124);
            this.phiRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phiRichTextBox.Name = "phiRichTextBox";
            this.phiRichTextBox.Size = new System.Drawing.Size(854, 34);
            this.phiRichTextBox.TabIndex = 18;
            this.phiRichTextBox.Text = "";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(689, 28);
            this.kLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(17, 13);
            this.kLabel.TabIndex = 19;
            this.kLabel.Text = "K:";
            // 
            // lLabel
            // 
            this.lLabel.AutoSize = true;
            this.lLabel.Location = new System.Drawing.Point(690, 58);
            this.lLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(16, 13);
            this.lLabel.TabIndex = 20;
            this.lLabel.Text = "L:";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(706, 25);
            this.kTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(41, 20);
            this.kTextBox.TabIndex = 21;
            // 
            // lTextBox
            // 
            this.lTextBox.Location = new System.Drawing.Point(706, 55);
            this.lTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(41, 20);
            this.lTextBox.TabIndex = 22;
            // 
            // eRichTextBox
            // 
            this.eRichTextBox.Location = new System.Drawing.Point(30, 162);
            this.eRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.eRichTextBox.Name = "eRichTextBox";
            this.eRichTextBox.Size = new System.Drawing.Size(854, 32);
            this.eRichTextBox.TabIndex = 23;
            this.eRichTextBox.Text = "";
            // 
            // dRichTextBox
            // 
            this.dRichTextBox.Location = new System.Drawing.Point(30, 198);
            this.dRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dRichTextBox.Name = "dRichTextBox";
            this.dRichTextBox.Size = new System.Drawing.Size(854, 34);
            this.dRichTextBox.TabIndex = 24;
            this.dRichTextBox.Text = "";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(13, 166);
            this.eLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(14, 13);
            this.eLabel.TabIndex = 25;
            this.eLabel.Text = "E";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(14, 200);
            this.dLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(15, 13);
            this.dLabel.TabIndex = 26;
            this.dLabel.Text = "D";
            // 
            // PrimeGenerationCheckbox
            // 
            this.PrimeGenerationCheckbox.AutoSize = true;
            this.PrimeGenerationCheckbox.Checked = true;
            this.PrimeGenerationCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PrimeGenerationCheckbox.Location = new System.Drawing.Point(771, 64);
            this.PrimeGenerationCheckbox.Name = "PrimeGenerationCheckbox";
            this.PrimeGenerationCheckbox.Size = new System.Drawing.Size(104, 17);
            this.PrimeGenerationCheckbox.TabIndex = 28;
            this.PrimeGenerationCheckbox.Text = "Generate Primes";
            this.PrimeGenerationCheckbox.UseVisualStyleBackColor = true;
            // 
            // RSAWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 604);
            this.Controls.Add(this.PrimeGenerationCheckbox);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.dRichTextBox);
            this.Controls.Add(this.eRichTextBox);
            this.Controls.Add(this.lTextBox);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.lLabel);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.phiRichTextBox);
            this.Controls.Add(this.phiLabel);
            this.Controls.Add(this.nRichTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.GenerateKeysButton);
            this.Controls.Add(this.KeysLabel);
            this.Controls.Add(this.DecryotedTextLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DecryptedRichTextBox);
            this.Controls.Add(this.EncryptedTextLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptedRichTextBox);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.PlainTextLabel);
            this.Controls.Add(this.PlainRichTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RSAWindow";
            this.Text = "RSA Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PlainRichTextBox;
        private System.Windows.Forms.Label PlainTextLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.RichTextBox EncryptedRichTextBox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label EncryptedTextLabel;
        private System.Windows.Forms.RichTextBox DecryptedRichTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label DecryotedTextLabel;
        private System.Windows.Forms.Label KeysLabel;
        private System.Windows.Forms.Button GenerateKeysButton;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.RichTextBox nRichTextBox;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.RichTextBox phiRichTextBox;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label lLabel;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.TextBox lTextBox;
        private System.Windows.Forms.RichTextBox eRichTextBox;
        private System.Windows.Forms.RichTextBox dRichTextBox;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.CheckBox PrimeGenerationCheckbox;
    }
}

