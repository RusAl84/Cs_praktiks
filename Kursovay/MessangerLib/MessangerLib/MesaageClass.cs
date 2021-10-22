using System;

namespace MessangerLib
{
  [Serializable]
  public class MesaageClass
  {
    public string userName { set; get; }
    public string messageText { set; get; }
    public string timeStamp { set; get; }

    public override string ToString()
    {
      return $"{timeStamp} - {userName}: {messageText}";
    }
  }
}
