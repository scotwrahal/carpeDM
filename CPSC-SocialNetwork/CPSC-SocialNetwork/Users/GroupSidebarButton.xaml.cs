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
using CPSC_SocialNetwork.Campaigns;
using CPSC_SocialNetwork.UserDisplay;

namespace CPSC_SocialNetwork.Users
{
    /// <summary>
    /// Interaction logic for GroupSidebarButton.xaml
    /// </summary>
    public partial class GroupSidebarButton : UserControl
    {
        private readonly ChatWindowGroup link;
        public ChatWindowGroup Link { get => this.link; }

        private Image picture;
        public Image Picture
        {
            get { return picture; }
            set
            {
                picture = value;
                this.GroupImage.Source = this.GroupImage.Source;
            }
        }

        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        public GroupSidebarButton()
        {
            InitializeComponent();
        }

        public GroupSidebarButton(Campaign campaign)
        {
            InitializeComponent();
            Title.Text = campaign.Name;
            Border.ToolTip = "Click to chat with the players of " + campaign.Name;
            link = ChatManager.Get(campaign);
            this.GroupImage.Source = new BitmapImage(new Uri(@"\Images\Campaign\" + campaign.Picture, UriKind.Relative));
        }

        private void GroupSidebarButton_Click(object sender, MouseButtonEventArgs e)
        {
            ChatManager.Load(this.link);
        }
    }
}
