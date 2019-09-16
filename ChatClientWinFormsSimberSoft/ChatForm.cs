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
    public partial class ChatForm : Form
    {
        internal static string NameUser;
        Connect connect = new Connect();

        public ChatForm()
        {
            // Авторизация пользователя
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            InitializeComponent();

            // Контекст потока UI 
            SynchronizationContext uiContext = SynchronizationContext.Current;

            connect.hub.Invoke("Connect", NameUser);

            connect.hub.On("ReceiveLength", x => uiContext.Post(s => NewMessage(x), null));
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            
            string message = null;
            if ((message = tbInputText.Text) != null)
            {
                await connect.hub.Invoke("SendMessage", NameUser, message);
            }

            tbInputText.Text = null;
        }

        private async void SendOldMessage(object sender, EventArgs e)
        {
            string message = null;
            if ((message = tbInputText.Text) != null)
            {
                await connect.hub.Invoke("SendMessage", NameUser, message);
            }

            tbInputText.Text = null;
        }

        private void NewMessage(object state)
        {
            tbChat.Text = state.ToString() + "\r\n" + tbChat.Text;
        }

    }
}
