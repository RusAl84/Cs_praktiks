using System;
using System.Drawing;
using System.Windows.Forms;

namespace CosmoStar.Game.Objects
{
    public class Player: GameObject
    {
        // Скорость игрока
        public float speed = 4f;

        // Конструктор игрока + конструктор наследуемого объекта
        public Player(): base() {
            accFade = 0.9f;
            size = 30f;
        }

        // Логика игрока
        public override void Update(GameState state)
        {
            base.Update(state);

            // Реакция на управление пользователя
            if (state.input.IsPressed((int)Keys.W)) acc.Y -= speed;
            if (state.input.IsPressed((int)Keys.S)) acc.Y += speed;
            if (state.input.IsPressed((int)Keys.A)) acc.X -= speed;
            if (state.input.IsPressed((int)Keys.D)) acc.X += speed;
            
            // Выстрел ракеты
            if (state.input.IsPressed((int)Keys.Space))
            {
                // Выбираем случайный угол
                var angle = (float)(Math.PI * 2f * state.rand.NextDouble());
                // Вычисляем вектор
                var vect = new PointF((float)Math.Sin(angle), (float)Math.Cos(angle));
                // Создаём ракету и добавляем её на сцену
                state.scene.AddChild(new Rocket(pos, vect));
            }
        }

        // Отрисовка игрока
        public override void Draw(GameState state)
        {
            base.Draw(state);

            // Рисуем круг игрока
            state.gCtx.FillEllipse(
                new SolidBrush(Color.White),
                pos.X - size / 2f,
                pos.Y - size / 2f,
                size,
                size
            );

            // Рисуем тень/хвост игрока
            state.gCtxShadow.FillEllipse(
                new SolidBrush(Color.Aqua),
                pos.X - size / 2f,
                pos.Y - size / 2f,
                size,
                size
            );

            // Рисуем щит игрока
            {
                var shieldSize = 6f;
                var shieldsCount = 3f;
                var shieldsSpeed = 15f;
                var shieldsDistance = 30f;
                var shieldAddAngle = (float)(Math.PI * 2f / shieldsCount);

                for (var i = 0; i < shieldsCount; i++)
                {
                    var shieldAngle = state.gameTime / shieldsSpeed + shieldAddAngle * i;
                    // Отрисовка щита
                    state.gCtxShadow.FillEllipse(
                        new SolidBrush(Color.Violet),
                        pos.X + (float)Math.Sin(shieldAngle) * shieldsDistance - shieldSize / 2f,
                        pos.Y + (float)Math.Cos(shieldAngle) * shieldsDistance - shieldSize / 2f,
                        shieldSize,
                        shieldSize
                    );
                }
            }
        }
    }
}
