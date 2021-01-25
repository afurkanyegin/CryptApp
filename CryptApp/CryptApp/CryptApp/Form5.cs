using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CryptApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string encrypted, key;

        private void encryptedrichTextBox_TextChanged(object sender, EventArgs e)
        {
            encrypted = encryptedrichTextBox.Text;
        }

        private void keytextBox_TextChanged(object sender, EventArgs e)
        {
            key = keytextBox.Text;
        }

        string filepath, filetext;
        private void decryptbutton_Click(object sender, EventArgs e)
        {
            if((key == "") || encrypted == "")
            {
                keytextBox.Focus();
            }
            else
            {
                vigenere vigenere = new vigenere();
                decryptedrichTextBox.Text = vigenere.vigeneredecrypt(encrypted, key);
            }
            
        }

        private void openfilebutton_Click(object sender, EventArgs e)
        {
            Stream mystream;

            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((mystream = openfile.OpenFile()) != null)
                {
                    filepath = openfile.FileName;
                    filetext = File.ReadAllText(filepath, System.Text.Encoding.UTF8);
                    encryptedrichTextBox.Text = filetext;
                }

            }
        }


    }
}
