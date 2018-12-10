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
using CPSC_SocialNetwork.UserDisplay;


namespace CPSC_SocialNetwork.Campaigns
{
    /// <summary>
    /// Interaction logic for PlayerEntry.xaml
    /// </summary>
    public partial class PlayerEntry : UserControl
    {
        private User user;
        public User User
        {
            get => this.user;
            set => this.user = value;
        }

        public PlayerEntry()
        {
            InitializeComponent();

            this.Image.Source = new BitmapImage(new Uri(@"\Images\System\default.png", UriKind.Relative));
            this.Name.Text = "Display Name";
        }

        public PlayerEntry(User user)
        {
            InitializeComponent();
            this.user = user;
            this.Image.Source = new BitmapImage(new Uri(@"\Images\User\" + user.Picture, UriKind.Relative));
            this.Name.Text = user.DisplayName;
        }

        private void PlayerEntry_Click(object sender, MouseButtonEventArgs e)
        {
            if (!(e.OriginalSource is Image))
                Switcher.Switch(SocialNetworkDatabase.ProfilePages[this.user]);
        }

        private void DMIcon_Click(object sender, MouseButtonEventArgs e)
        {
            ChatManager.Load(ChatManager.Get(this.user));
        }
    }
}
