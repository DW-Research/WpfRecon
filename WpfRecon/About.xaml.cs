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

namespace WpfRecon
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {



            // View The Home page  
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

            // View The About page 
            NavigationService.Navigate(new Uri("About.xaml", UriKind.Relative));
        }

        private void Results_Click(object sender, RoutedEventArgs e)
        {
            // View The Results page 
            NavigationService.Navigate(new Uri("Results.xaml", UriKind.Relative));
        }
    }
}
