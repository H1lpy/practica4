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

namespace practica3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Navigate(new Page1());
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {

            MyFrame.Navigate(new Page1());
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page2());
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page3());
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page4());
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page5());
        }
    }
}
