using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranspositionCipher
{
    public partial class Form1 : Form
    {
        Transposition t;

        public Form1()
        {
            InitializeComponent();

            t = new Transposition();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            t.SetKey(keyTextBox.Text);

            if (encryptRadioButton.Checked)
                outputTextBox.Text = t.Encrypt(inputTextBox.Text);
            else
                outputTextBox.Text = t.Decrypt(inputTextBox.Text);
        }
    }
}