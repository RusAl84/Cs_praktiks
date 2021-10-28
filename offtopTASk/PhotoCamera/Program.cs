using System;

namespace PhotoCamera
{
  class Program
  {
    class PhotoCameraClass
    {
      public string manufacturerCompany { get; set; }
      public decimal cost { get; set; }
      public PhotoCameraClass(string _manufacturerCompany, decimal _cost)
      {
        this.manufacturerCompany = _manufacturerCompany;
        this.cost = _cost;
      }
      public override string ToString()
      {
        return $"Фирма изготовитель: {manufacturerCompany}. Стоимость {cost}.";
      }
    }
    static void Main(string[] args)
    {
      PhotoCameraClass[] photoMas = 
      {
        new PhotoCameraClass("Canon", 123), 
        new PhotoCameraClass("Sony", 202), 
        new PhotoCameraClass("Nokian", 312), 
      };
      Console.WriteLine("Доступны к заказу следующие фотоаппараты");
      foreach (PhotoCameraClass item in photoMas)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("\nВведите ограничение по стоимости");
      Decimal limitCost = Convert.ToDecimal(Console.ReadLine());
      foreach(PhotoCameraClass item in photoMas)
      {
        if (item.cost < limitCost)
          Console.WriteLine(item);
      }
    }
  }
}
