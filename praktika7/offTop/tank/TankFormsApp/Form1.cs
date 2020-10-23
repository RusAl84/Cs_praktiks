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

namespace TankFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int fps = (int)(1000 / 60);
            timer1.Interval = fps;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Width = 400;
            int Height = 400;
            Bitmap bm = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bm);
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle(1, 1, Width - 2, Height - 2);
            Pen p = new Pen(Color.Black, 5);
            Brush b = new LinearGradientBrush(rect, Color.Violet, Color.White, (float)45);
            Random rand = new Random();
            int startAngle = 0 + rand.Next(-1, 1);
            int sweepAngle = 270 + rand.Next(-1, 1);
            g.FillPie(b, rect, startAngle, sweepAngle);
            g.DrawPie(p, rect, startAngle, sweepAngle);
            pictureBox1.Image = bm;
        }
    }
}
