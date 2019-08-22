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
    }
}
   