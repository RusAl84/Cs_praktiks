namespace MessangerLib
{
    [Serializable]
    public class MessageClass
    {
        public string messageText { get; set; }
        public string userName { get; set; }
        public string timeStamp { get; set; }

        public override string? ToString()
        {
            return $"{timeStamp} - {userName} : {messageText}";
        }
    }
}