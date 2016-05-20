using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers
{
    public class User
    {

        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }


        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }



    }
}
