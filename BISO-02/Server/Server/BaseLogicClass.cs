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
    public string login { get; set; }
    public string password { get; set; }

    public tokens()
    {
      this.token = -1;
      this.login = "none";
      this.password = "none";
    }

    public tokens(int token, string login, string password)
    {
      this.token = token;
      this.login = login;
      this.password = password;
    }

  }

  public class SessionsClass
  {
    public List<tokens> list_tokens = new List<tokens>();

    public void addValera()
    {
      Random rand = new Random();
      int int_token = rand.Next(1000 * 1000, 10 * 1000 * 1000);
      tokens token_record = new tokens(int_token, "Valera", "UWP");
      token_record.login = "Valera";
      token_record.password = "UWP";
      token_record.token = int_token;
      list_tokens.Add(token_record);
    }

    public int GenToken()
    {
      Random rand = new Random();
      return rand.Next(10 * 1000 , 100 * 1000 );
    }

    public int login(AuthData auth_data)
    {
      string login = auth_data.login;
      string password = auth_data.password;
      bool login_exist = false;
      int row_num = 0;
      foreach (tokens item in list_tokens)
      {
        if (item.login == login)
        {
          login_exist = true;
          if (item.password == password)
          {
            int token = GenToken();
            tokens record_token = new tokens(token, login, password);
            list_tokens[row_num].token = token;
            //list_tokens.Add(record_token);
            Console.WriteLine($"Аутификация успешно login: {login} password: {password} token: {token}");
            return token;
          }
          else
          {
            return -1;
          }
        }
        row_num++;
      }
      if (!login_exist)
      {
        return -2;
      }
      return -200;   // ошибка логики
    }

    public int registration(AuthData auth_data)
    {
      bool login_exist = false;
      foreach (tokens item in list_tokens)
      {
        if (item.login == auth_data.login)
        {
          login_exist = true;
        }
      }
      if (!login_exist) 
      { 
        int token = GenToken();
        tokens record_token = new tokens(token, auth_data.login, auth_data.password);
        list_tokens.Add(record_token);
        Console.WriteLine($"Регистрация успешно login: {auth_data.login} password: {auth_data.password} token: {token}");
        return token;
      }
      return -1;
    }


    public void SaveToFile(string filename = "data_sessions.json")
    {
      if (File.Exists(filename))
      {
        File.Delete(filename);
      }

      try
      {
        string Data = JsonConvert.SerializeObject(Program.Sessions);

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
      long size = 0;
      if (File.Exists(filename)) 
      { 
       System.IO.FileInfo file = new System.IO.FileInfo(filename);
       size = file.Length;
      }
      if (size > 0)
      {
        try
        {
          //Console.WriteLine("Dannie vigruzheni");
          string json = "";
          using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
          {
            json = sr.ReadToEnd();
          }
          Program.Sessions = JsonConvert.DeserializeObject<SessionsClass>(json);
          for (int i = 0; i < list_tokens.Count; i++)
          {
            list_tokens[i].token = 0;
          }
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
        // Console.WriteLine($"Загружено записей: {this.list_tokens.Count}");
      }

    }
  }

  public class AuthData
  {
    public string login { get; set; }
    public string password { get; set; }
  }


}
