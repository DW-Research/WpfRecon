using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using WpfRecon;
using System.Windows;
using WpfRecon.Models;
using WpfRecon.Wrappers;
using WpfRecon.Interfaces;

namespace WpfRecon.Scans
{
    public class LiveHost
    {

        //This is the ICMP request that uses the Pingwrapper and interface to send a ping and display a result on the main page
        public ScanResult PingSweep(string IpAddress)
        {
            PingWrapper ping = new PingWrapper();

            ScanResult result = new ScanResult
            {
                IpAdress = IpAddress,
                PingReply = ping.Send(IpAddress)
            };

            return result;
        }
    }
}


            
            
            
        




