using System;
using System.Drawing;
using System.Windows.Forms;

namespace CosmoStar.Game
{
    public class Game
    {
        // Объект состояний игры
        GameState state;

        public Game(GameState state) {
            this.state = state;

            // Инициализация теневого экрана
            state.shadowScreen = new Bitmap(state.screen.Width, state.screen.Height);
            state.gCtxShadow = Graphics.FromImage(state.shadowScreen);

            // Инициализация сцены
            state.scene = new Objects.GameObject();

            // Инициализация игровых объектов
            state.player = new Objects.Player();
            state.player.pos = new PointF(state.screen.Width / 2f, state.screen.Height / 2f);
            state.scene.AddChild(state.player);
        }

        // Логика обновления состояний игры
        public void Update() {
            state.scene.Update(state);            
        }

        // Логика отрисовки состояния игры
        public void Draw()
        {
            // Очистка основго экрана
            state.gCtx.Clear(Color.Black);
            // Очиста теневого экрана но частично для эффекта следа
            state.gCtxShadow.FillRectangle(
                new SolidBrush(Color.FromArgb(10, Color.Black)),
                0, 0, state.shadowScreen.Width, state.shadowScreen.Height
            );

            // Отрисовка теневого экрана
            state.gCtx.DrawImage(state.shadowScreen, 0, 0);

            // Отрисовка главной сцены с объектами
            state.scene.Draw(state);
        }
    }    
}
