using Newtonsoft.Json;
using System;

namespace ConsoleApp2
{
  [Serializable]
  class Ezhik
  {
    //public Ezhik()
    //{
    //  this.name = "Дима";
    //  this.age = 20;
    //}
    public string name { get ; set; }
    public int age { get; set; }
    public override string ToString()
    {
      //return base.ToString();
      return String.Format($"name Ezhika: {name}   Age: {age}");
    }
  }
  class megaEzhik : Ezhik
  {
    public int health;
    public megaEzhik() {
      this.weapon = "Кусь кусь;)";
      health = 100; }
    public override string ToString() =>
     String.Format($"name Ezhika: {name}   Age: {age}  Weapon: {this.weapon} Health: {health}");
    public void setWeapon(string str1)
    {
      this.weapon = str1;
    }
    public string weapon { set; get; }
    public int damange()
    {
      int dmg = 10; 
      health -= dmg;
      return dmg;
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
      string jsonString = "{ \"name\":\"Русаков\",\"age\":36}";
      ezh2 = JsonConvert.DeserializeObject<Ezhik>(jsonString);
      Console.WriteLine(ezh2);


      ezh1.age = 19;
      megaEzhik mEzh1 = new megaEzhik();
      mEzh1.setWeapon("ням ням;)");
      megaEzhik mEzh2 = new megaEzhik { name = "Rusakov", age = 36, weapon = "тук тук;)" };
      mEzh1.damange();
      mEzh1.damange();
      mEzh2.damange();
      Console.WriteLine(mEzh1);
      Console.WriteLine(mEzh2);


    }
  }
}
