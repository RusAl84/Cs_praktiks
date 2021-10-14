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

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    public int posX = 0;
    public int posY = 0;
    public static int Width = 600;
    public static int Height = 600;
    public static Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);
    public Pen _pen = new Pen(Color.Black, 5);
    public Brush _brush = Brushes.Green;
    public Graphics g;
    public Bitmap bm = new Bitmap(Width, Height);

    public void drawEl(int lx, int ly, int rx, int ry)
    {
      Rectangle rect = new Rectangle(lx, ly, rx, ry);
      g.DrawEllipse(_pen, rect);
      g.FillEllipse(_brush, rect);
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

    public void draw()
    {
      g.Clear(Color.White);
      _brush = Brushes.OrangeRed;
      drawEl(210,120, 100, 190);   //верхний лепесток
      drawEl(210,310, 100, 190);   //нижний лепесток
      _brush = Brushes.YellowGreen;
      drawEl(210, 260, 100, 100);  // круг

      _brush = Brushes.OrangeRed;
      drawEl(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
      pictureBox1.Image = bm;
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
