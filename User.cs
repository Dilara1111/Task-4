using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class User
    {
        public string Name;
        public string Email;
        public string Password;
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        public bool IspassWordValid()
        {
            if (Password == Name && Password.Length <= 6)
            { return false; }
            else { return true; }

        }
    }
}
