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
  class megaEzhik : Ezhik
  {
    public megaEzhik() => this.weapon="Кусь кусь;)";
    public override string ToString() =>
     String.Format($"name Ezhika: {name}   Age: {age}  Weapon: {this.weapon}");
    public void setWeapon(string str1)
    {
      this.weapon = str1;
    }
    public string weapon { set; get; }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Ezhik ezh1 = new Ezhik();
      //string json = JsonConvert.SerializeObject(ezh1);
      //Console.WriteLine(json);
      //Ezhik ezh2 = new Ezhik();
      //string jsonString = "{ \"name\":\"ЕВГЕНИЙ\",\"age\":17}";
      //ezh2 = JsonConvert.DeserializeObject<Ezhik>(jsonString);
      megaEzhik mEzh = new megaEzhik();
      //mEzh.setWeapon("ням ням;)");
      Console.WriteLine(ezh1);
      Console.WriteLine(mEzh);
      megaEzhik mEzh1 = new megaEzhik { name = "Rusakov", age=36, weapon = "тук тук;)" };
      Console.WriteLine(mEzh1);


    }
  }
}
