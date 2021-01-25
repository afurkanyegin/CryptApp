namespace CryptApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptionradioButton = new System.Windows.Forms.RadioButton();
            this.cryptionradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vigenereradioButton = new System.Windows.Forms.RadioButton();
            this.rsaradioButton = new System.Windows.Forms.RadioButton();
            this.continuebutton = new System.Windows.Forms.Button();
            this.filebasedcheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Operation";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Method";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.decryptionradioButton);
            this.groupBox1.Controls.Add(this.cryptionradioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(138, 54);
            this.groupBox1.MinimumSize = new System.Drawing.Size(227, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 150);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // decryptionradioButton
            // 
            this.decryptionradioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.decryptionradioButton.AutoSize = true;
            this.decryptionradioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decryptionradioButton.Location = new System.Drawing.Point(239, 92);
            this.decryptionradioButton.Name = "decryptionradioButton";
            this.decryptionradioButton.Size = new System.Drawing.Size(132, 34);
            this.decryptionradioButton.TabIndex = 12;
            this.decryptionradioButton.TabStop = true;
            this.decryptionradioButton.Text = "Decryption";
            this.decryptionradioButton.UseVisualStyleBackColor = true;
            this.decryptionradioButton.CheckedChanged += new System.EventHandler(this.decryptionradioButton_CheckedChanged);
            // 
            // cryptionradioButton
            // 
            this.cryptionradioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cryptionradioButton.AutoSize = true;
            this.cryptionradioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cryptionradioButton.Location = new System.Drawing.Point(76, 92);
            this.cryptionradioButton.Name = "cryptionradioButton";
            this.cryptionradioButton.Size = new System.Drawing.Size(129, 34);
            this.cryptionradioButton.TabIndex = 11;
            this.cryptionradioButton.TabStop = true;
            this.cryptionradioButton.Text = "Encryption";
            this.cryptionradioButton.UseVisualStyleBackColor = true;
            this.cryptionradioButton.CheckedChanged += new System.EventHandler(this.cryptionradioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.vigenereradioButton);
            this.groupBox2.Controls.Add(this.rsaradioButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(59, 221);
            this.groupBox2.MinimumSize = new System.Drawing.Size(523, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 164);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // vigenereradioButton
            // 
            this.vigenereradioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vigenereradioButton.AutoSize = true;
            this.vigenereradioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.vigenereradioButton.Location = new System.Drawing.Point(171, 100);
            this.vigenereradioButton.Name = "vigenereradioButton";
            this.vigenereradioButton.Size = new System.Drawing.Size(113, 34);
            this.vigenereradioButton.TabIndex = 13;
            this.vigenereradioButton.TabStop = true;
            this.vigenereradioButton.Text = "Vigenere";
            this.vigenereradioButton.UseVisualStyleBackColor = true;
            this.vigenereradioButton.CheckedChanged += new System.EventHandler(this.vigenereradioButton_CheckedChanged);
            // 
            // rsaradioButton
            // 
            this.rsaradioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rsaradioButton.AutoSize = true;
            this.rsaradioButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.rsaradioButton.Location = new System.Drawing.Point(338, 100);
            this.rsaradioButton.Name = "rsaradioButton";
            this.rsaradioButton.Size = new System.Drawing.Size(69, 34);
            this.rsaradioButton.TabIndex = 14;
            this.rsaradioButton.TabStop = true;
            this.rsaradioButton.Text = "RSA";
            this.rsaradioButton.UseVisualStyleBackColor = true;
            // 
            // continuebutton
            // 
            this.continuebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continuebutton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.continuebutton.Location = new System.Drawing.Point(493, 421);
            this.continuebutton.MinimumSize = new System.Drawing.Size(105, 37);
            this.continuebutton.Name = "continuebutton";
            this.continuebutton.Size = new System.Drawing.Size(138, 65);
            this.continuebutton.TabIndex = 14;
            this.continuebutton.Text = "Continue";
            this.continuebutton.UseVisualStyleBackColor = true;
            this.continuebutton.Click += new System.EventHandler(this.continuebutton_Click);
            this.continuebutton.Enter += new System.EventHandler(this.continuebutton_Click);
            // 
            // filebasedcheckbox
            // 
            this.filebasedcheckbox.AutoSize = true;
            this.filebasedcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filebasedcheckbox.Location = new System.Drawing.Point(59, 440);
            this.filebasedcheckbox.Name = "filebasedcheckbox";
            this.filebasedcheckbox.Size = new System.Drawing.Size(277, 29);
            this.filebasedcheckbox.TabIndex = 15;
            this.filebasedcheckbox.Text = "Use File Based Operation";
            this.filebasedcheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 518);
            this.Controls.Add(this.filebasedcheckbox);
            this.Controls.Add(this.continuebutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(610, 513);
            this.Name = "Form1";
            this.Text = "CryptApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button continuebutton;
        private System.Windows.Forms.RadioButton decryptionradioButton;
        private System.Windows.Forms.RadioButton cryptionradioButton;
        private System.Windows.Forms.RadioButton vigenereradioButton;
        private System.Windows.Forms.RadioButton rsaradioButton;
        private System.Windows.Forms.CheckBox filebasedcheckbox;
    }
}

