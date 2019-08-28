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
using WpfRecon.Models;
using WpfRecon.ViewModels;

namespace WpfRecon
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private ScanResult scanResult { get; set; }

        public MainPage()
        {
            InitializeComponent();

            var FirstTestText = Output.Text;
            
        }

        public TextBox MyTextBox
        {
            get { return IpAddress; }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Scan_Click(object sender, RoutedEventArgs e)
        {
            var MPVM = new MainPageVM();
           
            Output.Text = (MPVM.DisplayOutput(IpAddress.Text));
        }

        private void Firsttest_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void ProgressBar_ValueChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

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

            //somehow send scanResult to the page
            // View The Results page 
            NavigationService.Navigate(new Uri("Views/Results.xaml", UriKind.Relative));
        }
    }
}
