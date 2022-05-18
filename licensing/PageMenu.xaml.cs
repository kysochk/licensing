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

namespace licensing
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

      

        private void PagePlaers_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new PagePlayers());
        }

        private void PageCoach_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new PageCoach());
        }

        private void BackMenu_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.MainFrame.Navigate(new Avtorizacia());
        }
    }
}
