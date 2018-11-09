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
using CPSC_SocialNetwork.Pages;
using CPSC_SocialNetwork.UserDisplay;

namespace CPSC_SocialNetwork
{
    public partial class MainWindow : Window
    {
        ProfilePage profilePage = new ProfilePage();
        CampaignPage campaignPage = new CampaignPage();
        CharacterPage characterPage = new CharacterPage();

        public MainWindow()
        {
            InitializeComponent();

            Switcher.pageSwitcher = this;
            Switcher.Switch(profilePage);

            BrushConverter bc = new BrushConverter();
            Color myColor = Color.FromRgb(0, 0, 0);
            SolidColorBrush brush = new SolidColorBrush(myColor);

            for (int i = 0; i < 25; i++)
            {
                SidebarButton email = new SidebarButton();
                email.Image.Fill = brush;
                LeftSidebar.CharacterList.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(30, 0, 0));
                brush = new SolidColorBrush(myColor);
            }

            myColor = Color.FromRgb(0, 0, 0);
            brush = new SolidColorBrush(myColor);
            for (int i = 0; i < 25; i++)
            {
                SidebarButton email = new SidebarButton();
                email.Image.Fill = brush;
                LeftSidebar.CampaignList.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(0, 30, 0));
                brush = new SolidColorBrush(myColor);
            }

            myColor = Color.FromRgb(0, 0, 0);
            brush = new SolidColorBrush(myColor);
            for (int i = 0; i < 25; i++)
            {
                SidebarButton email = new SidebarButton();
                email.Image.Fill = brush;
                RightSidebar.FriendList.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(0, 0, 30));
                brush = new SolidColorBrush(myColor);
            }

            myColor = Color.FromRgb(0, 0, 0);
            brush = new SolidColorBrush(myColor);
            for (int i = 0; i < 25; i++)
            {
                SidebarButton email = new SidebarButton();
                email.Image.Fill = brush;
                RightSidebar.GroupList.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(30, 30, 30));
                brush = new SolidColorBrush(myColor);
            }
        }


        public void Navigate(UserControl nextPage)
        {
            if (!this.CurrentPage.Children.Equals(nextPage))
            {
                this.CurrentPage.Children.Add(nextPage);
            }
        }


        private void ProfilePageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Navigate(campaignPage);
        }
    }
}