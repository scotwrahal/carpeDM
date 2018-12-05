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
        User mainUser;
        ProfilePage profile;
        
        public MainWindow()
        {
            InitializeComponent();

            this.mainUser = SocialNetworkDatabase.Users[SocialNetworkDatabase.USERNAME[0]];
            this.profile = SocialNetworkDatabase.ProfilePages[mainUser];

            Switcher.pageSwitcher = this;
            Switcher.Switch(profile);

            foreach(Character character in SocialNetworkDatabase.Characters[SocialNetworkDatabase.USERNAME[0]].Values)
            {
                CharacterSidebarButton button = new CharacterSidebarButton(
                    title: character.CharacterName, 
                    description: character.ToString(), 
                    picture: character.Picture, 
                    linkedControl: SocialNetworkDatabase.CharacterPages[character]);
                this.LeftSidebar.CharacterList.Children.Add(button);
            }

            foreach(Campaign campaign in SocialNetworkDatabase.Campaigns[SocialNetworkDatabase.USERNAME[0]].Values)
            {
                CampaignSidebarButton button = new CampaignSidebarButton(
                    title: campaign.Name, 
                    description: campaign.Description, 
                    picture: campaign.Picture,
                    linkedControl: SocialNetworkDatabase.CampaignPages[campaign]);
                this.LeftSidebar.CampaignList.Children.Add(button);
            }

            foreach(User friend in SocialNetworkDatabase.Users.Values)
            {
                if(friend.Username != this.mainUser.Username)
                {
                    UserSidebarButton button = new UserSidebarButton(
                        title: friend.DisplayName, 
                        picture: friend.Picture, 
                        linkedControl: SocialNetworkDatabase.ProfilePages[friend]);
                    this.RightSidebar.FriendList.Children.Add(button);
                }
            }

            foreach(Campaign campaign in SocialNetworkDatabase.Campaigns[SocialNetworkDatabase.USERNAME[0]].Values)
            {
                GroupSidebarButton button = new GroupSidebarButton(
                    title: "Chat - " + campaign.Name, 
                    picture: campaign.Picture, 
                    linkedControl: SocialNetworkDatabase.CampaignPages[campaign]);
                this.RightSidebar.GroupList.Children.Add(button);
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