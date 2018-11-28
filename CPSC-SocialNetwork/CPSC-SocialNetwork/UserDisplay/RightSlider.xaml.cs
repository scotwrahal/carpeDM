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
    /// <summary>
    /// Interaction logic for LeftSlider.xaml
    /// </summary>
    public partial class RightSlider : UserControl
    {
        public RightSlider()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            FriendViewer.Visibility = Visibility.Hidden;
            GroupViewer.Visibility = Visibility.Hidden;
            MiddleTab.Visibility = Visibility.Hidden;

            CloseButton.Visibility = Visibility.Hidden;

            OpenButton.Visibility = Visibility.Visible;
            OpenButtonLabels.Visibility = Visibility.Visible;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            FriendViewer.Visibility = Visibility.Visible;
            GroupViewer.Visibility = Visibility.Visible;
            MiddleTab.Visibility = Visibility.Visible;

            CloseButton.Visibility = Visibility.Visible;

            OpenButton.Visibility = Visibility.Hidden;
            OpenButtonLabels.Visibility = Visibility.Hidden;
        }
    }
}
