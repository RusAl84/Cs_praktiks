using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppVazelin
{
  public partial class Form1 : Form
  {
    private bool flag;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

      if (checkBox1.Checked)
        timer1.Enabled = true;
      else
        timer1.Enabled = false;

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (flag) { 
        progressBar1.Value++;
        if (progressBar1.Value >= 99)
          progressBar1.Value = 0;
      }
      else
      {
        if (progressBar1.Value >=1)
          progressBar1.Value--;
        if (progressBar1.Value <= 1)
          progressBar1.Value = 100;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      flag = false;
      timer1.Enabled=true;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}
