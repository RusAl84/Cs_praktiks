using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stretches the image to fit the pictureBox.
            Bitmap MyImage;
            string fileToDisplay = @"D:\temp\1.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            MyImage = new Bitmap(fileToDisplay);

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 30);
            // Create coordinates of points that define line.
            x += 5;
            int x1 = 1 + x;   //topleft to topright
            int y1 = 1 + x;
            int x2 = 300 + x + (int)(1 * x);
            int y2 = 300 + x + (int)(1 * x);

            // Draw line to screen.
            using (var graphics = Graphics.FromImage(MyImage))
            {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }


            pictureBox1.ClientSize = new Size(400, 400);
            pictureBox1.Image = (Image)MyImage;
        }
    }
}
