using Newtonsoft.Json;
using System;
using System.Threading;

namespace devMessenger
{
  class Ezh
  {
    public string name;
    public int age;
    public  Ezh()
    {
      name="Неизвестно";
      age=18;
    }
    public Ezh(string _name)
    {
      name=_name;
      age=18;
    }
    public Ezh(string _name, int _age)
    {
      name=_name;
      age=_age;
    }
    public void Dislay()
    {
      string str1 = "Ёжика зовут: " + name + "\n" +
                    "Ёжику " + age + " лет";
      Console.WriteLine(str1);

    }
    public override string ToString()
    {
      return String.Format($"Ёжика зовут: {name} \n" +
                           $"Ёжику  {age} лет");
    }
  }
  class MegaEzh : Ezh
  {
    public int health;
    public int damage;
    string weapon;
    public MegaEzh()
    {
    }
    public MegaEzh(string _name, int _health, int _demage, string _weapon)
    {
      this.name = _name;
      this.health = _health;
      this.damage = _demage;
      this.weapon = _weapon;
    }

    public override string ToString()
    {
      if (health > 0)
        return String.Format($"Ёжик: {name} Здоровье: {health}");
      else
      {
        Console.Beep(3000, 1000);
        Thread.Sleep(1000);
        return String.Format($"Ёжик: {name} GameOver");
      }
    }
  }

  class Program
  {
    static void Atacka(ref MegaEzh kto, ref MegaEzh kogo)
    {
      if ((kto.health > 0) &&(kogo.health>0))
      {
        kogo.health -= kto.damage;
        Console.WriteLine(String.Format($"Ёжик {kto.name} атаковал {kogo.name}"));
        Console.Beep(1500, 200);
        Thread.Sleep(200);
      }
    }
    /// <summary>
    /// Функция которая описывает сражение 3х ежей
    /// </summary>
    /// <param name="mEzh1">1й игрок</param>
    /// <param name="mEzh2">2й игрок</param>
    /// <param name="mEzh3">3й игрок</param>

    /// <param name="n"></param>
    static void Battle(ref MegaEzh mEzh1, ref MegaEzh mEzh2, ref MegaEzh mEzh3, int n)
    {
      for (int i=0; i < n; i++) {
        Console.WriteLine($"Battle №{i + 1}");
        Atacka(ref mEzh1, ref mEzh2); // 1->2
        Atacka(ref mEzh2, ref mEzh3); // 2->3
        Atacka(ref mEzh3, ref mEzh1); // 3->1
        Atacka(ref mEzh1, ref mEzh3); // 1->3
        Atacka(ref mEzh2, ref mEzh1); // 2->1
        Atacka(ref mEzh3, ref mEzh2); // 3->2
        Console.WriteLine("___________________________");
        Console.WriteLine(mEzh1.ToString());
        Console.WriteLine(mEzh2);
        Console.WriteLine(mEzh3);
        Console.WriteLine("___________________________\n");
      }
    } 
    static void Main(string[] args)
    {
      //Ezh ezh1 = new Ezh();   //пример классов с разными конструкторами
      //Ezh ezh2 = new Ezh("Алихана");   //пример классов с разными конструкторами
      //Ezh ezh3 = new Ezh("Русаков", 36);   //пример классов с разными конструкторами 
      ////ezh1.Dislay();
      ////ezh2.Dislay();
      ////ezh3.Dislay();
      //Console.WriteLine(ezh1.ToString());
      //Console.WriteLine(ezh2);
      //Console.WriteLine(ezh3);

      MegaEzh mEzh1 = new MegaEzh("Вова", 100, 10, "кусь, кусь;)");
      MegaEzh mEzh2 = new MegaEzh("Даня", 120, 15, "тук, тук;)");
      MegaEzh mEzh3 = new MegaEzh("Русаков", 150, 20, "ай, ай;)");
      Battle(ref mEzh1, ref mEzh2, ref mEzh3, 5);

      //string jsonString = JsonConvert.SerializeObject(mEzh1);
      //Console.WriteLine(jsonString);
      //MegaEzh recoverEzh = new MegaEzh();
      //jsonString = "{ \"health\":30,\"damage\":3,\"name\":\"Никита\",\"age\":11}";
      //recoverEzh = JsonConvert.DeserializeObject<MegaEzh>(jsonString);
      //Console.WriteLine(recoverEzh);
    }
  }
}
