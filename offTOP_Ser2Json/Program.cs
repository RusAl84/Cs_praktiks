using Newtonsoft.Json;
using System;

namespace ConsoleApp2
{
  [Serializable]
  class Ezhik
  {
    public Ezhik()
    {
      this.name = "Iliya";
      this.age = 19;
    }
    public string name { get; set; }
    public int age { get; set; }

    public override string ToString()
    {
      //return base.ToString();
      return String.Format($"name Ezhika: {name}   Age: {age}");
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      Ezhik ezh1 = new Ezhik();
      string json = JsonConvert.SerializeObject(ezh1);
      Console.WriteLine(json);
      Ezhik ezh2 = new Ezhik();
      string jsonString = "{ \"name\":\"ЕВГЕНИЙ\",\"age\":17}";
      ezh2 = JsonConvert.DeserializeObject<Ezhik>(jsonString);
      Console.WriteLine(ezh2);

    }
  }
}
