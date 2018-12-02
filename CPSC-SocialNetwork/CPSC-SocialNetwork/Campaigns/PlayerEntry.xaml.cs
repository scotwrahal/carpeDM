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


namespace CPSC_SocialNetwork.Campaigns
{
    /// <summary>
    /// Interaction logic for PlayerEntry.xaml
    /// </summary>
    public partial class PlayerEntry : UserControl
    {
        public PlayerEntry()
        {
            InitializeComponent();

            this.Image.Source = new BitmapImage(new Uri(@"\Images\" + "1.png", UriKind.Relative));
            this.Name.Text = "Display Name";
        }

        public PlayerEntry(User user)
        {
            InitializeComponent();
            
            this.Image.Source = new BitmapImage(new Uri(@"\Images\" + user.Picture, UriKind.Relative));
            this.Name.Text = user.DisplayName;
        }
    }
}
