using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotChatWF
{
  public partial class RegistartionForm : Form
  {
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
        mForm.Show();
        this.Visible = false;
      }
        else
      {
        MessageBox.Show("Passwords don't match");
      }

    }
  }
}
