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

namespace CPSC_SocialNetwork.Users
{
    /// <summary>
    /// Interaction logic for GroupSidebarButton.xaml
    /// </summary>
    public partial class GroupSidebarButton : UserControl
    {
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

        public GroupSidebarButton(string title, UserControl linkedControl, string picture = "")
        {
            InitializeComponent();
            Title.Text = title;
            link = linkedControl;
            this.GroupImage.Source = new BitmapImage(new Uri(@"\Images\Campaign\" + picture, UriKind.Relative));
        }
    }
}
