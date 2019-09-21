using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace ChatClientWinFormsSimberSoft
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            //WebClient client = new WebClient();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://localhost:44303/Account/Token");
            request.Method = "POST";
            string body = "email=" + tbLogin.Text + "&password=" + tbPassword.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(body);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            request.GetRequestStream();

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            string otvetServera;
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    otvetServera = reader.ReadToEnd();
                }
            }

            AuthResponse authResponse = JsonConvert.DeserializeObject<AuthResponse>(otvetServera);

            ChatForm.Token = authResponse.Token;

            // TODO: проверка пустого поля, дублирование логина, максимальная длина...
            if (authResponse.Token != null)
            {
                ChatForm.NameUser = tbLogin.Text;
                Close();
            }
        }

        private async void btnRegistration_Click(object sender, EventArgs e)
        {
            if(tbLoginForRegistration.Text == "")
            {
                MessageForm errorForm = new MessageForm("Заполните поле Email");
                errorForm.ShowDialog();
            }
            else if(tbPasswordForRegistration.Text != tbConfirmPasswordForRegistration.Text)
            {
                MessageForm errorForm = new MessageForm("Пароль и его подтвержения разные");
                errorForm.ShowDialog();
            }
            else
            {
                string url = "https://localhost:44303/AccountRegistration/Register";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                string body = "email=" + tbLoginForRegistration.Text + "&password=" + tbPasswordForRegistration.Text;
                byte[] byteArray = Encoding.UTF8.GetBytes(body);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                request.GetRequestStream();

                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                string otvetServera;
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        otvetServera = reader.ReadToEnd();
                    }
                }

                AuthResponse authResponse = JsonConvert.DeserializeObject<AuthResponse>(otvetServera);

                MessageForm messageForm = new MessageForm(authResponse.Message);
                messageForm.ShowDialog();

                tbLogin.Text = tbLoginForRegistration.Text;
                tbPassword.Text = tbPasswordForRegistration.Text;

            }
        }
    }
}
