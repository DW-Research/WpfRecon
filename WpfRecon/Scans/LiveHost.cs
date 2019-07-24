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

        //TO-DO add error codes, This is not a live host, this is not a correct IP.
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


            
            
            
        




