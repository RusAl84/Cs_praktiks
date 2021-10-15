using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mgupiWF
{
  public partial class Form1 : Form
  {
    public int posX = 0;
    public int posY = 0;
    public static int Width = 600;
    public static int Height = 600;
    public static Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);
    public Pen _pen = new Pen(Color.Black, 5);
    public Brush _brush = Brushes.Linen;
    public Graphics g;
    public Bitmap bm = new Bitmap(Width, Height);

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
      g.Clear(Color.White);
      _brush = Brushes.AntiqueWhite;
      drawRect(50, 190, 500, 380);
      _brush = Brushes.SaddleBrown;
      drawRect(30, 150, 540, 40);
      drawRect(90, 240, 120, 180);
      drawRect(250, 240, 120, 180);
      drawRect(410, 240, 120, 180);
      //g.DrawString("МГУПИ",this.Font, Brushes.Black, 0, 0);
      var fontFamily = new FontFamily("Times New Roman");
      var font = new Font(fontFamily, 32, FontStyle.Regular, GraphicsUnit.Pixel);
      var solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
      g.TextRenderingHint = TextRenderingHint.AntiAlias;
      g.DrawString("МГУПИ", font, solidBrush, new PointF(120, 200));

      drawRect(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
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
