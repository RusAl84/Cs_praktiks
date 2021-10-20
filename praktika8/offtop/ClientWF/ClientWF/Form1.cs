using MessangerLibrary;
using Newtonsoft.Json;
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
    public int pos;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageClass mes = new MessageClass();
      mes.userName = "SAHSA KOZHANAY KURTKA";
      mes.messaageText = "SASHA SNEMI KURTKU";
      var client = new RestClient("http://localhost:5000");
      var request = new RestRequest("/api/SendMessage", Method.POST);
      request.AddJsonBody(JsonConvert.SerializeObject(mes));
      var res = client.Execute(request);
      //if (response.StatusCode == System.Net.HttpStatusCode.Created)
      //{
      //  string str1 = "";
      //}
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      pos = 0;
      listBox1.Items.Clear();
      UpdateLB();
    }
    public void UpdateLB()
    {
      string jsonString = "";
      while (jsonString != "\"Not found\"") { 
      var client = new RestClient("http://localhost:5000");
      var request = new RestRequest("api/GetMessages/"+pos.ToString(), Method.GET);
      var res = client.Execute(request);
      if (res.IsSuccessful)
      {
        //MessageBox.Show($"Успех: {res.Content}");
        jsonString = res.Content;
        if (jsonString != "\"Not found\"") {
            jsonString = jsonString.Replace("\\", "");
            MessageClass mes = new MessageClass();
            string str1 = "";
            for (int i = 1; i < jsonString.Length-1; i++)
              str1 += jsonString[i];
            mes = JsonConvert.DeserializeObject<MessageClass>(str1);
            listBox1.Items.Add(mes);
            pos++;
        }
      }
        //else
        //{
        //  if (res.StatusCode == 0)
        //  {
        //    MessageBox.Show($"Ошибка: ошибка сети: {res.ErrorMessage}");
        //  }
        //  else
        //  {
        //    MessageBox.Show($"Ошибка: {(int)res.StatusCode} - {res.StatusDescription}");
        //  }
        //}
        //MessageBox.Show(queryResult);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      UpdateLB();
    }
  }
}
