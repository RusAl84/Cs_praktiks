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

namespace WindowsFormsDrawCanvas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Width = 200;
            int Height = 200;
            Bitmap bm = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bm);
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);
            Pen p = new Pen(Color.Black, 5);
            Brush b = new LinearGradientBrush(rect, Color.Violet, Color.White, (float)45);
            Random rand = new Random();

            //int startAngle = 45;//rand.Next(-1, 1);
            //int sweepAngle = 270;//rand.Next(-1, 1);
            //g.FillPie(b, rect, startAngle, sweepAngle);
            //g.DrawPie(p, rect, startAngle, sweepAngle);

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle.
            Rectangle rect2 = new Rectangle(0, 0, 200, 200);

            // Draw rectangle to screen.
            g.DrawRectangle(blackPen, rect2);

            pictureBox1.Image = bm;
        }
    }
}
