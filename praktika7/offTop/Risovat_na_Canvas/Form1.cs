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
    public class Shot {
        public int lifeTime;
        public Point pos;

        public Shot(Point pos) {
            this.pos = pos;
            this.lifeTime = 50;
        }
    }

    public partial class Form1 : Form
    {
        public int x = 0;
        public int x1 = 0;   
        public int y1 = 0;

        public int gameTime = 0;

        // Пути к ресурсам спрайтов
        string girlImagePath = "../../Resources/girl.jpg";
        string tankImagePath = "../../Resources/tank.png";

        // Ресурсы игры
        Bitmap girlImage;
        Bitmap tankImage;
        Pen aquaPen;
        Font fontMain;
        Random rand;

        // Экраны
        Bitmap screen;

        // Инструменты
        Graphics g;

        // Состояние игры
        List<Shot> shots = new List<Shot>();

        public Form1()
        {
            InitializeComponent();

            this.Width = 400;
            this.Height = 400;
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;

            // Загрузка ресурсов
            girlImage = new Bitmap(girlImagePath);
            tankImage = new Bitmap(tankImagePath);
            aquaPen = new Pen(Color.Aqua, 3);
            aquaPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            aquaPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            fontMain = new Font(FontFamily.GenericSansSerif, 15);
            rand = new Random();

            // Инициализация экранов
            screen = new Bitmap(400, 400);

            // Инициализация инструментов
            g = Graphics.FromImage(screen);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            // Настройка компонентов
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Create pen.
            //Pen blackPen = new Pen(Color.Aqua, 10);
            //DrawHair(blackPen);

            // Очистка экрана и отрисовка девочки
            g.Clear(Color.White);
            g.DrawImage(girlImage, 0, 0, screen.Width, screen.Height);

            // Отрисовка волос
            for (var i = 0; i < 30; i++) {
                int hairOffsetX = 150;
                int hairOffsetY = 70;
                g.DrawLine(
                    aquaPen, 
                    hairOffsetX + i * 5, 
                    hairOffsetY, 
                    hairOffsetX + i * 5 + (int)(Math.Sin(gameTime / 8.0) * 8.0), 
                    hairOffsetY - 50
                );
            }

            // Отрисовка танка            
            var tankPos = new Point(
                (int)(Math.Sin(gameTime / 10.0) * 100.0 + 200.0), 
                (int)(Math.Cos(gameTime / 15.0) * 100.0 + 200.0)
            );            
            g.DrawImage(
                tankImage, 
                tankPos.X,
                tankPos.Y,
                50, 
                50
            );

            // Создание выстрела
            if (gameTime % 10 == 0) {
                shots.Add(new Shot(new Point(rand.Next(0, screen.Width), rand.Next(0, screen.Height))));
            }

            // Отрисовка выстрелов
            foreach (var shot in shots) {
                var radius = shot.lifeTime;
                g.FillEllipse(
                    new SolidBrush(Color.Red), 
                    shot.pos.X - radius/2, 
                    shot.pos.Y - radius/2, 
                    radius, 
                    radius
                );                
            }
           
            // Обработка жизненного цикла выстрелов
            for (var i = 0; i < shots.Count; i++)
            {
                var shot = shots[i];
                shot.lifeTime--;
                if (shot.lifeTime <= 0) {
                    shots.RemoveAt(i);
                    i--;
                }
            }

            // Отрисовка текста
            g.DrawString("Я люблю C#", fontMain, new SolidBrush(Color.Black), 0, 0);

            // Обновление изображения на экране
            pictureBox1.Image = screen;

            gameTime++;
        }
    }
}
