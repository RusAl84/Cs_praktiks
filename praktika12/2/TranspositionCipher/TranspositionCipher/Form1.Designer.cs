namespace TranspositionCipher
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(166, 16);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(305, 23);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(166, 54);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(305, 23);
            this.outputTextBox.TabIndex = 1;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(281, 196);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(190, 23);
            this.keyTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(304, 112);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(149, 39);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Выполнить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decryptRadioButton);
            this.groupBox1.Controls.Add(this.encryptRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опция";
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Checked = true;
            this.encryptRadioButton.Location = new System.Drawing.Point(27, 33);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(118, 21);
            this.encryptRadioButton.TabIndex = 0;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Зашифровать";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Location = new System.Drawing.Point(27, 73);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(125, 21);
            this.decryptRadioButton.TabIndex = 1;
            this.decryptRadioButton.Text = "Расшифровать";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Обработанный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Шифр перестановки - VSCODE.RU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

