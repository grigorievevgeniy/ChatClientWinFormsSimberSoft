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

            connection.On<string, string>("ReceiveMessage", (user, message) => uiContext.Post(s => NewMessage(user, message), null));
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string message = null;
                if ((message = tbInputText.Text) != null)
                {
                    await connection.InvokeAsync("SendMessage", NameUser, message);
                }

                tbInputText.Text = null;
            }
            catch (Exception ex)
            {
                tbChat.Text = ex.Message;
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
            tbChat.Text = user.ToString() + ": " +message.ToString() + "\r\n" + tbChat.Text;
        }

    }
}
