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
using CPSC_SocialNetwork.Database;

namespace CPSC_SocialNetwork.UserDisplay
{
    public partial class ProfilePageButton : UserControl
    {
        private User user;
        public User User
        {
            get => this.user;
            set => this.user = value;
        }

        private string name;
        public string DisplayName
        {
            get => this.name;
            set
            {
                this.name = value;
                this.MainUserName.Text = this.name;
            }
        }

        private Image picture;
        public Image Picture
        {
            get => this.picture;
            set
            {
                this.picture = value;
                this.Image.Source = this.picture.Source;
            }
        }

        public ProfilePageButton()
        {
            InitializeComponent();
        }
        public ProfilePageButton(User user)
        {
            InitializeComponent();
            this.user = user;
            this.DisplayName = user.DisplayName;
            this.Image.Source = new BitmapImage(new Uri(@"\Images\User\" + user.Picture, UriKind.Relative));
        }

        private void ProfilePageButton_Click(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(SocialNetworkDatabase.ProfilePages[this.user]);
        }
    }
}
