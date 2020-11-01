using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using Terminal.Gui;

namespace DotChat
{
    // Класс сообщения
    [Serializable]
    public class Message
    {
        public string username { get; set; } = "";
        public string text { get; set; } = "";
        public DateTime timestamp { get; set; }

        public Message()
        {
        }

        public Message(string username, string text)
        {
            this.username = username;
            this.text = text;
            this.timestamp = DateTime.UtcNow;
        }
    }

    class Program
    {
        // Очередь сообщений
        private static List<Message> messages = new List<Message>();

        // Компоненты формы
        private static MenuBar menu;
        private static Window winMain;
        private static Window winMessages;
        private static Label labelUser;
        private static TextField fieldUsername;
        private static Label labelMessage;
        private static TextField fieldMessage;
        private static Button btnSend;

        // Точка входа программы
        static void Main(string[] args)
        {
            // Инициялизация консольного приложения
            Application.Init();

            // Верхнеуровневый компонент
            var top = Application.Top;

            // Компонент меню
            menu = new MenuBar(new MenuBarItem[]
            {
                new MenuBarItem("_App", new MenuItem[]
                {
                    new MenuItem("_Quit", "Close the app", Application.RequestStop),
                }),
            });
            top.Add(menu);

            // Компонент главной формы
            winMain = new Window()
            {
                Title = "DotChat",
                // Позиция начала окна
                X = 0,
                Y = 1, //< Место под меню
                // Авто растягивание по размерам терминала
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };
            top.Add(winMain);

            // Компонент сообщений
            winMessages = new Window()
            {
                X = 0,
                Y = 0,
                Width = winMain.Width,
                Height = winMain.Height - 2,
            };
            winMain.Add(winMessages);

            // Текст "Пользователь"
            labelUser = new Label()
            {
                X = 0,
                Y = Pos.Bottom(winMain) - 5,
                Width = 15,
                Height = 1,
                Text = "Username:",
            };
            winMain.Add(labelUser);

            // Поле ввода имени пользователя
            fieldUsername = new TextField()
            {
                X = 15,
                Y = Pos.Bottom(winMain) - 5,
                Width = winMain.Width - 14,
                Height = 1,
            };
            winMain.Add(fieldUsername);

            // Текст "Сообщение"
            labelMessage = new Label()
            {
                X = 0,
                Y = Pos.Bottom(winMain) - 4,
                Width = 15,
                Height = 1,
                Text = "Message:",
            };
            winMain.Add(labelMessage);

            // Поле ввода сообщения
            fieldMessage = new TextField()
            {
                X = 15,
                Y = Pos.Bottom(winMain) - 4,
                Width = winMain.Width - 14,
                Height = 1,
            };
            winMain.Add(fieldMessage);

            // Кнопка отправки
            btnSend = new Button()
            {
                X = Pos.Right(winMain) - 10 - 5,
                Y = Pos.Bottom(winMain) - 4,
                Width = 10,
                Height = 1,
                Text = "  Send  ",
            };
            winMain.Add(btnSend);

            // Обработка клика по кнопке
            btnSend.Clicked += OnBtnSendClick;

            // Запуск цикла проверки обновлений сообщений
            var updateLoop = new System.Timers.Timer();
            updateLoop.Interval = 800;
            int lastMsgID = 0;
            updateLoop.Elapsed += (sender, eventArgs) =>
            {
                //messages.Add(new Message("TEST", "123"));
                //UpdateMessages();
                
                var msg = ClientGetMessage(lastMsgID);
                if (msg != null)
                {
                    messages.Add(msg);
                    UpdateMessages();
                    lastMsgID++;
                }
            }; 
            updateLoop.Start();

            // Запуск приложения
            Application.Run();
            Console.Clear();
        }

        // При нажатии на кнопку отправки
        static void OnBtnSendClick()
        {
            if (fieldMessage.Text.ToString() != "" && fieldUsername.Text.ToString() != "")
            {
                var msg = new Message(fieldUsername.Text.ToString(), fieldMessage.Text.ToString());
                ClientSendMessage(msg);

                // Добавление сообщений локально
                // В этом нет необходимости, т.к. серв вернёт отправленное нами сообщение в цикле обновлений
                // messages.Add(msg);                
                // UpdateMessages();

                fieldMessage.Text = "";
            }
        }

        // Синхронизирует список сообщений с отображением
        static void UpdateMessages()
        {
            // Удаляем все компоненты сообщений
            winMessages.RemoveAll();
            // Идём в обратном порядке и добавляе сообщения (вверху - самые новые)
            int offset = 0;
            for (var i = messages.Count - 1; i >= 0; i--)
            {
                var msg = messages[i];
                winMessages.Add(new View()
                {
                    X = 0,
                    Y = offset,
                    Width = winMessages.Width,
                    Height = 1,
                    Text = $"{msg.timestamp} > [{msg.username}] {msg.text}",
                });
                offset++;
            }
            // Обвноялем отображение
            Application.Refresh();
        }

        // Отправляет сообщение на сервер
        static void ClientSendMessage(Message msg)
        {            
            WebRequest request = WebRequest.Create("http://localhost:5000/api/chat");            
            request.Method = "POST";            
            string postData = JsonConvert.SerializeObject(msg);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);            
            request.ContentType = "application/json";            
            request.ContentLength = byteArray.Length;            
            Stream dataStream = request.GetRequestStream();            
            dataStream.Write(byteArray, 0, byteArray.Length);            
            dataStream.Close();            

            request.GetResponse();            
        }

        // Запускает цикл обновления сообщений
        static Message ClientGetMessage(int id)
        {
            var req = WebRequest.CreateHttp($"http://localhost:5000/api/chat/{id}");
            var resp = req.GetResponse();
            var smsg = new StreamReader(resp.GetResponseStream()).ReadToEnd();

            if (smsg == "Not found") return null;

            return JsonConvert.DeserializeObject<Message>(smsg);
        }
    }
}