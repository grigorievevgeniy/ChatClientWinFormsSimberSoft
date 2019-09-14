using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClientWinFormsSimberSoft
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //IHubProxy _hub;
            //string url = @"http://localhost:8080/";
            //var connection = new HubConnection(url);
            //_hub = connection.CreateHubProxy("TestHub");
            //connection.Start().Wait();

            //_hub.On("ReceiveLength", x => Console.WriteLine(x));

            //string line = null;
            //while ((line = System.Console.ReadLine()) != null)
            //{
            //    _hub.Invoke("SameMetod", line).Wait();
            //}

            //Console.Read();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChatForm());
        }
    }
}
