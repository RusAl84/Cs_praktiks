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

namespace B01Canvas
{
  public partial class Form1 : Form
  {
    int posX = 1;
    int posY = 1;

    public static int Width = 700;
    public static int Height = 700;
    public static Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);
    public Pen _pen = new Pen(Color.Black, 5);
    public Brush _brush = Brushes.Violet;
    public Graphics g;
    public Bitmap bm = new Bitmap(Width, Height);
    public List<Color> listOfColor = new List<Color>();



    public void drawEl(int lx, int ly, int rx, int ry)
    {
      Rectangle rect = new Rectangle(lx, ly, rx, ry);
      g.DrawEllipse(_pen, rect);
      g.FillEllipse(_brush, rect);
    }
    public void drawRect(int lx, int ly, int rx, int ry)
    {
      Rectangle rect = new Rectangle(lx, ly, rx, ry);
      g.DrawRectangle(_pen, rect);
      g.FillRectangle(_brush, rect);
    }


    public void draw()
    {

      Random rnd = new Random();

       
      _brush = new SolidBrush(listOfColor[rnd.Next(listOfColor.Count)]);
      drawEl(rnd.Next(700), rnd.Next(700), rnd.Next(500), rnd.Next(500));
            _brush = new SolidBrush(listOfColor[rnd.Next(listOfColor.Count)]);
      drawEl(rnd.Next(700), rnd.Next(700), rnd.Next(500), rnd.Next(500));
       _brush = new SolidBrush(listOfColor[rnd.Next(listOfColor.Count)]);
      drawEl(rnd.Next(700), rnd.Next(700), rnd.Next(300), rnd.Next(300));
      
      
      _brush = new SolidBrush(listOfColor[rnd.Next(listOfColor.Count)]);
      drawRect(rnd.Next(700), rnd.Next(700), rnd.Next(500), rnd.Next(500));
            _brush = new SolidBrush(listOfColor[rnd.Next(listOfColor.Count)]);
      drawRect(rnd.Next(700), rnd.Next(700), rnd.Next(500), rnd.Next(500));
      
      
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

    private void Form1_Load(object sender, EventArgs e)
    {
      g = Graphics.FromImage(bm);
      g.SmoothingMode = SmoothingMode.HighQuality;
      listOfColor.Add(Color.IndianRed);
      listOfColor.Add(Color.BlueViolet);
      listOfColor.Add(Color.HotPink);
      listOfColor.Add(Color.Aquamarine);
      listOfColor.Add(Color.DarkGoldenrod);
      listOfColor.Add(Color.LightSeaGreen);


      draw();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      g.Clear(Color.White);
      draw();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      draw();
    }
  }
}
