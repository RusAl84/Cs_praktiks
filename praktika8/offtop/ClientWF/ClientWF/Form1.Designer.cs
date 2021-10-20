
namespace ClientWF
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.userNameTB = new System.Windows.Forms.TextBox();
      this.messageTextTB = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(12, 12);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(748, 344);
      this.listBox1.TabIndex = 0;
      // 
      // userNameTB
      // 
      this.userNameTB.Location = new System.Drawing.Point(12, 372);
      this.userNameTB.Name = "userNameTB";
      this.userNameTB.Size = new System.Drawing.Size(246, 27);
      this.userNameTB.TabIndex = 1;
      this.userNameTB.Text = "Ilusha";
      // 
      // messageTextTB
      // 
      this.messageTextTB.Location = new System.Drawing.Point(12, 416);
      this.messageTextTB.Name = "messageTextTB";
      this.messageTextTB.Size = new System.Drawing.Size(571, 27);
      this.messageTextTB.TabIndex = 2;
      this.messageTextTB.Text = "Любит есть Ёжиков";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(602, 378);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(158, 60);
      this.button1.TabIndex = 3;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.messageTextTB);
      this.Controls.Add(this.userNameTB);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox userNameTB;
    private System.Windows.Forms.TextBox messageTextTB;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Timer timer1;
  }
}

