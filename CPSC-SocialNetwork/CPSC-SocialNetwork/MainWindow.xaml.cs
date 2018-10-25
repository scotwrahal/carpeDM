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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BrushConverter bc = new BrushConverter();
            Color myColor = Color.FromRgb(0, 0, 0);
            SolidColorBrush brush = new SolidColorBrush(myColor);

            for (int i = 0; i < 25; i++)
            {
                UserControl1 email = new UserControl1();
                email.image.Fill = brush;
                Left.List.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(30, 0, 0));
                brush = new SolidColorBrush(myColor);
            }

            myColor = Color.FromRgb(0, 0, 0);
            brush = new SolidColorBrush(myColor);
            for (int i = 0; i < 25; i++)
            {
                UserControl1 email = new UserControl1();
                email.image.Fill = brush;
                Left.List2.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(0, 30, 0));
                brush = new SolidColorBrush(myColor);
            }

            myColor = Color.FromRgb(0, 0, 0);
            brush = new SolidColorBrush(myColor);
            for (int i = 0; i < 25; i++)
            {
                UserControl1 email = new UserControl1();
                email.image.Fill = brush;
                Right.List.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(0, 0, 30));
                brush = new SolidColorBrush(myColor);
            }

            myColor = Color.FromRgb(0, 0, 0);
            brush = new SolidColorBrush(myColor);
            for (int i = 0; i < 25; i++)
            {
                UserControl1 email = new UserControl1();
                email.image.Fill = brush;
                Right.List2.Children.Add(email);
                myColor = Color.Add(myColor, Color.FromRgb(30, 30, 30));
                brush = new SolidColorBrush(myColor);
            }
        }
    }
}