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

            var FirstTestText = firsttest.Text;
        }
        
        public TextBox MyTextBox
        {
            get { return IpAddress; }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            firsttest.Text = IpAddress.Text;
        }

        private void Scan_Click(object sender, RoutedEventArgs e)
        {
           
           
        }

        private void Firsttest_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void ProgressBar_ValueChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
   