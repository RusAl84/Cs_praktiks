using CosmoStar.Game.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoStar.Game
{
    // Состояние игры
    // Контекст экрана, рисования, позиции противников, игрока и пр.
    public class GameState
    {
        // Игровой экран ссылающийся на vScreen формы
        public Bitmap screen;
        // Экран со следом от объектов
        public Bitmap shadowScreen;
        // Контекст рисования ссылающийся на vGCtx формы
        public Graphics gCtx;
        // Контекст рисования на shadowScreen;
        public Graphics gCtxShadow;

        // Состояние игрового ввода
        public GameInput input;
        // Количество прошедших тиков с момента старта игры
        public float gameTime = 0f;
        // Генератор случайный чисел
        public Random rand = new Random();

        // Конструктор объекта состояний игры
        public GameState(Bitmap screen, Graphics gCtx, GameInput input) {
            this.screen = screen;
            this.gCtx = gCtx;
            this.input = input;
        }

        // Главная игровая сцена
        public GameObject scene;

        // Объект игрока
        public Player player;
    }
}
