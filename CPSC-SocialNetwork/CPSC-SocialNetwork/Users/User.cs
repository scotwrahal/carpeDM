using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPSC_SocialNetwork.Characters;
using CPSC_SocialNetwork.Campaigns;

namespace CPSC_SocialNetwork.Users
{
    public class User
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

        private Dictionary<string, Character> characters;
        public Dictionary<string, Character> Characters
        {
            get { return this.characters; }
            set { this.characters = value; }
        }

        private Dictionary<string, Campaign> campaigns;
        public Dictionary<string, Campaign> Campaigns
        {
            get { return this.campaigns; }
            set { this.campaigns = value; }
        }


        public User(string username = "User123", string displayname = "Unnamed User", Dictionary<string, Character> characters = null, Dictionary<string, Campaign> campaigns = null)
        {
            this.username = username;
            this.displayname = displayname;
            this.characters = characters;
            this.campaigns = campaigns;
        }
    }
}
