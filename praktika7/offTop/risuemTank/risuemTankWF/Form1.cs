using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risuemTankWF
{
  public partial class Form1 : Form
  {
    public static int Width = 700;
    public static int Height = 700;
    public static Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);
    public Pen _pen = new Pen(Color.Black, 5);
    public Brush _brush = Brushes.Violet;
    public Graphics g;
    public Bitmap bm = new Bitmap(Width, Height);
    public void drawEl(int lx, int ly, int rx, int ry)
    {
      Rectangle rect = new Rectangle(lx, ly, rx, ry);
      g.DrawEllipse(_pen, rect);
      g.FillEllipse(_brush, rect);
    }
    public void draw()
    {
      g.Clear(Color.White);
      drawEl(490, 250, 160, 20); // дуло
      drawEl(250, 190, 260, 210); // башня
      drawEl(100, 300, 550, 200); // ГусеницА
      drawEl(140, 330, 140, 140); // Колесо 1
      drawEl(290, 330, 140, 140); // Колесо 2
      drawEl(440, 330, 140, 140); // Колесо 3


      drawEl(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
      pictureBox1.Image = bm;
    }



    public Form1()
    {
      InitializeComponent();
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      label1.Text = e.X.ToString();
      label2.Text = e.Y.ToString();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      draw();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      g = Graphics.FromImage(bm);
      g.SmoothingMode = SmoothingMode.HighQuality;
      draw();
    }
  }
}
