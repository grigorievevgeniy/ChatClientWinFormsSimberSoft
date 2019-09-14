using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClientWinFormsSimberSoft
{
    public partial class Form1 : Form
    {
        IHubProxy _hub;

        public Form1()
        {
            InitializeComponent();

            string url = @"http://localhost:8080/";
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("TestHub");
            connection.Start().Wait();

            //_hub.On("ReceiveLength", x => Console.WriteLine(x));
            _hub.On("ReceiveLength", x => NewMessage(x.ToString()));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tbChat.Text = "Normal";

            string line = null;
            while ((line = tbInputText.Text) != null)
            {
                _hub.Invoke("SameMetod", line).Wait();
            }

            tbInputText.Text = null;
        }

        private void NewMessage(string message)
        {
            tbChat.Text += message;
        }
    }
}
