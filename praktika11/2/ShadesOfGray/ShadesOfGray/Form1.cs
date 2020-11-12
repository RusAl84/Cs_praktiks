using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadesOfGray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // кнопка Открыть
        private void openButton_Click(object sender, EventArgs e)
        {
            // диалог для выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем изображение
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // кнопка Сохранить
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) // если изображение в pictureBox2 имеется
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true; // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                sfd.CheckPathExists = true; // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                // фильтр форматов файлов
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true; // отображается ли кнопка Справка в диалоговом окне
                // если в диалоге была нажата кнопка ОК
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // сохраняем изображение
                        pictureBox2.Image.Save(sfd.FileName);
                    }
                    catch // в случае ошибки выводим MessageBox
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

// кнопка Ч/Б
private void grayButton_Click(object sender, EventArgs e)
{
    if (pictureBox1.Image != null) // если изображение в pictureBox1 имеется
    {
        // создаём Bitmap из изображения, находящегося в pictureBox1
        Bitmap input = new Bitmap(pictureBox1.Image);
        // создаём Bitmap для черно-белого изображения
        Bitmap output = new Bitmap(input.Width, input.Height);
        // перебираем в циклах все пиксели исходного изображения
        for (int j = 0; j < input.Height; j++)
            for (int i = 0; i < input.Width; i++)
            {
                // получаем (i, j) пиксель
                UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                // получаем компоненты цветов пикселя
                float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                float B = (float)(pixel & 0x000000FF); // синий
                // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                R = G = B = (R + G + B) / 3.0f;
                // собираем новый пиксель по частям (по каналам)
                UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                // добавляем его в Bitmap нового изображения
                output.SetPixel(i, j, Color.FromArgb((int)newPixel));
            }
        // выводим черно-белый Bitmap в pictureBox2
        pictureBox2.Image = output;
    }
}
    }
}
