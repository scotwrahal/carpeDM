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

namespace CPSC_SocialNetwork.Characters
{
    /// <summary>
    /// Interaction logic for CharacterSidebarButton.xaml
    /// </summary>
    public partial class CharacterSidebarButton : UserControl
    {
        private UserControl link;
        public UserControl Link
        {
            get { return link; }
        }

        private Image picture;
        public Image Picture
        {
            get { return picture; }
            set
            {
                picture = value;
                this.CharacterImage.Source = this.CharacterImage.Source;
            }
        }

        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        public CharacterSidebarButton()
        {
            InitializeComponent();
        }

        public CharacterSidebarButton(string title, UserControl linkedControl, string description = "", string picture = "")
        {
            InitializeComponent();
            Title.Text = title;
            Description.Text = description;
            link = linkedControl;
            this.CharacterImage.Source = new BitmapImage(new Uri(@"\Images\Character\" + picture, UriKind.Relative));
        }

        private void CharacterSidebarButton_Click(object sender, MouseButtonEventArgs e)
        {
            CharacterSidebarButton Sender = (CharacterSidebarButton)sender;
            Switcher.Switch(Sender.Link);
        }
    }
}
