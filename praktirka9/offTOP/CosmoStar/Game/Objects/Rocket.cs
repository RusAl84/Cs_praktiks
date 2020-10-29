using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoStar.Game.Objects
{
    public class Rocket: GameObject
    {
        // Скорость перемещения ракеты
        public float speed = 5f;
        // Вектор полёта
        public PointF vect;
        // Время жизни ракеты после которого она исчезнет
        public float lifeTime = 50f;

        public Rocket(PointF pos, PointF vect) : base() {
            this.pos = pos;
            this.vect = vect;
            size = 6f;
            accFade = 0.9f;
        }

        // Лгика полёта ракеты
        public override void Update(GameState state)
        {
            base.Update(state);

            // Нормализация вектора
            var len = (float)Math.Sqrt(Math.Pow(vect.X, 2) + Math.Pow(vect.Y, 2));
            var nVect = new PointF(vect.X / len, vect.Y / len);

            // Прибавление вектора направления к вектору ускорения
            acc.X += nVect.X * speed;
            acc.Y += nVect.Y * speed;

            // Уменьшаем время жизни и удаляем ракету если оно меньше 0
            lifeTime--;
            if (lifeTime < 0) deleted = true;
        }

        // Отрисовка ракеты
        public override void Draw(GameState state)
        {
            base.Draw(state);

            // Отрисовка тела ракеты
            state.gCtxShadow.FillEllipse(
                new SolidBrush(Color.Violet),
                pos.X, pos.Y, size, size
            );
        }
    }
}
