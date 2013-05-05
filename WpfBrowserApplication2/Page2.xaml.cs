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
using System.Net;
using System.Json;

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

            if (App.Current.Properties["user"] != null)
            {
                fillData();
            }
        }

        private void fillData()
        {
            WebClient webClient = new WebClient();
            var result = JsonValue.Parse(webClient.DownloadString("http://hot100number1s.com/wpf/test.php?method=GetAllUsers")).ToList();

            var db = result.Select(
               x => new
               {
                   user = x.Value[0].ToString(),
                   password = x.Value[1].ToString(),
                   name = x.Value[2].ToString(),
                   zip = x.Value[3].ToString(),
                   dob = x.Value[4].ToString(),
                   phone = x.Value[5].ToString(),
                   street = x.Value[6].ToString(),
                   city = x.Value[7].ToString(),
                   state = x.Value[8].ToString(),
                   creditCard = x.Value[9].ToString(),
                   chk1 = x.Value[10].ToString(),
                   chk2 = x.Value[11].ToString(),
                   chk3 = x.Value[12].ToString(),
                   expiration = x.Value[13].ToString()
               }

            );


            var user = db.First(x => x.user == "\"" + App.Current.Properties["user"] + "\"");

            c1.Text = user.name.Replace("\"", "");
            c5.Text = user.zip.Replace("\"", "");
            datePicker1.Text  = user.dob.Replace("\"", "").Replace("-","/");
            datePicker2.Text = user.expiration.Replace("\"", "").Replace("-", "/");
            c6.Text = user.phone.Replace("\"", "");
            c2.Text = user.street.Replace("\"", "");
            c3.Text = user.city.Replace("\"", "");
            c4.Text = user.state.Replace("\"", "");
            creditCard.Text = user.creditCard.Replace("\"", "");
            checkbox.IsChecked = user.chk1.Replace("\"", "") == "1".ToString();
            checkbox1.IsChecked = user.chk2.Replace("\"", "") == "1".ToString();
            checkbox2.IsChecked = user.chk3.Replace("\"", "") == "1".ToString();

            button1.Content = "Save";
            userNameLabel.Visibility = Visibility.Hidden;
            username.Visibility = Visibility.Hidden;
            passwordLabel.Visibility = Visibility.Hidden;
            password.Visibility = Visibility.Hidden;
           

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (((c5.Text == "90210") || (c5.Text == "90211") || (c5.Text == "90212")))
            {
                if (registeredSuccessfully())
                {
                    Application.Current.Properties["user"] = null;
                    Uri pageURI = new Uri("page1.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(pageURI);
                }
            }

            else
            {

                zip.Text = "Sorry " + c1.Text + " we do not service your area";
            }
        }

        private bool registeredSuccessfully()
        {
            if (App.Current.Properties["user"] == null)
            {
                if (username.Text == "" || password.Password == "")
                {
                    registerlabel.Content = "Username and Password are required";
                    return false;

                }
            }

            var usernam =  App.Current.Properties["user"]?? username.Text;
            var pass = String.IsNullOrEmpty(password.Password) ? "n" : password.Password;
            var name = c1.Text;
            var zip = c5.Text;
            var dob = datePicker1.Text.Replace("/","-");
            var phone = c6.Text;
            var street = c2.Text;
            var city = c3.Text;
            var state = c4.Text;
            var credit = creditCard.Text;
            var chk1 = checkbox.IsChecked==true?1:0;
            var chk2 = checkbox1.IsChecked == true ? 1 : 0;
            var chk3 = checkbox2.IsChecked == true ? 1 : 0;
            var expiration = datePicker2.Text.Replace("/", "-");

            WebClient webClient = new WebClient();
            var result = JsonValue.Parse(webClient.DownloadString("http://hot100number1s.com/wpf/test.php?method=SaveUser&u=" + usernam + "&p=" + pass + "&n=" + name + "&z=" + zip + "&d=" + dob + "&phone=" + phone + "&street=" + street + "&city=" + city + "&state=" + state + "&credit=" + credit + "&chk1=" + chk1 + "&chk2=" + chk2 + "&chk3=" + chk3 + "&expiration=" + expiration)).ToString();

            var item = result == "\"saved\"";

            return true;

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
