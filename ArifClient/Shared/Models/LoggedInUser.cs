using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifClient.Shared.Models
{
    public class LoggedInUser
    {
        public string CorrectUserName = "Arif";
        public string CorrectPassword = "123";
        public string Name { get; set; }

        public bool isLoggedIn = false;
        public bool Login(string username, string password)
        {
            if (username == CorrectUserName.ToLower() && password == CorrectPassword)
            {
                isLoggedIn = true;
                Name = CorrectUserName;
            }
            return isLoggedIn;
        }
        public void LogOut()
        {
            isLoggedIn = false;
            Name = "";
        }
    }
}
