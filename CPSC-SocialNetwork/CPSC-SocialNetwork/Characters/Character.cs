﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CPSC_SocialNetwork.Users;


namespace CPSC_SocialNetwork.Characters
{
    public class Character
    {
        private User owner;
        public User Owner
        {
            get => this.owner;
            set => this.owner = value;
        }

        private string characterName;
        public string CharacterName
        {
            get => this.characterName; 
            set => this.characterName = value;
        }

        private string characterRace;
        public string CharacterRace
        {
            get => this.characterRace;
            set => this.characterRace = value;
        }

        private string characterClass;
        public string CharacterClass
        {
            get => this.characterClass; 
            set => this.characterClass = value; 
        }

        private int characterLevel;
        public int CharacterLevel
        {
            get => this.characterLevel; 
            set => this.characterLevel = value; 
        }

        private string picture;
        public string Picture
        {
            get => this.picture;
            set => this.picture = value;
        }


        public Character(User owner, string characterName = "", string characterRace = "", string characterClass = "", int characterLevel = 0, string picture = "")
        {
            this.owner = owner;
            this.characterName = characterName;
            this.characterRace = characterRace;
            this.characterClass = characterClass;
            this.characterLevel = characterLevel;
            this.picture = picture;
        }

        public override string ToString()
        {
            string leveltag = "";
   
            if (this.characterLevel == 1)
                leveltag = "1st Level";
            else if (this.characterLevel == 2)
                leveltag = "2nd Level";
            else
                leveltag = this.characterLevel.ToString() + "th Level";

            return this.characterRace + ", " + CharacterClass + ", " + leveltag; 
        }
    }
}
