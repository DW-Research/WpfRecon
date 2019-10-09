using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
        MainPageVM MPVM = new MainPageVM();
        public MainPage()
        {
            InitializeComponent();
           
        }

       //TODO: Create an error to report an incorrect IP Address to the homePage
       //This is a input validation field 

        public bool ValidateIPv4(string ipString)
        {
            //if it is blank throw an error
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }
            // is is in the correct format if not error
            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        //This is in here as a place holder for the IPAddress textbox to get rid of an error. 
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //This process runs the live host and the nmap scan if the ping was a success.
        private void ScanprocessReturn()
        {
            //this is set to true to show generic progress and not a percentage style
            pbStatus.IsIndeterminate = true;
            //start an async
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;

            //output the results of the View model and scan and display them in the output text block
            Output.Text = (MPVM.DisplayOutput(IpAddress.Text));

            //if the live host scan was a success then make the progress bar visable 
            //TODO: Create a pop up informing the user the scan is running
            if (State.SuccessfulPing)
                pbStatus.Visibility = Visibility.Visible;

            MPVM.ScanComplete += ScanCompleteHandler;

            worker.RunWorkerAsync();
        }

        //This is a keyscan on using the enter key to run the scan rather than having to click the button
        private void RichTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ScanprocessReturn();

                e.Handled = true;
            }
        }
      //This is the click button to run the scan 
        private void Scan_Click(object sender, RoutedEventArgs e)
        {

            ScanprocessReturn();
                                 
        }

        //Automate the nmap scan to run in the background whilst the progress bar is working 
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            MPVM.LoadNmapScanInBackground(() => { });
        }

        //Once the scan has succsessfully completed hide the progress bar and inform the user to check for the full results in the results page 

        //TODO: sleep for 5 seconds and autodirect to to the results page 
        private void ScanCompleteHandler(object sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() => {
                pbStatus.Visibility = Visibility.Hidden;
                Output.Text += "\nNMap Scan Completed, Check Results Pages for details.";
            });
            
        }

        //Navigation pane section 
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
