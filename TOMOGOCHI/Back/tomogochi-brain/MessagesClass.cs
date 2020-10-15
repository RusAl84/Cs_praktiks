using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class message
{
    public string username { get; set; }
    public string text { get; set; }
    public DateTime timestamp { get; set; }

    public message()
    {
        this.username = "Server";
        this.text = "Server is running...";
        this.timestamp = DateTime.UtcNow;
    }

    public message( string username, string text, DateTime timestamp)
    {
        this.username = username;
        this.text = text;
        this.timestamp = timestamp;
    }
    public message(string username, string text)
    {
        this.username = username;
        this.text = text;
        this.timestamp = DateTime.UtcNow;
    }

    //public override string ToString()
    //{
    //    return base.ToString();
    //}
}
	[Serializable]
public class MessagesClass
{
    public List<message> messages = new List<message>();

    public void  Add(message ms)
    {
        ms.timestamp = DateTime.UtcNow;
        messages.Add(ms);
        Console.WriteLine(messages.Count);
    }

    public void Add(string username, string text)
    {
        message msg = new message(username, text);
        messages.Add(msg);
        Console.WriteLine(messages.Count);
    }

    public MessagesClass()
	{
        messages.Clear();
        message ms = new message();
        //for (int i = 0; i < 10; i++)
        messages.Add(ms);
    }

    public MessagesClass(List<message> messages)
    {
		messages.Clear();
		message ms = new message();
        //for(int i=0; i<10;i++)
        messages.Add(ms);
	}

    public override string ToString()
    {
        return messages.ToString();
    }
}
