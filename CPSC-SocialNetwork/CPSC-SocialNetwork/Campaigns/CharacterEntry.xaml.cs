using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using CPSC_SocialNetwork;
using CPSC_SocialNetwork.Characters;
using CPSC_SocialNetwork.Database;

namespace CPSC_SocialNetwork.Campaigns
{
    /// <summary>
    /// Interaction logic for CharacterEntry.xaml
    /// </summary>
    public partial class CharacterEntry : UserControl
    {
        private readonly Character character;
        public Character Character { get => this.character; } 


        public CharacterEntry()
        {
            InitializeComponent();
        }

        public CharacterEntry(Character character)
        {
            InitializeComponent();
            this.character = character;
            this.Image.Source = new BitmapImage(new Uri(@"\Images\Character\" + character.Picture, UriKind.Relative));
            this.CharacterName.Text = character.CharacterName;
            this.CharacterDescription.Text = "Level " + character.CharacterLevel + " " + character.CharacterRace + " " + character.CharacterClass;
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(SocialNetworkDatabase.CharacterPages[this.character]);
        }
    }
}
