using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BISO_chat
{
  public partial class Form1 : Form
  {
    public string authorization;
    public Form2 form2;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("Love BISO");
      //Declare your new form
      //Form2 form2 = new Form2();
      //Show your new form
      form2.Show();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      authorization = "нет авторизации";
      form2 = new Form2();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      authorization = form2.authorization;
      label1.Text = authorization;
    }
  }
}
