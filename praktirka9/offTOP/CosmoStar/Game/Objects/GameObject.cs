using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CosmoStar.Game.Objects
{
    // Общеигровой класс от которого должны наследоваться все объекты
    public class GameObject
    {
        // Позиция объекта
        public PointF pos = new PointF(0, 0);
        // Ускорение объекта
        public PointF acc = new PointF(0, 0);
        // Коэффициент затухания скорости
        public float accFade = 1f;
        // Размер объекта
        public float size = 0f;

        // Состояние удаления объекта
        // Объект может установить этот флаг после чего его обработка будет
        // Прекращена и он будет удалён сборщиком мусора
        public bool deleted = false;

        // Дочерние объекты которые будут перерисовываться вместе с корневым объектом
        public Dictionary<GameObject, GameObject> childs = new Dictionary<GameObject, GameObject>();

        // Добавляет дочерний объект
        public void AddChild(GameObject child) {
            childs.Add(child, child);
        }

        // Удаляет дочерний объект
        public void RemoveChild(GameObject child) {
            if (childs.ContainsKey(child)) childs.Remove(child);
        }

        // Делает сборку мусора объектов помеченных как удалённые
        public void RemoveDeleted() {
            var childsList = childs.Keys;
            foreach (var c in childsList) { 
                // Если дочерний объект помечен как удалённый
                if (c.deleted)
                {
                    // Помечаем как удалённые все дочерние объекты и удаляем их
                    foreach (var subChilds in c.childs) {
                        subChilds.Value.deleted = true;
                        subChilds.Value.RemoveDeleted();
                    }
                    // Удаляем сам дочерний объект
                    RemoveChild(c);
                }
            }
        }

        // Обновление логики объекта
        public virtual void Update(GameState state)
        {
            // Изменение позиции игрока прибавлением вектора скорости
            pos.X += acc.X;
            pos.Y += acc.Y;

            // Затухание вектора скорости
            acc.X *= accFade;
            acc.Y *= accFade;

            // Удержание объекта в рамках экрана
            if (pos.X - size / 2f < 0)
            {
                pos.X = size / 2f;
                acc.X *= -1f;
            }
            if (pos.X + size / 2f > state.screen.Width)
            {
                pos.X = state.screen.Width - size / 2f;
                acc.X *= -1f;
            }
            if (pos.Y - size / 2f < 0)
            {
                pos.Y = size / 2f;
                acc.Y *= -1f;
            }
            if (pos.Y + size / 2f > state.screen.Height)
            {
                pos.Y = state.screen.Height - size / 2f;
                acc.Y *= -1f;
            }

            // Рекурсивная обработка логики дочерних объектов
            foreach (var child in childs) {
                if (!child.Value.deleted)
                    child.Value.Update(state);
            }
        }

        // Обновление графики объекта
        public virtual void Draw(GameState state) {
            // Рекурсивная обработка логики отрисовки дочерних объектов
            foreach (var child in childs)
            {
                if (!child.Value.deleted)
                    child.Value.Draw(state);
            }
        }
    }
}
