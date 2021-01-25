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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string filepath, filetext;
        string plaintext, key;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            plaintext = richTextBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((key == "") || plaintext == "")
            {
                textBox1.Focus();
            }
            else
            {
                vigenere vigenere = new vigenere();
                richTextBox2.Text = vigenere.vigenerecrypt(plaintext, key);
            }

        }

        //private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox2.Copy();
        //}
        string fname = String.Empty;

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            key = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream mystream;

            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((mystream = openfile.OpenFile()) != null)
                {
                    filepath = openfile.FileName;
                    filetext = File.ReadAllText(filepath, System.Text.Encoding.UTF8);
                    richTextBox1.Text = filetext;
                }

            }
        }

  
    }
}
