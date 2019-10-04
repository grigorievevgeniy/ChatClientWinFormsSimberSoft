using Microsoft.AspNetCore.SignalR.Client;
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
    public partial class StartChatForm : Form
    {
        HubConnection _connection;
        string nameUser;

        public StartChatForm(string NameUser, HubConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            nameUser = NameUser;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                    ChatData dataFromClient = new ChatData()
                    {
                        User = nameUser,
                        Message = "//start"
                    };
                    _connection.InvokeAsync("SendMessage", dataFromClient);

                Close();
            }
            catch (Exception ex)
            {
                string ss = ex.Message;
            }


        }
    }
}
