using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox3.Text = textBox1.Text + textBox2.Text;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      textBox3.Text = textBox1.Text + textBox2.Text;
    }
  }
}
