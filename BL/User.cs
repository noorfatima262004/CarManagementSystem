using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal abstract class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int UserType { get; private set; }

        protected User(string username, string password, int userType)
        {
            Username = username;
            Password = password;
            UserType = userType;
        }
        protected User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
