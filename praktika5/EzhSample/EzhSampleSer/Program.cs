using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

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
        Ezh Ezh2 = (Ezh)formatter.Deserialize(fs);
        Console.WriteLine("Объект десериализован");
        Console.WriteLine($"Имя: {Ezh2.Name} --- Возраст: {Ezh2.Age}");
      }
    }

    static void JsonSer(ref Ezh ezh1)
    {
      string jsonString = JsonConvert.SerializeObject(ezh1);
      Console.WriteLine(jsonString);
      //Ezh restoredPerson = JsonSerializer.Deserialize<Ezh>(json);
      Ezh restoredEzh = JsonConvert.DeserializeObject<Ezh>(jsonString);
      Console.WriteLine(restoredEzh);
    }
    static void XMLSer(Ezh ezh1)
    {
      // передаем в конструктор тип класса
      XmlSerializer formatter = new XmlSerializer(typeof(Ezh));
      // получаем поток, куда будем записывать сериализованный объект
      using (FileStream fs = new FileStream("ezh_xlml.txt", FileMode.OpenOrCreate))
      {
        formatter.Serialize(fs, ezh1);
        Console.WriteLine("Объект сериализован");
      }
      // десериализация
      using (FileStream fs = new FileStream("ezh_xlml.txt", FileMode.OpenOrCreate))
      {
        Ezh newEzh = (Ezh)formatter.Deserialize(fs);
        Console.WriteLine("Объект десериализован");
        Console.WriteLine(newEzh);
      }

    }

    static void Main(string[] args)
    {
      Ezh ezh1 = new Ezh (){ Name = "Максим", Age = 11 };
      Console.WriteLine(ezh1);
      BinarySer(ezh1); // Бинарная сериализация
      JsonSer(ref ezh1); //Сериализация в JSON
      XMLSer(ezh1);
      Console.ReadLine();





    }
  }
}
