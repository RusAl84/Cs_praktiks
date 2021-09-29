using System;
[Serializable]
public class Ezh
{
  private string name;
  //public string Name { set; get; }
  private int age;
  //public int Age { get; set; }
  public Ezh(string name, int age)
  {
    this.name = name;
    this.age = age;
  }
  public Ezh()
  {
  }
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
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
