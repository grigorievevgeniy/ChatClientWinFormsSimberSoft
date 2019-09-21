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
    public partial class MessageForm : Form
    {
        public MessageForm(string message)
        {
            InitializeComponent();
            lblErrorMessage.Text = message;
        }

        public MessageForm()
        {
            InitializeComponent();
        }
    }
}
