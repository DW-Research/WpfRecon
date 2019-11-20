using System.Windows;
using System.Windows.Controls;
using WpfRecon.Models;
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
            //this loads the mainpage and the whole appliation from there
            InitializeComponent();
            NavFrame.Navigate(new MainPage());

            ////////////////////////////////////////
            ///                                  ///
        }   ///        Do not delete this!       ///
    }       ////////////////////////////////////////
}
   