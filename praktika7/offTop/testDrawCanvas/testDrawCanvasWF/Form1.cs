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

namespace testDrawCanvasWF
{
  public partial class Form1 : Form
  {



    public static int Width = 700;
    public static int Height = 700;
    Bitmap bm = new Bitmap(Width, Height);
    Graphics g;
    List<Color> listColor = new List<Color>() { Color.FloralWhite, Color.Orange, Color.DarkBlue, Color.IndianRed, Color.Chocolate, Color.HotPink, Color.GreenYellow, Color.DarkViolet, Color.MediumPurple}; 
    public void draw()
    {

      Pen p = new Pen(Color.Black, 5);
      Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);
      Brush b = new LinearGradientBrush(rect, Color.Violet, Color.White, (float)45);
      Pen blackPen = new Pen(Color.Black, 3);
      Random rnd = new Random();


      
      Rectangle rect2 = new Rectangle(rnd.Next(700), rnd.Next(700), rnd.Next(200), rnd.Next(200));
      g.DrawRectangle(blackPen, rect2);
      g.FillRectangle(new SolidBrush(listColor[rnd.Next(listColor.Count)]), rect2);
      Rectangle rect3 = new Rectangle(rnd.Next(700), rnd.Next(700), rnd.Next(200), rnd.Next(200));
      g.DrawRectangle(blackPen, rect3);
      g.FillRectangle(new SolidBrush(listColor[rnd.Next(listColor.Count)]), rect3);
      Rectangle rect4 = new Rectangle(rnd.Next(700), rnd.Next(700), rnd.Next(200), rnd.Next(200));
      g.DrawRectangle(blackPen, rect4);
      g.FillRectangle(new SolidBrush(listColor[rnd.Next(listColor.Count)]), rect4);         
      Rectangle rect5 = new Rectangle(rnd.Next(700), rnd.Next(700), rnd.Next(200), rnd.Next(200));
      g.DrawEllipse(blackPen, rect5);
      g.FillEllipse(new SolidBrush(listColor[rnd.Next(listColor.Count)]), rect5);

      pictureBox1.Image = bm;
    }

    public Form1()
    {
      InitializeComponent();
      listBox1.DrawMode = DrawMode.OwnerDrawVariable;
      listBox1.Items.Clear();

      foreach (Color item in listColor)
      {
        listBox1.Items.Add(item.Name);
      }
      listBox1.BackColor = Color.Thistle;
      this.listBox1.DrawItem +=
  new System.Windows.Forms.DrawItemEventHandler(
  this.listBox1_DrawItem);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      g = Graphics.FromImage(bm);
      g.SmoothingMode = SmoothingMode.HighQuality;
      // расширенное окно для выбора цвета
      colorDialog1.FullOpen = true;
      // установка начального цвета для colorDialog
      colorDialog1.Color = this.BackColor;




    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      draw();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        timer1.Enabled = true;
      }
      if (!checkBox1.Checked)
      {
        timer1.Enabled = false;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (colorDialog1.ShowDialog() == DialogResult.Cancel)
        return;
      // установка цвета формы
      this.BackColor = colorDialog1.Color;
    }

    private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
    {
      // Перерисовываем фон всех элементов ListBox.  
      e.DrawBackground();

      // Создаем объект Brush.  
      Brush myBrush = new SolidBrush(listColor[e.Index]);

      // Определяем номер текущего элемента  
      //switch (e.Index)
      //{
      //  case 0:
      //    myBrush = Brushes.Red;
      //    break;
      //  case 1:
      //    myBrush = Brushes.Green;
      //    break;
      //  case 2:
      //    myBrush = Brushes.Blue;
      //    break;
      //  default:
          
      //    break;
      //}

      //Если необходимо, закрашиваем фон   
      //активного элемента в новый цвет  
      e.Graphics.FillRectangle(myBrush, e.Bounds);  

      // Перерисовываем текст текущего элемента  
      e.Graphics.DrawString(
          ((ListBox)sender).Items[e.Index].ToString(),
          e.Font, myBrush, e.Bounds,
          StringFormat.GenericDefault);

      // Если ListBox в фокусе, рисуем прямоугольник   
      //вокруг активного элемента.  
      e.DrawFocusRectangle();
    }

    }
}
