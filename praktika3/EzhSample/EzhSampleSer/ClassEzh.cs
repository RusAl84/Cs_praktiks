using System;
[Serializable]
public class Ezh
{
  private string name;
  public string Name
  {
    get { return name; }
    set
    {
      if (value == "Артем")
      {
        name = "Артем полосатый";
      }
      else
        name = value;
    }
  }
  private int age;
  public int Age
  {
    get { return age; }
    set { age = value; }
  }
  public override string ToString()
  {
    return String.Format($"Ёжика зовут: {this.name} \n" +
      $"Ёжику {this.age} лет");
  }
}
