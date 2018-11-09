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
    public partial class SidebarButton : UserControl {

        private string name;
        public string Name
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


        public SidebarButton()
        {
            InitializeComponent();
        }
    }
}