using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
          if (progressBar1.Value > 99)
         {
            progressBar1.Value = 0;
          }

         progressBar1.Value += 1;
         trackBar1.Value = progressBar1.Value;
         progressBar3.Value=100 - progressBar1.Value;

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
      progressBar1.Value = trackBar1.Value;
    }
  }
}
