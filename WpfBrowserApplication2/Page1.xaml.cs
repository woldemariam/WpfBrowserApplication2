using System;
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

            Uri pageURI = new Uri("page2.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageURI);

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}


    

