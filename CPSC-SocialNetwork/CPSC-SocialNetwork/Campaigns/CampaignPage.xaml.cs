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

using CPSC_SocialNetwork.Characters;
using CPSC_SocialNetwork.Users;
using CPSC_SocialNetwork.Database;
using CPSC_SocialNetwork.UserDisplay;

namespace CPSC_SocialNetwork.Campaigns
{
    /// <summary>
    /// Interaction logic for CampaignPage.xaml
    /// </summary>
    public partial class CampaignPage : UserControl
    {
        private readonly Campaign campaign;
        public Campaign Campaign { get => this.campaign; }

        /*
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
        */

        public CampaignPage()
        {
            InitializeComponent();
        }

        public CampaignPage(Campaign campaign)
        {
            InitializeComponent();

            this.campaign = campaign;

            //header
            this.CampaignImage.Source = new BitmapImage(new Uri(@"\Images\Campaign\" + campaign.Picture, UriKind.Relative));
            this.CampaignName.Text = campaign.Name;

            this.MasterImage.Source = new BitmapImage(new Uri(@"\Images\User\" + campaign.Owner.Picture, UriKind.Relative));
            this.OwnerName.Text = campaign.Owner.DisplayName;


            //about tab
            this.Version.Text = campaign.Version;
            this.Created.Text = campaign.DateCreated;
            this.Time.Text = campaign.MeetingTime;

            foreach (string tag in campaign.Tags)
                this.Tags.Children.Add(new Tag(tag));

            this.Description.Text = campaign.Description;


            //story tab
            if (campaign.StoryEntries.Count == 0)
                this.StoryList.Children.Add(new StoryEntry("", "Nothing to display."));

            else
                foreach (StoryEntry entry in campaign.StoryEntries)
                    this.StoryList.Children.Add(entry);

            //characters tab
            /*
            characterEntries = new List<CharacterEntry>();
            foreach (Character character in campaign.PlayerCharacters.Values)
                characterEntries.Add(new CharacterEntry(character));

            foreach (CharacterEntry entry in this.characterEntries)
                this.CharacterList.Children.Add(entry);
            */

            foreach (Character character in campaign.PlayerCharacters.Values)
            {
                this.PCharacterList.Children.Add(new CharacterEntry(character));
            }

            foreach (Character character in campaign.NonPlayerCharacters.Values)
            {
                this.NPCharacterList.Children.Add(new CharacterEntry(character));
            }

            //players tab
            /*
            playerEntries = new List<PlayerEntry>();
            foreach (User user in campaign.Players.Values)
                playerEntries.Add(new PlayerEntry(user));

            foreach (PlayerEntry entry in this.playerEntries)
                this.PlayerList.Children.Add(entry);
            */

            foreach (User user in campaign.Players.Values)
                this.PlayerList.Children.Add(new PlayerEntry(user));

            //extras tab
            ExtrasTab.Children.Add(new ExtrasPage());
        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DM_Click(object sender, MouseButtonEventArgs e)
        {
            if (this.campaign.Owner.DisplayName != "Micah Peacock")
            ChatManager.Load(ChatManager.Get(this.campaign.Owner));
        }

        private void GM_Click(object sender, MouseButtonEventArgs e)
        {
            ChatManager.Load(ChatManager.Get(this.campaign));
        }
    }
}
