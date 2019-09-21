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
    public partial class ErrorForm : Form
    {
        public ErrorForm(string message)
        {
            InitializeComponent();
            lblErrorMessage.Text = message;
        }

        public ErrorForm()
        {
            InitializeComponent();
        }
    }
}
