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

using CPSC_SocialNetwork;
using CPSC_SocialNetwork.Campaigns;

namespace CPSC_SocialNetwork.UserDisplay
{
    public partial class ChatWindowGroup : UserControl
    {
        private string name;
        public string DisplayName
        {
            get => this.name;
            set
            {
                this.name = value;
                this.Name.Text = this.name;
                this.ClosedWindowName.Text = this.name;
            }
        }

        private Image picture;
        public Image Picture
        {
            get => this.picture;
            set
            {
                this.picture = value;
                this.Image.Source = picture.Source;
                this.ClosedWindowImage.Source = picture.Source;
            }
        }

        public ChatWindowGroup()
        {
            InitializeComponent();
        }

        public ChatWindowGroup(Campaign campaign)
        {
            InitializeComponent();
            this.DisplayName = campaign.Name;
            this.Image.Source = new BitmapImage(new Uri(@"\Images\Campaign\" + campaign.Picture, UriKind.Relative));
            this.ClosedWindowImage.Source = new BitmapImage(new Uri(@"\Images\Campaign\" + campaign.Picture, UriKind.Relative));
        }

        private void MaximizeButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.ClosedWindow.Visibility = Visibility.Hidden;
            this.OpenWindow.Visibility = Visibility.Visible;
        }

        private void MinimizeButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.ClosedWindow.Visibility = Visibility.Visible;
            this.OpenWindow.Visibility = Visibility.Hidden;
        }

        private void CloseButton_Click(object sender, MouseButtonEventArgs e)
        {
            ChatManager.Delete(this);
        }

        private void SendButton_Click(object sender, MouseButtonEventArgs e)
        {
            WriteMessage();
        }

        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                WriteMessage();
        }

        private void WriteMessage()
        {
            if (Message.Text.Length > 0)
            {
                Messages.Children.Add(new Message(Message.Text));
                Message.Text = "";
                Scroller.ScrollToEnd();
            }
        }
    }
}
