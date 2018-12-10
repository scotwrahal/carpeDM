using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPSC_SocialNetwork.Characters;
using CPSC_SocialNetwork.Campaigns;
using CPSC_SocialNetwork.UserDisplay;

namespace CPSC_SocialNetwork.Users
{
    public class User
    {
        private string username;
        public string Username
        {
            get => this.username; 
            set => this.username = value; 
        }

        private string displayname;
        public string DisplayName
        {
            get => this.displayname; 
            set => this.displayname = value; 
        }

        private string picture;
        public string Picture
        {
            get => this.picture;
            set => this.picture = value;
        }

        private Dictionary<string, Character> characters;
        public Dictionary<string, Character> Characters
        {
            get => this.characters; 
            set => this.characters = value;
        }

        private Dictionary<string, Campaign> campaigns;
        public Dictionary<string, Campaign> Campaigns
        {
            get => this.campaigns; 
            set => this.campaigns = value; 
        }

        private ChatWindowDirect chat;
        public ChatWindowDirect Chat
        {
            get => this.chat;
            set => this.chat = value;
        }



        public User(string username = "User123", string displayname = "Unnamed User", string picture = "", Dictionary<string, Character> characters = null, Dictionary<string, Campaign> campaigns = null)
        {
            this.username = username;
            this.displayname = displayname;
            this.picture = picture;
            this.characters = characters;
            this.campaigns = campaigns;
            this.chat = null;
        }
    }
}
