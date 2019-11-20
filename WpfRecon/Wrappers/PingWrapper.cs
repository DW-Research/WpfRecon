using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WpfRecon.Interfaces;
using WpfRecon.Models;

namespace WpfRecon.Wrappers
//This is the ICMP PingReply wrapper that will allow me to conduct Nunit testing.
{
    public class PingWrapper : IPingWrapper
    {
        public PingReply Send(string IpAddress)
        {
            
            string LocalAdd = LocalAddress.GetLocalAddress();
            try
            {
                var ping = new Ping();
                return ping.Send(IpAddress);

            }
            catch
            {
                var ping = new Ping();
                return ping.Send(LocalAdd);
            }
        }
    }
}
