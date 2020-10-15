using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;

namespace PieChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            ArrayList data = new ArrayList();
            data.Add(new PieChartElement("East", (float)50.75));
            data.Add(new PieChartElement("West", (float)22));
            data.Add(new PieChartElement("North", (float)72.32));
            data.Add(new PieChartElement("South", (float)12));
            data.Add(new PieChartElement("Central", (float)44));

            chart.Image = drawPieChart(data, new Size(chart.Width, chart.Height));
        }

        private Image drawPieChart(ArrayList elements, Size s)
        {
            Color[] colors = { Color.Red, Color.Violet, Color.Pink, Color.FromArgb(0xAA00FF), 
                Color.Lavender, Color.Indigo, Color.DarkSalmon, Color.DarkRed, 
                Color.DarkOrange, Color.DarkSalmon, Color.DarkGreen, 
                Color.DarkBlue, Color.Lavender, Color.LightBlue, Color.Coral };

            if (elements.Count > colors.Length)
            {
                throw new ArgumentException("Pie chart must have " + colors.Length + " or fewer elements");
            }

            Bitmap bm = new Bitmap(s.Width, s.Height);
            Graphics g = Graphics.FromImage(bm);
            g.SmoothingMode = SmoothingMode.HighQuality;

            // Calculate total value of all rows
            float total = 0;

            foreach (PieChartElement e in elements)
            {
                if (e.value < 0)
                {
                    throw new ArgumentException("All elements must have positive values");
                }
                total += e.value;
            }

            if (!(total > 0))
            {
                throw new ArgumentException("Must provide at least one PieChartElement with a positive value");
            }

            // Define the rectangle that the pie chart will use
            Rectangle rect = new Rectangle(1, 1, s.Width - 2, s.Height - 2);

            Pen p = new Pen(Color.Black, 5);

            // Draw the first section at 0 degrees
            float startAngle = 0;
            int colorNum = 0;

            // Draw each of the pie shapes
            foreach (PieChartElement e in elements)
            {
                // Create a brush with a nice gradient
                //Brush b = new LinearGradientBrush(rect, colors[colorNum++], Color.White, (float)45);
                Brush b = new SolidBrush(colors[colorNum++]);
                
                // Calculate the degrees that this section will consume,
                // based on the percentage of the total
                float sweepAngle = (e.value / total) * 360;
                
                // Draw the filled in pie shapes
                g.FillPie(b, rect, startAngle, sweepAngle);

                // Draw the pie shape outlines
                g.DrawPie(p, rect, startAngle, sweepAngle);
                
                // Calculate the angle for the next pie shape by adding
                // the current shape's degrees to the previous total.
                startAngle += sweepAngle;
            }
            return bm;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}