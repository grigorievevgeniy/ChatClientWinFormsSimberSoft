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
    public partial class HelpForm : Form
    {
        public string Command;
        private string[] ListRooms;
        private string[] ListUsers;

        public HelpForm()
        {
            InitializeComponent();
        }

        public HelpForm(string Rooms, string Users)
        {
            InitializeComponent();

            string[] separator = new string[1] { "\r\n" };

            ListRooms = Rooms.Split(separator, StringSplitOptions.None);
            ListUsers = Users.Split(separator, StringSplitOptions.None);

            cbRooms.Items.AddRange(ListRooms);
            cbUsers.Items.AddRange(ListUsers);
        }

        private void btnEnterCommand_Click(object sender, EventArgs e)
        {
            Command = cbCommand.Text;
            if (cbRooms.Text != "")
            {
                Command += " " + cbRooms.Text;
            }
            else if (cbUsers.Text != "")
            {
                Command += " " + cbUsers.Text;
            }

            Close();

            //TODO передать значение
            //http://www.cyberforum.ru/windows-forms/thread110436.html
        }
    }
}
