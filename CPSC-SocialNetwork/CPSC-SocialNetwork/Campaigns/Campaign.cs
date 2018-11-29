using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPSC_SocialNetwork.Users;
using CPSC_SocialNetwork.Characters;

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

        private readonly User owner;
        public User Owner
        {
            get => owner;
        }

        private SortedList<string, User> players;
        public SortedList<string, User> Players
        {
            get => this.players; 
            set => this.players = value; 
        }

        private SortedList<string, CharacterPage> characters;
        public SortedList<string, CharacterPage> PlayerCharacters
        {
            get => this.characters;
            set => this.characters = value;
        }

        private SortedList<string, CharacterPage> npcs;
        public SortedList<string, CharacterPage> NonPlayerCharacters
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
            SortedList<string, User> players = null, 
            SortedList<string, CharacterPage> characters = null, 
            List<StoryEntry> entries = null)
        {
            this.name = name;
            this.description = description;
            this.owner = owner;
            this.players = players;
            this.characters = characters;
            this.entries = entries;

            if (players == null)
                this.players = new SortedList<string, User>();
            if (characters == null)
                this.characters = new SortedList<string, CharacterPage>();
            if (entries == null)
                this.entries = new List<StoryEntry>();
        }
    }
}
