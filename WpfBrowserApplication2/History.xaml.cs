using System;
using System.Collections.Generic;
using System.Json;
using System.Linq;
using System.Net;
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
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Page
    {
        public History()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            var result = JsonValue.Parse(webClient.DownloadString("http://hot100number1s.com/wpf/test.php?method=GetAllHistory")).ToList();

            var db = result.Select(
               x => new
               {
                   user = x.Value.First().Value.ToString(),
                   date = x.Value[1].ToString(),
                   items = x.Value[2].ToString(),
               }

            );

            foreach (var item in db)
            {
                if (item.user == "\"" + App.Current.Properties["user"] + "\"")
                {
                    label1.Text += item.date.ToUpper() + "\n-->\t" + item.items + "\n\n";
                }
            }

            
        }

        
    }
}
