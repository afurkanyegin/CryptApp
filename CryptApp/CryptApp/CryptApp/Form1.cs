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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string method = "";
        string operation = "";

        private void cryptionradioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "cryption";
        }

        private void decryptionradioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "decryption";
        }

        private void vigenereradioButton_CheckedChanged(object sender, EventArgs e)
        {
            method = "vigenere";
        }

        private void continuebutton_Click(object sender, EventArgs e)
        {
            if (rsaradioButton.Checked)
            {
                MessageBox.Show("RSA method is not available at the moment", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if ((operation == "cryption") && (method == "vigenere"))
            {
                if (filebasedcheckbox.Checked)
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                    return;
                }
                //this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if ((operation == "decryption") && (method == "vigenere"))
            {
                if (filebasedcheckbox.Checked)
                {
                    Form5 form5 = new Form5();
                    form5.ShowDialog();
                    return;
                }
                //this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select operation and method !","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
