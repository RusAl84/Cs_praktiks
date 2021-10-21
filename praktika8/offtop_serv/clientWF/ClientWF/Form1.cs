using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWF
{
  public partial class Form1 : Form
  {
    public int pos = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      string res = "";
      while (res != "Not found")
      {
        var client = new RestClient("http://localhost:5000");
        var request = new RestRequest("api/getMessage/" + pos, Method.GET);
        var queryResult = client.Execute(request);
        res = queryResult.Content;
        res = res.Trim('\"');
        if (res != "Not found") { 
          listBox1.Items.Add(res);
          pos++;
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var client = new RestClient("http://localhost:5000");
      var request = new RestRequest("api/SendMessage", Method.POST);
      request.RequestFormat = DataFormat.Json;
      ClassLib.MessageClass mes = new ClassLib.MessageClass()
      {
        userName = textBox1.Text,
        messageText = textBox2.Text,
        timeStamp = DateTime.Now.ToString()

      };
      request.AddBody(mes);
      client.Execute(request);
    }
  }
}
