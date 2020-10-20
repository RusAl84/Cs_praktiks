using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWindowsForms
{
    // Класс игрока
        public class Player {
        public PointF pos;
        public PointF acc;
        public float speed = 5f;
        public float fade = 0.9f;
        public float size = 30;

        public Player(PointF pos) {
            this.pos = pos;
            this.acc = new PointF(0, 0);
        }
    }

    // Класс снаряда
    public class Shot {
        public PointF pos;
        public PointF acc;
        public float size = 10;
        public float lifeTime = 200;

        public Shot(PointF pos, PointF acc) {
            this.pos = pos;
            this.acc = acc;
        }
    }

    public partial class Form1 : Form
    {
        // Ресурсы игры
        int gameTime = 0;
        Bitmap scene;
        Graphics g;
        Brush brushBlack;
        Font mainFont;
        Image spriteGrass;

        // Состояние игры
        Player player;
        List<Shot> shots;
        bool keyW = false;
        bool keyA = false;
        bool keyS = false;
        bool keyD = false;
        bool keySpace = false;

        public Form1()
        {
            InitializeComponent();
            gameTimer.Interval = 1000 / 30;
            gameTimer.Start();

            // Инициализация объектов
            scene = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(scene);
            brushBlack = new SolidBrush(Color.Black);
            mainFont = new Font(FontFamily.GenericSansSerif, 15);
            spriteGrass = Image.FromFile("../../resources/texture_grass.jpg");
            player = new Player(new PointF(scene.Width/2, scene.Height/2));
            shots = new List<Shot>();
        }

        // Обработка нажатия кнопок клавиатуры
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) this.keyW = true;
            if (e.KeyCode == Keys.A) this.keyA = true;
            if (e.KeyCode == Keys.S) this.keyS = true;
            if (e.KeyCode == Keys.D) this.keyD = true;
            if (e.KeyCode == Keys.Space) this.keySpace = true;
        }

        // Обработка нажатия кнопок клавиатуры
        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) this.keyW = false;
            if (e.KeyCode == Keys.A) this.keyA = false;
            if (e.KeyCode == Keys.S) this.keyS = false;
            if (e.KeyCode == Keys.D) this.keyD = false;
            if (e.KeyCode == Keys.Space) this.keySpace = false;
        }

        // Логика игры и отрисовка объектов
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g.DrawImage(spriteGrass, 0, 0, scene.Width, scene.Height);

            // Логика перемещения персонажа
            if (keyW) player.acc.Y -= player.speed;
            if (keyA) player.acc.X -= player.speed;
            if (keyS) player.acc.Y += player.speed;
            if (keyD) player.acc.X += player.speed;

            // Логика игрового перемещения
            player.pos.X += player.acc.X;
            player.pos.Y += player.acc.Y;
            player.acc.X *= player.fade;
            player.acc.Y *= player.fade;

            // Инверсия ускорения игрока дла предотвращения
            // выхода за границы игровой карты
            if (player.pos.X < 0)
            {
                player.pos.X = 0;
                player.acc.X *= -1f;
            }
            if (player.pos.Y < 0)
            {
                player.pos.Y = 0;
                player.acc.Y *= -1f;
            }
            if (player.pos.X > scene.Width)
            {
                player.pos.X = scene.Width;
                player.acc.X *= -1f;
            }
            if (player.pos.Y > scene.Height)
            {
                player.pos.Y = scene.Height;
                player.acc.Y *= -1f;
            }

            // Отрисовка игрока
            g.FillEllipse(
                brushBlack,
                player.pos.X - player.size / 2f,
                player.pos.Y - player.size / 2f,
                player.size,
                player.size
            );

            // Текущее направление выстрела
            var direction = new PointF(
                    (float)Math.Sin(gameTime / 10f),
                    (float)Math.Cos(gameTime / 10f)
            );

            // Отрисовка подсказки для текущего направления
            g.DrawLine(
                new Pen(Color.Red, 3), 
                player.pos, 
                new PointF(
                    player.pos.X + direction.X * player.size/2f,
                    player.pos.Y + direction.Y * player.size/2f
                )
            );

            // Обработка логики выстрела
            if (keySpace)
            {
                var speed = 5f;                
                shots.Add(new Shot(player.pos, new PointF(direction.X * speed, direction.Y * speed)));                
            }

            // Отрисовка снарядов
            for (var i = 0; i < shots.Count; i++) {
                var shot = shots[i];

                // Отрисовка одного снадяра
                g.FillEllipse(
                    new SolidBrush(Color.FromArgb(255 - (int)(200 - shot.lifeTime), Color.Yellow)),
                    shot.pos.X - shot.size / 2f,
                    shot.pos.Y - shot.size / 2f,
                    shot.size,
                    shot.size
                );

                // Изменение позиции снаряда
                shot.pos.X += shot.acc.X;
                shot.pos.Y += shot.acc.Y;

                // Уменьшение времени жизни снаряда
                shot.lifeTime--;
                if (shot.lifeTime <= 0) {
                    shots.RemoveAt(i);
                    i--;
                }
            }

            // Отрисовка отладочной информации
            g.DrawString(
                Convert.ToString(player.pos), 
                mainFont, 
                brushBlack, 
                0, 
                0
            );

            canvas.Image = scene;
            gameTime++;
        }
    }
}
