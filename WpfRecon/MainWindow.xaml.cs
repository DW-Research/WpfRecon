using System.Windows;
using System.Windows.Controls;
using WpfRecon.Scans;
using System;
using System.Windows.Navigation;
using System.Windows.Input;

namespace WpfRecon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            NavFrame.Navigate(new MainPage());

        }
        
    //    public TextBox MyTextBox
    //    {
    //        get { return IpAddress; }
    //    }

    //    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    //    {
            
    //    }

    //    private void Scan_Click(object sender, RoutedEventArgs e)
    //    {
    //        LiveHost lh = new LiveHost();
            
    //        Output.Text = lh.PingSweep(IpAddress.Text);
            
    //    }

    //    private void Firsttest_SelectionChanged(object sender, RoutedEventArgs e)
    //    {

    //    }
    //    private void ProgressBar_ValueChanged(object sender, RoutedEventArgs e)
    //    {

    //    }

    //    private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    //    {

    //    }

    //    private void Home_Click(object sender, RoutedEventArgs e)
    //    {
                  
    //        // View The Home page 
    //        MainWindow h1 = new MainWindow();
    //        NavigationService.GetNavigationService(this).Navigate(this);
    //   }

    //    private void About_Click(object sender, RoutedEventArgs e)
    //    {

    //        // View The About page 
    //        AboutPage about = new AboutPage();
    //        NavigationService.GetNavigationService(this).Navigate(about);
    //    }

    //    private void Results_Click(object sender, RoutedEventArgs e)
    //    {
    //        // View The Results page 
    //        ResultsPage results = new ResultsPage();
    //        NavigationService navService = NavigationService.GetNavigationService(this);
    //        navService.Navigate("Results.xaml");
    //    }
    }
}
   