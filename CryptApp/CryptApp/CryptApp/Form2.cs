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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string plaintext = String.Empty;
        string key = String.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            plaintext = textBox1.Text;
            button1.Focus();
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            key = textBox3.Text;
            button1.Focus();
            textBox3.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((key == "") || (plaintext == ""))
            {
                textBox2.Text = String.Empty;
                textBox3.Focus();
                return;
            }
            else
            {
                vigenere vigenere = new vigenere();
                textBox2.Text = vigenere.vigenerecrypt(plaintext, key);
            }
            
            
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                textBox3.Focus();
            }
        }
    }
}
