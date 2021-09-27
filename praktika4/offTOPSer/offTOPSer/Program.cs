using Newtonsoft.Json;
using System;

namespace offTOPSer
{
  [Serializable]
  class Ezhik
  {
    public Ezhik(string name, byte age)
    {
      this.name = name;
      this.age = age;
    }    
    public Ezhik()
    {
      this.name = "Атем";
      this.age = 19;
    }

    public string name { set; get; }
    public byte age { set; get; }

    public override string ToString()
    {
      //return base.ToString();
      return string.Format($"name: {name}     age: {age}");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Ezhik cip1 = new Ezhik();
      string json = JsonConvert.SerializeObject(cip1);
      Console.WriteLine(json);
      string jsonstring = "{ \"name\":\"Вадим\",\"age\":13}";
      Ezhik cip2 = new Ezhik();
      cip2 = JsonConvert.DeserializeObject<Ezhik>(jsonstring);
      Console.WriteLine(cip2);
    }
  }
}
