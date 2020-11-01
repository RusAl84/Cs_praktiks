namespace DotChatWF
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
            this.listMessages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.updateLoop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.ItemHeight = 16;
            this.listMessages.Location = new System.Drawing.Point(12, 12);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(776, 340);
            this.listMessages.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // fieldUsername
            // 
            this.fieldUsername.Location = new System.Drawing.Point(108, 374);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(520, 22);
            this.fieldUsername.TabIndex = 3;
            // 
            // fieldMessage
            // 
            this.fieldMessage.Location = new System.Drawing.Point(108, 408);
            this.fieldMessage.Name = "fieldMessage";
            this.fieldMessage.Size = new System.Drawing.Size(520, 22);
            this.fieldMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(644, 374);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(144, 57);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // updateLoop
            // 
            this.updateLoop.Enabled = true;
            this.updateLoop.Interval = 500;
            this.updateLoop.Tick += new System.EventHandler(this.updateLoop_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.fieldMessage);
            this.Controls.Add(this.fieldUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldUsername;
        private System.Windows.Forms.TextBox fieldMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer updateLoop;
    }
}

