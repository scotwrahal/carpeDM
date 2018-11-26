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

namespace CPSC_SocialNetwork
{
    public partial class MainWindow : Window
    {
        ProfilePage profilePage; 
        CampaignPage campaignPage; 
        CharacterPage characterPage; 

        List<Character> characters; 
        List<Campaign> campaigns; 
        List<User> friends; 
            
        public MainWindow()
        {
            InitializeComponent();

            profilePage = new ProfilePage();
            campaignPage = new CampaignPage();
            characterPage = new CharacterPage();

            characters = new List<Character>();
            campaigns = new List<Campaign>();
            friends = new List<User>();

            Switcher.pageSwitcher = this;
            Switcher.Switch(profilePage);

            UserControl temp = new UserControl();
            for (int x = 0; x < 3; x++) // (Character character in characters)
            {
                SidebarButton button = new SidebarButton("hello", "This is the desc", temp);
                button.Name = "SidebarButton" + x.ToString();
                button.MouseLeftButtonDown += SidebarButtonHandler; 
                this.LeftSidebar.CharacterList.Children.Add(button);
            }

            foreach(Campaign campaign in campaigns)
            {
                SidebarButton button = new SidebarButton();
                this.LeftSidebar.CampaignList.Children.Add(button);
            }

            foreach(User friend in friends)
            {
                SidebarButton button = new SidebarButton();
                this.RightSidebar.FriendList.Children.Add(button);
            }
        }

        private void SidebarButtonHandler(object sender, MouseButtonEventArgs e)
        {
            SidebarButton Sender = (SidebarButton)sender;
            if (Sender.Name == "SidebarButton1")
            {
                Close();
            }
        }

        public void Navigate(UserControl nextPage)
        {
            this.CurrentPage.Children.Remove(nextPage);
            this.CurrentPage.Children.Add(nextPage);
        }


        private void ProfilePageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Navigate(campaignPage);
        }


        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}