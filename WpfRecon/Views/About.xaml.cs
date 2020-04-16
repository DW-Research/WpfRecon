using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
            NavigationService.Navigate(new Uri("Views/MainPage.xaml", UriKind.Relative));
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

            // View The About page 
            NavigationService.Navigate(new Uri("Views/About.xaml", UriKind.Relative));
        }

        //Results page 
        private void Results_Click(object sender, RoutedEventArgs e)
        {

            // View The Results page 
            NavigationService.Navigate(new Uri("Views/Results.xaml", UriKind.Relative));
        }
    }
}
