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
    static class SocialNetworkDatabase
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

        public static Dictionary<string, User> Users = InitializeUsers();
        public static Dictionary<string, Dictionary<string, Character>> Characters = InitializeCharacters();
        public static Dictionary<string, Dictionary<string, Campaign>> Campaigns = InitializeCampaigns();

        public static Dictionary<User, ProfilePage> ProfilePages = InitializeProfilePages();
        public static Dictionary<Character, CharacterPage> CharacterPages = InitializeCharacterPages();
        public static Dictionary<Campaign, CampaignPage> CampaignPages = InitializeCampaignPages(); 


        // Initialization functions
        private static Dictionary<string, User> InitializeUsers()
        {
            return new Dictionary<string, User>
            {
                { USERNAME[0], new User(username: USERNAME[0], displayname: DISPLAYNAME[0], picture: "ProfilePicture.png") },
                { USERNAME[1], new User(username: USERNAME[1], displayname: DISPLAYNAME[1], picture: "4.png") },
                { USERNAME[2], new User(username: USERNAME[2], displayname: DISPLAYNAME[2], picture: "5.png") },
                { USERNAME[3], new User(username: USERNAME[3], displayname: DISPLAYNAME[3], picture: "1.png") },
                { USERNAME[4], new User(username: USERNAME[4], displayname: DISPLAYNAME[4], picture: "3.png") },
                { USERNAME[5], new User(username: USERNAME[5], displayname: DISPLAYNAME[5], picture: "7.png") },
                { USERNAME[6], new User(username: USERNAME[6], displayname: DISPLAYNAME[6], picture: "6.png") }
            };
        }
        

        private static Dictionary<string, Dictionary<string, Character>> InitializeCharacters()
        {
            return new Dictionary<string, Dictionary<string, Character>>
            {
                { USERNAME[0], new Dictionary<string, Character>
                    {
                        { "Eridan Xanthas", new Character(owner: Users[USERNAME[0]], characterName: "Eridan Xanthas", characterRace: "Half-Elf", characterClass: "Magus", characterLevel: 6, picture: "1.png") },
                        { "Soren Riftbane", new Character(owner: Users[USERNAME[0]], characterName: "Soren Riftbane", characterRace: "Tiefling (Pit-born)", characterClass: "Inquisitor", characterLevel: 13, picture: "2.png") },
                        { "Gradius Braveheart", new Character(owner: Users[USERNAME[0]], characterName: "Gradius Braveheart", characterRace: "Human", characterClass:"Barbarian", characterLevel: 7, picture: "3.png") }
                    }
                },
                { USERNAME[1], new Dictionary<string, Character>
                    {
                        { "Doralig Cragarm", new Character(owner: Users[USERNAME[1]], characterName: "Doralig Cragarm", characterRace: "Dwarf", characterClass: "Druid", characterLevel: 16) },
                        { "Luvon Keywynn", new Character(owner: Users[USERNAME[1]], characterName: "Luvon Keywynn", characterRace: "Elf", characterClass: "Ranger", characterLevel: 7) }
                    }
                },
                { USERNAME[2], new Dictionary<string, Character>
                    {
                        { "Aeyi Oyu", new Character(owner: Users[USERNAME[2]], characterName: "Aeyi Oyu", characterRace: "Elf", characterClass: "Shadowdancer", characterLevel: 7) },
                        { "Finnan Cobblepot", new Character(owner: Users[USERNAME[2]], characterName: "Finnan Cobblepot", characterRace: "Halfing", characterClass: "Rogue", characterLevel: 2) }
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
        }


        private static Dictionary<string, Dictionary<string, Campaign>> InitializeCampaigns()
        {
            return new Dictionary<string, Dictionary<string, Campaign>>
            {
                { USERNAME[0], new Dictionary<string, Campaign>
                    {
                        { "Red Hand of Doom", new Campaign(
                            name: "Red Hand of Doom",
                            description: "An old 3e campaign.",
                            owner: Users[USERNAME[0]],
                            picture: "11.png",
                            players: new SortedList<string, User>
                            {
                                { Users[USERNAME[0]].DisplayName, Users[USERNAME[0]] },
                                { Users[USERNAME[1]].DisplayName, Users[USERNAME[1]] },
                                { Users[USERNAME[2]].DisplayName, Users[USERNAME[2]] }
                            },
                            characters: new SortedList<string, Character>
                            {
                                { Characters[USERNAME[1]]["Doralig Cragarm"].CharacterName, Characters[USERNAME[1]]["Doralig Cragarm"] }
                            })
                        },
                        { "Kingmaker", new Campaign(name: "Kingmaker", description: "A politically based campaign with the goal of building a kingdom.", owner: Users[USERNAME[0]]) }
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
        }


        private static Dictionary<User, ProfilePage> InitializeProfilePages()
        {
            Dictionary<User, ProfilePage> pages = new Dictionary<User, ProfilePage>();
            foreach (User user in Users.Values)
                pages.Add(user, new ProfilePage(user));
            return pages;
        }


        private static Dictionary<Character, CharacterPage> InitializeCharacterPages()
        {
            return new Dictionary<Character, CharacterPage>();
        }


        private static Dictionary<Campaign, CampaignPage> InitializeCampaignPages()
        {
            return new Dictionary<Campaign, CampaignPage>();
        }


        // Add to Database Functions
        public static void Add(User user)
        {
            Users[user.Username] = user;
        }

            
        public static void Add(Character character)
        {
            Characters[character.Owner.Username][character.CharacterName] = character;
        }


        public static void Add(Campaign campaign)
        {
            Campaigns[campaign.Owner.Username][campaign.Name] = campaign;
        }


        public static void Add(ProfilePage page)
        {
            ProfilePages[page.Owner] = page;
        }


        public static void Add(CharacterPage characterpage)
        {
            CharacterPages[characterpage.Character] = characterpage;
        }


        public static void Add(CampaignPage campaignpage)
        {
            CampaignPages[campaignpage.Campaign] = campaignpage;
        }


        // Remove from Database functions
        public static void Remove(User user)
        {
            Characters.Remove(user.Username);

            Campaigns.Remove(user.Username);

            ProfilePages.Remove(user);
            Users.Remove(user.Username);
        }


        public static void Remove(Character character)
        {
            CharacterPages.Remove(character);
            Characters[character.Owner.Username].Remove(character.CharacterName);
        }


        public static void Remove(Campaign campaign)
        {
            CampaignPages.Remove(campaign);
            Campaigns[campaign.Owner.Username].Remove(campaign.Name);
        }

        public static User GetUser(string name)
        {
            if (!Users.ContainsKey(name))
                throw new KeyNotFoundException("Username does not exist in database.");
            return Users[name];
        }

        public static Character GetCharacter(string username, string charactername)
        {
            if (!Characters.ContainsKey(username))
                throw new KeyNotFoundException("Username does not exist in database.");
            if (!Characters[username].ContainsKey(charactername))
                throw new KeyNotFoundException("Character Name doesn't exist in database.");
            return Characters[username][charactername];
        }

        public static Campaign GetCampaign(string username, string campaignname)
        {
            if (!Campaigns.ContainsKey(username))
                throw new KeyNotFoundException("Username does not exist in database.");
            if (!Campaigns[username].ContainsKey(campaignname))
                throw new KeyNotFoundException("Campaign Name doesn't exist in database.");
            return Campaigns[username][campaignname];
        }
    }
}
