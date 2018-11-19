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


        public Character()
        {
            characterName = "";
            characterRace = "";
            characterClass = "";
        }


        public Character(string characterName, string characterRace, string characterClass)
        {
            this.characterName = characterName;
            this.characterRace = characterRace;
            this.characterClass = characterClass;
        }
    }
}
