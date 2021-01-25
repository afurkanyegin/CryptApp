using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string encrypted=String.Empty;
        string key=String.Empty;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            encrypted = textBox4.Text;
            button1.Focus();
            textBox4.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            key = textBox3.Text;
            button1.Focus();
            textBox3.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((key=="") || encrypted=="")
            {
                textBox1.Text = string.Empty;
                textBox3.Focus();
                return;
            }
            else
            {
                vigenere vigenere = new vigenere();
                textBox1.Text = vigenere.vigeneredecrypt(encrypted, key);
            }
            
  
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
  
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }
    }
}
