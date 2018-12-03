using System;
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
        public Dictionary<string, Dictionary<string, Character>> Characters { get => this.characters; }
        
        private Dictionary<string, Dictionary<string, Campaign>> campaigns;
        public Dictionary<string, Dictionary<string, Campaign>> Campaigns { get => this.campaigns; }

        private Dictionary<string, User> users;
        public Dictionary<string, User> Users { get => this.users; }


        public SocialNetworkDatabase()
        {

            users = new Dictionary<string, User>
            {
                { "HardworkingIdiot", new User(username: "HardworkingIdiot", displayname: "Micah Peacock", picture: "ProfilePicture.png") },
                { "ToolboxMoron", new User(username: "ToolboxMoron", displayname: "Scot Rahal", picture: "3.png") },
                { "VirtualWaffles", new User(username: "VirtualWaffles", displayname: "Jesse Shewfelt", picture: "4.png") },
                { "ThatSmartGuy", new User(username: "ThatSmartGuy", displayname: "Kris Lugtu", picture: "2.png") },
                { "ThatOtherSmartGuy", new User(username: "ThatOtherSmartGuy", displayname: "Kendrick Ankamah", picture: "5.png") },
                { "MrRobotDood", new User(username: "MrRobotDood", displayname: "Claire's Talking Robot", picture: "7.png") }
            };

            characters = new Dictionary<string, Dictionary<string, Character>>
            {
                { "HardworkingIdiot", new Dictionary<string, Character>
                    { 
                        { "Eridan Xanthas", new Character(owner: users["HardworkingIdiot"], characterName: "Eridan Xanthas", characterRace: "Half-Elf", characterClass: "Magus", characterLevel: 6, picture: "1.png") },
                        { "Soren Riftbane", new Character(owner: users["HardworkingIdiot"], characterName: "Soren Riftbane", characterRace: "Tiefling (Pit-born)", characterClass: "Inquisitor", characterLevel: 13, picture: "2.png") },
                        { "Gradius Braveheart", new Character(owner: users["HardworkingIdiot"], characterName: "Gradius Braveheart", characterRace: "Human", characterClass:"Barbarian", characterLevel: 7, picture: "3.png") }
                    }
                },
                { "ToolboxMoron", new Dictionary<string, Character>
                    {
                        { "Doralig Cragarm", new Character(owner: users["ToolboxMoron"], characterName: "Doralig Cragarm", characterRace: "Dwarf", characterClass: "Druid", characterLevel: 16, picture: "5.png") },
                        { "Luvon Keywynn", new Character(owner: users["ToolboxMoron"], characterName: "Luvon Keywynn", characterRace: "Elf", characterClass: "Ranger", characterLevel: 7) }
                    }
                },
                { "VirtualWaffles", new Dictionary<string, Character>
                    {
                    { "Aeyi Oyu", new Character(users["VirtualWaffles"], "Aeyi Oyu", "Elf", "Shadowdancer", 6, "100.png") }
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
                        { "Red Hand of Doom", new Campaign(
                            name: "Red Hand of Doom", 
                            description: "An old 3e campaign.", 
                            owner: users["HardworkingIdiot"],
                            picture: "11.png",
                            players: new SortedList<string, User>
                            {
                                { users["HardworkingIdiot"].DisplayName, users["HardworkingIdiot"] },
                                { users["VirtualWaffles"].DisplayName, users["VirtualWaffles"] },
                                { users["ToolboxMoron"].DisplayName, users["ToolboxMoron"] }
                            },
                            characters: new SortedList<string, Character>
                            {
                                { characters["ToolboxMoron"]["Doralig Cragarm"].CharacterName, characters["ToolboxMoron"]["Doralig Cragarm"] },
                                { characters["VirtualWaffles"]["Aeyi Oyu"].CharacterName, characters["VirtualWaffles"]["Aeyi Oyu"] }
                            }
                            )
                        },
                        { "Kingmaker", new Campaign(name: "Kingmaker", description: "A politically based campaign with the goal of building a kingdom.", owner: users["HardworkingIdiot"]) }
                    }
                },
                { "ToolboxMoron", new Dictionary<string, Campaign>
                    {

                    }
                },
                { "VirtualWaffles", new Dictionary<string, Campaign>
                    {
                        {
                        "Quest for the Breeziest Shorts",
                        new Campaign("Quest for the Breeziest Shorts",
                                     "Join some of the bravest adventurers in all the land in an action filled quest to find the ancient and mythical shorts of brííz.",
                                     users["VirtualWaffles"],
                                     "6.png"
                                     /*
                                     new SortedList<string, User>
                                     {
                                        { users["VirtualWaffles"].DisplayName, users["VirtualWaffles"] },
                                        { users["HardworkingIdiot"].DisplayName, users["HardworkingIdiot"] },
                                        { users["ToolboxMoron"].DisplayName, users["ToolboxMoron"] }
                                     },
                                     new SortedList<string, Character>
                                     {
                                        { characters["ToolboxMoron"]["Luvon Keywynn"].CharacterName, characters["ToolboxMoron"]["Luvon Keywynn"] },
                                        { characters["HardworkingIdiot"]["Gradius Braveheart"].CharacterName, characters["ToolboxMoron"]["Gradius Braveheart"] }
                                     }
                                     */
                                     )
                        }
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

        
        public void Add(User user)
        {
            users[user.Username] = user;
        }


        public void Add(Character character)
        {
            characters[character.Owner.Username][character.CharacterName] = character;
        }


        public void Add(Campaign campaign)
        {
            campaigns[campaign.Owner.Username][campaign.Name] = campaign;
        }


        public void Remove(User user)
        {
            characters.Remove(user.Username);
            campaigns.Remove(user.Username);
            users.Remove(user.Username);
        }


        public void Remove(Character character)
        {
            characters[character.Owner.Username].Remove(character.CharacterName);
        }


        public void Remove(Campaign campaign)
        {
            campaigns[campaign.Owner.Username].Remove(campaign.Name);
        }
    }
}
