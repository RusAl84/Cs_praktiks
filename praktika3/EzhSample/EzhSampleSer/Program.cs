using System;

namespace EzhSampleSer
{
  class Ezh
  {
    public string name="Артем";

    public override string ToString()
    {
      return this.name;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Ezh ezh1 = new Ezh();

      Console.WriteLine(ezh1);
    }
  }
}
