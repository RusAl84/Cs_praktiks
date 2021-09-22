using Newtonsoft.Json;
using System;

namespace offTOPSer
{
  [Serializable]
  class Cipa
  {
    public Cipa(string name, byte age)
    {
      this.name = name;
      this.age = age;
    }    
    public Cipa()
    {
      this.name = "Артём";
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
      Cipa cip1 = new Cipa();
      string json = JsonConvert.SerializeObject(cip1);
      Console.WriteLine(json);
      string jsonstring = "{ \"name\":\"Саша\",\"age\":17}";
      Cipa cip2 = new Cipa();
      cip2 = JsonConvert.DeserializeObject<Cipa>(jsonstring);
      Console.WriteLine(cip2);
    }
  }
}
