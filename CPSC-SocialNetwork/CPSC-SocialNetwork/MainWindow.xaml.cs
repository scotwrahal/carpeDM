using System;
using System.Collections.Generic;
using System.Diagnostics;
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

using CPSC_SocialNetwork.UserDisplay;
using CPSC_SocialNetwork.Characters;
using CPSC_SocialNetwork.Campaigns;
using CPSC_SocialNetwork.Users;

using CPSC_SocialNetwork.Database;

namespace CPSC_SocialNetwork
{
    public partial class MainWindow : Window
    {
        SocialNetworkDatabase database;

        User mainUser;
        ProfilePage profile;
        
        public MainWindow()
        {
            InitializeComponent();

            database = new SocialNetworkDatabase();

            this.mainUser = database.Users[SocialNetworkDatabase.USERNAME_1];
            this.profile = new ProfilePage(mainUser);

            Switcher.pageSwitcher = this;
            Switcher.Switch(profile);

            foreach(Character character in database.Users[SocialNetworkDatabase.USERNAME_1].Characters.Values)
            {
                CharacterPage page = new CharacterPage(character);
                database.Add(page);
                SidebarButton button = new SidebarButton(title: character.CharacterName, description: character.ToString(), picture: character.Picture, linkedControl: page);
                button.MouseLeftButtonDown += SidebarButtonHandler;
                this.LeftSidebar.CharacterList.Children.Add(button);
            }

            foreach(Campaign campaign in database.Users[SocialNetworkDatabase.USERNAME_1].Campaigns.Values)
            {
                CampaignPage page = new CampaignPage(campaign);
                database.Add(page);
                SidebarButton button = new SidebarButton(title: campaign.Name, description: campaign.Description, linkedControl: page);
                button.MouseLeftButtonDown += SidebarButtonHandler;
                this.LeftSidebar.CampaignList.Children.Add(button);
            }

            foreach(User friend in database.Users.Values)
            {
                if(friend.Username != this.mainUser.Username)
                {
                    ProfilePage page = new ProfilePage(friend);
                    database.Add(page);
                    SidebarButton button = new SidebarButton(title: friend.DisplayName, picture: friend.Picture, linkedControl: page);
                    button.MouseLeftButtonDown += SidebarButtonHandler;
                    this.RightSidebar.FriendList.Children.Add(button);
                }
            }
        }

        private void SidebarButtonHandler(object sender, MouseButtonEventArgs e)
        {
            SidebarButton Sender = (SidebarButton)sender;
            this.Navigate(Sender.Link);
        }

        public void Navigate(UserControl nextPage)
        {
            this.CurrentPage.Children.Remove(nextPage);
            this.CurrentPage.Children.Add(nextPage);
        }


        private void ProfilePageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Navigate(profile);
        }


        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}