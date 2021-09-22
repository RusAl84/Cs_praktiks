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
   static public int health;
    public megaEzhik() {
      this.weapon = "Кусь кусь;)";
      health = 100;}
    public override string ToString() =>
     String.Format($"name Ezhika: {name}   Age: {age}  Weapon: {this.weapon} Health: {health}" );
    public void setWeapon(string str1)
    {
      this.weapon = str1;
 
    }
    public string weapon { set; get; }
    public void damange()
    {
      health -= 10;
    }

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

      ezh1.age = 19;
      megaEzhik mEzh = new megaEzhik();
      //mEzh.setWeapon("ням ням;)");
      megaEzhik mEzh1 = new megaEzhik { name = "Rusakov", age=36, weapon = "тук тук;)" };
      mEzh1.damange();
      mEzh1.damange();
      mEzh.damange();
      Console.WriteLine(mEzh1);
      Console.WriteLine(mEzh);


    }
  }
}
