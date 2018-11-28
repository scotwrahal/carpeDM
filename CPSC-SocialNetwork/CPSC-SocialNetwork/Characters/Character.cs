using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_SocialNetwork.Characters
{
    class Character
    {
        private string characterName;
        public string CharacterName
        {
            get { return characterName; }
            set { this.characterName = value; }
        }

        private string characterRace;
        public string CharacterRace
        {
            get { return characterRace; }
            set { this.characterRace = value; }
        }

        private string characterClass;
        public string CharacterClass
        {
            get { return characterClass; }
            set { this.characterClass = value; }
        }

        private int characterLevel;
        public int CharacterLevel
        {
            get { return characterLevel; }
            set { this.characterLevel = value; }
        }


        public Character()
        {
            characterName = "";
            characterRace = "";
            characterClass = "";
            characterLevel = 0;
        }


        public Character(string characterName = "", string characterRace = "", string characterClass = "", int characterLevel = 0)
        {
            this.characterName = characterName;
            this.characterRace = characterRace;
            this.characterClass = characterClass;
            this.characterLevel = characterLevel;
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
