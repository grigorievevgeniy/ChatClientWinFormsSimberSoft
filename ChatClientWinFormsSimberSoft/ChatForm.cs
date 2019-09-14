using Microsoft.AspNet.SignalR.Client;
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
    public partial class Chat : Form
    {
        IHubProxy _hub;
        internal static string NameUser;

        public Chat()
        {
            InitializeComponent();

            SynchronizationContext uiContext = SynchronizationContext.Current;

            // Авторизация пользователя
            Login loginForm = new Login();
            loginForm.ShowDialog();

            string url = @"http://localhost:8080/";
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("TestHub");
            connection.Start().Wait();

            //_hub.On("ReceiveLength", x => Console.WriteLine(x));
            //_hub.On("ReceiveLength", x => NewMessage(x.ToString()));

            _hub.On("ReceiveLength", x => uiContext.Post(s => NewMessage(x), null));
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string line = null;
            if ((line = tbInputText.Text) != null)
            {
                await _hub.Invoke("SameMetod", line);
            }

            tbInputText.Text = null;
        }

        private void NewMessage(object state)
        {
            tbChat.Text += state.ToString() + "\r\n";
        }

    }
}
