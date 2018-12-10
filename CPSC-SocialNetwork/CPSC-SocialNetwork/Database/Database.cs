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
            "ABadJoke",
            "MissErection",
            "UnholyCannoli"
        };

        public static readonly string[] DISPLAYNAME =
        {
            "Micah Peacock",
            "Scot Rahal",
            "Jesse Shewfelt",
            "Kris Lugtu",
            "Kendrick Ankamah",
            "Claire's Talking Robot",
            "Not Claire",
            "Matt Findlay",
            "Shelby Hodgson"
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
                { USERNAME[6], new User(username: USERNAME[6], displayname: DISPLAYNAME[6], picture: "6.png") },
                { USERNAME[7], new User(username: USERNAME[7], displayname: DISPLAYNAME[7], picture: "2.png") },
                { USERNAME[8], new User(username: USERNAME[8], displayname: DISPLAYNAME[8], picture: "4.png") }
            };
        }
        
        // Character Database
        private static Dictionary<string, Dictionary<string, Character>> InitializeCharacters()
        {
            return new Dictionary<string, Dictionary<string, Character>>
            {
                { USERNAME[0], new Dictionary<string, Character>
                    {
                        { "Soren Riftbane", new Character(owner: Users[USERNAME[0]], characterName: "Soren Riftbane", characterRace: "Tiefling (Pit-born)", characterClass: "Inquisitor", characterLevel: 13, picture: "8.png") },
                        { "Gradius Braveheart", new Character(owner: Users[USERNAME[0]], characterName: "Gradius Braveheart", characterRace: "Human", characterClass:"Barbarian", characterLevel: 7, picture: "3.png") },
                        { "Tak Lavalian", new Character(owner: Users[USERNAME[0]], characterName: "Tak Lavalian", characterRace: "Skinwalker", characterClass: "Fighter", characterLevel: 12, picture: "4.png") }
                    }
                },
                { USERNAME[1], new Dictionary<string, Character>
                    {
                        { "Doralig Cragarm", new Character(owner: Users[USERNAME[1]], characterName: "Doralig Cragarm", characterRace: "Dwarf", characterClass: "Druid", characterLevel: 7, picture: "5.png") },
                        { "Luvon Keywynn", new Character(owner: Users[USERNAME[1]], characterName: "Luvon Keywynn", characterRace: "Elf", characterClass: "Ranger", characterLevel: 7, picture: "7.png") },
                        { "Gareth Silvermane", new Character(owner: Users[USERNAME[1]], characterName: "Gareth Silvermane", characterRace: "Human", characterClass: "Fighter", characterLevel: 13, picture: "2.png") },
                        { "Jonathan Ablebody", new Character(owner: Users[USERNAME[1]], characterName: "Jonathan Ablebody", characterRace: "Half-Elf", characterClass: "Ranger", characterLevel: 14, picture: "6.png") }
                    }
                },
                { USERNAME[2], new Dictionary<string, Character>
                    {
                        { "Aeyi Oyu", new Character(owner: Users[USERNAME[2]], characterName: "Aeyi Oyu", characterRace: "Elf", characterClass: "Shadowdancer", characterLevel: 7, picture: "4.png") },
                        { "Finnan Tosscobble", new Character(owner: Users[USERNAME[2]], characterName: "Finnan Tosscobble", characterRace: "Halfling", characterClass: "Rogue", characterLevel: 2, picture: "1.png") },
                        { "Durgen Deemon", new Character(owner: Users[USERNAME[2]], characterName: "Durgen Deemon", characterRace: "Dragonborn", characterClass: "Monk", characterLevel: 5, picture: "3.png") }
                    }
                },
                { USERNAME[3], new Dictionary<string, Character>
                    {
                        { "Eridan Xanthas", new Character(owner: Users[USERNAME[3]], characterName: "Eridan Xanthas", characterRace: "Half-Elf", characterClass: "Magus", characterLevel: 6, picture: "6.png") },
                        { "Regium Baatori", new Character(owner: Users[USERNAME[3]], characterName: "Regium Baatori", characterRace: "Tiefling", characterClass: "Cerebremancer", characterLevel: 13, picture: "10.png") },
                        { "Raelyn Lebeda", new Character(owner: Users[USERNAME[3]], characterName: "Raelyn Lebeda", characterRace: "Aasimar", characterClass: "Paladin", characterLevel: 12, picture: "11.png") },
                        { "Dominic Baatori", new Character(owner: Users[USERNAME[3]], characterName: "Dominic Baatori", characterRace: "Nephilim", characterClass: "Magus", characterLevel: 3, picture: "9.png") }
                    }
                },
                { USERNAME[4], new Dictionary<string, Character>
                    {
                        { "Finnan Cobblepot", new Character(owner: Users[USERNAME[4]], characterName: "Finnan Cobblepot", characterRace: "Halfing", characterClass: "Rogue", characterLevel: 2, picture: "9.png") },
                        { "Terence", new Character(owner: Users[USERNAME[4]], characterName: "Terence", characterRace: "Tortle", characterClass: "Barbarian", characterLevel: 6, picture: "1.png") }
                    }
                },
                { USERNAME[5], new Dictionary<string, Character>
                    {
                        { "", new Character(owner: Users[USERNAME[5]], characterName: "", characterRace: "", characterClass: "", characterLevel: 0, picture: "") }
                    }
                },
                { USERNAME[6], new Dictionary<string, Character>
                    {
                        { "", new Character(owner: Users[USERNAME[6]], characterName: "", characterRace: "", characterClass: "", characterLevel: 0, picture: "") }
                    }
                },
                { USERNAME[7], new Dictionary<string, Character>
                    {
                        { "", new Character(owner: Users[USERNAME[7]], characterName: "", characterRace: "", characterClass: "", characterLevel: 0, picture: "") }
                    }
                },
                { USERNAME[8], new Dictionary<string, Character>
                    {
                        { "", new Character(owner: Users[USERNAME[8]], characterName: "", characterRace: "", characterClass: "", characterLevel: 0, picture: "") }
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
                            version: "Pathfinder",
                            picture: "2.png",
                            date: "October 29th, 2018",
                            meeting: "5pm to 9pm - Mondays - Weekly",
                            players: new SortedList<string, User>
                            {
                                { Users[USERNAME[3]].DisplayName, Users[USERNAME[3]] },
                                { Users[USERNAME[1]].DisplayName, Users[USERNAME[1]] },
                                { Users[USERNAME[2]].DisplayName, Users[USERNAME[2]] },
                                { Users[USERNAME[7]].DisplayName, Users[USERNAME[7]] },
                                { Users[USERNAME[8]].DisplayName, Users[USERNAME[8]] }
                            },
                            characters: new SortedList<string, Character>
                            { 
                                { Characters[USERNAME[1]]["Doralig Cragarm"].CharacterName, Characters[USERNAME[1]]["Doralig Cragarm"] },
                                { Characters[USERNAME[2]]["Aeyi Oyu"].CharacterName, Characters[USERNAME[2]]["Aeyi Oyu"] },
                                { Characters[USERNAME[3]]["Regium Baatori"].CharacterName, Characters[USERNAME[3]]["Regium Baatori"] }
                            },
                            npcs: new SortedList<string, Character>
                            {
                                { "Sorana Anittah", new Character(null, "Sorana Anittah", "Human", "Fighter", 5, "9.png") },
                                { "Jorr Natherson", new Character(null, "Jorr Natherson", "Human", "Ranger" , 3, "10.png") }
                            },
                            tags: new List<string>
                            {
                                "Goblins","Fighting","Fantasy","War"
                            },
                            entries: new List<StoryEntry>
                            {
                                { new StoryEntry("Background", "The half-dragon hobgoblin leader, Azar Kul, has amassed a massive army in Cinder Hill with the primary goal of annihilating the human empire.") },
                                { new StoryEntry("October 29th", "The party of treasure has defeated Zarr and his band of Marauders.") },
                                { new StoryEntry("November 5th", "The party runs into Drellin's ferry. Iyla suggests strongly to literally pick up and move the entire town to avoid the potential goblin threat.") },
                                { new StoryEntry("November 12th", "The party spends half the session debating whether to kill the friendly NPC ranger who demands a small sum of gold for his travels.") }
                            })
                        },

                        { "Kingmaker", new Campaign(
                            name: "Kingmaker",
                            description: "A politically based campaign with the goal of building a kingdom.",
                            owner: Users[USERNAME[0]],
                            version: "Pathfinder",
                            picture: "1.png",
                            date: "January 1st, 2016",
                            meeting: "6pm to 10pm - Thursdays - Weekly",
                            players: new SortedList<string, User>
                            {
                                { Users[USERNAME[4]].DisplayName, Users[USERNAME[4]] },
                                { Users[USERNAME[2]].DisplayName, Users[USERNAME[2]] },
                                { Users[USERNAME[1]].DisplayName, Users[USERNAME[1]] },
                                { Users[USERNAME[6]].DisplayName, Users[USERNAME[6]] },
                                { Users[USERNAME[7]].DisplayName, Users[USERNAME[7]] }
                            },
                            characters: new SortedList<string, Character>
                            {
                                { "Finnan Cobblepot", Characters[USERNAME[4]]["Finnan Cobblepot"] },
                                { "Durgen Deemon", Characters[USERNAME[2]]["Durgen Deemon"] },
                                { "Gareth Silvermane", Characters[USERNAME[1]]["Gareth Silvermane"] },
                                { "Raelyn Lebeda", Characters[USERNAME[3]]["Raelyn Lebeda"] }
                            },
                            npcs: new SortedList<string, Character>
                            {
                                { "Keston", new Character(null, "Keston", "Human", "Fighter", 8, "3.png") },
                                { "Corax", new Character(null, "Corax", "Human", "Barbarian", 7, "2.png") },
                                { "Tirresia", new Character(null, "Tirresia", "Fey", "Sorceress", 13, "5.png") },
                                { "Vorodaki", new Character(null, "Vorodaki", "Cyclops", "Lich", 15, "6.png") },
                                { "Havard", new Character(null, "Havard", "Havard", "Hellknight", 4, "1.png") }
                            },
                            tags: new List<string>
                            {
                                "Long Term", "Politics", "Kingdom Building",
                            },
                            entries: new List<StoryEntry>
                            {
                                { new StoryEntry("Background", "Quisque ipsum magna, sollicitudin sit amet commodo in, aliquam a erat. Nulla facilisi. Suspendisse imperdiet nec nisi vitae finibus. Nullam ultrices ligula feugiat erat iaculis, quis dignissim nunc tristique. Nulla dolor est, pharetra id pretium quis, aliquet sit amet nunc. Aliquam luctus porttitor augue nec ullamcorper. Vivamus commodo, mauris id sollicitudin luctus, velit nibh vulputate sem, sit amet faucibus lectus elit pretium erat. Morbi eget eros pretium, rutrum mi ac, ullamcorper enim. Maecenas vitae neque et lorem pulvinar vestibulum sit amet eget lectus. Fusce a nibh ut orci lacinia fermentum. Integer cursus elit ac sodales maximus. Aliquam massa mi, tincidunt sed diam quis, bibendum tristique magna. Nullam sit amet cursus sapien, ac mattis lacus. Vestibulum consectetur eget ipsum ac sodales. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed dui ex, laoreet eu nisi et, consectetur varius risus.") },
                                { new StoryEntry("November 9th", "Suspendisse ornare ut massa eget pulvinar. Phasellus porttitor ante a augue venenatis euismod. Suspendisse sit amet risus vel ante imperdiet ullamcorper. Curabitur venenatis dui sit amet dui consectetur, sit amet blandit arcu commodo. In diam eros, egestas malesuada tortor et, blandit tempus neque. In in ante ut quam consequat euismod. Integer accumsan, diam mattis dignissim maximus, risus augue venenatis diam, nec tristique urna nunc vitae quam. Aliquam id sem purus. Nullam quis nisl vel nisl blandit aliquet sed nec diam.") },
                                { new StoryEntry("November 18th", "Quisque mauris nulla, vestibulum et ullamcorper tincidunt, vehicula finibus ante. Etiam molestie, lacus id commodo finibus, massa mi molestie urna, vel ultricies tellus magna vitae libero. Sed sit amet ante nibh. Sed porta diam vel nunc semper efficitur. Nam maximus leo et ex lobortis, in molestie ante laoreet. Proin dictum luctus aliquet. Duis fermentum mi id ante aliquet, at aliquam sapien luctus.") },
                                { new StoryEntry("December 1st", "Sed vitae lacinia libero, vitae finibus tortor. Sed laoreet cursus nisi eget tincidunt. Sed lacinia nisi vel ex finibus sollicitudin. In hac habitasse platea dictumst. Fusce dictum ac lacus vel laoreet. Fusce et dignissim tortor. Etiam aliquet quam vitae viverra tempor. Fusce varius mattis enim, vel laoreet est molestie at. Mauris ac lectus at nunc venenatis tincidunt. Proin condimentum placerat risus quis egestas. Vestibulum molestie commodo diam in tincidunt. Curabitur blandit viverra velit, et tincidunt metus accumsan sed. Nam diam neque, accumsan eu ligula non, lacinia lacinia eros. Proin placerat velit massa, vitae tincidunt mauris placerat sed. In elementum egestas dolor, eget rhoncus libero viverra in. Sed non mollis purus.") },
                                { new StoryEntry("December 24th", "The party randomly celebrates for Christmas (even though Christmas doesn't exist in this setting)...") },
                                { new StoryEntry("December 31st", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras at libero id lorem aliquam aliquet non imperdiet orci. Nunc egestas hendrerit dolor, nec fermentum augue ultrices at. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Phasellus semper est enim, et fringilla ligula lobortis eget. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Cras sit amet metus in urna tincidunt consectetur ac vel ipsum. Pellentesque eu semper risus. Pellentesque odio elit, sodales ac ligula quis, porta aliquet arcu.") }
                            })
                        },

                        { "Legend of the Five Tomes", new Campaign(
                            name: "Legend of the Five Tomes",
                            description: "Delve deep into an ancient city filled with wonder and peril. Fight unearthed monsters and discover the secrets of a lost civilization. Be courageous and intelligent to piece together the Legend of the Five Tomes.",
                            owner: Users[USERNAME[2]],
                            picture: "10.png",
                            date: "Novermber 12th, 2018",
                            meeting: "4pm to 6pm - Sundays - Weekly",
                            players: new SortedList<string, User>
                            {
                                { Users[USERNAME[0]].DisplayName, Users[USERNAME[0]] },
                                { Users[USERNAME[1]].DisplayName, Users[USERNAME[1]] },
                                { Users[USERNAME[3]].DisplayName, Users[USERNAME[3]] },
                                { Users[USERNAME[4]].DisplayName, Users[USERNAME[4]] }
                            },
                            characters: new SortedList<string, Character>
                            {
                                { Characters[USERNAME[0]]["Soren Riftbane"].CharacterName, Characters[USERNAME[0]]["Soren Riftbane"] },
                                { Characters[USERNAME[1]]["Luvon Keywynn"].CharacterName, Characters[USERNAME[1]]["Luvon Keywynn"] },
                                { Characters[USERNAME[3]]["Eridan Xanthas"].CharacterName, Characters[USERNAME[3]]["Eridan Xanthas"] },
                                { Characters[USERNAME[4]]["Finnan Cobblepot"].CharacterName, Characters[USERNAME[4]]["Finnan Cobblepot"] }
                            },
                            npcs: new SortedList<string, Character>
                            {
                                {"Ulag the Wise", new Character(null, "Ulag the Wise", "Halfling", "Diviner", 9, "100.png") }
                            },
                            tags: new List<string>
                            {
                                "Ancient","City","Mystery","Horror","Ruins","Dungeon"
                            },
                            entries: new List<StoryEntry>
                            {
                                new StoryEntry("Background", "The Legend of the Five Tomes is a story older than the wisest of the village but lives on past down through each generation. " +
                                                              "It tells of a great and vast civilization of old whose remains still buzz with life beneath the depths of an ancient forest. " +
                                                              "Within a sprawling labyrinth of collapsed structures and roads long since travelled rumors tell of five tomes of untold knowledge " +
                                                              "and power."),
                                new StoryEntry("November 25th", "The party of brave adventurers, having heard of the legendary city, decide to embark to the ancient forest to the east. They gather " +
                                                               "the gear they require and hone their skills before setting out from the village."),
                                new StoryEntry("December 2nd", "At the roots of a mighty tree the party found the remains of a mystic portal. Unable to open it they decided to search the remains of " +
                                                               "what seemed to be the adventurers that came before them. On one of the bodies was a map with confusing markings and strange imagery that " +
                                                               "seemed to be leading toward the lake to the north.")
                                          

                            }
                            )
                        }
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
                },
                { USERNAME[7], new Dictionary<string, Campaign>
                    {

                    }
                },
                { USERNAME[8], new Dictionary<string, Campaign>
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
            Dictionary<Character, CharacterPage> pages = new Dictionary<Character, CharacterPage>();
            foreach (User user in Users.Values)
                foreach (Character character in Characters[user.Username].Values)
                    if (character != null)
                        pages.Add(character, new CharacterPage(character));
            return pages;
        }


        private static Dictionary<Campaign, CampaignPage> InitializeCampaignPages()
        {
            Dictionary<Campaign, CampaignPage> pages = new Dictionary<Campaign, CampaignPage>();
            foreach (User user in Users.Values)
                foreach (Campaign campaign in Campaigns[user.Username].Values)
                    if (campaign != null)
                        pages.Add(campaign, new CampaignPage(campaign));
            return pages;
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
