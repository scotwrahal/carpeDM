﻿using System;
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
    /// Interaction logic for Tag.xaml
    /// </summary>
    public partial class Tag : UserControl
    {
        public Tag()
        {
            InitializeComponent();
        }

        public Tag(string text)
        {
            InitializeComponent();
            this.Label.Text = text;
            this.Tooltip.Text = text;
        }           
    }
}
