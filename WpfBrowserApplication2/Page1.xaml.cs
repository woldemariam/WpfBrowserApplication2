﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Json;

namespace WpfBrowserApplication1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            var result = JsonValue.Parse(webClient.DownloadString("http://hot100number1s.com/wpf/test.php?method=GetAllUsers")).ToList();

            if (result.Any(x => x.Value.ToString() == "\"" + username.Text + "\""))
            {

                Uri pageURI = new Uri("page3.xaml", UriKind.Relative);
                this.NavigationService.Navigate(pageURI);
            }
            else
            {
                userNotFound.Content = "User Not Found.";
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Uri pageURI = new Uri("page2.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageURI);

        }
    }
}


    

