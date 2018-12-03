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
        public const string USERNAME_1 = "HardworkingIdiot";
        public const string USERNAME_2 = "ToolboxMoron";
        public const string USERNAME_3 = "VirtualWaffles";
        public const string USERNAME_4 = "ThatSmartGuy";
        public const string USERNAME_5 = "ThatOtherSmartGuy";
        public const string USERNAME_6 = "MrRobotDood";
        public const string USERNAME_7 = "ABadJoke";

        public const string DISPLAYNAME_1 = "Micah Peacock";
        public const string DISPLAYNAME_2 = "Scot Rahal";
        public const string DISPLAYNAME_3 = "Jesse Shewfelt";
        public const string DISPLAYNAME_4 = "Kris Lugtu";
        public const string DISPLAYNAME_5 = "Kendrick Ankamah";
        public const string DISPLAYNAME_6 = "Claire's Talking Robot";
        public const string DISPLAYNAME_7 = "Not Claire";

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
                { USERNAME_1, new User(username: USERNAME_1, displayname: DISPLAYNAME_1, picture: "ProfilePicture.png") },
                { USERNAME_2, new User(username: USERNAME_2, displayname: DISPLAYNAME_2, picture: "4.png") },
                { USERNAME_3, new User(username: USERNAME_3, displayname: DISPLAYNAME_3, picture: "5.png") },
                { USERNAME_4, new User(username: USERNAME_4, displayname: DISPLAYNAME_4, picture: "1.png") },
                { USERNAME_5, new User(username: USERNAME_5, displayname: DISPLAYNAME_5, picture: "3.png") },
                { USERNAME_6, new User(username: USERNAME_6, displayname: DISPLAYNAME_6, picture: "7.png") },
                { USERNAME_7, new User(username: USERNAME_7, displayname: DISPLAYNAME_7, picture: "6.png") }
            };
        }
        

        private static Dictionary<string, Dictionary<string, Character>> InitializeCharacters()
        {
            return new Dictionary<string, Dictionary<string, Character>>
            {
                { USERNAME_1, new Dictionary<string, Character>
                    {
                        { "Eridan Xanthas", new Character(owner: Users[USERNAME_1], characterName: "Eridan Xanthas", characterRace: "Half-Elf", characterClass: "Magus", characterLevel: 6, picture: "1.png") },
                        { "Soren Riftbane", new Character(owner: Users[USERNAME_1], characterName: "Soren Riftbane", characterRace: "Tiefling (Pit-born)", characterClass: "Inquisitor", characterLevel: 13, picture: "2.png") },
                        { "Gradius Braveheart", new Character(owner: Users[USERNAME_1], characterName: "Gradius Braveheart", characterRace: "Human", characterClass:"Barbarian", characterLevel: 7, picture: "3.png") }
                    }
                },
                { USERNAME_2, new Dictionary<string, Character>
                    {
                        { "Doralig Cragarm", new Character(owner: Users[USERNAME_2], characterName: "Doralig Cragarm", characterRace: "Dwarf", characterClass: "Druid", characterLevel: 16) },
                        { "Luvon Keywynn", new Character(owner: Users[USERNAME_2], characterName: "Luvon Keywynn", characterRace: "Elf", characterClass: "Ranger", characterLevel: 7) }
                    }
                },
                { USERNAME_3, new Dictionary<string, Character>
                    {
                        { "Aeyi Oyu", new Character(owner: Users[USERNAME_3], characterName: "Aeyi Oyu", characterRace: "Elf", characterClass: "Shadowdancer", characterLevel: 7) }
                    }
                },
                { USERNAME_4, new Dictionary<string, Character>
                    {

                    }
                },
                { USERNAME_5, new Dictionary<string, Character>
                    {

                    }
                },
                { USERNAME_6, new Dictionary<string, Character>
                    {

                    }
                },
                { USERNAME_7, new Dictionary<string, Character>
                    {

                    }
                }
            };
        }


        private static Dictionary<string, Dictionary<string, Campaign>> InitializeCampaigns()
        {
            return new Dictionary<string, Dictionary<string, Campaign>>
            {
                { USERNAME_1, new Dictionary<string, Campaign>
                    {
                        { "Red Hand of Doom", new Campaign(
                            name: "Red Hand of Doom",
                            description: "An old 3e campaign.",
                            owner: Users[USERNAME_1],
                            picture: "11.png",
                            players: new SortedList<string, User>
                            {
                                { Users[USERNAME_1].DisplayName, Users[USERNAME_1] },
                                { Users[USERNAME_2].DisplayName, Users[USERNAME_2] },
                                { Users[USERNAME_3].DisplayName, Users[USERNAME_3] }
                            },
                            characters: new SortedList<string, Character>
                            {
                                { Characters[USERNAME_2]["Doralig Cragarm"].CharacterName, Characters[USERNAME_2]["Doralig Cragarm"] }
                            })
                        },
                        { "Kingmaker", new Campaign(name: "Kingmaker", description: "A politically based campaign with the goal of building a kingdom.", owner: Users[USERNAME_1]) }
                    }
                },
                { USERNAME_2, new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME_3, new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME_4, new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME_5, new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME_6, new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME_7, new Dictionary<string, Campaign>
                    {

                    }
                }
            };
        }


        private static Dictionary<User, ProfilePage> InitializeProfilePages()
        {
            return new Dictionary<User, ProfilePage>();
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
    }
}
