using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_SocialNetwork.Users
{
    class User
    {
        private string username;
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        private string displayname;
        public string DisplayName
        {
            get { return this.displayname; }
            set { this.displayname = value; }
        }


        public User(string username = "User123", string displayname = "Unnamed User")
        {
            this.username = username;
            this.displayname = displayname;
        }
    }
}
