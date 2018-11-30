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
        private List<StoryEntry> storyEntries;
        public List<StoryEntry> StoryEntries
        {
            get => this.storyEntries;
            set {
                this.storyEntries = value;
                this.StoryList.DataContext = storyEntries;
            }
        }

        public CampaignPage()
        {
            InitializeComponent();
        }

        public CampaignPage(Campaign campaign)
        {
            InitializeComponent();
            storyEntries = new List<StoryEntry>
            {
                { new StoryEntry("Test", "This is a test!") },
                { new StoryEntry("Also a test!", "Another Test for the testings") }
            };

            foreach(StoryEntry entry in this.storyEntries)
                this.StoryList.Children.Add(entry);
        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
