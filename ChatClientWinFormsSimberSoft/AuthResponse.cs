using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClientWinFormsSimberSoft
{
    class AuthResponse
    {
        public string Token { get; set; }
        public string Message { get; set; }
        public string StartMessage { get; set; }
        public string ListRooms { get; set; }
    }
}
