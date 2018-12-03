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

using CPSC_SocialNetwork.Users;


namespace CPSC_SocialNetwork.Characters
{
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : UserControl
    {
        private Character character;
        public Character Character
        {
            get => this.character;
            set => this.character = value;
        }


        public CharacterPage()
        {
            InitializeComponent();
        }
        

        public CharacterPage(Character character)
        {
            InitializeComponent();
            this.character = character;
        }
    }
}
