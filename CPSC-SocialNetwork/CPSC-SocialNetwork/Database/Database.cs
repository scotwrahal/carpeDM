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
        
        public static readonly string[] USERNAME =
        {
            "HardworkingIdiot",
            "ToolboxMoron",
            "VirtualWaffles",
            "ThatSmartGuy",
            "ThatOtherSmartGuy",
            "MrRobotDood",
            "ABadJoke"
        };

        public static readonly string[] DISPLAYNAME =
        {
            "Micah Peacock",
            "Scot Rahal",
            "Jesse Shewfelt",
            "Kris Lugtu",
            "Kendrick Ankamah",
            "Claire's Talking Robot",
            "Not Claire"
        };

        /*
        public const string USERNAME[0] = "HardworkingIdiot";
        public const string USERNAME[1] = "ToolboxMoron";
        public const string USERNAME[2] = "VirtualWaffles";
        public const string USERNAME[3] = "ThatSmartGuy";
        public const string USERNAME[4] = "ThatOtherSmartGuy";
        public const string USERNAME[5] = "MrRobotDood";
        public const string USERNAME[6] = "ABadJoke";

        public const string DISPLAYNAME[0] = "Micah Peacock";
        public const string DISPLAYNAME[1] = "Scot Rahal";
        public const string DISPLAYNAME[2] = "Jesse Shewfelt";
        public const string DISPLAYNAME[3] = "Kris Lugtu";
        public const string DISPLAYNAME[4] = "Kendrick Ankamah";
        public const string DISPLAYNAME[5] = "Claire's Talking Robot";
        public const string DISPLAYNAME[6] = "Not Claire";
        */
        private readonly Dictionary<string, User> users;
        public Dictionary<string, User> Users { get => this.users; }

        private readonly Dictionary<string, Dictionary<string, Character>> characters;
        public Dictionary<string, Dictionary<string, Character>> Characters { get => this.characters; }
        
        private readonly Dictionary<string, Dictionary<string, Campaign>> campaigns;
        public Dictionary<string, Dictionary<string, Campaign>> Campaigns { get => this.campaigns; }

        private readonly Dictionary<User, ProfilePage> profilepages;
        public Dictionary<User, ProfilePage> ProfilePages { get => this.profilepages; }

        private readonly Dictionary<Character, CharacterPage> characterpages;
        public Dictionary<Character, CharacterPage> CharacterPages { get => this.characterpages; }

        private readonly Dictionary<Campaign, CampaignPage> campaignpages;
        public Dictionary<Campaign, CampaignPage> CampaignPages { get => this.campaignpages; }


        public SocialNetworkDatabase()
        {

            users = new Dictionary<string, User>
            {
                { USERNAME[0], new User(username: USERNAME[0], displayname: DISPLAYNAME[0], picture: "ProfilePicture.png") },
                { USERNAME[1], new User(username: USERNAME[1], displayname: DISPLAYNAME[1], picture: "4.png") },
                { USERNAME[2], new User(username: USERNAME[2], displayname: DISPLAYNAME[2], picture: "5.png") },
                { USERNAME[3], new User(username: USERNAME[3], displayname: DISPLAYNAME[3], picture: "0.png") },
                { USERNAME[4], new User(username: USERNAME[4], displayname: DISPLAYNAME[4], picture: "3.png") },
                { USERNAME[5], new User(username: USERNAME[5], displayname: DISPLAYNAME[5], picture: "7.png") },
                { USERNAME[6], new User(username: USERNAME[6], displayname: DISPLAYNAME[6], picture: "6.png") }
            };

            characters = new Dictionary<string, Dictionary<string, Character>>
            {
                { USERNAME[0], new Dictionary<string, Character>
                    { 
                        { "Eridan Xanthas", new Character(owner: users[USERNAME[0]], characterName: "Eridan Xanthas", characterRace: "Half-Elf", characterClass: "Magus", characterLevel: 6, picture: "0.png") },
                        { "Soren Riftbane", new Character(owner: users[USERNAME[0]], characterName: "Soren Riftbane", characterRace: "Tiefling (Pit-born)", characterClass: "Inquisitor", characterLevel: 3, picture: "2.png") },
                        { "Gradius Braveheart", new Character(owner: users[USERNAME[0]], characterName: "Gradius Braveheart", characterRace: "Human", characterClass:"Barbarian", characterLevel: 7, picture: "3.png") }
                    }
                },
                { USERNAME[1], new Dictionary<string, Character>
                    {
                        { "Doralig Cragarm", new Character(owner: users[USERNAME[1]], characterName: "Doralig Cragarm", characterRace: "Dwarf", characterClass: "Druid", characterLevel: 6) },
                        { "Luvon Keywynn", new Character(owner: users[USERNAME[1]], characterName: "Luvon Keywynn", characterRace: "Elf", characterClass: "Ranger", characterLevel: 7) }
                    }
                },
                { USERNAME[2], new Dictionary<string, Character>
                    {
                        { "Aeyi Oyu", new Character(owner: users[USERNAME[2]], characterName: "Aeyi Oyu", characterRace: "Elf", characterClass: "Shadowdancer", characterLevel: 7) }
                    }
                },
                { USERNAME[3], new Dictionary<string, Character>
                    {

                    }
                },
                { USERNAME[4], new Dictionary<string, Character>
                    {

                    }
                },
                { USERNAME[5], new Dictionary<string, Character>
                    {

                    }
                },
                { USERNAME[6], new Dictionary<string, Character>
                    {

                    }
                }
            };

            campaigns = new Dictionary<string, Dictionary<string, Campaign>>
            {
                { USERNAME[0], new Dictionary<string, Campaign>
                    {
                        { "Red Hand of Doom", new Campaign(
                            name: "Red Hand of Doom", 
                            description: "An old 3e campaign.", 
                            owner: users[USERNAME[0]],
                            picture: "0.png",
                            players: new SortedList<string, User>
                            {
                                { users[USERNAME[0]].DisplayName, users[USERNAME[0]] },
                                { users[USERNAME[1]].DisplayName, users[USERNAME[1]] },
                                { users[USERNAME[2]].DisplayName, users[USERNAME[2]] }
                            },
                            characters: new SortedList<string, Character>
                            {
                                { characters[USERNAME[1]]["Doralig Cragarm"].CharacterName, characters[USERNAME[1]]["Doralig Cragarm"] }
                            })
                        },
                        { "Kingmaker", new Campaign(name: "Kingmaker", description: "A politically based campaign with the goal of building a kingdom.", owner: users[USERNAME[0]]) }
                    }
                },
                { USERNAME[1], new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME[2], new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME[3], new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME[4], new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME[5], new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME[6], new Dictionary<string, Campaign>
                    {

                    }
                }
            };

            foreach(User user in users.Values)
            {
                user.Characters = characters[user.Username];
                user.Campaigns = campaigns[user.Username];
            }

            profilepages = new Dictionary<User, ProfilePage>
            {

            };

            characterpages = new Dictionary<Character, CharacterPage>
            {

            };

            campaignpages = new Dictionary<Campaign, CampaignPage>
            {

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


        public void Add(ProfilePage page)
        {
            profilepages[page.Owner] = page;
        }


        public void Add(CharacterPage characterpage)
        {
            characterpages[characterpage.Character] = characterpage;
        }


        public void Add(CampaignPage campaignpage)
        {
            campaignpages[campaignpage.Campaign] = campaignpage;
        }


        public void Remove(User user)
        {
            characters.Remove(user.Username);

            campaigns.Remove(user.Username);

            users.Remove(user.Username);
        }


        public void Remove(Character character)
        {
            characterpages.Remove(character);
            characters[character.Owner.Username].Remove(character.CharacterName);
        }


        public void Remove(Campaign campaign)
        {
            campaignpages.Remove(campaign);
            campaigns[campaign.Owner.Username].Remove(campaign.Name);
        }
    }
}
