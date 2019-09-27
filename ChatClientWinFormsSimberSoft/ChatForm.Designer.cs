namespace ChatClientWinFormsSimberSoft
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.tbChat = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbRooms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(180, 12);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(289, 418);
            this.tbChat.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbRooms
            // 
            this.tbRooms.Location = new System.Drawing.Point(12, 33);
            this.tbRooms.Multiline = true;
            this.tbRooms.Name = "tbRooms";
            this.tbRooms.Size = new System.Drawing.Size(162, 186);
            this.tbRooms.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список доступных комнат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список пользователей";
            // 
            // tbUsers
            // 
            this.tbUsers.Location = new System.Drawing.Point(12, 268);
            this.tbUsers.Multiline = true;
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(162, 189);
            this.tbUsers.TabIndex = 5;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRooms);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsers;
    }
}

