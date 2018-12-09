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

using CPSC_SocialNetwork.Users;

namespace CPSC_SocialNetwork.UserDisplay
{
    /// <summary>
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class Message : UserControl
    {
        public Message()
        {
            InitializeComponent();
        }

        public Message(User user, string text)
        {
            InitializeComponent();
            this.MessageImage.Source = new BitmapImage(new Uri(@"\Images\User\" + user.Picture, UriKind.Relative));
            this.Author.Text = user.DisplayName;
            this.Text.Text = text;
        }
    }
}
