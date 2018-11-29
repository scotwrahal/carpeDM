﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPSC_SocialNetwork.Campaigns;
using CPSC_SocialNetwork.Users;
using CPSC_SocialNetwork.Characters;

namespace CPSC_SocialNetwork.Database
{
    class SocialNetworkDatabase
    {
        private Dictionary<string, Dictionary<string, Character>> characters;
        public Dictionary<string, Dictionary<string, Character>> Characters
        {
            get { return this.characters; }
        }

        private Dictionary<string, Dictionary<string, Campaign>> campaigns;
        public Dictionary<string, Dictionary<string, Campaign>> Campaigns
        {
            get { return this.campaigns; }
        }

        private Dictionary<string, User> users;
        public Dictionary<string, User> Users
        {
            get { return this.users; }
        }


        public SocialNetworkDatabase()
        {

            users = new Dictionary<string, User>
            {
                { "HardworkingIdiot", new User(username: "HardworkingIdiot", displayname: "Micah Peacock") },
                { "ToolboxMoron", new User(username: "ToolboxMoron", displayname: "Scot Rahal") },
                { "Doooooood", new User(username: "Doooooood", displayname: "Jesse Shewfelt") },
                { "ThatSmartGuy", new User(username: "ThatSmartGuy", displayname: "Kris Lugtu") },
                { "ThatOtherSmartGuy", new User(username: "ThatOtherSmartGuy", displayname: "Kendrick Ankamah") } 
            };

            characters = new Dictionary<string, Dictionary<string, Character>>
            {
                { "HardworkingIdiot", new Dictionary<string, Character>
                    { 
                        { "Eridan Xanthas", new Character(characterName: "Eridan Xanthas", characterRace: "Half-Elf", characterClass: "Magus", characterLevel: 6) },
                        { "Soren Riftbane", new Character(characterName: "Soren Riftbane", characterRace: "Tiefling (Pit-born)", characterClass: "Inquisitor", characterLevel: 13) },
                        { "Gradius Braveheart", new Character(characterName: "Gradius Braveheart", characterRace: "Human", characterClass:"Barbarian", characterLevel: 7) }
                    }
                },
                { "ToolboxMoron", new Dictionary<string, Character>
                    {
                        { "Doralig Cragarm", new Character(characterName: "Doralig Cragarm", characterRace: "Dwarf", characterClass: "Druid", characterLevel: 16) },
                        { "Luvon Keywynn", new Character(characterName: "Luvon Keywynn", characterRace: "Elf", characterClass: "Ranger", characterLevel: 7) }
                    }
                },
                { "Doooooood", new Dictionary<string, Character>
                    {

                    }
                },
                { "ThatSmartGuy", new Dictionary<string, Character>
                    {

                    }
                },
                { "ThatOtherSmartGuy", new Dictionary<string, Character>
                    {

                    }
                }
            };

            campaigns = new Dictionary<string, Dictionary<string, Campaign>>
            {
                { "HardworkingIdiot", new Dictionary<string, Campaign>
                    {
                        { "Red Hand of Doom", new Campaign(name: "Red Hand of Doom", description: "An old 3e campaign.", owner: users["HardworkingIdiot"]) },
                        { "Kingmaker", new Campaign(name: "Kingmaker", description: "A politically based campaign with the goal of building a kingdom.", owner: users["HardworkingIdiot"]) }
                    }
                },
                { "ToolboxMoron", new Dictionary<string, Campaign>
                    {

                    }
                },
                { "Doooooood", new Dictionary<string, Campaign>
                    {

                    }
                },
                { "ThatSmartGuy", new Dictionary<string, Campaign>
                    {

                    }
                },
                { "ThatOtherSmartGuy", new Dictionary<string, Campaign>
                    {

                    }
                }
            };
        }

        
    }
}