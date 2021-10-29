using RestSharp;

namespace clientWF
{
    public partial class Form1 : Form
    {
        public int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strContent = "";
            while (strContent!="Not found") { 
                var client = new RestClient("http://localhost:5000");
                // client.Authenticator = new HttpBasicAuthenticator(username, password);
                var request = new RestRequest($"api/Message/{id}");
                //request.AddParameter("thing1", "Hello");
                //request.AddParameter("thing2", "world");
                //request.AddHeader("header", "value");
                //request.AddFile("file", path);
                var response = client.Get(request);
                var content = response.Content; // Raw content as string
                strContent = content.Trim('\"');
                if (strContent != "Not found") {
                    listBox1.Items.Add(strContent);
                    id++;
                }
            }
            //var response2 = client.Post<Person>(request);
            //var name = response2.Data.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest($"api/Message");
            request.AddJsonBody(new MessangerLib.MessageClass()
            {
                timeStamp = DateTime.Now.ToString(),
                userName = textBox1.Text,
                messageText = textBox2.Text
            });
            var response = client.Post(request);
        }
    }
}