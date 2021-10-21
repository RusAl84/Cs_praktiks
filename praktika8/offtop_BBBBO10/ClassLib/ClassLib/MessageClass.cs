using System;

namespace ClassLib
{
  [Serializable]
  public class MessageClass
  {
    public string userName { set; get; }
    public string textMessage { set; get; }
    public string timeStamp { set; get; }

    public override string ToString()
    {
      return $"{timeStamp} - {userName} : {textMessage} ";
    }
  }
}
