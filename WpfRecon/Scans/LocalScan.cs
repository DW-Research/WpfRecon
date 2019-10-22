using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WpfRecon.Scans
{
    class LocalScan
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  

            // Get the IP
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();

            //TODO: Get the local scan working with myIP and not just IpAddress

        }
    }
}
