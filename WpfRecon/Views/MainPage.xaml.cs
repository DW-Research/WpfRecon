using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        public static bool AP = false;
        public static bool WN = false;

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
            //this variable is called from the nmap scan to run a scan on all 65535 ports 
            AP = AllPorts.IsChecked.Value;

            //this variable is called from the nmap scan to run a nmap scan on all devices on a class C network
            WN = WholeNetwork.IsChecked.Value;
            //this is set to true to show generic progress and not a percentage style
            pbStatus.IsIndeterminate = true;
            //start an async progress bar output
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;

            //output the results of the View model and scan and display them in the output text block
            Output.Text = (MPVM.DisplayOutput(IpAddress.Text));


            //if the live host scan was a success then make the progress bar visable 

            if (State.SuccessfulPing)
            { //(ASCII ART FOR A BIT OF FUN) the formatting is for the center of the screen as it is a fixed size

                Output.Text += "\n";
                Output.Text += "\n                                 ##########################";
                Output.Text += "\n                                 ### FULL SCAN IN PROGRESS ###";
                Output.Text += "\n                                 ##########################";
                Output.Text += "\n";

                // show status bar when scan is running 
                pbStatus.Visibility = Visibility.Visible;
            }

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
        private void ScanCompleteHandler(object sender, EventArgs e)
        {
            this.Dispatcher.Invoke(() => {
                pbStatus.Visibility = Visibility.Hidden;
                //In case redirect is lagging an error come up informing the user to click results
                Output.Text += "\nNMap Scan Completed, Check Results Pages for details.";
                NavigationService.Navigate(new Uri("Views/Results.xaml", UriKind.Relative));
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

        //this is the check box on the xaml that gets called from the variable AP from the nmap scan
        public void AllPorts_Checked(object sender, RoutedEventArgs e)
        {

        }

        //this is the chack box that gets called from the WN variable from the Nmap Scan 
        private void WholeNetwork_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void LocalNetwork_Checked_1(object sender, RoutedEventArgs e)
        {
            if (LocalNetwork.checked == true)
              {
                    IpAddress.Visibility = System.Windows.Visibility.Hidden;
                }


                else
                {
                    IpAddress.Visibility = System.Windows.Visibility.Visible;

                }



                }
        }
    }
}

