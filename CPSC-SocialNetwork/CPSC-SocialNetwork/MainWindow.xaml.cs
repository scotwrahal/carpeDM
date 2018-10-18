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

namespace CPSC_SocialNetwork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpenLeftSidebar_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenLeftSidebar.Visibility = Visibility.Collapsed;
            ButtonCloseLeftSidebar.Visibility = Visibility.Visible;
        }

        private void ButtonCloseLeftSidebar_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenLeftSidebar.Visibility = Visibility.Visible;
            ButtonCloseLeftSidebar.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenRightSidebar_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenRightSidebar.Visibility = Visibility.Collapsed;
            ButtonCloseRightSidebar.Visibility = Visibility.Visible;
        }

        private void ButtonCloseRightSidebar_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenRightSidebar.Visibility = Visibility.Visible;
            ButtonCloseRightSidebar.Visibility = Visibility.Collapsed;
        }
    }
}
