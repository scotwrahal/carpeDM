using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPSC_SocialNetwork.Users;
using CPSC_SocialNetwork.Characters;

using CPSC_SocialNetwork.Database;
using CPSC_SocialNetwork.UserDisplay;

namespace CPSC_SocialNetwork.Campaigns
{
    public class Campaign
    {
        private string name;
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        private string description;
        public string Description
        {
            get => this.description;
            set => this.description = value; 
        }

        private string version;
        public string Version
        {
            get => this.version;
            set => this.version = value;
        }

        private string picture;
        public string Picture
        {
            get => this.picture;
            set => this.picture = value;
        }

        private ChatWindowGroup chat;
        public ChatWindowGroup Chat
        {
            get => this.chat;
            set => this.chat = value;
        }

        private readonly User owner;
        public User Owner { get => this.owner; }

        private readonly string datecreated;
        public string DateCreated { get => this.datecreated; }

        private string meetingtime;
        public string MeetingTime
        {
            get => this.meetingtime;
            set => this.meetingtime = value;
        }

        private List<string> tags;
        public List<string> Tags
        {
            get => this.tags;
            set => this.tags = value;
        }

        private SortedList<string, User> players;
        public SortedList<string, User> Players
        {
            get => this.players; 
            set => this.players = value; 
        }

        private SortedList<string, Character> characters;
        public SortedList<string, Character> PlayerCharacters
        {
            get => this.characters;
            set => this.characters = value;
        }

        private SortedList<string, Character> npcs;
        public SortedList<string, Character> NonPlayerCharacters
        {
            get => this.npcs;
            set => this.npcs = value;
        }

        private List<StoryEntry> entries;
        public List<StoryEntry> StoryEntries
        {
            get => this.entries;
            set => this.entries = value;
        }


        public Campaign(
            string name,
            string description,
            User owner,
            string version = "D&D 5th Edition",
            string picture = "",
            string date = "December 10th, 2018",
            string meeting = "No meeting time specified",
            List<string> tags = null,
            SortedList<string, User> players = null, 
            SortedList<string, Character> characters = null, 
            SortedList<string, Character> npcs = null,
            List<StoryEntry> entries = null)
        {
            this.name = name;
            this.description = description;
            this.owner = owner;
            this.version = version;
            this.picture = picture;
            this.datecreated = date;
            this.meetingtime = meeting;
            this.tags = tags;
            this.players = players;
            this.characters = characters;
            this.npcs = npcs;
            this.entries = entries;
            this.chat = null;

            if (tags == null)
                this.tags = new List<string>();
            if (players == null)
                this.players = new SortedList<string, User>();
            if (characters == null)
                this.characters = new SortedList<string, Character>();
            if (npcs == null)
                this.npcs = new SortedList<string, Character>();
            if (entries == null)
                this.entries = new List<StoryEntry>();
        }
    }
}
