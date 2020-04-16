using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfRecon.ViewModels;

namespace WpfRecon
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        public ResultsPage()
        {
            InitializeComponent();
            var RPVM = new ResultPageVM();

            //display the results from the scans and display them in the textblock called Fullresults 
            FullResults.Text = (RPVM.DisplayOutput(string.Empty));
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

        private void Results_Click(object sender, RoutedEventArgs e)
        {
            // View The Results page 
            NavigationService.Navigate(new Uri("Views/Results.xaml", UriKind.Relative));
        }
    }
}
