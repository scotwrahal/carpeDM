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
        public const string USERNAME_1 = "HardworkingIdiot";
        public const string USERNAME_2 = "ToolboxMoron";
        public const string USERNAME_3 = "Doooooood";
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

        private readonly Dictionary<string, User> users;
        public Dictionary<string, User> Users { get => this.users; }

        private readonly Dictionary<string, Dictionary<string, Character>> characters;
        public Dictionary<string, Dictionary<string, Character>> Characters { get => this.characters; }
        
        private readonly Dictionary<string, Dictionary<string, Campaign>> campaigns;
        public Dictionary<string, Dictionary<string, Campaign>> Campaigns { get => this.campaigns; }

        private readonly Dictionary<User, ProfilePage> profilepages;
        public Dictionary<User, ProfilePage> ProfilePages { get => this.profilepages; }

        private readonly Dictionary<User, Dictionary<Character, CharacterPage>> characterpages;
        public Dictionary<User, Dictionary<Character, CharacterPage>> CharacterPages { get => this.characterpages; }

        private readonly Dictionary<User, Dictionary<Campaign, CampaignPage>> campaignpages;
        public Dictionary<User, Dictionary<Campaign, CampaignPage>> CampaignPages { get => this.campaignpages; }


        public SocialNetworkDatabase()
        {

            users = new Dictionary<string, User>
            {
                { USERNAME_1, new User(username: USERNAME_1, displayname: DISPLAYNAME_1, picture: "ProfilePicture.png") },
                { USERNAME_2, new User(username: USERNAME_2, displayname: DISPLAYNAME_2, picture: "4.png") },
                { USERNAME_3, new User(username: USERNAME_3, displayname: DISPLAYNAME_3, picture: "5.png") },
                { USERNAME_4, new User(username: USERNAME_4, displayname: DISPLAYNAME_4, picture: "6.png") },
                { USERNAME_5, new User(username: USERNAME_5, displayname: DISPLAYNAME_5, picture: "7.png") },
                { USERNAME_6, new User(username: USERNAME_6, displayname: DISPLAYNAME_6, picture: "8.png") },
                { USERNAME_7, new User(username: USERNAME_7, displayname: DISPLAYNAME_7, picture: "9.png") }
            };

            characters = new Dictionary<string, Dictionary<string, Character>>
            {
                { USERNAME_1, new Dictionary<string, Character>
                    { 
                        { "Eridan Xanthas", new Character(owner: users[USERNAME_1], characterName: "Eridan Xanthas", characterRace: "Half-Elf", characterClass: "Magus", characterLevel: 6, picture: "1.png") },
                        { "Soren Riftbane", new Character(owner: users[USERNAME_1], characterName: "Soren Riftbane", characterRace: "Tiefling (Pit-born)", characterClass: "Inquisitor", characterLevel: 13, picture: "2.png") },
                        { "Gradius Braveheart", new Character(owner: users[USERNAME_1], characterName: "Gradius Braveheart", characterRace: "Human", characterClass:"Barbarian", characterLevel: 7, picture: "3.png") }
                    }
                },
                { USERNAME_2, new Dictionary<string, Character>
                    {
                        { "Doralig Cragarm", new Character(owner: users[USERNAME_2], characterName: "Doralig Cragarm", characterRace: "Dwarf", characterClass: "Druid", characterLevel: 16) },
                        { "Luvon Keywynn", new Character(owner: users[USERNAME_2], characterName: "Luvon Keywynn", characterRace: "Elf", characterClass: "Ranger", characterLevel: 7) }
                    }
                },
                { USERNAME_3, new Dictionary<string, Character>
                    {

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

            campaigns = new Dictionary<string, Dictionary<string, Campaign>>
            {
                { USERNAME_1, new Dictionary<string, Campaign>
                    {
                        { "Red Hand of Doom", new Campaign(
                            name: "Red Hand of Doom", 
                            description: "An old 3e campaign.", 
                            owner: users[USERNAME_1],
                            picture: "11.png",
                            players: new SortedList<string, User>
                            {
                                { users[USERNAME_1].DisplayName, users[USERNAME_1] },
                                { users[USERNAME_2].DisplayName, users[USERNAME_2] },
                                { users[USERNAME_3].DisplayName, users[USERNAME_3] }
                            },
                            characters: new SortedList<string, CharacterPage>
                            {
                                { characters[USERNAME_2]["Doralig Cragarm"].CharacterName, new CharacterPage(characters[USERNAME_2]["Doralig Cragarm"]) }
                            })
                        },
                        { "Kingmaker", new Campaign(name: "Kingmaker", description: "A politically based campaign with the goal of building a kingdom.", owner: users[USERNAME_1]) }
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

            foreach(User user in users.Values)
            {
                user.Characters = characters[user.Username];
                user.Campaigns = campaigns[user.Username];
            }

            profilepages = new Dictionary<User, ProfilePage>
            {

            };

            characterpages = new Dictionary<User, Dictionary<Character, CharacterPage>>();
            foreach (User user in users.Values)
                characterpages[user] = new Dictionary<Character, CharacterPage>();

            campaignpages = new Dictionary<User, Dictionary<Campaign, CampaignPage>>();
            foreach (User user in users.Values)
                campaignpages[user] = new Dictionary<Campaign, CampaignPage>();
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
            characterpages[characterpage.Character.Owner][characterpage.Character] = characterpage;
        }


        public void Add(CampaignPage campaignpage)
        {
            campaignpages[campaignpage.Campaign.Owner][campaignpage.Campaign] = campaignpage;
        }


        public void Remove(User user)
        {
            characters.Remove(user.Username);
            characterpages.Remove(user);

            campaigns.Remove(user.Username);
            campaignpages.Remove(user);

            users.Remove(user.Username);
        }


        public void Remove(Character character)
        {
            characterpages[character.Owner].Remove(character);
            characters[character.Owner.Username].Remove(character.CharacterName);
        }


        public void Remove(Campaign campaign)
        {
            campaignpages[campaign.Owner].Remove(campaign);
            campaigns[campaign.Owner.Username].Remove(campaign.Name);
        }
    }
}
