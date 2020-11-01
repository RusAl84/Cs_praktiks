using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    public class message
    {
        public string username { get; set; }
        public string text { get; set; }
        public DateTime timestamp { get; set; }
        public message()
        {
            this.username = "Server";
            this.text = "Server is running...";
            this.timestamp = DateTime.UtcNow;
        }

        public message(string username, string text)
        {
            this.username = username;
            this.text = text;
            this.timestamp = DateTime.UtcNow;
        }
    }
[Serializable]
public class MessagesClass
{
    public List<message> messages = new List<message>();

    public void Add(message ms)
    {
        ms.timestamp = DateTime.UtcNow;
        messages.Add(ms);
        Console.WriteLine(messages.Count);
    }

    public void Add(string username, string text)
    {
        message msg = new message(username, text);
        messages.Add(msg);
        Console.WriteLine(messages.Count);
    }

    public message Get(int id)
    {
            return messages.ElementAt(id);
    }


    public int GetCountMessages()
    {
        return messages.Count;
    }


    public MessagesClass()
    {
        messages.Clear();
        message ms = new message();
        messages.Add(ms);
    }

    public void SaveData()
    {
            Console.WriteLine("Save messages");
            // сохранение данных
            using (FileStream fs = new FileStream("server_data.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<MessagesClass>(fs, this);
                Console.WriteLine("Data has been saved to file");
            }
    }

    public override string ToString()
    {
        return messages.ToString();
    }
}


}
