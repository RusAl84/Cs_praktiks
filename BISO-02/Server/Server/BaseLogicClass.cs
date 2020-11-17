using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

  }

  public class tokens
  {
    public int token { get; set; }
    public string username { get; set; }
    public string password { get; set; }

    public tokens()
    {
      this.token = -1;
      this.username = "none";
      this.password = "none";
    }

    public tokens(int token, string username, string password)
    {
      this.token = token;
      this.username = username;
      this.password = password;
    }

  }



  public class SessionsClass
  {
    public List<tokens> list_tokens = new List<tokens>();

    public void add()
    {
      tokens token = new tokens(515, "Valera", "UWP");
      list_tokens.Add(token);
    }

    public void SaveToFile(string filename = "data_sessions.json")
    {
      try
      {
        string Data = JsonConvert.SerializeObject(Program.Sessions);
        Console.WriteLine("Dannie vigruzheni");

        using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
        {
          sw.WriteLine(Data);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

    }

    public void LoadFromFile(string filename = "data_sessions.json")
    {
      try
      {
        Console.WriteLine("Dannie vigruzheni");
        string json = "";
        using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
        {
          json = sr.ReadToEnd();
        }
        SessionsClass ses = JsonConvert.DeserializeObject<SessionsClass>(json);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }

}