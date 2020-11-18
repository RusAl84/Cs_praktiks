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
  public partial class RegistartionForm : Form
  {
    public class AuthData
    {
      public string login { get; set; }
      public string password { get; set; }
    }

    public MainForm mForm; 
    public RegistartionForm()
    {
      InitializeComponent();
    }

    private void RegistartionForm_Load(object sender, EventArgs e)
    {

    }

    private void btnReg2serv_Click(object sender, EventArgs e)
    {
        string pass1 = TBPass1.Text;
        string pass2 = TBPass2.Text;
      if (pass1 == pass2)
      {
        WebRequest req = WebRequest.Create("http://localhost:5000/api/reg");
        req.Method = "POST";
        AuthData auth_data = new AuthData();
        auth_data.login = fieldUserName.Text;
        auth_data.password = pass1;
        string postData = JsonConvert.SerializeObject(auth_data);
        req.ContentType = "application/json";
        StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
        reqStream.Write(postData);
        reqStream.Close();
        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
        string content = sr.ReadToEnd();
        sr.Close();
        int int_token= Convert.ToInt32(content, 10);
        if (int_token != -1) 
        {
          mForm.int_token = int_token;
          mForm.TextBox_username.Text = auth_data.login;
          mForm.Show();
          this.Visible = false;
        }
        else
        {
          MessageBox.Show("Такой пользователь уже зарегистрирован, обратитесь к администратору");
        }
      }
        else
      {
        MessageBox.Show("Passwords don't match");
      }

    }

    private void RegistartionForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void RegistartionForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      mForm.Show();
      //this.Visible = false;
    }
  }
}
