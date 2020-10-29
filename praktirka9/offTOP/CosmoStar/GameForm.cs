using System;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using System.Threading.Tasks;

namespace CosmoStar
{
    public class GameForm: Form
    {
        // Реальный экран где будем выводить итоговый кадр
        PictureBox screen = new PictureBox();
        // ВИртуальный игровой экран (может не совпадать с пропорциями и размерами реального)
        Bitmap vScreen;
        // Контекст рисования на виртуальном экране
        Graphics vGCtx;
        // Состояние ввода поользователя
        Game.GameInput input;

        // Экзнмпляр класса игры
        Game.Game game;
        // Экземпляр состояний игры
        Game.GameState state;

        // Конструктор формы
        public GameForm() {
            // Настройка формы
            this.ClientSize = new Size(500, 500);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.DoubleBuffered = true;

            // Настройка PictureBox (Screen)
            this.screen.Width = this.ClientSize.Width;
            this.screen.Height = this.ClientSize.Height;
            this.screen.BackColor = Color.White;            
            this.screen.Parent = this;

            // Настройка виртуального экрана
            this.vScreen = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            // Настрйока контекста рисования виртуального экрана
            this.vGCtx = Graphics.FromImage(this.vScreen);

            // Настройка ввода пользователя
            this.input = new Game.GameInput();
            // Подписка на событие клавиатуры
            this.KeyDown += (object sender, KeyEventArgs e) => this.input.DispatchKeyDown(e.KeyValue);            
            this.KeyUp += (object sender, KeyEventArgs e) => this.input.DispatchKeyUp(e.KeyValue);            

            // Инициализация объекта состояний игры
            this.state = new Game.GameState(this.vScreen, this.vGCtx, this.input);
            // Настройка игры
            this.game = new Game.Game(this.state);

            // Запуск игровых таймеров
            this.StartTimers();
        }

        // Запускает игровые таймеры
        public void StartTimers() {
            // Настрйока таймера вывода изображения
            var graphicalTimer = new System.Timers.Timer();
            graphicalTimer.Interval = (int)(1000f / 60f); //< Указание FPS графики
            graphicalTimer.Elapsed += (object sender, ElapsedEventArgs e) => {
                // Вывоз обработки графики                
                this.OnDraw();
                // Синхронизация виртуального экрана с реальным
                this.screen.Image = this.vScreen;
            };
            graphicalTimer.Start();

            // Настройка вычислительного таймера (таймера обновлений)                        
            new Task(() => {
                // Запуск таймера в отдельном потоке
                var logicalTimer = new System.Timers.Timer();
                logicalTimer.Interval = (int)(1000f / 30f); //< Указание FPS логики
                logicalTimer.Elapsed += (object sender, ElapsedEventArgs e) => {
                    // Вызов обработки логики                          
                    this.OnUpdate();
                    // Инкрементация игрового времени
                    this.state.gameTime++;
                };
                logicalTimer.Start();
            }).Start();                        
        }

        // Обработка логики обновлений
        public void OnUpdate()
        {
            lock (this.state)
            {
                this.game.Update();
            }            
        }

        // Обработка логики отрисовки
        public void OnDraw() {
            lock (this.state)
            {
                this.game.Draw();
            }
        }
    }
}
