using Newtonsoft.Json;
using System;

namespace offTOP_ret
{
  class Ret
  {
    public Ret()
    {
      this.name = "Gosha";
      this.age = 19;
    }

    public string name { set; get; }
    public int age { set; get; }

    public override string ToString()
    {
      //return base.ToString();
      return String.Format($"name: {name}     age: {age}");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Ret ret1 = new Ret();
      string json = JsonConvert.SerializeObject(ret1);
      Console.WriteLine(json);
      string jsonstring = "{\"name\":\"Георгий MUZHIK\",\"age\":19}";
      Ret ret2 = new Ret();
      ret2 = JsonConvert.DeserializeObject<Ret>(jsonstring);
      Console.WriteLine(jsonstring);
    }
  }
}
