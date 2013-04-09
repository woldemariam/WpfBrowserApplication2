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
using System.Text.RegularExpressions;

namespace WpfBrowserApplication1
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if ((c5.Text == "90210") || (c5.Text == "90211") || (c5.Text == "90212"))
            {
                Uri pageURI = new Uri("page3.xaml", UriKind.Relative);
                this.NavigationService.Navigate(pageURI);
            }

            else
            {

                zip.Text = "Sorry " + c1.Text + " we do not service your area";
            }


        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            checkbox.Content = "You selected Mastercard";

        }

        private void checkbox1_Checked(object sender, RoutedEventArgs e)
        {
            checkbox1.Content = "You selected Visa";
        }

        private void checkbox2_Checked(object sender, RoutedEventArgs e)
        {
            checkbox2.Content = "You selected American Express";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void c6_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void datePicker2_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
