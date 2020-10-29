using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmoStar.Game
{
    // Обработка ввода пользователя    
    public class GameInput
    {
        // Список нажатых клавиш
        Dictionary<int, bool> keyboard = new Dictionary<int, bool>();

        // Имитация нажатия клавиши
        public void DispatchKeyDown(int key)
        {
            keyboard[key] = true;
        }

        // Имитация отпускания клавиши
        public void DispatchKeyUp(int key)
        {
            keyboard[key] = false;
        }

        // Проверяет нажати ли указанная клавиша
        public bool IsPressed(int key) {
            return keyboard.ContainsKey(key) && keyboard[key];
        }
    }
}
