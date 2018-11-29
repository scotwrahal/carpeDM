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

namespace CPSC_SocialNetwork.Campaigns
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class StoryEntry : UserControl
    {
        private readonly string title;
        public string Title { get => this.title; }

        private readonly string text;
        public string Text { get => this.text; }


        public StoryEntry(string title, string text)
        {
            InitializeComponent();
            this.title = title;
            this.TitleBox.Text = title;
            this.text = text;
            this.TextBox.Text = text;
        }
    }
}
