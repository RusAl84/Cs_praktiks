
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
      this.button1 = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(686, 369);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(94, 29);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(12, 12);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(768, 344);
      this.listBox1.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(13, 363);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(403, 27);
      this.textBox1.TabIndex = 3;
      this.textBox1.Text = "Ваня";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(12, 409);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(668, 27);
      this.textBox2.TabIndex = 4;
      this.textBox2.Text = "Развития и сил Вам ребята;)";
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
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Timer timer1;
  }
}

