﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using McPlat.Pages;

namespace McPlat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());

            AllStats.Week = new Week();
        }

        private void GoToMainPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }
        private void GoToMonthPay(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MonthPayPage());
        }
        private void GoToFinance(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Finance());
        }

    }
}