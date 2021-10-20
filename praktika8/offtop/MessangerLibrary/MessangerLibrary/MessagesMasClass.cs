using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerLibrary
{
  public class MessagesMasClass
  {
    public List<MessageClass> data = new List<MessageClass>();
    public MessagesMasClass()
    {
      MessageClass mes = new MessageClass();
      mes.userName = "System";
      mes.messaageText = "Server is running...";
      mes.timeStamp = DateTime.Now.ToString();
      //mes.timeStamp = DateTime.Now.ToString("HH:MM:SS");
      data.Add(mes);
    }
    public string GetMessage(int pos)
    {
      if ((pos >= 0) && (pos < data.Count))
      {
        return JsonConvert.SerializeObject(data[pos]);
      }
      else
        return "Not found";
    }
    public void AddMessage(MessageClass mes)
    {
      data.Add(mes);
    }
    public void SaveToFile(string FileName)
    {
      string jsonstring = JsonConvert.SerializeObject(data, Formatting.Indented);
      File.WriteAllText(FileName, jsonstring);
    }
    public void LoadFromFile(string FileName)
    {
      if (File.Exists(FileName))
      {
        string jsonstring = File.ReadAllText(FileName);
        data = JsonConvert.DeserializeObject<List<MessageClass>>(jsonstring);
      }
    }

  }
}
