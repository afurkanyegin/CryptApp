namespace CryptApp
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.keytextBox = new System.Windows.Forms.TextBox();
            this.decryptbutton = new System.Windows.Forms.Button();
            this.decryptedrichTextBox = new System.Windows.Forms.RichTextBox();
            this.openfilebutton = new System.Windows.Forms.Button();
            this.encryptedrichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Key :";
            // 
            // keytextBox
            // 
            this.keytextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.keytextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F);
            this.keytextBox.Location = new System.Drawing.Point(129, 544);
            this.keytextBox.Name = "keytextBox";
            this.keytextBox.Size = new System.Drawing.Size(935, 40);
            this.keytextBox.TabIndex = 10;
            this.keytextBox.TextChanged += new System.EventHandler(this.keytextBox_TextChanged);
            // 
            // decryptbutton
            // 
            this.decryptbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decryptbutton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decryptbutton.Location = new System.Drawing.Point(467, 159);
            this.decryptbutton.Name = "decryptbutton";
            this.decryptbutton.Size = new System.Drawing.Size(171, 63);
            this.decryptbutton.TabIndex = 9;
            this.decryptbutton.Text = "DECRYPT->";
            this.decryptbutton.UseVisualStyleBackColor = true;
            this.decryptbutton.Click += new System.EventHandler(this.decryptbutton_Click);
            // 
            // decryptedrichTextBox
            // 
            this.decryptedrichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptedrichTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decryptedrichTextBox.Location = new System.Drawing.Point(641, 19);
            this.decryptedrichTextBox.Name = "decryptedrichTextBox";
            this.decryptedrichTextBox.Size = new System.Drawing.Size(444, 506);
            this.decryptedrichTextBox.TabIndex = 8;
            this.decryptedrichTextBox.Text = "";
            // 
            // openfilebutton
            // 
            this.openfilebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openfilebutton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.openfilebutton.Location = new System.Drawing.Point(467, 445);
            this.openfilebutton.Name = "openfilebutton";
            this.openfilebutton.Size = new System.Drawing.Size(171, 65);
            this.openfilebutton.TabIndex = 7;
            this.openfilebutton.Text = "OPEN FILE";
            this.openfilebutton.UseVisualStyleBackColor = true;
            this.openfilebutton.Click += new System.EventHandler(this.openfilebutton_Click);
            // 
            // encryptedrichTextBox
            // 
            this.encryptedrichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.encryptedrichTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.encryptedrichTextBox.Location = new System.Drawing.Point(23, 19);
            this.encryptedrichTextBox.Name = "encryptedrichTextBox";
            this.encryptedrichTextBox.Size = new System.Drawing.Size(442, 506);
            this.encryptedrichTextBox.TabIndex = 6;
            this.encryptedrichTextBox.Text = "";
            this.encryptedrichTextBox.TextChanged += new System.EventHandler(this.encryptedrichTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 134);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keytextBox);
            this.Controls.Add(this.decryptbutton);
            this.Controls.Add(this.decryptedrichTextBox);
            this.Controls.Add(this.openfilebutton);
            this.Controls.Add(this.encryptedrichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1125, 900);
            this.MinimumSize = new System.Drawing.Size(1125, 641);
            this.Name = "Form5";
            this.Text = "Vigenere Decryption from File";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keytextBox;
        private System.Windows.Forms.Button decryptbutton;
        private System.Windows.Forms.RichTextBox decryptedrichTextBox;
        private System.Windows.Forms.Button openfilebutton;
        private System.Windows.Forms.RichTextBox encryptedrichTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}