using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotChatWF
{

    public partial class MainForm : Form
    {
        
        // Глобальные переменные
        int lastMsgID = 0;
        AuthentificationForm AuthForm;
        RegistartionForm RegForm;
        public TextBox TextBox_username;
        public int int_token;


        public MainForm()
        {
            InitializeComponent();
        }

        private void updateLoop_Tick(object sender, EventArgs e)
        {
            Message msg = GetMessage(lastMsgID);
            if (msg != null) {
                listMessages.Items.Add($"[{msg.username}] {msg.text}");
                lastMsgID++;
            }
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (int_token == 0)
      {
        MessageBox.Show("Please log in or register");
      }
      else 
      { 
            SendMessage(new Message() { 
                username = fieldUsername.Text,
                text = fieldMessage.Text,
            });
      }
    }

        // Отправляет сообщение на сервер
        void SendMessage(Message msg)
        {
            WebRequest req = WebRequest.Create("http://localhost:5000/api/chat");
            req.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            //byte[] bytes = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/json";
            //req.ContentLength = bytes.Length;
            StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
            reqStream.Write(postData);
            reqStream.Close();
            req.GetResponse();
        }

        // Получает сообщение с сервера
        Message GetMessage(int id)
        {
            try
            {
                WebRequest req = WebRequest.Create($"http://localhost:5000/api/chat/{id}");
                WebResponse resp = req.GetResponse();
                string smsg = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                if (smsg == "Not found") return null;
                return JsonConvert.DeserializeObject<Message>(smsg);
            } catch {
                return null;
            }
        }

    private void btnAuth_Click(object sender, EventArgs e)
    {
      AuthForm.Show();
      this.Visible = false;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      int_token = 0;
      AuthForm = new AuthentificationForm();
      RegForm = new RegistartionForm();
      TextBox_username = fieldUsername;

    }

    private void btnReg_Click(object sender, EventArgs e)
    {
      RegForm.mForm = this;
      RegForm.Show();
      this.Visible = false;
    }
  }
  [Serializable]
    public class Message
    {
        public string username = "";
        public string text = "";
        public DateTime timestamp;
    }
}
