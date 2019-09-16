using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClientWinFormsSimberSoft
{
    public class Connect
    {
        public IHubProxy hub;
        public HubConnection connection;

        public Connect()
        {
            string url = @"http://localhost:8080/";
            connection = new HubConnection(url);
            hub = connection.CreateHubProxy("MessageHub");
            //connection.Start().Wait();
            connection.Start();
        }


    }
}
