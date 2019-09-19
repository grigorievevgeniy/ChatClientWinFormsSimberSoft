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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // TODO: проверка пустого поля, дублирование логина, максимальная длина...
            if (tbLogin.Text != "")
            {
                ChatForm.NameUser = tbLogin.Text;


                Close();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            // TODO: отправка POST запроса на сервер с регистрационными данными
            // проверка на дублирование логина
        }
    }
}
