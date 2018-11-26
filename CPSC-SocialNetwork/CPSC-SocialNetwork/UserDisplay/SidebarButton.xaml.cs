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
    public partial class SidebarButton : UserControl
    {

        public SidebarButton()
        {
            this.ButtonName = "No name";
            this.ButtonDescription = "No description";
        }

        public SidebarButton(string name, string description)
        {
            this.ButtonName = name;
            this.ButtonDescription = description;
        }

        public string ButtonName
        {
            get { return (string)GetValue(ButtonNameProperty); }
            set { SetValue(ButtonNameProperty, value); }
        }

        public string ButtonDescription
        {
            get { return (string)GetValue(ButtonDescriptionProperty); }
            set { SetValue(ButtonDescriptionProperty, value); }
        }

        public static readonly DependencyProperty ButtonNameProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(SidebarButton));

        public static readonly DependencyProperty ButtonDescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(SidebarButton));
    }
}