using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EzhSampleSer
{

  class Program
  {
    static void BinarySer(Ezh ezh1)
    {
      // создаем объект BinaryFormatter
      BinaryFormatter formatter = new BinaryFormatter();
      // получаем поток, куда будем записывать сериализованный объект
      using (FileStream fs = new FileStream("Ehz_b.txt", FileMode.OpenOrCreate))
      {
        formatter.Serialize(fs, ezh1);
        Console.WriteLine("Объект сериализован");
      }
      // десериализация из файла Ehz_b.txt
      using (FileStream fs = new FileStream("Ehz_b.txt", FileMode.OpenOrCreate))
      {
        Ezh newPerson = (Ezh)formatter.Deserialize(fs);
        Console.WriteLine("Объект десериализован");
        Console.WriteLine($"Имя: {newPerson.Name} --- Возраст: {newPerson.Age}");
      }
    }

    static void JsonSer(ref Ezh ezh1)
    {
      string json = JsonConvert.SerializeObject(ezh1);
      Console.WriteLine(json);
      //Ezh restoredPerson = JsonSerializer.Deserialize<Ezh>(json);
      Ezh restoredEzh = JsonConvert.DeserializeObject<Ezh>(json);
      Console.WriteLine(restoredEzh.Name);
    }


    static void Main(string[] args)
    {
      Ezh ezh1 = new Ezh { Name = "Артем",  Age=13};
      Console.WriteLine(ezh1);
      BinarySer(ezh1); // Бинарная сериализация
      JsonSer(ref ezh1); //Сериализация в JSON





      Console.ReadLine();





    }
  }
}
