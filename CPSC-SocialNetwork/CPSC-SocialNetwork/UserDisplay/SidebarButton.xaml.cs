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

        private string name;
        public string ButtonName
        {
            get { return name; }
            set
            {
                name = value;
                this.Title.Text = this.name;
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                this.Body.Text = this.description;
            }
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


        public SidebarButton()
        {
            InitializeComponent();
        }
    }
}