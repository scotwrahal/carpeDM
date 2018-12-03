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

namespace CPSC_SocialNetwork.UserDisplay
{
    public partial class SidebarButton : UserControl {

        public enum ButtonType
        {
            User,
            Character,
            Campaign,
            Group
        };

        private UserControl link;
        public UserControl Link
        {
            get { return link; }
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

        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        public SidebarButton()
        {
            InitializeComponent();
        }

        public SidebarButton(ButtonType type, string title, UserControl linkedControl, string description = "", string picture = "")
        {
            InitializeComponent();
            Title.Text = title;
            Description.Text = description;
            link = linkedControl;
            if(picture != "")
            {
                switch (type)
                {
                    case ButtonType.User:
                        Image.Source = new BitmapImage(new Uri(@"\Images\User\" + picture, UriKind.Relative));
                        break;
                    case ButtonType.Character:
                        Image.Source = new BitmapImage(new Uri(@"\Images\Character\" + picture, UriKind.Relative));
                        break;
                    case ButtonType.Campaign:
                        Image.Source = new BitmapImage(new Uri(@"\Images\Campaign\" + picture, UriKind.Relative));
                        break;
                };
            }
        }
    }
}