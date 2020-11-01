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
    [Serializable]
    public class Message
    {
        public string username = "";
        public string text = "";
        public DateTime timestamp;
    }

    public partial class Form1 : Form
    {
        int lastMsgID = 0;

        public Form1()
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
            SendMessage(new Message() { 
                username = fieldUsername.Text,
                text = fieldMessage.Text,
            });
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
    }
}
