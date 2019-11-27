using System.Windows;
using System.Windows.Controls;
using WpfRecon.Models;
using System;
using System.Windows.Navigation;
using System.Windows.Input;

namespace WpfRecon
{
    /// <summary>
    /// Interaction logic for Recon.xaml
    /// </summary>
    public partial class Recon
    {
        public Recon()
        {
            //this loads the mainpage and the whole appliation from there
            InitializeComponent();
            NavFrame.Navigate(new MainPage());

            ////////////////////////////////////////
            ///                                  ///
        }   ///        Do not delete this!       ///
    }       ////////////////////////////////////////
}
   