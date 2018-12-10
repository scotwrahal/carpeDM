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
using CPSC_SocialNetwork.UserDisplay;

namespace CPSC_SocialNetwork.Users
{
    public partial class UserSidebarButton : UserControl
    {
        private readonly ChatWindowDirect link;
        public ChatWindowDirect Link { get => this.link; }

        private Image picture;
        public Image Picture
        {
            get { return picture; }
            set
            {
                picture = value;
                this.UserImage.Source = this.UserImage.Source;
            }
        }

        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        public UserSidebarButton()
        {
            InitializeComponent();
        }

        public UserSidebarButton(User friend)
        {
            InitializeComponent();
            Title.Text = friend.DisplayName;
            link = ChatManager.Get(friend);
            this.UserImage.Source = new BitmapImage(new Uri(@"\Images\User\" + friend.Picture, UriKind.Relative));
        }

        private void UserControl_Click(object sender, MouseButtonEventArgs e)
        {
            ChatManager.Load(this.link);
        }
    }
}
