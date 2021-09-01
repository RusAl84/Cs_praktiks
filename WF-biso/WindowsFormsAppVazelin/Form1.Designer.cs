
namespace WindowsFormsAppVazelin
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.button1 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(627, 391);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(321, 120);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 12);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(620, 108);
      this.progressBar1.TabIndex = 1;
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(68, 464);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(98, 21);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "checkBox1";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(717, 79);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(231, 106);
      this.checkedListBox1.TabIndex = 3;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(26, 151);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
      this.dateTimePicker1.TabIndex = 4;
      this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(176, 158);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(445, 327);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(960, 523);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.checkedListBox1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

