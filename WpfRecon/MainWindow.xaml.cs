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
using WpfRecon.Scans;

namespace WpfRecon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.InitializeComponent();

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
            LiveHost lh = new LiveHost();
            
            Output.Text = lh.PingSweep(IpAddress.Text);
            
        }

        private void Firsttest_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void ProgressBar_ValueChanged(object sender, RoutedEventArgs e)
        {

        }

    }
}
   