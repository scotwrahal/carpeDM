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

namespace CPSC_SocialNetwork.Campaigns
{
    /// <summary>
    /// Interaction logic for CampaignPage.xaml
    /// </summary>
    public partial class CampaignPage : UserControl
    {
        private Campaign campaign;
        public Campaign Campaign { get => this.campaign; }

        private List<StoryEntry> storyEntries;
        public List<StoryEntry> StoryEntries
        {
            get => this.storyEntries;
            set
            {
                this.storyEntries = value;
                this.StoryList.DataContext = storyEntries;
            }
        }


        private List<CharacterEntry> characterEntries;

        private List<PlayerEntry> playerEntries;
        public List<PlayerEntry> PlayerEntries
        {
            get => this.playerEntries;
            set
            {
                this.playerEntries = value;
                this.PlayerList.DataContext = playerEntries;
            }
        }

        private Image picture;
        public Image Picture
        {
            get { return picture; }
            set
            {
                picture = value;
                this.Picture.Source = this.picture.Source;
            }
        }

        public CampaignPage()
        {
            InitializeComponent();
        }

        public CampaignPage(Campaign campaign)
        {
            InitializeComponent();

            this.campaign = campaign;

            storyEntries = new List<StoryEntry>
            {
                { new StoryEntry("Test", "This is a test!") },
                { new StoryEntry("Also a test!", "Another Test for the testings") },
                { new StoryEntry("This test involves both properties having exceptionally long names to see how that changes the formatting of the output text within the bounds of their designated text areas",
                                 "As you can see like it said above this text is quite considerably longer than that of previous text boxes. The intent behind this is to show how the text behaves when the input data is long enough to span multiple lines within the text area") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") },
                { new StoryEntry("Another test", "more testing") }
            };

            foreach(StoryEntry entry in this.storyEntries)
                this.StoryList.Children.Add(entry);

            playerEntries = new List<PlayerEntry>();
            foreach (Users.User user in campaign.Players.Values)
                playerEntries.Add(new PlayerEntry(user));


            foreach (PlayerEntry entry in this.playerEntries)
                this.PlayerList.Children.Add(entry);

            this.CampaignImage.Source = new BitmapImage(new Uri(@"\Images\" + campaign.Picture, UriKind.Relative));
            this.CampaignName.Text = campaign.Name;

            this.MasterImage.Source = new BitmapImage(new Uri(@"\Images\" + campaign.Owner.Picture, UriKind.Relative));
            this.OwnerName.Text = campaign.Owner.DisplayName;

        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
