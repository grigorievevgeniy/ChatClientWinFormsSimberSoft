﻿namespace ChatClientWinFormsSimberSoft
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
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbRooms = new System.Windows.Forms.TextBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.tbUsers = new System.Windows.Forms.TextBox();
            this.lblNameRoom = new System.Windows.Forms.Label();
            this.tbAllRooms = new System.Windows.Forms.TextBox();
            this.lblAllRooms = new System.Windows.Forms.Label();
            this.tbAllUsers = new System.Windows.Forms.TextBox();
            this.lblAllUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(180, 33);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChat.Size = new System.Drawing.Size(289, 397);
            this.tbChat.TabIndex = 2;
            // 
            // tbInputText
            // 
            this.tbInputText.Location = new System.Drawing.Point(180, 436);
            this.tbInputText.Name = "tbInputText";
            this.tbInputText.Size = new System.Drawing.Size(208, 20);
            this.tbInputText.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(394, 434);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbRooms
            // 
            this.tbRooms.Location = new System.Drawing.Point(12, 33);
            this.tbRooms.Multiline = true;
            this.tbRooms.Name = "tbRooms";
            this.tbRooms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRooms.Size = new System.Drawing.Size(162, 186);
            this.tbRooms.TabIndex = 3;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(12, 12);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(140, 13);
            this.lblRooms.TabIndex = 4;
            this.lblRooms.Text = "Список доступных комнат";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(475, 12);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(135, 13);
            this.lblUsers.TabIndex = 6;
            this.lblUsers.Text = "Список польз. в комнате";
            // 
            // tbUsers
            // 
            this.tbUsers.Location = new System.Drawing.Point(478, 33);
            this.tbUsers.Multiline = true;
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUsers.Size = new System.Drawing.Size(162, 186);
            this.tbUsers.TabIndex = 5;
            // 
            // lblNameRoom
            // 
            this.lblNameRoom.AutoSize = true;
            this.lblNameRoom.Location = new System.Drawing.Point(177, 12);
            this.lblNameRoom.Name = "lblNameRoom";
            this.lblNameRoom.Size = new System.Drawing.Size(89, 13);
            this.lblNameRoom.TabIndex = 7;
            this.lblNameRoom.Text = "Вы в комнате ...";
            // 
            // tbAllRooms
            // 
            this.tbAllRooms.Location = new System.Drawing.Point(15, 250);
            this.tbAllRooms.Multiline = true;
            this.tbAllRooms.Name = "tbAllRooms";
            this.tbAllRooms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAllRooms.Size = new System.Drawing.Size(162, 205);
            this.tbAllRooms.TabIndex = 3;
            // 
            // lblAllRooms
            // 
            this.lblAllRooms.AutoSize = true;
            this.lblAllRooms.Location = new System.Drawing.Point(12, 232);
            this.lblAllRooms.Name = "lblAllRooms";
            this.lblAllRooms.Size = new System.Drawing.Size(110, 13);
            this.lblAllRooms.TabIndex = 4;
            this.lblAllRooms.Text = "Список всех комнат";
            // 
            // tbAllUsers
            // 
            this.tbAllUsers.Location = new System.Drawing.Point(475, 250);
            this.tbAllUsers.Multiline = true;
            this.tbAllUsers.Name = "tbAllUsers";
            this.tbAllUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAllUsers.Size = new System.Drawing.Size(162, 205);
            this.tbAllUsers.TabIndex = 5;
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Location = new System.Drawing.Point(475, 232);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(150, 13);
            this.lblAllUsers.TabIndex = 6;
            this.lblAllUsers.Text = "Список всех пользователей";
            // 
            // ChatForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 473);
            this.Controls.Add(this.lblNameRoom);
            this.Controls.Add(this.lblAllUsers);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.tbAllUsers);
            this.Controls.Add(this.lblAllRooms);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.tbAllRooms);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.tbRooms);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbInputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.Text = "Добро пожаловать!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox tbInputText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox tbUsers;
        private System.Windows.Forms.Label lblNameRoom;
        private System.Windows.Forms.TextBox tbAllRooms;
        private System.Windows.Forms.Label lblAllRooms;
        private System.Windows.Forms.TextBox tbAllUsers;
        private System.Windows.Forms.Label lblAllUsers;
    }
}

