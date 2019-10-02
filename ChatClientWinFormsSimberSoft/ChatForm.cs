using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClientWinFormsSimberSoft
{
    public partial class ChatForm : Form
    {
        //IHubProxy _hub;
        HubConnection connection;
        internal static string NameUser;
        internal static string NameRoom = "";
        //NameRoom = "SimbirSoft";
        internal static string Token;
        internal static string StartMessage;
        //internal static string ListRooms;

        public ChatForm()
        {
            // Авторизация пользователя
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            InitializeComponent();

            lblNameRoom.Text = "Вы пока не вошли в комнату...";
            Text = "Добро пожаловать " + NameUser + "!!!";
            tbChat.Text = StartMessage;
            //tbRooms.Text = ListRooms;

            // Контекст потока UI 
            SynchronizationContext uiContext = SynchronizationContext.Current;

            string url = @"https://localhost:44303/chatHub";

            // Код перезагрузки соединения
            //connection.Closed += async (error) =>
            //{
            //    await Task.Delay(new Random().Next(0, 5) * 1000);
            //    await connection.StartAsync();
            //};

            connection = new HubConnectionBuilder()
                .WithUrl(url, options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(Token);
                })
                .Build();

            connection.StartAsync();

            //_hub.Invoke("Connect", NameUser);

            //connection.On<string, string>("ReceiveMessage", (user, message) => uiContext.Post(s => NewMessage(user, message), null));

            connection.On<ChatData>("ReceiveData", data => uiContext.Post(s => NewMessage(data), null));
        }

        private void NewMessage(ChatData data)
        {
            //if (NameRoom == data.Room)
            {
                tbChat.Text = data.User + ": " + data.Message + "\r\n" + tbChat.Text;
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameRoom == "" && tbInputText.Text != "//start")
                {
                    tbChat.Text = "Вы не вошли не в одну комнату. Следуйте инструкциям. \r\n\r\n" + tbChat.Text;
                    tbInputText.Text = null;
                }
                else if (tbInputText.Text != null)
                {
                    ChatData data = new ChatData() { User = NameUser, Message = tbInputText.Text, Room = NameRoom };
                    await connection.InvokeAsync("SendMessage", data);
                    tbInputText.Text = null;
                }
            }
            catch (Exception ex)
            {
                // TODO разобраться почему выходит исключение
                // An unexpected error occurred invoking 'SendMessage' on the server.
                tbChat.Text = ex.Message + "\r\n" + tbChat.Text;
            }

        }

        private async void SendOldMessage(object sender, EventArgs e)
        {
            string message = null;
            if ((message = tbInputText.Text) != null)
            {
                await connection.InvokeAsync("SendMessage", NameUser, message);
            }

            tbInputText.Text = null;
        }

        private void NewMessage(object user, object message)
        {
            tbChat.Text = user.ToString() + ": " + message.ToString() + "\r\n" + tbChat.Text;
        }

    }
}
