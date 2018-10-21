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

            for (int i = 0; i < 30; i++)
            {
                UserControl1 email = new UserControl1();
                Characters.List.Children.Add(email);
                email = new UserControl1();
                Campaigns.List.Children.Add(email);
                email = new UserControl1();
                Friends.List.Children.Add(email);
                email = new UserControl1();
                Groups.List.Children.Add(email);
            }
        }
    }
}
