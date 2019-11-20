using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WpfRecon.Models
{
    class LocalAddress
    {
        public static string GetLocalAddress()
        {
            string IPAddress = Dns.GetHostName(); // Retrive the Name of HOST  

            // Get the IP
            string myIP = Dns.GetHostEntry(IPAddress).AddressList[0].ToString();

            return myIP;
        }
    }
}
