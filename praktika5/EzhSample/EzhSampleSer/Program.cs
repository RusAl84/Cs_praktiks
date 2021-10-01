using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
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
      try
      {
        using (StreamWriter sw = new StreamWriter("Ehz_JSON.txt", false, System.Text.Encoding.Default))
        {
          sw.WriteLine(jsonString);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      string restoredJsonString = "";
      using (StreamReader sr = new StreamReader("Ehz_JSON.txt"))
      {
        restoredJsonString = sr.ReadToEnd();
      }
      Ezh restoredEzh = JsonConvert.DeserializeObject<Ezh>(restoredJsonString);
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

    static void SOAPSer(Ezh ezh1)
    {
       //// создаем объект SoapFormatter
       //     SoapFormatter formatter = new SoapFormatter();
       //     // получаем поток, куда будем записывать сериализованный объект
       //     using (FileStream fs = new FileStream("Ehz_", FileMode.OpenOrCreate))
       //     {
       //         formatter.Serialize(fs, people);
       //         Console.WriteLine("Объект сериализован");
       //     }
 
       //     // десериализация
       //     using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
       //     {
       //         Person[] newPeople = (Person[])formatter.Deserialize(fs);
 
       //         Console.WriteLine("Объект десериализован");
       //         foreach (Person p in newPeople)
       //         {
       //             Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Age);
       //         }
       //     }
    }

    static void Main(string[] args)
    {
      Ezh ezh1 = new Ezh (){ Name = "Никита", Age = 40 };
      Console.WriteLine(ezh1);
      BinarySer(ezh1);   // Бинарная сериализация
      JsonSer(ref ezh1); //Сериализация в JSON
      XMLSer(ezh1);      //Сериализация в XML
      // SOAP формат убрали MS
      Console.ReadLine();

    }
  }
}
