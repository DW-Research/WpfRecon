using System;
using System.Net;
using System.Net.Sockets;

namespace WpfRecon.Models
{
    class LocalAddress
    {
        //Get local Ipv4 adress from local machine
        public static string GetLocalIPAddress()
        {

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                //Selects IPV4 
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
