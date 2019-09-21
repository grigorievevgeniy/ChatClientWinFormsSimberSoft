using Microsoft.AspNetCore.SignalR.Client;
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
        internal static string Token;

        public ChatForm()
        {
            // Авторизация пользователя
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            InitializeComponent();

            // Контекст потока UI 
            SynchronizationContext uiContext = SynchronizationContext.Current;

            string url = @"https://localhost:44303/chatHub";

            //connection = new HubConnectionBuilder()
            //    .WithUrl("http://localhost:53353/ChatHub")
            //    .Build();

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

            connection.On<string, string>("ReceiveLength", (user, message) => uiContext.Post(s => NewMessage(message), null));
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string message = null;
            if ((message = tbInputText.Text) != null)
            {
                await connection.InvokeAsync("SendMessage", NameUser, message);
            }

            tbInputText.Text = null;
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

        private void NewMessage(object state)
        {
            tbChat.Text = state.ToString() + "\r\n" + tbChat.Text;
        }

    }
}
