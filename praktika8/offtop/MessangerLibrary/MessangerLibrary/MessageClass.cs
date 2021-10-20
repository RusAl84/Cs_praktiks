using System;

namespace MessangerLibrary
{
  [Serializable]
  public class MessageClass
  {
    public string userName { get; set; }
    public string messaageText { get; set; }
    public string timeStamp { get; set; }

    public override string ToString()
    {
      return $"{timeStamp} - {userName} : {messaageText}";
    }
  }
}
