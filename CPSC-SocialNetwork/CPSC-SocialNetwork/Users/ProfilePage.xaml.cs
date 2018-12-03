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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : UserControl
    {
        private User owner;
        public User Owner { get => this.owner; }


        public ProfilePage()
        {
            InitializeComponent();
        }


        public ProfilePage(User user)
        {
            InitializeComponent();
            this.owner = user;
        }
    }
}
