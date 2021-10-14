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

namespace ScreanSaverWF
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
    public List<Color> listOfColor = new List<Color>() { Color.Bisque, Color.BlueViolet, Color.AliceBlue,
    Color.DarkGreen, Color.Silver, Color.DarkGoldenrod, Color.Chocolate, Color.Aquamarine,
    Color.IndianRed, Color.DarkBlue, Color.PapayaWhip, Color.DarkSeaGreen};

    public void drawEl(int lx, int ly, int rx, int ry)
    {
      Rectangle rect = new Rectangle(lx, ly, rx, ry);
      g.DrawEllipse(_pen, rect);
      g.FillEllipse(_brush, rect);
    }
    public void drawRectangle(int lx, int ly, int rx, int ry)
    {
      Rectangle rect = new Rectangle(lx, ly, rx, ry);
      g.DrawRectangle(_pen, rect);
      g.FillRectangle(_brush, rect);
    }
    public void draw()
    {
      Random rnd = new Random();
      _brush = new SolidBrush(listOfColor[rnd.Next(listOfColor.Count)]);
      drawEl(0+rnd.Next(700), 0 + rnd.Next(700), 1 + rnd.Next(100), 1 + rnd.Next(100));
      _brush = new SolidBrush(listOfColor[rnd.Next(listOfColor.Count)]);
      drawRectangle(0+rnd.Next(700), 0 + rnd.Next(700), 1 + rnd.Next(100), 1 + rnd.Next(100));
      var shape = new PointF[6];

      var r = 4 + rnd.Next(400); //70 px radius 

      //Create 6 points
      //var x_0 = 700 / 2;
      //var y_0 = 700 / 2;
      var x_0 = rnd.Next(700);
      var y_0 = rnd.Next(700);
      for (int a = 0; a < 6; a++)
      {

        shape[a] = new PointF(
            x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
            y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
      }
      _pen = new Pen(_brush,rnd.Next(10));
      g.DrawPolygon(_pen, shape);
      _pen = new Pen(Color.Black);

      //drawEl(180, 275, 100, 50);
      //drawEl(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
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

    private void button2_Click(object sender, EventArgs e)
    {
      g.Clear(Color.White);
      pictureBox1.Image = bm;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      for(int i=0; i<10; i++)
      draw();
      pictureBox1.Image = bm;
    }
  }
}
